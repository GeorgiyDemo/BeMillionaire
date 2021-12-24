using System.Windows;

namespace BeMillionaire
{
    /// <summary>
    /// Логика взаимодействия для LoseWindow.xaml
    /// </summary>
    public partial class LoseWindow : Window
    {
        public LoseWindow(int number, int price)
        {
            InitializeComponent();
            LoseLabel.Content = "Вы проиграли!\nВы ответили на "+ number.ToString() + " из 15 вопросов c депозитом "+price.ToString()+ " руб.";
        }

        private void RepeatButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
