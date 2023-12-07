using ryle.Pages;
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
using System.Windows.Threading;

namespace ryle
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int sessionTimeInMinutes = 3600;
        private int remainingTimeInSeconds;
        private DispatcherTimer timer;
        public MainWindow()
        {
            InitializeComponent();
            Classes.dbconnect.modeldb = new Models.ryleEntities1();
            InitializeTimer();
        }
        private void InitializeTimer()
        {
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;
            StartSessionTimer();
        }

        private void StartSessionTimer()
        {
            remainingTimeInSeconds = sessionTimeInMinutes * 60;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            remainingTimeInSeconds--;
            if (remainingTimeInSeconds <= 0)
            {
                timer.Stop();
                Application.Current.Shutdown();
            }
            else
            {
                TimerTextBlock.Text = TimeSpan.FromSeconds(remainingTimeInSeconds).ToString(@"mm\:ss");

                if (remainingTimeInSeconds == 2 * 60) // Оповещение за 2 минуты до конца
                {
                    MessageBox.Show("До конца сессии осталось 2 минуты!");
                }
                else if (remainingTimeInSeconds == 60) // Блокировка кнопки за 1 минуту до конца
                {
                    time.Visibility = Visibility.Hidden;
                }
            }
        }

        private void regClick(object sender, RoutedEventArgs e)
        {
            string log = login.Text;
            string pas = password.Password;
            string proo = proof.Password;

            bool hasError = false;

            if (log.Length < 5)
            {
                login.ToolTip = "Мало символов!";
                login.BorderBrush = Brushes.Red;
                hasError = true;
            }
            else
            {
                login.ToolTip = "Все хорошо!";
                login.BorderBrush = Brushes.LimeGreen;
            }

            if (pas.Length < 5)
            {
                password.ToolTip = "Мало символов!";
                password.BorderBrush = Brushes.Red;
                hasError = true;
            }
            else
            {
                password.ToolTip = "Все хорошо!";
                password.BorderBrush = Brushes.LimeGreen;
            }

            if (proo != pas)
            {
                proof.ToolTip = "Повторите попытку!";
                proof.BorderBrush = Brushes.Red;
                hasError = true;
            }
            else
            {
                proof.ToolTip = "Все хорошо!";
                proof.BorderBrush = Brushes.LimeGreen;
            }

            if (hasError)
            {
                // Если есть ошибки, не выполняем регистрацию
                return;
            }

            // Создаем нового пользователя
            var newUser = new Models.users
            {
                login = log,
                pasword = pas,
                id_type = 3 // 3 соответствует роли "Client"
            };

            // Добавляем пользователя в таблицу users
            Classes.dbconnect.modeldb.users.Add(newUser);

            try
            {
                // Сохраняем изменения в базе данных
                Classes.dbconnect.modeldb.SaveChanges();
                MessageBox.Show("Регистрация прошла успешно!", "Успешная регистрация",
                    MessageBoxButton.OK, MessageBoxImage.Information);

                // Очищаем поля ввода
                login.Clear();
                password.Clear();
                proof.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при регистрации: {ex.Message}", "Ошибка при регистрации",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void OpenAutor(object sender, RoutedEventArgs e)
        {
            Autor autor = new Autor();
            this.Visibility = Visibility.Hidden;
            autor.Show();
        }

        private void tovariClick(object sender, RoutedEventArgs e)
        {
            tovari tovar = new tovari();
            this.Visibility = Visibility.Hidden;
            tovar.Show();
        }

        private void lvClick(object sender, RoutedEventArgs e)
        {
            listviewmerch list = new listviewmerch();
            Visibility = Visibility.Hidden;
            list.Show();
        }
    }
}