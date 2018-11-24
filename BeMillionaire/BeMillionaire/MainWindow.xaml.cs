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

namespace BeMillionaire
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

            InitializeComponent();

            for (int i=5;i<11;i++)
                MenuComboBox.Items.Add(i.ToString());
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            if (MenuComboBox.SelectedIndex != -1)
            {
                string questionscounter = MenuComboBox.SelectedItem.ToString();
                RandomClass.GetList(true, Convert.ToInt32(questionscounter));
                MainGameWindow obj = new MainGameWindow(0, questionscounter);
                obj.Show();
                this.Close();
            }
            else
                MessageBox.Show("Выберите количество вопросов");
        }
    }
}
