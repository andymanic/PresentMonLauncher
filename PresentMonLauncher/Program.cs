using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Management;
using System.Management.Instrumentation;
using System.Security.Cryptography;

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
      public static double VersionNumber = 0.8;

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

            //Check version number
            VersionNo();

            //Check the games.json file
            GameListCheck();

            //Collect system info and store in a .txt file
            HWInfo();

            // Run the Launcher.
            Application.Run(new PresentMonLauncher());
        }
        public static void HWInfo()
        {
            //Code from Daniel T. Holtzclaw's "DeviceRegister" application.

            string save_to = "";
            save_to = Path.Combine(Application.StartupPath) + "//HWinfo.txt";
            
            if (File.Exists(save_to))
                File.Delete(save_to);

            // Will overwrite.
            using (FileStream fs = File.Open(save_to, FileMode.Create))
            {
                StreamWriter write_stream = new StreamWriter(fs);



                //Logical Disks = "Win32_LogicalDisk"
                //Processes = "Win32_Process"
                //Processors = "Win32_Processor"
                //Graphics = "Win32_DisplayConfiguration"
                //??? = "Win32_Account"
                //??? = "Win32_AllocatedResource"
                //??? = "Win32_BootConfiguration"
                //??? = "Win32_ClassCOMApplicationClasses"

                //CONSULT: https://msdn.microsoft.com/en-us/library/dn792258%28v=vs.85%29.aspx

                //Logical Disks
                

                //CPU's
                ManagementObjectCollection cpu_collection = new ManagementClass(new ManagementPath("Win32_Processor")).GetInstances();
                //Graphics
                ManagementObjectCollection gpu_collection = new ManagementClass(new ManagementPath("Win32_DisplayConfiguration")).GetInstances();
                //Graphics take two
                ManagementObjectCollection gpu_controller = new ManagementClass(new ManagementPath("Win32_VideoController")).GetInstances();


                int count = 0;

                

                write_stream.WriteLine("\n\n\nPROCESS-----------------------------------------");
                count = 0;
                foreach (ManagementObject obj in cpu_collection)
                {
                    PropertyDataCollection prop_collection = obj.Properties;
                    write_stream.WriteLine("Processor: " + count++);
                    foreach (PropertyData data in prop_collection)
                    {
                        if (data != null)
                        {
                            //if (data.Value != null)
                            // {
                            //if (!String.IsNullOrEmpty(data.Value.ToString()))
                            write_stream.WriteLine("   " + data.Name + ": " + data.Value);
                            //}
                        }
                    }
                    write_stream.WriteLine();
                }

                write_stream.WriteLine("\n\n\nGRAPHICS-----------------------------------------");
                count = 0;
                foreach (ManagementObject obj in gpu_collection)
                {
                    PropertyDataCollection prop_collection = obj.Properties;
                    write_stream.WriteLine("GPU: " + count++);
                    foreach (PropertyData data in prop_collection)
                    {
                        if (data != null)
                        {
                            //if (data.Value != null)
                            //{
                            //if (!String.IsNullOrEmpty(data.Value.ToString()))
                            write_stream.WriteLine("   " + data.Name + ": " + data.Value);
                            //}
                        }
                    }
                    write_stream.WriteLine();
                }

                write_stream.WriteLine("\n\n\nGRAPHICS Controller----------------------------------");
                count = 0;
                foreach (ManagementObject obj in gpu_controller)
                {
                    PropertyDataCollection prop_collection = obj.Properties;
                    write_stream.WriteLine("GPU: " + count++);
                    foreach (PropertyData data in prop_collection)
                    {
                        if (data != null)
                        {
                            //if (data.Value != null)
                            //{
                            //if (!String.IsNullOrEmpty(data.Value.ToString()))
                            write_stream.WriteLine("   " + data.Name + ": " + data.Value);
                            //}
                        }
                    }
                    write_stream.WriteLine();
                }

                write_stream.Close();

                cpu_collection.Dispose();
                gpu_collection.Dispose();
                
            }
        }
        public static void VersionNo()
        {
            System.Net.WebClient wc = new System.Net.WebClient();
            byte[] raw = wc.DownloadData("https://raw.githubusercontent.com/andymanic/PresentMonLauncher/master/VersionNo.txt");

            string VNo = System.Text.Encoding.UTF8.GetString(raw);
            double Vnum = Convert.ToDouble(VNo);
            if (Vnum > VersionNumber)
            {
                if(MessageBox.Show("Update available, visit download page?", "Update Available", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start("https://github.com/andymanic/PresentMonLauncher/blob/master/PresentMonLauncher%20Installer.exe");
                    return;
                }
                return;
            }

        }

        public static void GameListCheck()
        {
            byte[] hashlocal;
            byte[] hashremote;

            try
            {
                System.Net.WebClient gamefile = new System.Net.WebClient();
                gamefile.DownloadFile("https://raw.githubusercontent.com/andymanic/PresentMonLauncher/master/PresentMonLauncher/games.json", Path.Combine(Application.StartupPath) + "\\remotegames.json");
            }
            catch
            {
                if (MessageBox.Show("We tried to check the 'Games' file online but couldn't reach it, would you like to try checking again?", "Games file check", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                {
                    try
                    {
                        System.Net.WebClient gamefile = new System.Net.WebClient();
                        gamefile.DownloadFile("https://raw.githubusercontent.com/andymanic/PresentMonLauncher/master/PresentMonLauncher/games.json", Path.Combine(Application.StartupPath) + "\\remotegames.json");
                    }
                    catch
                    {
                        if (MessageBox.Show("We tried to check the 'Games' file online but couldn't reach it, would you like to try checking again?", "Games file check", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                        {
                            System.Net.WebClient gamefile = new System.Net.WebClient();
                            gamefile.DownloadFile("https://raw.githubusercontent.com/andymanic/PresentMonLauncher/master/PresentMonLauncher/games.json", Path.Combine(Application.StartupPath) + "\\remotegames.json");
                        }
                        else
                        {
                            MessageBox.Show("This isn't working, perhaps try again later.");
                            return;
                        }
                        return;

                    }
                }
                return;
            }
            

            using (var md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(Path.Combine(Application.StartupPath) + "\\games.json"))
                {
                    hashlocal = md5.ComputeHash(stream);
                   
                }
                using (var stream2 = File.OpenRead(Path.Combine(Application.StartupPath) + "\\remotegames.json"))
                {
                    hashremote = md5.ComputeHash(stream2);
                }
            }
            if (hashlocal.SequenceEqual(hashremote))
            {
                System.IO.File.Delete("remotegames.json");
            }
            else
            {
                System.IO.File.Delete("games.json");
                System.IO.File.Move("remotegames.json", "games.json");
            }
        }
    }
    
}
