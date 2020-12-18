using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.Net;
namespace AwireAPI
{
    public class SystemApps
    {
        public static void PowerShell()
        {
            Process.Start("%windir%/System32/WindowsPowerShell/v1.0/powershell.exe");
        }
        public static void TaskManger()
        {
            Process.Start("%windir%/System32/Taskmgr.exe");
        }
        public static void BluetoothFileTransfer()
        {
            Process.Start("%windir%/System32/fsquirt.exe");
        }
        public static void OnScreenKeyborad()
        {
            Process.Start("%windir%/System32/osk.exe");
        }
        public static void FileExplorer()
        {
            Process.Start("%windir%/explorer.exe");
        }


    }
           public class DownloadFile
    {
        public static void DownloadInternetFile(string URL, string SaveFileAs)
        {
            WebClient Client = new WebClient();
            Client.DownloadFile(URL, SaveFileAs);
        }

    }
    public class OpenOtherFiles
    {
        public static void OpenProgram(string ProgramFile, string ProgramCommand)
        {
            Process.Start(ProgramFile, ProgramCommand);
        }

        public static void OpenFile(string FileToOpen)
        {

            string[] lines = { "echo off", "SET FileName=%windir%", "IF EXIST % FileName % (start / B " + FileToOpen + ")" };
            File.WriteAllLines(@"AwireAPIOpenFile.bat", lines);
            Process.Start("AwireAPIOpenFile.bat");
            File.Delete("AwireAPIOpenFile.bat");
        }


        public class ComputerFunc
        {
            public static void QuickShutDown()
            {
                Process.Start("%windir%/System32/shutdown.exe", "/s /t 0");
            }
            public static void QuickRestart()
            {
                Process.Start("%windir%/System32/shutdown.exe", "/r /t 0");
            }
            public static void QuickLogout()
            {
                Process.Start("%windir%/System32/shutdown.exe", "/l /t 0");
            }
            public static void Shutdown(string DelayTimeInSeconds)
            {
                Process.Start("%windir%/System32/shutdown.exe", "/s /t " + DelayTimeInSeconds);
            }

            public static void Restart(string DelayTimeInSeconds)
            {
                Process.Start("%windir%/System32/shutdown.exe", "/r /t " + DelayTimeInSeconds);
            }
            public static void Logout(string DelayTimeInSeconds)
            {
                Process.Start("%windir%/System32/shutdown.exe", "/l /t " + DelayTimeInSeconds);
            }



        }

        public class Filewrite
        {
            public static void WriteToFile(string FileContents, string FileLocation)
            {

                string[] lines = {FileContents};
                File.WriteAllLines(FileLocation, lines);
                
               
            }

        }
       }
     }
