using iPlatoVwModel;
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

namespace iPlato
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       
        //private readonly PeopleVwModel _pepvwModel;
        public MainWindow()
        {
            InitializeComponent();
            // _pepvwModel = new PeopleVwModel();
            PeopleVwModel _pepModel = PeopleVwModel.Instance();
            DataContext = _pepModel;
            
        }
    }
}
