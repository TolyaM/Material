using System;
using System.Collections.Generic;
using Material.Model;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Windows;
using GalaSoft.MvvmLight.Messaging;

namespace Material.ViewModel
{
    class SkirtViewModel : INotifyPropertyChanged
    {

        #region Private Variables
        private ObservableCollection<Skirt> _skirtT;
        private ObservableCollection<Skirt> _skirtP;
        private List<string> _headersSkirtT { get; set; }
        private List<string> _headersSkirtP { get; set; }
        #endregion

        //public delegate void InputDataCollectionChangedEventHandler(IList<string> inputDataCollection);
        //public event InputDataCollectionChangedEventHandler InputDataCollectionChanged;

        #region Constructor
        public SkirtViewModel()
        {
            #region AddSkirtT
            _headersSkirtT = new List<string> { "T7", "Т9", "T12", "Т18", "T19", "Т25", "T26", "Т46" };
            _skirtT = new ObservableCollection<Model.Skirt>();
            _headersSkirtT.ForEach(item => _skirtT.Add(new Skirt(item, string.Empty)));
            #endregion

            #region AddSkirtP
            _headersSkirtP = new List<string> { "П(41 - 91)", "П(51 - 57)", "П(94 - 441)", "П(97 - 47)", "П(41 - 470)", "П(470 - 47(dt))" };
            _skirtP = new ObservableCollection<Model.Skirt>();
            _headersSkirtP.ForEach(item => _skirtP.Add(new Skirt(item, string.Empty)));
            #endregion   

            //Messenger.Default.Send(SkirtP);

            //Messenger.Default.Register<Skirt>(this, (SkirtP) =>
            //{
            //    // Works with the Person object.
            //});
        }
        #endregion

        #region Events
        public event PropertyChangedEventHandler PropertyChanged;
        //public event EventHandler CanExecuteChanged;
        #endregion

        #region Public Properties
        public ObservableCollection<Skirt> SkirtT
        {
            get { return _skirtT; }
            set
            {
                _skirtT = value;
                OnPropertyChanged("SkirtT");
            }
        }

        public ObservableCollection<Skirt> SkirtP
        {
            get { return _skirtP; }
            set
            {
                _skirtP = value;
                OnPropertyChanged("SkirtP");
            }
        }
        #endregion

        #region Command
    
        #endregion

        #region Private Methods
        private void OnPropertyChanged(string propertyChanged)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyChanged));
        }
        #endregion
    }
}
