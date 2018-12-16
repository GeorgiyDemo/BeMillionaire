﻿using System;
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
    /// Логика взаимодействия для ResultWindow.xaml
    /// </summary>
    public partial class ResultWindow : Window
    {
        public ResultWindow(string allstrnumbers)
        {
            InitializeComponent();
            WinTextBlock.Text = "Поздравляем!\nВы ответили на все "+ allstrnumbers + " из "+ allstrnumbers + " вопросов";
        }

        private void RepeatButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
