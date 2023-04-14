
using Authorization.DB;
using Microsoft.EntityFrameworkCore;
using ModernWpf;
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
using Authorization.Windows;

namespace Authorization
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ApplicationContext db = new ApplicationContext();
            db.Database.Migrate();
        }

        

        private void btn_up_Click(object sender, RoutedEventArgs e)
        {
            Sign_Up sign_Up = new Sign_Up();
            Close();
            sign_Up.ShowDialog();
        } 
    }
}
