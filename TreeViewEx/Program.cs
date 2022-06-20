using System;
using System.Windows;

namespace TreeViewEx
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            new Application().Run(new MainWindow());
        }
    }
}
