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
            
            kleur1 = ChooseColor(rnd.Next(0, 6));
            kleur2 = ChooseColor(rnd.Next(0, 6));
            kleur3 = ChooseColor(rnd.Next(0, 6));
            kleur4= ChooseColor(rnd.Next(0, 6));

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




    }
}
