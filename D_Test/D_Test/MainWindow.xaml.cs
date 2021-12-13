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

namespace D_Test
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /*
        public static user1Entities _context;

        public static user1Entities GetContext()
        {
            if (_context == null)
            {
                _context = GetContext();
            }
            return _context;
        }
        */
        public user1Entities1 user1Entities = new user1Entities1();
        public MainWindow()
        {
            InitializeComponent();
            OneText.Text = Convert.ToString(user1Entities1.GetContext().View_1.Where(x => x.ID == 1));

        }
    }
}
