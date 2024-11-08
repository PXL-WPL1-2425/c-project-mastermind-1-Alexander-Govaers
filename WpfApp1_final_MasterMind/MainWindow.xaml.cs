using System;
using System.CodeDom.Compiler;
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
            string voornaam = "alexander";
            kleur1 = ChooseColor(rnd.Next(0, 6));
            kleur2 = ChooseColor(rnd.Next(0, 6));
            kleur3 = ChooseColor(rnd.Next(0, 6));
            kleur4= ChooseColor(rnd.Next(0, 6));

            this.Title = $"MasterMind: {kleur1}, {kleur2}, {kleur3}, {kleur4}";

            this.Title = Hi(voornaam);



        }

        private string ChooseColor(int colorChange)
        {
            if (colorChange == 0)
            {
                return "Rood";
            }
            else if (colorChange == 1)
            {
                return "Geel";
            }
            else if (colorChange == 2)
            {
                return "Oranje";
            }
            else if (colorChange == 3)
            {
                return "Wit";
            }
            else if (colorChange == 4)
            {
                return "Groen";
            }
            else if (colorChange == 5)
            {
                return "Blauw";
            }
            else
            {
                return "ERROR";
            }
        }

        private string Hi(string naam)
        {
            return $"Goedendag {naam}";

        }


    }
}
