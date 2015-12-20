using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DesignPatternsEx01
{
    class FolderBrowser
    {
        public static string SelectOrCreateFolder()
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            folderBrowser.ShowDialog();
            return folderBrowser.SelectedPath;
        }
    }
}
