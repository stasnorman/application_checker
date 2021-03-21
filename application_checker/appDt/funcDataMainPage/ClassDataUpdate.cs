using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace application_checker.appDt.funcDataMainPage
{
    class ClassDataUpdate
    {        
        private Process[] localAll { get; set; }

        public DateTime StartProcess { get; set; }
        public string NameProcess{ get; set; }
        public int IdProcess{ get; set; }

        
        public void LoadDataInGrid(DataGrid dataView) {
         
            localAll = Process.GetProcesses();

            dataView.ItemsSource = localAll.GroupBy(x => x.ProcessName).ToList();


            //dataView.Items.Refresh();
        }
    }
}
