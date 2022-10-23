using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

namespace Tema3_CalculadoraDinamica
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            GeneraCalculadora();
        }

        private void GeneraCalculadora()
        {
            for (int i = 0; i<5; i++)
            {
                if (i<3) calculadora_Grid.ColumnDefinitions.Add(new ColumnDefinition());
                calculadora_Grid.RowDefinitions.Add(new RowDefinition());
            }

            int n = 0;
            for (int i = 0; i<5; i++)
            {
                for (int j = 0; j<3; j++)
                {
                    TextBlock tb = new TextBlock();
                    Viewbox vb = new Viewbox();
                    if (i == 0)
                    {
                        Border border = new Border();
                        vb.Child = tb;
                        border.Child = vb;
                        Grid.SetColumnSpan(border, 3);
                        calculadora_Grid.Children.Add(border);
                    }
                    else if (i==4)
                    {
                        tb.Text = "" + (0);
                        vb.Child = tb;

                        Button btn = new Button();
                        btn.Content = vb;
                        Grid.SetRow(btn, i);
                        Grid.SetColumnSpan(btn, 3);
                        calculadora_Grid.Children.Add(btn);
                    }
                    else
                    {
                        tb.Text = "" + (n + 1);
                        vb.Child = tb;

                        Button btn = new Button();

                        btn.Content = vb;

                        Grid.SetRow(btn, i);
                        Grid.SetColumn(btn, j);

                        calculadora_Grid.Children.Add(btn);
                        n++;
                    }
                }
            }
        }
    }
}
