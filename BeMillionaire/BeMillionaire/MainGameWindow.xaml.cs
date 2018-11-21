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
using System.Windows.Shapes;

namespace BeMillionaire
{
    /// <summary>
    /// Логика взаимодействия для MainGameWindow.xaml
    /// </summary>
    public partial class MainGameWindow : Window
    {
        public MainGameWindow()
        {
            InitializeComponent();

            List<int> AllNumbers = RandomClass.GetList(false);

            foreach (int s in AllNumbers)
            {
                MessageBox.Show(s.ToString());
            }
            QuestionBlock.Text = SQLiteClass.SQLiteGet("SELECT question FROM Questions WHERE id=1");
            FirstAnswerButton.Content = SQLiteClass.SQLiteGet("SELECT first FROM Questions WHERE id=1");
            SecondAnswerButton.Content = SQLiteClass.SQLiteGet("SELECT second FROM Questions WHERE id=1");
            ThirdAnswerButton.Content = SQLiteClass.SQLiteGet("SELECT third FROM Questions WHERE id=1");
            ForthAnswerButton.Content = SQLiteClass.SQLiteGet("SELECT fourth FROM Questions WHERE id=1");
        }

        private bool CheckAnswer(int number)
        {
            string answerresult = SQLiteClass.SQLiteGet("SELECT answer FROM Questions WHERE id=1");
            if (number.ToString() == answerresult)
                return true;
            return false;
        }

        private void FirstAnswerButton_Click(object sender, RoutedEventArgs e)
        {
            if (CheckAnswer(1)
        }

        private void SecondAnswerButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ThirdAnswerButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ForthAnswerButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
