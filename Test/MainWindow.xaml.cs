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

namespace Test
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int PlayerBoy = 0;
        private int[] p1 = new int[9];
        private int[] p2 = new int[9];

        private bool Hit_1 = false;
        private bool Hit_2 = false;
        private bool Hit_3 = false;
        private bool Hit_4 = false;
        private bool Hit_5 = false;
        private bool Hit_6 = false;
        private bool Hit_7 = false;
        private bool Hit_8 = false;
        private bool Hit_9 = false;

        public MainWindow()
        {
            InitializeComponent();
            hideImages();
            
        }


        private void hideImages()
        {
            x_1.Opacity = 0;
            x_1.IsHitTestVisible = false;
            x_2.Opacity = 0;
            x_2.IsHitTestVisible = false;
            x_3.Opacity = 0;
            x_3.IsHitTestVisible = false;
            x_4.Opacity = 0;
            x_4.IsHitTestVisible = false;
            x_5.Opacity = 0;
            x_5.IsHitTestVisible = false;
            x_6.Opacity = 0;
            x_6.IsHitTestVisible = false;
            x_7.Opacity = 0;
            x_7.IsHitTestVisible = false;
            x_8.Opacity = 0;
            x_8.IsHitTestVisible = false;
            x_9.Opacity = 0;
            x_9.IsHitTestVisible = false;

            kreis_1.Opacity = 0;
            kreis_1.IsHitTestVisible = false;
            kreis_2.Opacity = 0;
            kreis_2.IsHitTestVisible = false;
            kreis_3.Opacity = 0;
            kreis_3.IsHitTestVisible = false;
            kreis_4.Opacity = 0;
            kreis_4.IsHitTestVisible = false;
            kreis_5.Opacity = 0;
            kreis_5.IsHitTestVisible = false;
            kreis_6.Opacity = 0;
            kreis_6.IsHitTestVisible = false;
            kreis_7.Opacity = 0;
            kreis_7.IsHitTestVisible = false;
            kreis_8.Opacity = 0;
            kreis_8.IsHitTestVisible = false;
            kreis_9.Opacity = 0;
            kreis_9.IsHitTestVisible = false;

            overTTT.Opacity = 0;
            overTTT.IsHitTestVisible = false;

            tb1.Text = "";
            t2.Text = "";

        }

        private void Rectangle_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if(Hit_1 == false && PlayerBoy == 0)
            {
                x_1.Opacity = 100;
                p1[0] = 1;
                PlayerBoy = 1;
                Hit_1 = true;
            }
            if (Hit_1 == false && PlayerBoy == 1)
            {
                kreis_1.Opacity = 100;
                p2[0] = 1;
                PlayerBoy = 0;
                Hit_1 = true;
            }
            checkWin();
        }
        private void Rectangle_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            if (Hit_2 == false && PlayerBoy == 0)
            {
                x_2.Opacity = 100;
                p1[1] = 1;
                PlayerBoy = 1;
                Hit_2 = true;
            }
            if (Hit_2 == false && PlayerBoy == 1)
            {
                kreis_2.Opacity = 100;
                p2[1] = 1;
                PlayerBoy = 0;
                Hit_2 = true;
            }
            checkWin();
        }
        private void Rectangle_MouseLeftButtonDown_2(object sender, MouseButtonEventArgs e)
        {
            if (Hit_3 == false && PlayerBoy == 0)
            {
                x_3.Opacity = 100;
                p1[2] = 1;
                PlayerBoy = 1;
                Hit_3 = true;
            }
            if (Hit_3 == false && PlayerBoy == 1)
            {
                kreis_3.Opacity = 100;
                p2[2] = 1;
                PlayerBoy = 0;
                Hit_3 = true;
            }
            checkWin();
        }
        private void Rectangle_MouseLeftButtonDown_3(object sender, MouseButtonEventArgs e)
        {
            if (Hit_4 == false && PlayerBoy == 0)
            {
                x_4.Opacity = 100;
                p1[3] = 1;
                PlayerBoy = 1;
                Hit_4 = true;
            }
            if (Hit_4 == false && PlayerBoy == 1)
            {
                kreis_4.Opacity = 100;
                p2[3] = 1;
                PlayerBoy = 0;
                Hit_4 = true;
            }
            checkWin();
        }
        private void Rectangle_MouseLeftButtonDown_4(object sender, MouseButtonEventArgs e)
        {
            if (Hit_5 == false && PlayerBoy == 0)
            {
                x_5.Opacity = 100;
                p1[4] = 1;
                PlayerBoy = 1;
                Hit_5 = true;
            }
            if (Hit_5 == false && PlayerBoy == 1)
            {
                kreis_5.Opacity = 100;
                p2[4] = 1;
                PlayerBoy = 0;
                Hit_5 = true;
            }
            checkWin();
        }
        private void Rectangle_MouseLeftButtonDown_5(object sender, MouseButtonEventArgs e)
        {
            if (Hit_6 == false && PlayerBoy == 0)
            {
                x_6.Opacity = 100;
                p1[5] = 1;
                PlayerBoy = 1;
                Hit_6 = true;
            }
            if (Hit_6 == false && PlayerBoy == 1)
            {
                kreis_6.Opacity = 100;
                p2[5] = 1;
                PlayerBoy = 0;
                Hit_6 = true;
            }
            checkWin();
        }
        private void Rectangle_MouseLeftButtonDown_6(object sender, MouseButtonEventArgs e)
        {
            if (Hit_7 == false && PlayerBoy == 0)
            {
                x_7.Opacity = 100;
                p1[6] = 1;
                PlayerBoy = 1;
                Hit_7 = true;
            }
            if (Hit_7 == false && PlayerBoy == 1)
            {
                kreis_7.Opacity = 100;
                p2[6] = 1;
                PlayerBoy = 0;
                Hit_7 = true;
            }
            checkWin();
        }
        private void Rectangle_MouseLeftButtonDown_7(object sender, MouseButtonEventArgs e)
        {
            if (Hit_8 == false && PlayerBoy == 0)
            {
                x_8.Opacity = 100;
                p1[7] = 1;
                PlayerBoy = 1;
                Hit_8 = true;
            }
            if (Hit_8 == false && PlayerBoy == 1)
            {
                kreis_8.Opacity = 100;
                p2[7] = 1;
                PlayerBoy = 0;
                Hit_8 = true;
            }
            checkWin();
        }
        private void Rectangle_MouseLeftButtonDown_8(object sender, MouseButtonEventArgs e)
        {
            if (Hit_9 == false && PlayerBoy == 0)
            {
                x_9.Opacity = 100;
                p1[8] = 1;
                PlayerBoy = 1;
                Hit_9 = true;
            }
            if (Hit_9 == false && PlayerBoy == 1)
            {
                kreis_9.Opacity = 100;
                p2[8] = 1;
                PlayerBoy = 0;
                Hit_9 = true;
            }
            checkWin();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            x_1.Opacity = 0;
            x_2.Opacity = 0;
            x_3.Opacity = 0;
            x_4.Opacity = 0;
            x_5.Opacity = 0;
            x_6.Opacity = 0;
            x_7.Opacity = 0;
            x_8.Opacity = 0;
            x_9.Opacity = 0;

            kreis_1.Opacity = 0;
            kreis_2.Opacity = 0;
            kreis_3.Opacity = 0;
            kreis_4.Opacity = 0;
            kreis_5.Opacity = 0;
            kreis_6.Opacity = 0;
            kreis_7.Opacity = 0;
            kreis_8.Opacity = 0;
            kreis_9.Opacity = 0;

            for(int i = 0; i < 9; i++)
            {
                p1[i] = 0;
                p2[i] = 0;
            }

            Hit_1 = false;
            Hit_2 = false;
            Hit_3 = false;
            Hit_4 = false;
            Hit_5 = false;
            Hit_6 = false;
            Hit_7 = false;
            Hit_8 = false;
            Hit_9 = false;

            tb1.Text = "";
            t2.Text = "";

            overTTT.IsHitTestVisible = false;
        }

        private void checkWin()
        {

            // links rechts p1
            if (p1[0] == 1 && p1[1] == 1 && p1[2] == 1) winX();
            if (p1[3] == 1 && p1[4] == 1 && p1[5] == 1) winX();
            if (p1[6] == 1 && p1[7] == 1 && p1[8] == 1) winX();
            // oben unten p1
            if (p1[0] == 1 && p1[3] == 1 && p1[6] == 1) winX();
            if (p1[1] == 1 && p1[4] == 1 && p1[7] == 1) winX();
            if (p1[2] == 1 && p1[5] == 1 && p1[8] == 1) winX();
            // sitewards p1
            if (p1[2] == 1 && p1[4] == 1 && p1[6] == 1) winX();
            if (p1[0] == 1 && p1[4] == 1 && p1[8] == 1) winX();

            // links rechts p2
            if (p2[0] == 1 && p2[1] == 1 && p2[2] == 1) winKreis();
            if (p2[3] == 1 && p2[4] == 1 && p2[5] == 1) winKreis();
            if (p2[6] == 1 && p2[7] == 1 && p2[8] == 1) winKreis();
            // oben unten p2
            if (p2[0] == 1 && p2[3] == 1 && p2[6] == 1) winKreis();
            if (p2[1] == 1 && p2[4] == 1 && p2[7] == 1) winKreis();
            if (p2[2] == 1 && p2[5] == 1 && p2[8] == 1) winKreis();
            // sitewards p2
            if (p2[2] == 1 && p2[4] == 1 && p2[6] == 1) winKreis();
            if (p2[0] == 1 && p2[4] == 1 && p2[8] == 1) winKreis();
        }
        private void winX()
        {
            tb1.Text = "Spieler X Gewinnt!";
            t2.Text = "Drücke R E S E T um das Spiel neu zu starten ";
            overTTT.IsHitTestVisible = true;
        }
        private void winKreis()
        {
            tb1.Text = "Spieler O Gewinnt!";
            t2.Text = "Drücke R E S E T um das Spiel neu zu starten ";
            overTTT.IsHitTestVisible = true;
        }
    }

    
}
