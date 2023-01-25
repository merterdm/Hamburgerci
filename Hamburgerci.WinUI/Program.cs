using System;
using System.Net.NetworkInformation;

namespace Hamburgerci.WinUI
{
    internal static class Program
    {
        public delegate void Test(int a);
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Test testDelegate = a=> { global::System.Console.WriteLine(a*a); };
            testDelegate.Invoke(5);
           
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }

        public static void deneme(int a)
        {
            Console.WriteLine(a*a);
        }
    }
}