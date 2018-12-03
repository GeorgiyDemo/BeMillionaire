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
            LoseLabel.Content = "Вы проиграли! Вы ответили на "+ number.ToString() + " из 15 вопросов c депозитом "+price.ToString()+ " руб.";
        }
    }
}
