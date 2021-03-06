﻿using System;
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
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class SkirtPage : Page
    {
        public SkirtPage()
        {
            InitializeComponent();
            //this.DataContext = new SkirtViewModel();
            
        }

        private void DataPreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            TextBox T = new TextBox();
            T = (TextBox)e.Source;

            if (T.Text.Length == 0) e.Handled = "0123456789".IndexOf(e.Text) < 0;
            else
                if (T.Text.IndexOf(",") != -1) e.Handled = "0123456789".IndexOf(e.Text) < 0;
            else
                e.Handled = "0123456789 ,".IndexOf(e.Text) < 0;
        }

        private void DataPreviewLostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
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

        private void DataPreviewKeyDown(object sender, KeyEventArgs e)
        {
            var s = e.Source as TextBox;
            if (s == null) return;
            switch (e.Key)
            {
                case Key.Enter:
                    s.MoveFocus(new TraversalRequest(FocusNavigationDirection.Next));
                    break;
                case Key.Right:
                    s.MoveFocus(new TraversalRequest(FocusNavigationDirection.Right));
                    break;
                case Key.Left:
                    s.MoveFocus(new TraversalRequest(FocusNavigationDirection.Left));
                    break;
                case Key.Up:
                    s.MoveFocus(new TraversalRequest(FocusNavigationDirection.Up));
                    break;
                case Key.Down:
                    s.MoveFocus(new TraversalRequest(FocusNavigationDirection.Down));
                    break;
                default:
                    e.Handled = false;
                    return;
            }
            e.Handled = true;
        }
    }
}
