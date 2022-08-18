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

namespace ToF_Stats
{
    /// <summary>
    /// floateraction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Resis_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {
           
        }

        private void Result2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_4(object sender,RoutedEventArgs e)
        {

        }

        private void Button_Minimize(object sender,RoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Normal)
            {
                this.WindowState = WindowState.Minimized;
            }
            else if (this.WindowState == WindowState.Minimized)
            {
                this.WindowState = WindowState.Normal;
            }



        }

        private void TextBox_TextChanged_1(object sender,TextChangedEventArgs e)
        {

        }
        private void Result_TextChanged(object sender,TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender,RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
            
        }

        private void Window_MouseDown(object sender,MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }


        private void TextBox_TextChanged(object sender,TextChangedEventArgs e)
        {
                        
        }

        private void Button_Click_2(object sender,RoutedEventArgs e)
        {
            MessageBox.Show("EN:crit rate and resists scaling changes on lvl growth\nRU:крит шанс и резисты скалируются в зависимости от уровня\n\nEN:crit rate is linear.but resist is hyperbolic\nRU:крит шанс линейный.а резист гиперболическое");
        }

        private void Button_Click_3(object sender,RoutedEventArgs e)
        {
           
        }

        public void Button_CritRate(object sender,RoutedEventArgs e)
        {
            float a,b;
            a = Convert.ToSingle(TextBox.Text);
            b = Convert.ToSingle(Lv1.Text);

            if (b == 1)
            {
                Result.Text = Convert.ToString(a / 150 * 100 + "%");
            }
            if (b == 2)
            {
                Result.Text = Convert.ToString(a / 300 * 100 + "%");

            }
            if (b == 3)
            {
                Result.Text = Convert.ToString(a / 450 * 100 + "%");
            }
            if (b == 4)
            {
                Result.Text = Convert.ToString(a / 600 * 100 + "%");
            }
            if (b == 5)
            {
                Result.Text = Convert.ToString(a / 750 * 100 + "%");
            }
            if (b == 6)
            {
                Result.Text = Convert.ToString(a / 900 * 100 + "%");
            }
            if (b == 7)
            {
                Result.Text = Convert.ToString(a / 1050 * 100 + "%");
            }
            if (b == 8)
            {
                Result.Text = Convert.ToString(a / 1200 * 100 + "%");
            }
            if (b == 9)
            {
                Result.Text = Convert.ToString(a / 1350 * 100 + "%");
            }
            if (b == 10)
            {
                Result.Text = Convert.ToString(a / 1602 * 100 + "%");
            }
            if (b == 11)
            {
                Result.Text = Convert.ToString(a / 1926 * 100 + "%");
            }
            if (b == 12)
            {
                Result.Text = Convert.ToString(a / 2242 * 100 + "%");
            }
            if (b == 13)
            {
                Result.Text = Convert.ToString(a / 2550 * 100 + "%");
            }
            if (b == 14)
            {
                Result.Text = Convert.ToString(a / 2850 * 100 + "%");
            }
            if (b == 15)
            {
                Result.Text = Convert.ToString(a / 3142 * 100 + "%");
            }
            if (b == 16)
            {
                Result.Text = Convert.ToString(a / 3426 * 100 + "%");
            }
            if (b == 17)
            {
                Result.Text = Convert.ToString(a / 3702 * 100 + "%");
            }
            if (b == 18)
            {
                Result.Text = Convert.ToString(a / 3970 * 100 + "%");
            }
            if (b == 19)
            {
                Result.Text = Convert.ToString(a / 4230 * 100 + "%");
            }
            if (b == 20)
            {
                Result.Text = Convert.ToString(a / 4482 * 100 + "%");
            }
            if (b == 21)
            {
                Result.Text = Convert.ToString(a / 4726 * 100 + "%");
            }
            if (b == 22)
            {
                Result.Text = Convert.ToString(a / 4962 * 100 + "%");
            }
            if (b == 23)
            {
                Result.Text = Convert.ToString(a / 5190 * 100 + "%");
            }
            if (b == 24)
            {
                Result.Text = Convert.ToString(a / 5410 * 100 + "%");
            }
            if (b == 25)
            {
                Result.Text = Convert.ToString(a / 5622 * 100 + "%");
            }
            if (b == 26)
            {
                Result.Text = Convert.ToString(a / 5826 * 100 + "%");
            }
            if (b == 27)
            {
                Result.Text = Convert.ToString(a / 6022 * 100 + "%");
            }
            if (b == 28)
            {
                Result.Text = Convert.ToString(a / 6210 * 100 + "%");
            }
            if (b == 29)
            {
                Result.Text = Convert.ToString(a / 6390 * 100 + "%");
            }
            if (b == 30)
            {
                Result.Text = Convert.ToString(a / 6562 * 100 + "%");
            }
            if (b == 31)
            {
                Result.Text = Convert.ToString(a / 6726 * 100 + "%");
            }
            if (b == 32)
            {
                Result.Text = Convert.ToString(a / 6882 * 100 + "%");
            }
            if (b == 33)
            {
                Result.Text = Convert.ToString(a / 7030 * 100 + "%");
            }
            if (b == 34)
            {
                Result.Text = Convert.ToString(a / 7170 * 100 + "%");
            }
            if (b == 35)
            {
                Result.Text = Convert.ToString(a / 7302 * 100 + "%");
            }
            if (b == 36)
            {
                Result.Text = Convert.ToString(a / 7426 * 100 + "%");
            }
            if (b == 37)
            {
                Result.Text = Convert.ToString(a / 7542 * 100 + "%");
            }
            if (b == 38)
            {
                Result.Text = Convert.ToString(a / 7650 * 100 + "%");
            }
            if (b == 39)
            {
                Result.Text = Convert.ToString(a / 7750 * 100 + "%");
            }
            if (b == 40)
            {
                Result.Text = Convert.ToString(a / 7842 * 100 + "%");
            }
            if (b == 41)
            {
                Result.Text = Convert.ToString(a / 8195.997f * 100 + "%");
            }
            if (b == 42)
            {
                Result.Text = Convert.ToString(a / 8467.468f * 100 + "%");
            }
            if (b == 43)
            {
                Result.Text = Convert.ToString(a / 8738.613f * 100 + "%");
            }
            if (b == 44)
            {
                Result.Text = Convert.ToString(a / 9009.432f * 100 + "%");
            }
            if (b == 45)
            {
                Result.Text = Convert.ToString(a / 9279.925f * 100 + "%");
            }
            if (b == 46)
            {
                Result.Text = Convert.ToString(a / 9550.092f * 100 + "%");
            }
            if (b == 47)
            {
                Result.Text = Convert.ToString(a / 9819.933f * 100 + "%");
            }
            if (b == 48)
            {
                Result.Text = Convert.ToString(a / 10089.448f * 100 + "%");
            }
            if (b == 49)
            {
                Result.Text = Convert.ToString(a / 10358.637f * 100 + "%");
            }
            if (b == 50)
            {
                Result.Text = Convert.ToString(a / 10627.5f * 100 + "%");
            }
            if (b == 51)
            {
                Result.Text = Convert.ToString(a / 10896.037f * 100 + "%");
            }
            if (b == 52)
            {
                Result.Text = Convert.ToString(a / 11164.248f * 100 + "%");
            }
            if (b == 53)
            {
                Result.Text = Convert.ToString(a / 11432.133f * 100 + "%");
            }
            if (b == 54)
            {
                Result.Text = Convert.ToString(a / 11699.692f * 100 + "%");
            }
            if (b == 55)
            {
                Result.Text = Convert.ToString(a / 11966.925f * 100 + "%");
            }
            if (b == 56)
            {
                Result.Text = Convert.ToString(a / 12233.832f * 100 + "%");
            }
            if (b == 57)
            {
                Result.Text = Convert.ToString(a / 12500.413f * 100 + "%");
            }

            if (b == 58)
            {
                Result.Text = Convert.ToString(a / 12766.668f * 100 + "%");
            }
            if (b == 59)
            {
                Result.Text = Convert.ToString(a / 13032.597f * 100 + "%");
            }
            if (b == 60)
            {
                Result.Text = Convert.ToString(a / 13298.2f * 100 + "%");
            }
            if (b == 61)
            {
                Result.Text = Convert.ToString(a / 13563.477f * 100 + "%");
            }
            if (b == 62)
            {
                Result.Text = Convert.ToString(a / 13828.428f * 100 + "%");
            }
            if (b == 63)
            {
                Result.Text = Convert.ToString(a / 14093.053f * 100 + "%");
            }
            if (b == 64)
            {
                Result.Text = Convert.ToString(a / 14357.352f * 100 + "%");
            }
            if (b == 65)
            {
                Result.Text = Convert.ToString(a / 14621.325f * 100 + "%");
            }
            if (b == 66)
            {
                Result.Text = Convert.ToString(a / 14884.972f * 100 + "%");
            }
            if (b == 67)
            {
                Result.Text = Convert.ToString(a / 15148.293f * 100 + "%");
            }
            if (b == 68)
            {
                Result.Text = Convert.ToString(a / 15411.288f * 100 + "%");
            }
            if (b == 69)
            {
                Result.Text = Convert.ToString(a / 15673.957f * 100 + "%");
            }
            if (b == 70)
            {
                Result.Text = Convert.ToString(a / 15936.3f * 100 + "%");
            }
            if (b == 71)
            {
                Result.Text = Convert.ToString(a / 16198.317f * 100 + "%");
            }
            if (b == 72)
            {
                Result.Text = Convert.ToString(a / 16460.008f * 100 + "%");
            }
            if (b == 73)
            {
                Result.Text = Convert.ToString(a / 16721.373f * 100 + "%");
            }
            if (b == 74)
            {
                Result.Text = Convert.ToString(a / 16982.412f * 100 + "%");
            }
            if (b == 75)
            {
                Result.Text = Convert.ToString(a / 17243.125f * 100 + "%");
            }
            if (b == 76)
            {
                Result.Text = Convert.ToString(a / 17503.512f * 100 + "%");
            }
            if (b == 77)
            {
                Result.Text = Convert.ToString(a / 17763.573f * 100 + "%");
            }
            if (b == 78)
            {
                Result.Text = Convert.ToString(a / 18023.308f * 100 + "%");
            }
            if (b == 79)
            {
                Result.Text = Convert.ToString(a / 18282.717f * 100 + "%");
            }
            if (b == 80)
            {
                Result.Text = Convert.ToString(a / 18541.8f * 100 + "%");
            }
            if (b == 81)
            {
                Result.Text = Convert.ToString(a / 18800.557f * 100 + "%");
            }
            if (b == 82)
            {
                Result.Text = Convert.ToString(a / 19058.988f * 100 + "%");
            }
            if (b == 83)
            {
                Result.Text = Convert.ToString(a / 19317.093f * 100 + "%");
            }
            if (b == 84)
            {
                Result.Text = Convert.ToString(a / 19574.872f * 100 + "%");
            }
            if (b == 85)
            {
                Result.Text = Convert.ToString(a / 19832.325f * 100 + "%");
            }
            if (b == 86)
            {
                Result.Text = Convert.ToString(a / 20089.452f * 100 + "%");
            }
            if (b == 87)
            {
                Result.Text = Convert.ToString(a / 20346.253f * 100 + "%");
            }
            if (b == 88)
            {
                Result.Text = Convert.ToString(a / 20602.728f * 100 + "%");
            }
            if (b == 89)
            {
                Result.Text = Convert.ToString(a / 20858.877f * 100 + "%");
            }
            if (b == 90)
            {
                Result.Text = Convert.ToString(a / 21114.7f * 100 + "%");
            }
            if (b == 91)
            {
                Result.Text = Convert.ToString(a / 21370.197f * 100 + "%");
            }
            if (b == 92)
            {
                Result.Text = Convert.ToString(a / 21625.368f * 100 + "%");
            }
            if (b == 93)
            {
                Result.Text = Convert.ToString(a / 21880.213f * 100 + "%");
            }
            if (b == 94)
            {
                Result.Text = Convert.ToString(a / 22134.732f * 100 + "%");
            }
            if (b == 95)
            {
                Result.Text = Convert.ToString(a / 22388.925f * 100 + "%");
            }
            if (b == 96)
            {
                Result.Text = Convert.ToString(a / 22642.792f * 100 + "%");
            }
            if (b == 97)
            {
                Result.Text = Convert.ToString(a / 22896.333f * 100 + "%");
            }
            if (b == 98)
            {
                Result.Text = Convert.ToString(a / 23149.548f * 100 + "%");
            }
            if (b == 99)
            {
                Result.Text = Convert.ToString(a / 23402.437f * 100 + "%");
            }
            if (b == 100)
            {
                Result.Text = Convert.ToString(a / 23655f * 100 + "%");
            }
            if (b == 0)
            {
                Result.Text = Convert.ToString("Error due to value zero exception");
            }
            if (b < 0)
            {
                Result.Text = Convert.ToString("Error due to negative value");
            }
            if (b > 100)
            {
                Result.Text = Convert.ToString("Error: lv limit surpassed");
            }

        }

        private void Button_Res(object sender, RoutedEventArgs e)
        {
            float c,d;
            c = Convert.ToSingle(Resist.Text);
            d = Convert.ToSingle(Lv2.Text);

            if (d == 1)
            {
                Result2.Text = Convert.ToString(c / (c + 75) * 100 + "%");           
            }
            if (d == 2)
            {
                Result2.Text = Convert.ToString(c / (c + 150) * 100 + "%");
            }
            if (d == 3)
            {
                Result2.Text = Convert.ToString(c / (c + 225) * 100 + "%");
            }
            if (d == 4)
            {
                Result2.Text = Convert.ToString(c / (c + 300) * 100 + "%");
            }
            if (d == 5)
            {
                Result2.Text = Convert.ToString(c / (c + 375) * 100 + "%");
            }
            if (d == 6)
            {
                Result2.Text = Convert.ToString(c / (c + 450) * 100 + "%");
            }
            if (d == 7)
            {
                Result2.Text = Convert.ToString(c / (c + 525) * 100 + "%");
            }
            if (d == 8)
            {
                Result2.Text = Convert.ToString(c / (c + 600) * 100 + "%");
            }
            if (d == 9)
            {
                Result2.Text = Convert.ToString(c / (c + 675) * 100 + "%");
            }
            if (d == 10)
            {
                Result2.Text = Convert.ToString(c / (c + 801) * 100 + "%");
            }
            if (d == 11)
            {
                Result2.Text = Convert.ToString(c / (c + 963) * 100 + "%");
            }
            if (d == 12)
            {
                Result2.Text = Convert.ToString(c / (c + 1121) * 100 + "%");
            }
            if (d == 13)
            {
                Result2.Text = Convert.ToString(c / (c + 1275) * 100 + "%");
            }
            if (d == 14)
            {
                Result2.Text = Convert.ToString(c / (c + 1425) * 100 + "%");
            }
            if (d == 15)
            {
                Result2.Text = Convert.ToString(c / (c + 1571) * 100 + "%");
            }
            if (d == 16)
            {
                Result2.Text = Convert.ToString(c / (c + 1713) * 100 + "%");
            }
            if (d == 17)
            {
                Result2.Text = Convert.ToString(c / (c + 1851) * 100 + "%");
            }
            if (d == 18)
            {
                Result2.Text = Convert.ToString(c / (c + 1985) * 100 + "%");
            }
            if (d == 19 )
            {
                Result2.Text = Convert.ToString(c / (c + 2115) * 100 + "%");
            }
            if (d == 20)
            {
                Result2.Text = Convert.ToString(c / (c + 2241) * 100 + "%");
            }
            if (d == 21)
            {
                Result2.Text = Convert.ToString(c / (c + 2363) * 100 + "%");
            }
            if (d == 22)
            {
                Result2.Text = Convert.ToString(c / (c + 2481) * 100 + "%");
            }
            if (d == 23)
            {
                Result2.Text = Convert.ToString(c / (c + 2595) * 100 + "%");
            }
            if (d == 24)
            {
                Result2.Text = Convert.ToString(c / (c + 2705) * 100 + "%");
            }
            if (d == 25)
            {
                Result2.Text = Convert.ToString(c / (c + 2811) * 100 + "%");
            }
            if (d == 26)
            {
                Result2.Text = Convert.ToString(c / (c + 2913) * 100 + "%");
            }
            if (d == 27)
            {
                Result2.Text = Convert.ToString(c / (c + 3011) * 100 + "%");
            }
            if (d == 28)
            {
                Result2.Text = Convert.ToString(c / (c + 3105) * 100 + "%");
            }
            if (d == 29)
            {
                Result2.Text = Convert.ToString(c / (c + 3195) * 100 + "%");
            }
            if (d == 30)
            {
                Result2.Text = Convert.ToString(c / (c + 3281) * 100 + "%");
            }
            if (d == 31)
            {
                Result2.Text = Convert.ToString(c / (c + 3363) * 100 + "%");
            }
            if (d == 32)
            {
                Result2.Text = Convert.ToString(c / (c + 3441) * 100 + "%");
            }
            if (d == 33)
            {
                Result2.Text = Convert.ToString(c / (c + 3515) * 100 + "%");
            }
            if (d == 34)
            {
                Result2.Text = Convert.ToString(c / (c + 3585) * 100 + "%");
            }
            if (d == 35)
            {
                Result2.Text = Convert.ToString(c / (c + 3651) * 100 + "%");
            }
            if (d == 36)
            {
                Result2.Text = Convert.ToString(c / (c + 3713) * 100 + "%");
            }
            if (d == 37)
            {
                Result2.Text = Convert.ToString(c / (c + 3771) * 100 + "%");
            }
            if (d == 38)
            {
                Result2.Text = Convert.ToString(c / (c + 3825) * 100 + "%");
            }
            if (d == 39)
            {
                Result2.Text = Convert.ToString(c / (c + 3875) * 100 + "%");
            }
            if (d == 40)
            {
                Result2.Text = Convert.ToString(c / (c + 3921) * 100 + "%");
            }
            if (d == 41)
            {
                Result2.Text = Convert.ToString(c / (c + 4097.9985f) * 100 + "%");
            }
            if (d == 42)
            {
                Result2.Text = Convert.ToString(c / (c + 4233.734f) * 100 + "%");
            }
            if (d == 43)
            {
                Result2.Text = Convert.ToString(c / (c + 4369.3065f) * 100 + "%");
            }
            if (d == 44)
            {
                Result2.Text = Convert.ToString(c / (c + 4504.716f) * 100 + "%");
            }
            if (d == 45)
            {
                Result2.Text = Convert.ToString(c / (c + 4639.9625f) * 100 + "%");
            }
            if (d == 46)
            {
                Result2.Text = Convert.ToString(c / (c + 4775.046f) * 100 + "%");
            }
            if (d == 47)
            {
                Result2.Text = Convert.ToString(c / (c + 4909.9665f) * 100 + "%");
            }
            if (d == 48)
            {
                Result2.Text = Convert.ToString(c / (c + 5044.724f) * 100 + "%");
            }
            if (d == 49)
            {
                Result2.Text = Convert.ToString(c / (c + 5179.3185f) * 100 + "%");
            }
            if (d == 50)
            {
                Result2.Text = Convert.ToString(c / (c + 5313.75f) * 100 + "%");
            }
            if (d == 51)
            {
                Result2.Text = Convert.ToString(c / (c + 5448.0185f) * 100 + "%");
            }
            if (d == 52)
            {
                Result2.Text = Convert.ToString(c / (c + 5582.124f) * 100 + "%");
            }
            if (d == 53)
            {
                Result2.Text = Convert.ToString(c / (c + 5716.0665f) * 100 + "%");
            }
            if (d == 54)
            {
                Result2.Text = Convert.ToString(c / (c + 5849.846f) * 100 + "%");
            }
            if (d == 55)
            {
                Result2.Text = Convert.ToString(c / (c + 5983.4625f) * 100 + "%");
            }
            if (d == 56)
            {
                Result2.Text = Convert.ToString(c / (c + 6116.916f) * 100 + "%");
            }
            if (d == 57)
            {
                Result2.Text = Convert.ToString(c / (c + 6250.2065f) * 100 + "%");
            }
            if (d == 58)
            {
                Result2.Text = Convert.ToString(c / (c + 6383.334f) * 100 + "%");
            }
            if (d == 59)
            {
                Result2.Text = Convert.ToString(c / (c + 6516.2985f) * 100 + "%");
            }
            if (d == 60)
            {
                Result2.Text = Convert.ToString(c / (c + 6649.1f) * 100 + "%");
            }
            if (d == 61)
            {
                Result2.Text = Convert.ToString(c / (c + 6781.7385f) * 100 + "%");
            }
            if (d == 62)
            {
                Result2.Text = Convert.ToString(c / (c + 6914.214f) * 100 + "%");
            }
            if (d == 63)
            {
                Result2.Text = Convert.ToString(c / (c + 7046.5265f) * 100 + "%");
            }
            if (d == 64)
            {
                Result2.Text = Convert.ToString(c / (c + 7178.676f) * 100 + "%");
            }
            if (d == 65)
            {
                Result2.Text = Convert.ToString(c / (c + 7310.6625f) * 100 + "%");
            }
            if (d == 66)
            {
                Result2.Text = Convert.ToString(c / (c + 7442.486f) * 100 + "%");
            }
            if (d == 67)
            {
                Result2.Text = Convert.ToString(c / (c + 7574.1465f) * 100 + "%");
            }
            if (d == 68)
            {
                Result2.Text = Convert.ToString(c / (c + 7705.644f) * 100 + "%");
            }
            if (d == 69)
            {
                Result2.Text = Convert.ToString(c / (c + 7836.9785f) * 100 + "%");
            }
            if (d == 70)
            {
                Result2.Text = Convert.ToString(c / (c + 7968.15f) * 100 + "%");
            }
            if (d == 71)
            {
                Result2.Text = Convert.ToString(c / (c + 8099.1585f) * 100 + "%");
            }
            if (d == 72)
            {
                Result2.Text = Convert.ToString(c / (c + 8230.004f) * 100 + "%");
            }
            if (d == 73)
            {
                Result2.Text = Convert.ToString(c / (c + 8360.6865f) * 100 + "%");
            }
            if (d == 74)
            {
                Result2.Text = Convert.ToString(c / (c + 8491.206f) * 100 + "%");
            }
            if (d == 75)
            {
                Result2.Text = Convert.ToString(c / (c + 8621.5625f) * 100 + "%");
            }
            if (d == 76)
            {
                Result2.Text = Convert.ToString(c / (c + 8751.756f) * 100 + "%");
            }
            if (d == 77)
            {
                Result2.Text = Convert.ToString(c / (c + 8881.7865f) * 100 + "%");
            }
            if (d == 78)
            {
                Result2.Text = Convert.ToString(c / (c + 9011.654f) * 100 + "%");
            }
            if (d == 79)
            {
                Result2.Text = Convert.ToString(c / (c + 9141.3585f) * 100 + "%");
            }
            if (d == 80)
            {
                Result2.Text = Convert.ToString(c / (c + 9270.9f) * 100 + "%");
            }
            if (d == 81)
            {
                Result2.Text = Convert.ToString(c / (c + 9400.2785f) * 100 + "%");
            }
            if (d == 82)
            {
                Result2.Text = Convert.ToString(c / (c + 9529.494f) * 100 + "%");
            }
            if (d == 83)
            {
                Result2.Text = Convert.ToString(c / (c + 9658.5465f) * 100 + "%");
            }
            if (d == 84)
            {
                Result2.Text = Convert.ToString(c / (c + 9787.436f) * 100 + "%");
            }
            if (d == 85)
            {
                Result2.Text = Convert.ToString(c / (c + 9916.1625f) * 100 + "%");
            }
            if (d == 86)
            {
                Result2.Text = Convert.ToString(c / (c + 10044.726f) * 100 + "%");
            }
            if (d == 87)
            {
                Result2.Text = Convert.ToString(c / (c + 10173.1265f) * 100 + "%");
            }
            if (d == 88)
            {
                Result2.Text = Convert.ToString(c / (c + 10301.364f) * 100 + "%");
            }
            if (d == 89)
            {
                Result2.Text = Convert.ToString(c / (c + 10429.4385f) * 100 + "%");
            }
            if (d == 90)
            {
                Result2.Text = Convert.ToString(c / (c + 10557.35f) * 100 + "%");
            }
            if (d == 91)
            {
                Result2.Text = Convert.ToString(c / (c + 10685.0985f) * 100 + "%");
            }
            if (d == 92)
            {
                Result2.Text = Convert.ToString(c / (c + 10812.684f) * 100 + "%");
            }
            if (d == 93)
            {
                Result2.Text = Convert.ToString(c / (c + 10940.1065f) * 100 + "%");
            }
            if (d == 94)
            {
                Result2.Text = Convert.ToString(c / (c + 11067.366f) * 100 + "%");
            }
            if (d == 95)
            {
                Result2.Text = Convert.ToString(c / (c + 11194.4625f) * 100 + "%");
            }
            if (d == 96)
            {
                Result2.Text = Convert.ToString(c / (c + 11321.396f) * 100 + "%");
            }
            if (d == 97)
            {
                Result2.Text = Convert.ToString(c / (c + 11448.1665f) * 100 + "%");
            }
            if (d == 98)
            {
                Result2.Text = Convert.ToString(c / (c + 11574.774f) * 100 + "%");
            }
            if (d == 99)
            {
                Result2.Text = Convert.ToString(c / (c + 11701.2185f) * 100 + "%");
            }
            if (d == 100)
            {
                Result2.Text = Convert.ToString(c / (c + 11827.5f) * 100 + "%");
            }
            if (d == 0)
            {
                Result2.Text = Convert.ToString("Error due to value zero exception");
            }
            if (d < 0)
            {
                Result2.Text = Convert.ToString("Error due to negative value");
            }
            if (d > 100)
            {
                Result2.Text = Convert.ToString("Error: lv limit surpassed");
            }
        }
    }
}
