using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_Manager
{
    public static class RunTask
    {
        public static void RunNewTask(Guna2TextBox text)
        {
            if (!string.IsNullOrEmpty(text.Text))
            {
                try
                {
                    Process process = new Process();
                    process.StartInfo.FileName = text.Text;
                    process.Start();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
