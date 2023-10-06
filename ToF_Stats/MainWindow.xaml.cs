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
            MessageBox.Show("EN: Crit rate and resists scaling changes on lvl growth\nRU: Крит шанс и резисты скалируются в зависимости от уровня\n\nEN: Crit rate is linear.but resist is hyperbolic\nRU: Крит шанс линейный, а резист гиперболический");
        }

        private void Button_Click_3(object sender,RoutedEventArgs e)
        {
           
        }

        public void Button_CritRate(object sender,RoutedEventArgs e)
        {
            float a,b;
            float divisor = 1.0f;
            a = Convert.ToSingle(TextBox.Text);
            b = Convert.ToSingle(Lv1.Text);


            switch (b)
            {
                case 0:
                    Result.Text = "Error due to value zero exception";
                    break;
                case var lv when lv < 0:
                    Result.Text = "Error due to negative value";
                    break;
                case var lv when lv > 100:
                    Result.Text = "Error: lv limit surpassed";
                    break;
                case 1:
                    divisor = 150f;
                    break;
                case 2:
                    divisor = 300f;
                    break;
                case 3:
                    divisor = 450f;
                    break;
                case 4:
                    divisor = 600f;
                    break;
                case 5:
                    divisor = 750f;
                    break;
                case 6:
                    divisor = 900f;
                    break;
                case 7:
                    divisor = 1050f;
                    break;
                case 8:
                    divisor = 1200f;
                    break;
                case 9:
                    divisor = 1350f;
                    break;
                case 10:
                    divisor = 1602f;
                    break;
                case 11:
                    divisor = 1926f;
                    break;
                case 12:
                    divisor = 2242f;
                    break;
                case 13:
                    divisor = 2550f;
                    break;
                case 14:
                    divisor = 2850f;
                    break;
                case 15:
                    divisor = 3142f;
                    break;
                case 16:
                    divisor = 3426f;
                    break;
                case 17:
                    divisor = 3702f;
                    break;
                case 18:
                    divisor = 3970f;
                    break;
                case 19:
                    divisor = 4230f;
                    break;
                case 20:
                    divisor = 4482f;
                    break;
                case 21:
                    divisor = 4726f;
                    break;
                case 22:
                    divisor = 4962f;
                    break;
                case 23:
                    divisor = 5190f;
                    break;
                case 24:
                    divisor = 5410f;
                    break;
                case 25:
                    divisor = 5622f;
                    break;
                case 26:
                    divisor = 5826f;
                    break;
                case 27:
                    divisor = 6022f;
                    break;
                case 28:
                    divisor = 6210f;
                    break;
                case 29:
                    divisor = 6390f;
                    break;
                case 30:
                    divisor = 6562f;
                    break;
                case 31:
                    divisor = 6726f;
                    break;
                case 32:
                    divisor = 6882f;
                    break;
                case 33:
                    divisor = 7030f;
                    break;
                case 34:
                    divisor = 7170f;
                    break;
                case 35:
                    divisor = 7302f;
                    break;
                case 36:
                    divisor = 7426f;
                    break;
                case 37:
                    divisor = 7542f;
                    break;
                case 38:
                    divisor = 7650f;
                    break;
                case 39:
                    divisor = 7750f;
                    break;
                case 40:
                    divisor = 7842f;
                    break;
                case 41:
                    divisor = 8195.997f;
                    break;
                case 42:
                    divisor = 8467.468f;
                    break;
                case 43:
                    divisor = 8738.613f;
                    break;
                case 44:
                    divisor = 9009.432f;
                    break;
                case 45:
                    divisor = 9279.925f;
                    break;
                case 46:
                    divisor = 9550.092f;
                    break;
                case 47:
                    divisor = 9819.933f;
                    break;
                case 48:
                    divisor = 10089.448f;
                    break;
                case 49:
                    divisor = 10358.637f;
                    break;
                case 50:
                    divisor = 10627.5f;
                    break;
                case 51:
                    divisor = 10896.037f;
                    break;
                case 52:
                    divisor = 11164.248f;
                    break;
                case 53:
                    divisor = 11432.133f;
                    break;
                case 54:
                    divisor = 11699.692f;
                    break;
                case 55:
                    divisor = 11966.925f;
                    break;
                case 56:
                    divisor = 12233.832f;
                    break;
                case 57:
                    divisor = 12500.413f;
                    break;
                case 58:
                    divisor = 12766.668f;
                    break;
                case 59:
                    divisor = 13032.597f;
                    break;
                case 60:
                    divisor = 13298.2f;
                    break;
                case 61:
                    divisor = 13563.477f;
                    break;
                case 62:
                    divisor = 13828.428f;
                    break;
                case 63:
                    divisor = 14093.053f;
                    break;
                case 64:
                    divisor = 14357.352f;
                    break;
                case 65:
                    divisor = 14621.325f;
                    break;
                case 66:
                    divisor = 14884.972f;
                    break;
                case 67:
                    divisor = 15148.293f;
                    break;
                case 68:
                    divisor = 15411.288f;
                    break;
                case 69:
                    divisor = 15673.957f;
                    break;
                case 70:
                    divisor = 15936.3f;
                    break;
                case 71:
                    divisor = 16198.317f;
                    break;
                case 72:
                    divisor = 16460.008f;
                    break;
                case 73:
                    divisor = 16721.373f;
                    break;
                case 74:
                    divisor = 16982.412f;
                    break;
                case 75:
                    divisor = 17243.125f;
                    break;
                case 76:
                    divisor = 17503.512f;
                    break;
                case 77:
                    divisor = 17763.573f;
                    break;
                case 78:
                    divisor = 18023.308f;
                    break;
                case 79:
                    divisor = 18282.717f;
                    break;
                case 80:
                    divisor = 18541.8f;
                    break;
                case 81:
                    divisor = 18800.557f;
                    break;
                case 82:
                    divisor = 19058.988f;
                    break;
                case 83:
                    divisor = 19317.093f;
                    break;
                case 84:
                    divisor = 19574.872f;
                    break;
                case 85:
                    divisor = 19832.325f;
                    break;
                case 86:
                    divisor = 20089.452f;
                    break;
                case 87:
                    divisor = 20346.253f;
                    break;
                case 88:
                    divisor = 20602.728f;
                    break;
                case 89:
                    divisor = 20858.877f;
                    break;
                case 90:
                    divisor = 21114.7f;
                    break;
                case 91:
                    divisor = 21370.197f;
                    break;
                case 92:
                    divisor = 21625.368f;
                    break;
                case 93:
                    divisor = 21880.213f;
                    break;
                case 94:
                    divisor = 22134.732f;
                    break;
                case 95:
                    divisor = 22388.925f;
                    break;
                case 96:
                    divisor = 22642.792f;
                    break;
                case 97:
                    divisor = 22896.333f;
                    break;
                case 98:
                    divisor = 23149.548f;
                    break;
                case 99:
                    divisor = 23402.437f;
                    break;
                case 100:
                    divisor = 23655f;
                    break;
                default:
                    Result.Text = "Invalid value of b";
                    break;
            }

            float result = (a / divisor * 100);
            Result.Text = $"{result}%";



        }

        private void Button_Res(object sender, RoutedEventArgs e)
        {
            float c, d;
            c = Convert.ToSingle(Resist.Text);
            d = Convert.ToSingle(Lv2.Text);


            float[] divisor = {
        75, 150, 225, 300, 375, 450, 525, 600, 675, 801,
        963, 1121, 1275, 1425, 1571, 1713, 1851, 1985, 2115, 2241,
        2363, 2481, 2595, 2705, 2811, 2913, 3011, 3105, 3195, 3281,
        3363, 3441, 3515, 3585, 3651, 3713, 3771, 3825, 3875, 3921,
        4097.9985f, 4233.734f, 4369.3065f, 4504.716f, 4639.9625f, 4775.046f,
        4909.9665f, 5044.724f, 5179.3185f, 5313.75f, 5448.0185f, 5582.124f,
        5716.0665f, 5849.846f, 5983.4625f, 6116.916f, 6250.2065f, 6383.334f,
        6516.2985f, 6649.1f, 6781.7385f, 6914.214f, 7046.5265f, 7178.676f,
        7310.6625f, 7442.486f, 7574.1465f, 7705.644f, 7836.9785f, 7968.15f,
        8099.1585f, 8230.004f, 8360.6865f, 8491.206f, 8621.5625f, 8751.756f,
        8881.7865f, 9011.654f, 9141.3585f, 9270.9f, 9400.2785f, 9529.494f,
        9658.5465f, 9787.436f, 9916.1625f, 10044.726f, 10173.1265f, 10301.364f,
        10429.4385f, 10557.35f, 10685.0985f, 10812.684f, 10940.1065f, 11067.366f,
        11194.4625f, 11321.396f, 11448.1665f, 11574.774f, 11701.2185f, 11827.5f
    };

            if (d >= 1 && d <= 100)
            {
                short index = Convert.ToInt16(d - 1);
                float result = c / (c + divisor[index]) * 100;
                Result2.Text = result.ToString("0.00") + "%";
            }
            else if (d == 0)
            {
                Result2.Text = "Error: Value of d cannot be zero";
            }
            else if (d < 0)
            {
                Result2.Text = "Error: Value of d cannot be negative";
            }
            else
            {
                Result2.Text = "Error: Value of d cannot be greater than 100";
            }
        }

    }

}
