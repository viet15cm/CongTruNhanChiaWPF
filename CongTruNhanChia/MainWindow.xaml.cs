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

namespace CongTruNhanChia
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        //chỉnh sữa lại 
        public int Tong(int n)
        {
            int tong = 0;
            for (int i = 0; i <= n; i++)
            {
                tong += i;
            }

            return tong;
        }

        public int TongChan(int n)
        {
            int tongChan = 0;
            for (int i = 0; i <= n; i += 2)
            {
                tongChan += i;
            }
            return tongChan;
        }

        public int TongLe(int n)
        {
            int tongLe = 0;
            for (int i = 1; i <= n; i += 2)
            {
                tongLe += i;
            }
            return tongLe;
        }

        public int chon()
        {
            if (rdTong.IsChecked == true)
                return 1;
            else if (rdTongChan.IsChecked == true)
                return 2;
            else if (rdTongLe.IsChecked == true)
                return 3;

            return 0;
        }

        public void disPlay(int chon)
        {


            int n = int.Parse(txbNhap.Text);
            int tong, tongLe, tongChan;
            tong = Tong(n);
            tongLe = TongLe(n);
            tongChan = TongChan(n);

            switch (chon)
            {
                case 1:
                    txbKetQua.Text = tong.ToString();
                    break;

            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            disPlay(chon());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}