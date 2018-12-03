using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;

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
        int currentprice;
        public MainGameWindow(int countvalue, string allquestionscount)
        {
                InitializeComponent();
                List<int> AllNumbers = RandomClass.GetList(false, 0);
                this.Title = "Кто хочет стать миллионером? | Вопрос " + (countvalue + 1).ToString() + " из " + allquestionscount;
                localequestionscount = allquestionscount;
                globalcountnumber = countvalue;
                thisnumber = AllNumbers[countvalue];
                QuestionBlock.Text = SQLiteClass.SQLiteGet("SELECT question FROM Questions WHERE id=" + thisnumber.ToString());
                FirstAnswerButton.Content = "A: "+SQLiteClass.SQLiteGet("SELECT first FROM Questions WHERE id=" + thisnumber.ToString());
                SecondAnswerButton.Content = "B: "+SQLiteClass.SQLiteGet("SELECT second FROM Questions WHERE id=" + thisnumber.ToString());
                ThirdAnswerButton.Content = "C: "+SQLiteClass.SQLiteGet("SELECT third FROM Questions WHERE id=" + thisnumber.ToString());
                ForthAnswerButton.Content = "D: "+SQLiteClass.SQLiteGet("SELECT fourth FROM Questions WHERE id=" + thisnumber.ToString());
                currentprice = SetPriceButtons(countvalue + 1);

        }

        public int SetPriceButtons(int questnumber)
        {
            switch (questnumber)
            {
                case 1:
                    Button1.Background = Brushes.Orange;
                    return 100;
                case 2:
                    Button2.Background = Brushes.Orange;
                    return 200;
                case 3:
                    Button3.Background = Brushes.Orange;
                    return 300;
                case 4:
                    Button4.Background = Brushes.Orange;
                    return 500;
                case 5:
                    Button5.Background = Brushes.Orange;
                    return 1000;
                case 6:
                    Button6.Background = Brushes.Orange;
                    return 2000;
                case 7:
                    Button7.Background = Brushes.Orange;
                    return 4000;
                case 8:
                    Button8.Background = Brushes.Orange;
                    return 8000;
                case 9:
                    Button9.Background = Brushes.Orange;
                    return 16000;
                case 10:
                    Button10.Background = Brushes.Orange;
                    return 32000;
                case 11:
                    Button11.Background = Brushes.Orange;
                    return 64000;
                case 12:
                    Button12.Background = Brushes.Orange;
                    return 125000;
                case 13:
                    Button13.Background = Brushes.Orange;
                    return 250000;
                case 14:
                    Button14.Background = Brushes.Orange;
                    return 500000;
                case 15:
                    Button15.Background = Brushes.Orange;
                    return 1000000;

            }
            return 0;
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
                LoseWindow obj = new LoseWindow(globalcountnumber, currentprice);
                obj.Show();
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
