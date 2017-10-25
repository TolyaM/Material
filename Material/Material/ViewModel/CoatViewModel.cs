using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Material.Model;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Material.ViewModel
{
    class CoatViewModel : INotifyPropertyChanged
    {
        #region Private Variables
        private ObservableCollection<Coat> _coatT;
        private ObservableCollection<Coat> _coatP;
        private List<string> _headerCoatT { get; set; }
        private List<string> _headerCoatP { get; set; }
        #endregion

        #region Constructor
        public CoatViewModel()
        {
            #region AddCoatT
            _headerCoatT = new List<string> { "T7", "T9", "T12", "T13", "T14", "T15", "T18", "T19", "T25", "T26", "T29", "T32", "T33", "T34", "T35", "T36", "T38", "T39", "T40", "T44", "T45", "T46", "T47", "T57" };
            _coatT = new ObservableCollection<Model.Coat>();
            _headerCoatT.ForEach(item => _coatT.Add(new Coat(item, string.Empty)));
            #endregion

            #region AddCoatP
            _headerCoatP = new List<string>() { "П(11 - 91)", "П(11 - 21)", "П(11 - 31)", "П(11 - 41)", "П(41 - 51)", "П(31 - 33)", "П(33 - 35)", "П(35 - 37)", "П(37 - 47)", "П(47 - 57)", "П(47 - 97)", "П(33 - 13)", "П(35 - 15)", "П(11 - 12)", "П(12 - 121)", "П(31 - 32)", "П(47 - 46)", "П(46 - 36)", "П(46 - 36)", "П(36 - 372)", "П(371` - 361)", "П(R36 - 16)", "П(16 - 161)", "П(511 - 570)", "П(351 - 333) - ШОР", "П(95 - 931)", "A17", "A18", "A19", "A21", "A39", "H", "K", "33 - 331"};
            _coatP = new ObservableCollection<Model.Coat>();
            _headerCoatP.ForEach(item => _coatP.Add(new Coat(item, string.Empty)));
            #endregion
        }
        #endregion

        #region Events
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        #region Public Properties
        public ObservableCollection<Coat> CoatT
        {
            get { return _coatT; }
            set
            {
                _coatT = value;
                OnPropertyChanged("CoatT");
            }
        }

        public ObservableCollection<Coat> CoatP
        {
            get { return _coatP; }
            set
            {
                _coatP = value;
                OnPropertyChanged("CoatP");
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
