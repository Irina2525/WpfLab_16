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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfLab_16
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            DoubleAnimation doubleAnimation = new DoubleAnimation(); // экз. класса 

            //doubleAnimation.From = 150; // с-во определяет стартовую позицию анимации

            doubleAnimation.To = 500; // с-во до каких размеров меняется кнопка
            // doubleAnimation.RepeatBehavior = new RepeatBehavior(2);  // кол-во шагов 2 
            doubleAnimation.Duration = TimeSpan.FromSeconds(2); // длительность анимации  2 сек

            //doubleAnimation.By = 10; // на сколько изменится размер 
            //doubleAnimation.RepeatBehavior = new RepeatBehavior(TimeSpan.FromSeconds(6)); // повтор 6 сек

            //doubleAnimation.AccelerationRatio = 0; // -	Без ускорения
            // doubleAnimation.AccelerationRatio = 1; // Ускорение в конце
            //doubleAnimation.AccelerationRatio = 0.5; // -	Ускорение закончиться к середине анимации, дальше скорость постоянна

            // doubleAnimation.SpeedRatio=0.5; // Замедляет. Вместо 2 сек 4 секунды
            //doubleAnimation.AutoReverse = true; // За 2 секунды кнопка увеличивается и потoм уменьшается плавно 

            //doubleAnimation.FillBehavior = FillBehavior.Stop; // Определяет нужно ли вернуться к стартовым значениям
            // doubleAnimation.FillBehavior = FillBehavior.HoldEnd; // Анимация дойдет до конца и останеться




           // btn.BeginAnimation(Button.WidthProperty, doubleAnimation);
          //  btn.BeginAnimation(Button.HeightProperty, doubleAnimation);


            ColorAnimation colorAnimation = new ColorAnimation();
            colorAnimation.From = Colors.Red; // настройки анимации начальные
            colorAnimation.To = Colors.Blue; // цвет в кт превратится 
            colorAnimation.Duration = TimeSpan.FromSeconds(2); // длительность  2 сек
           // btn.Background = new SolidColorBrush(Colors.Red);
          //  btn.Background.BeginAnimation(SolidColorBrush.ColorProperty, colorAnimation); // к кому применяется анимация (кнопка) 

        }
    }
}
