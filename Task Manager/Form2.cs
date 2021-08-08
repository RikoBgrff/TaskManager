using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_Manager
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void RunTaskBtn_Click(object sender, EventArgs e)
        {
            RunTask.RunNewTask(OpenTaskTxtBx);
            this.Close();
        }
    }
}
