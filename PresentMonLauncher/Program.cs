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
      default_present_mon_directory = @"C:\PresentMonLauncher\",
      default_config_directory = @"C:\PresentMonLauncher\config\";

    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      // Set the working Directory to the default PresentMon location
      if (!Directory.Exists(default_present_mon_directory))
      {
        Directory.CreateDirectory(default_present_mon_directory);
        Directory.CreateDirectory(default_config_directory);
      }

      else if (Directory.Exists(default_present_mon_directory) && !Directory.Exists(default_config_directory))
        Directory.CreateDirectory(default_config_directory);

      Directory.SetCurrentDirectory(@"C:\PresentMonLauncher");

      //These always need to run before there's any kind of window,
      //  else SetCompatibleTextRenderingDefault will except.
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);

      /*
      // If (PresentMon64.exe not found), in essence.
      //  Prompt user for a folder to look in.
      // else run normally.
      if (Directory.GetFiles(Directory.GetCurrentDirectory(), "PresentMon64.exe").Length == 0)
      {
        // Control variable.
        bool file_found = false;

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
            }
          }
        }
      }
      // If PresentMon64.exe IS found then it will continue as normal.
      */

      // Run the Launcher.
      Application.Run(new PresentMonLauncher());
    }
  }
}
