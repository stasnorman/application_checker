using application_checker.appDt.funcDataMainPage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace application_checker.appDt
{
    /// <summary>
    /// Логика взаимодействия для PageMainScreen.xaml
    /// </summary>
    public partial class PageMainScreen : Page
    {
        public PageMainScreen()
        {
            InitializeComponent();
            ClassDataUpdate classDataUpdate = new ClassDataUpdate();
            classDataUpdate.LoadDataInGrid(GridListProcess);            
        }

    }
}
