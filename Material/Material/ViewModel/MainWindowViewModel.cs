using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Material.ViewModel;
using System.Windows;
using System.Windows.Controls;
using Material.View.Pages;

namespace Material.ViewModel
{
    class MainWindowViewModel : INotifyPropertyChanged
    {

        public Page CurrentPage { get; set; }
        private List<Page> pages { get; set; }

        public MainWindowViewModel()
        {
            pages = new List<Page>() { new SkirtPage(), new CoatPage(), new PantsPage(), new SkirtCalculations(), new CoatCalculations(), new PantsCalculations(), new Material.View.Pages.Save(), new About() };
            CurrentPage = pages[0];
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(property));
        }

        #region Menu
        public ICommand ChangeCurrentPage
        {
            get
            {
                return new DelegateCommand(o =>
                {
                    if ((string)o != "8")
                    {
                        CurrentPage = pages[Convert.ToInt32(o)];
                    }
                    else
                    {
                        App.Current.Shutdown();
                    }
                    OnPropertyChanged(nameof(CurrentPage));
                });
            }
        }

        #region ExpandedProperty
        private bool _FirstExpander;

        public bool FirstExpander
        {
            get { return _FirstExpander; }
            set
            {
                if (_FirstExpander != value)
                {
                    if (value)
                    {
                        _FirstExpander = true;
                        _SecondExpander = false;
                    }
                    else _FirstExpander = value;
                    OnPropertyChanged("FirstExpander"); OnPropertyChanged("SecondExpander");
                }
            }
        }

        private bool _SecondExpander;

        public bool SecondExpander
        {
            get { return _SecondExpander; }
            set
            {
                if (_SecondExpander != value)
                {
                    if (value)
                    {
                        _SecondExpander = true;
                        _FirstExpander = false;
                    }
                    else _SecondExpander = value;
                    OnPropertyChanged("FirstExpander"); OnPropertyChanged("SecondExpander");
                }
            }
        }
        #endregion
        #endregion

    }
}
