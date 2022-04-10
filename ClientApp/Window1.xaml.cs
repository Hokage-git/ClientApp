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
using System.ComponentModel;

namespace ClientApp
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string message;
            message = vvod.Text;
            byte[] data = Encoding.Unicode.GetBytes(message);
            MainWindow.stream.Write(data, 0, data.Length);
        }

        private void DataWindow_Closing(object sender, CancelEventArgs e)
        {
            if (MainWindow.client != null)
                MainWindow.client.Close();//отключение клиента
            if (MainWindow.stream != null)
                MainWindow.stream.Close();//отключение потока
            Environment.Exit(0); //завершение процесса
        }
    }
}
