using System.Collections.Generic;
using System.Windows;

namespace BeMillionaire
{
    /// <summary>
    /// Логика взаимодействия для MainGameWindow.xaml
    /// </summary>
    public partial class MainGameWindow : Window
    {
        int thisnumber;
        int globalcountnumber;
        public MainGameWindow(int countvalue)
        {
           
            InitializeComponent();
            List<int> AllNumbers = RandomClass.GetList(false);
            globalcountnumber = countvalue;
            thisnumber = AllNumbers[countvalue];

            foreach (int s in AllNumbers)
            {
                MessageBox.Show(s.ToString());
            }


            QuestionBlock.Text = SQLiteClass.SQLiteGet("SELECT question FROM Questions WHERE id="+ thisnumber.ToString());
            FirstAnswerButton.Content = SQLiteClass.SQLiteGet("SELECT first FROM Questions WHERE id=" + thisnumber.ToString());
            SecondAnswerButton.Content = SQLiteClass.SQLiteGet("SELECT second FROM Questions WHERE id=" + thisnumber.ToString());
            ThirdAnswerButton.Content = SQLiteClass.SQLiteGet("SELECT third FROM Questions WHERE id=" + thisnumber.ToString());
            ForthAnswerButton.Content = SQLiteClass.SQLiteGet("SELECT fourth FROM Questions WHERE id=" + thisnumber.ToString());
        }

        private void CheckAnswer(int number)
        {
            string answerresult = SQLiteClass.SQLiteGet("SELECT answer FROM Questions WHERE id=" + thisnumber.ToString());
            if (number.ToString() == answerresult)
            {
                Close();
                MessageBox.Show("Вы выбрали правильный ответ!");
                MainGameWindow newobj = new MainGameWindow(globalcountnumber+1);
                newobj.Show();
            }
            else
            {
                MessageBox.Show("Вы проиграли");
                Close();
            }
        }

        private void FirstAnswerButton_Click(object sender, RoutedEventArgs e)
        {
            CheckAnswer(1);
        }

        private void SecondAnswerButton_Click(object sender, RoutedEventArgs e)
        {
            CheckAnswer(2);
        }

        private void ThirdAnswerButton_Click(object sender, RoutedEventArgs e)
        {
            CheckAnswer(3);
        }

        private void ForthAnswerButton_Click(object sender, RoutedEventArgs e)
        {
            CheckAnswer(4);
        }
    }
}
