using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace de28
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int UserID { get; set; } = 0;
        public string Search { get; set; }
        public string Filter { get; set; }
        public string Sort { get; set; } = "order by desc ";
        public int FullCount { get; set; } // = GetFullCount();
        public void RenderFullName()
        {
            if (UserID != 0)
            {
                // nameLabel.Content = GetNameFromId(UserID);
                nameLabel.Visibility = Visibility.Visible;
                sortCB.ItemsSource = SetSortOptions();
                sortCB.SelectedIndex = 0;
            }
        }

        public ObservableCollection<string> SetSortOptions()
        {
            return new ObservableCollection<string>()
            {
                "По убыванию",
                "По возрастанию",
            };
        }
        public MainWindow(int id)
        {
            UserID = id;
            InitializeComponent();
        }

        private void sortCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (sortCB.SelectedIndex == 0)
            {
                Sort = "order by desc ";
            }
            else
            {
                 Sort = "order by asc ";
            }
        }
    }
}
