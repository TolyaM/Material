using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using Material.ViewModel;

namespace Material.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class CoatPage : Page
    {
     
        public CoatPage()
        {
            InitializeComponent();
            //this.DataContext = new CoatViewModel();
        }

        private void T7_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            TextBox T = new TextBox();
            T = (TextBox)e.Source;
            if (T.Text.Length == 0) e.Handled = "0123456789".IndexOf(e.Text) < 0;
            else
                if (T.Text.IndexOf(",") != -1) e.Handled = "0123456789".IndexOf(e.Text) < 0;
            else
                e.Handled = "0123456789 ,".IndexOf(e.Text) < 0;
        }

        private void T7_PreviewLostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            TextBox T = new TextBox();
            T = (TextBox)e.Source;
            try
            {
                if (T.Text.Remove(0, T.Text.Length - 1) == ",") T.Text += "0";
            }
            catch (System.ArgumentOutOfRangeException)
            {
                //Значение счетчика не может быть меньше нуля.
            }
        }

        private void WrapPanel_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                TextBox s = e.Source as TextBox;
                if (s != null)
                {
                    s.MoveFocus(new TraversalRequest(FocusNavigationDirection.Next));
                }
                e.Handled = true;
            }

            if (e.Key == Key.Right)
            {
                TextBox s = e.Source as TextBox;
                if (s != null)
                {
                    s.MoveFocus(new TraversalRequest(FocusNavigationDirection.Right));
                }
                e.Handled = true;
            }

            if (e.Key == Key.Left)
            {
                TextBox s = e.Source as TextBox;
                if (s != null)
                {
                    s.MoveFocus(new TraversalRequest(FocusNavigationDirection.Left));
                }
                e.Handled = true;
            }

            if (e.Key == Key.Up)
            {
                TextBox s = e.Source as TextBox;
                if (s != null)
                {
                    s.MoveFocus(new TraversalRequest(FocusNavigationDirection.Up));
                }
                e.Handled = true;
            }

            if (e.Key == Key.Down)
            {
                TextBox s = e.Source as TextBox;
                if (s != null)
                {
                    s.MoveFocus(new TraversalRequest(FocusNavigationDirection.Down));
                }
                e.Handled = true;
            }
        }
    }
}
