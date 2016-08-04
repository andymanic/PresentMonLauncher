using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PresentMonLauncher
{
  static class Program
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      // Set the working Directory to the default PresentMon location
      if (!Directory.Exists(@"C:\PresentMonLauncher"))
        Directory.CreateDirectory(@"C:\PresentMonLauncher");

      Directory.SetCurrentDirectory(@"C:\PresentMonLauncher");

      //These always need to go before there's any kind of window, else SetCompatibleTextRenderingDefault will except.
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
      // If PresentMon64.exe IS found then it 
      */

      // Run the Launcher.
      Application.Run(new PresentMonLauncher());
    }
  }
}
