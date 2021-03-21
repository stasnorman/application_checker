using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace application_checker.appCls
{
    public class ClassRefresh
    {
        public Process[] localAll { get; set; }
        public static DispatcherTimer timer { get; set; }
        public void RefreshData()
        {
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(5);
            timer.Tick += CheckListData;
            timer.Start();
        }

        public void CheckListData(object sender, EventArgs e)
        {
            localAll = Process.GetProcesses();
        }
    }
}
