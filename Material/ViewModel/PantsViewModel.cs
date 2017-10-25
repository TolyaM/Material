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
    class PantsViewModel : INotifyPropertyChanged
    {
        #region Private Variables
        private ObservableCollection<Pants> _pantsT;
        private ObservableCollection<Pants> _pantsP;
        private List<string> _headerPantsT { get; set; }
        private List<string> _headerPantsP { get; set; }
        #endregion

        #region Constructor
        public PantsViewModel()
        {
            #region AddSkirtT
            _headerPantsT = new List<string>() { "T1", "T7", "T8", "T9", "T12", "T18", "T19", "T22", "T25", "T26", "T27", "T51" };
            _pantsT = new ObservableCollection<Model.Pants>();
            _headerPantsT.ForEach(item => _pantsT.Add(new Pants(item, string.Empty)));
            #endregion

            #region AddSkirtP
            _headerPantsP = new List<string>() { "П(51 - 57)", "П(51 - 58)", "П(57 - 58`)", "П(72 - 78)", "П(72 - 741)", "П(76 - 78`)", "П(92 - 98)", "П(92 - 941)", "П(96 - 98`)", "П(41 - 470)", "П(470 - 47(dt))", "A31", "K" };
            _pantsP = new ObservableCollection<Model.Pants>();
            _headerPantsP.ForEach(item => _pantsP.Add(new Pants(item, string.Empty)));
            #endregion
        }
        #endregion

        #region Events
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        #region Public Properties
        public ObservableCollection<Pants> PantsT
        {
            get { return _pantsT; }
            set
            {
                _pantsT = value;
                OnPropertyChanged("PantsT");
            }
        }

        public ObservableCollection<Pants> PantsP
        {
            get { return _pantsP; }
            set
            {
                _pantsP = value;
                OnPropertyChanged("PantsP");
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
