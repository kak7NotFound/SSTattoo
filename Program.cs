using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace SSTattoo
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        
        [DllImport("kernel32.dll")]
        static extern bool AttachConsole(int dwProcessId);
        private const int ATTACH_PARENT_PROCESS = -1;
        
        static public DataBase database = new DataBase();
        
        
        [STAThread]
        static void Main(string[] args)
        {
            AttachConsole(ATTACH_PARENT_PROCESS);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}