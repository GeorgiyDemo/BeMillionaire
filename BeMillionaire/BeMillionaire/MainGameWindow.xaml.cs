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
        string localequestionscount;
        public MainGameWindow(int countvalue, string allquestionscount)
        {

                InitializeComponent();
                List<int> AllNumbers = RandomClass.GetList(false, 0);
                this.Title = "Кто хочет стать миллионером? | Вопрос " + (countvalue + 1).ToString() + " из " + allquestionscount;
                localequestionscount = allquestionscount;
                globalcountnumber = countvalue;
                thisnumber = AllNumbers[countvalue];
                QuestionBlock.Text = SQLiteClass.SQLiteGet("SELECT question FROM Questions WHERE id=" + thisnumber.ToString());
                FirstAnswerButton.Content = SQLiteClass.SQLiteGet("SELECT first FROM Questions WHERE id=" + thisnumber.ToString());
                SecondAnswerButton.Content = SQLiteClass.SQLiteGet("SELECT second FROM Questions WHERE id=" + thisnumber.ToString());
                ThirdAnswerButton.Content = SQLiteClass.SQLiteGet("SELECT third FROM Questions WHERE id=" + thisnumber.ToString());
                ForthAnswerButton.Content = SQLiteClass.SQLiteGet("SELECT fourth FROM Questions WHERE id=" + thisnumber.ToString());
            
        }

        private void Window_Initialized(object sender, System.EventArgs e)
        {
        }

        private void CheckAnswer(int number)
        {
            string answerresult = SQLiteClass.SQLiteGet("SELECT answer FROM Questions WHERE id=" + thisnumber.ToString());
            if (number.ToString() == answerresult)
            {
                MessageBox.Show("Вы выбрали правильный ответ!");
                if ((globalcountnumber + 1) == System.Convert.ToInt32(localequestionscount))
                {
                    ResultWindow o = new ResultWindow(localequestionscount);
                    o.Show();
                }
                else
                {
                    MainGameWindow newobj = new MainGameWindow(globalcountnumber + 1, localequestionscount);
                    newobj.Show();
                }
                Close();
            }
            else
            {
                MessageBox.Show("Вы проиграли, хотите попробовать еще раз?");
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
