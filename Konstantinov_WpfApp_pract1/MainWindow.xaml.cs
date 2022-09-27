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

namespace Konstantinov_WpfApp_pract1
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

        private void cbChoose1val_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbChoose1val.SelectedIndex == 0)
            {
                spFromMetrs.Visibility = Visibility.Visible;
                spFromNotMetrs.Visibility = Visibility.Collapsed;
            
            }
            else
            {
                spFromMetrs.Visibility = Visibility.Collapsed;
                spFromNotMetrs.Visibility = Visibility.Visible;
            }
        }

        private void btnCalc_Click(object sender, RoutedEventArgs e)
        {
           
            try {
                if (tbKm.Text == "")
                    tbKm.Text = "0";
                if (tbM.Text == "")
                    tbM.Text = "0";

                int km = Convert.ToInt32(tbKm.Text);
                double m = Convert.ToInt32(tbM.Text);

                if (km == 0 && m == 0)
                {
                    MessageBox.Show("Введите хотя бы значение");
                    return;
                    
                }
                if (km < 0 || m < 0)
                {
                    MessageBox.Show("Введите положительные значения");
                    return;

                }


                switch (cbChoose2val.SelectedIndex)
                {
                    // в мили
                    case 0:
                        textBlockResult.Text = "Результат вычислений: " + Convert.ToString((km + m/1000) * 0.621371) + " миль";
                        break;
                    // в футы
                    case 1:
                        textBlockResult.Text = "Результат вычислений: " + Convert.ToString((km + m/1000) * 3280.84) + " футов";
                        break;
                       
                    // в ярды
                    case 2:
                        textBlockResult.Text = "Результат вычислений: " + Convert.ToString((km + m/1000) * 1093.61) + " ярдов";
                        break;
                       
                    // в дюймы
                    case 3:
                        textBlockResult.Text = "Результат вычислений: " + Convert.ToString((km + m/1000) * 39370.1) + " дюймов";
                        break;
                       
                    // в версты
                    case 4:
                        textBlockResult.Text = "Результат вычислений: " + Convert.ToString((km + m/1000) * 0.937383) + " верст";
                        break;
                }

                

                

            
            }
            catch
            {
                MessageBox.Show("Введите корректные значения");
            }
        }


        private void btnCalc2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double lenghtValue = Convert.ToDouble(tbValue.Text);

                if(lenghtValue == 0)
                {
                    MessageBox.Show("Значение не может равняться нулю");
                    return;
                }
                if(lenghtValue < 0)
                {
                    MessageBox.Show("Значение не может быть отрицательным");
                    return;
                }

                string[] result;
                string newResult;

                switch (cbChoose2valNotMetrs.SelectedIndex)
                {
                    // из миль
                    case 0:
                        result = (Convert.ToString(lenghtValue / 0.621371)).Split(',');
                        newResult = result[1][0] + "" +result[1][1];
                        textBlockResult.Text = "Результат вычислений: " + result[0] + " км " + newResult + " м";
                        break;
                    // из футов
                    case 1:
                        result = (Convert.ToString(lenghtValue / 3280.84)).Split(',');
                        newResult = result[1][0] + "" + result[1][1];
                        textBlockResult.Text = "Результат вычислений: " + result[0] + " км " + newResult + " м";
                        break;

                    // из ярдов
                    case 2:
                        result = (Convert.ToString(lenghtValue / 1093.61)).Split(',');
                        newResult = result[1][0] + "" + result[1][1];
                        textBlockResult.Text = "Результат вычислений: " + result[0] + " км " + newResult + " м";
                        break;

                    // из дюймов
                    case 3:
                        result = (Convert.ToString(lenghtValue / 39370.1)).Split(',');
                        newResult = result[1][0] + "" + result[1][1];
                        textBlockResult.Text = "Результат вычислений: " + result[0] + " км " + newResult + " м";
                        break;

                    // из верст
                    case 4:
                        result = (Convert.ToString(lenghtValue / 0.937383)).Split(',');
                        newResult = result[1][0] + "" + result[1][1];
                        textBlockResult.Text = "Результат вычислений: " + result[0] + " км " + newResult + " м";
                        break;
                }

            }
            catch
            {
                MessageBox.Show("Введите корректное значение");
            }
        }

        private void cbChoose2valNotMetrs_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
    }
}
