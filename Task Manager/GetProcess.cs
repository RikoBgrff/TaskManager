using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_Manager
{
    public static class GetProcess
    {
        public static Process[] Processes { get; set; }

        public static void GetAllProcesses(ListBox box)
        {

            Processes = Process.GetProcesses();
            box.Items.Clear();
            foreach (Process process in Processes)
            {
                box.Sorted = true;
                box.Items.Add(process.ProcessName);
            }

        }

    }
}
