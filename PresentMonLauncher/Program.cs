using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PresentMonLauncher
{
/* ----------------------------Notes-------------------------------------------
 * 
 * On Directories and Install:
 * Right here in Main, there is something we need to address regarding the directory
 *   of the program and related files. Users are likely wanting to change their
 *   install directory, so I feel we should allow them to.
 *   
 * With the installer, we could create a registry entry for the install directory
 *   and have this program reference that.
 * 
 * Or, better yet, just use the location of this program as a reference point for
 *   the working directory. 
 * 
 * This will allow the users to install on specific drives or wherever they like
 *   and still keep the program functioning normal.
 * 
 * Default directory tree:
 *  ./
 *  ./config
 *  
 *  config is where I will be placing the .cfg files, which will have a pretty
 *    simple structure, such that they can be edited outside of the program.
 *    
 *  Process: <process_name>
 *  Simple: yes/no
 *  NoCSV: yes/no
 *  Scroll: yes/no
 *  Flags: <rest of the line>
 */



  static class Program
  {
    public static string
      app_location = AppDomain.CurrentDomain.BaseDirectory,
      default_config_directory = AppDomain.CurrentDomain.BaseDirectory + @"config\",
      psm_path = AppDomain.CurrentDomain.BaseDirectory + @"path.cfg";

    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      //These always need to run before there's any kind of window,
      //  else SetCompatibleTextRenderingDefault will except.
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);

      string temp_path = "";

      // If (PresentMon64.exe not found where this executable is), in essence.
      //  Prompt user for a folder to look in.
      // else run normally.
      if (Directory.GetFiles(app_location, "PresentMon64.exe").Length == 0)
      {
        // Look for path.cfg
        bool no_path = Directory.GetFiles(app_location, @"path.cfg").Length == 0;
        // Control variable.
        bool file_found = false;


        if (!no_path)
        {
          using (StreamReader read_stream = new StreamReader(File.OpenRead(psm_path)))
          {
            temp_path = read_stream.ReadLine();

            if (!Directory.Exists(temp_path))
              no_path = true;
            else
            {
              Directory.SetCurrentDirectory(temp_path);
              file_found = Directory.GetFiles(temp_path, "PresentMon64.exe").Length != 0;
            }

            read_stream.Close();
          }
        }
 

        while (!file_found)
        {
          // Alert the user.
          MessageBox.Show("PresentMon64.exe not found.");

          // Prompt them for a new folder to look in.
          FolderBrowserDialog folder_browser = new FolderBrowserDialog();

          // Store the button click (if they clicked OK, Cancel, et al.)
          DialogResult diag_result = folder_browser.ShowDialog();

          // If the user clicked OK (clicking anything else will restart the loop).
          if (diag_result == DialogResult.OK)
          {
            // If found, exit loop. Else keep looping.
            if (Directory.GetFiles(folder_browser.SelectedPath, "PresentMon64.exe").Length != 0)
            {
              // Set the new directory.
              Directory.SetCurrentDirectory(folder_browser.SelectedPath);
              file_found = true;

              // Write to file.
              File.Delete(psm_path);
              using (StreamWriter sw = new StreamWriter(new FileStream(psm_path, FileMode.Create, FileAccess.Write)))
              {
                sw.WriteLine(Directory.GetCurrentDirectory());
                sw.Close();
              }
              no_path = false;
            }
          }
          // Makes PresentMon a dependency.
          else
            return;
        }

        if (no_path)
          File.Create(psm_path);
      }
      // If PresentMon64.exe IS found then it will continue as normal.

      // Set the working Directory to the default PresentMon location
      if (!Directory.Exists(default_config_directory))
        Directory.CreateDirectory(default_config_directory);

      // Run the Launcher.
      Application.Run(new PresentMonLauncher());
    }
  }
}
