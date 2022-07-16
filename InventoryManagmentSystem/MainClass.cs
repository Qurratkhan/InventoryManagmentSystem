using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace InventoryManagmentSystem
{
    class MainClass
    {
        public static string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        public static string s = File.ReadAllText(path+"\\connect");
        public static SqlConnection con = new SqlConnection(s);

        public DialogResult ShowMsg(string message , string heading , string type)
        {
            if (type == "Success")
            {
                return MessageBox.Show(message, heading, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                return MessageBox.Show(message, heading, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void showWindow( Form openWin , Form clsWin , Form MDIwin)
        {
            clsWin.Close();
            openWin.MdiParent = MDIwin;
            openWin.WindowState = FormWindowState.Maximized;
            openWin.Show();
        }

        public static void showWindow(Form openWin, Form MDIwin)
        {
           
            openWin.MdiParent = MDIwin;
            openWin.WindowState = FormWindowState.Maximized;
            openWin.Show();
        }
    }
}
