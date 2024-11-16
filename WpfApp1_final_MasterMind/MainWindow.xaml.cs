using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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

namespace WpfApp1_final_MasterMind
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random rnd = new Random();


        string kleur1, kleur2, kleur3, kleur4;





        public MainWindow()
        {
            InitializeComponent();

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            kleur1 = ChooseColor(rnd.Next(0, 6));
            kleur2 = ChooseColor(rnd.Next(0, 6));
            kleur3 = ChooseColor(rnd.Next(0, 6));
            kleur4 = ChooseColor(rnd.Next(0, 6));

            this.Title = $"MasterMind: {kleur1}, {kleur2}, {kleur3}, {kleur4}";


        }

        private string ChooseColor(int willekeurigNummer)
        {
            if (willekeurigNummer == 0)
            {
                return "Rood";
            }
            else if (willekeurigNummer == 1)
            {
                return "Geel";
            }
            else if (willekeurigNummer == 2)
            {
                return "Oranje";
            }
            else if (willekeurigNummer == 3)
            {
                return "Wit";
            }
            else if (willekeurigNummer == 4)
            {
                return "Groen";
            }
            else if (willekeurigNummer == 5)
            {
                return "Blauw";
            }
            else
            {
                return "ERROR";
            }
        }

        private void colorChange(object sender, EventArgs e)
        {

            ComboBox changedcombobox = sender as ComboBox;

            if (changedcombobox == comboBoxKl1)
            {
                label1.Background = GetColorFromIndex(changedcombobox.SelectedIndex);
            }
            else if (changedcombobox == comboBoxKl2)
            {
                label2.Background = GetColorFromIndex(changedcombobox.SelectedIndex);
            }
            else if (changedcombobox == comboBoxKl3)
            {
                label3.Background = GetColorFromIndex(changedcombobox.SelectedIndex);
            }
            else if (changedcombobox == comboBoxKl4)
            {
                label4.Background = GetColorFromIndex(changedcombobox.SelectedIndex);
            }



        }



        private void comboBoxKl1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            colorChange(sender, e);
        }

        private void comboBoxKl2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            colorChange(sender, e);

        }


        private void comboBoxKl3_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            colorChange(sender, e);

        }

        private void comboBoxKl4_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            colorChange(sender, e);

        }

        private Brush GetColorFromIndex(int selectedIndex)
        {

            switch (selectedIndex)
            {
                case 0:

                    return Brushes.Red;

                case 1:

                    return Brushes.White;

                case 2:
                    return Brushes.Yellow;

                case 3:
                    return Brushes.Orange;

                case 4:
                    return Brushes.Green;

                case 5:
                    return Brushes.Blue;

                default:
                    return Brushes.Black;




            }
        }
        private void checkButton_Click(object sender, RoutedEventArgs e)
        {

            LabelChanged(label1, this.Title, 0, comboBoxKl1);
            LabelChanged(label2, this.Title, 1, comboBoxKl2);
            LabelChanged(label3, this.Title, 2, comboBoxKl3);
            LabelChanged(label4, this.Title, 3, comboBoxKl4);



        }
        private void LabelChanged(Label kleurLabel, string titel, int positie, ComboBox input)
        {
            string oplossing;

            switch (positie)
            {
                case 0:
                    oplossing = kleur1;
                    break;

                case 1:
                    oplossing = kleur2;
                    break;

                case 2:
                    oplossing = kleur3;
                    break;
                case 3:
                    oplossing = kleur4;
                    break;
                default:
                    oplossing = "error";
                    break;

            }

            if (titel.Contains(input.Text) && input.Text != "")
            {
                kleurLabel.BorderBrush = Brushes.Wheat;

                if (input.Text == oplossing)
                {
                    kleurLabel.BorderBrush = Brushes.DarkRed;
                }

                kleurLabel.BorderThickness = new Thickness(4);

            }
            else
            {
                kleurLabel.BorderThickness = new Thickness(0);
            }


        }
    }
}
