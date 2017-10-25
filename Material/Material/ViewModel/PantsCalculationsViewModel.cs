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
    class PantsCalculationsViewModel : INotifyPropertyChanged
    {
        #region Private Variables
        private ObservableCollection<CalculationModel> _calculationmodel;
        //private List<string> _systemNumber;
        //private List<string> _lineSegment;
        #endregion

        #region Constructor
        public PantsCalculationsViewModel()
        {
            //_systemNumber = new List<string>() { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "31", "32.2", "34.2", "35", "38", "38.1", "39", "40", "40.1", "40.2", "40.3", "41", "41.1", "41.2", "41.3", "42", "42.1", "42.2"};
            //_lineSegment = new List<string>() { "41 - 51", "51 - 57", "51 - 54", "54` - 57", "44` - 940", "940 - 441`", "940 - 440", "940 - 64", "940 - 74", "940 - 94", "51 - 58", "57 - 58`", "58 - 52", "54` - 56", "72 - 78", "72 - 741", "76 - 741`", "76 - 78`", "92 - 98", "92 - 941", "96 - 941`", "96 - 98", "41 - 470", "68 - 681", "681 - 512", "68` - 57", "470 - 47 (dt)", "441 - 420", "441 - 442", "47 - 471", "411 - 421", "421 - 521", "421 - 422", "421 - 422", "411 - 43", "43 - 531", "43 - 431", "43 - 431`", "46 - 561", "46 - 461", "46 - 461`" };
            _calculationmodel = new ObservableCollection<Model.CalculationModel>();
            //_systemNumber.ForEach(item => _calculationmodel.Add(new Model.CalculationModel(item, string.Empty)));
            _calculationmodel.Add(new Model.CalculationModel() { SystemNumber = "1", LineSegment = "41 - 51", Formula = "", Answer = 1 });
            _calculationmodel.Add(new Model.CalculationModel() { SystemNumber = "2", LineSegment = "51 - 57", Formula = "", Answer = 1 });
            _calculationmodel.Add(new Model.CalculationModel() { SystemNumber = "3", LineSegment = "51 - 54", Formula = "", Answer = 1 });
            _calculationmodel.Add(new Model.CalculationModel() { SystemNumber = "4", LineSegment = "54` - 57", Formula = "", Answer = 1 });
            _calculationmodel.Add(new Model.CalculationModel() { SystemNumber = "5", LineSegment = "44` - 940", Formula = "", Answer = 1 });
            _calculationmodel.Add(new Model.CalculationModel() { SystemNumber = "6", LineSegment = "940 - 441`", Formula = "", Answer = 1 });
            _calculationmodel.Add(new Model.CalculationModel() { SystemNumber = "7", LineSegment = "940 - 440", Formula = "", Answer = 1 });
            _calculationmodel.Add(new Model.CalculationModel() { SystemNumber = "8", LineSegment = "940 - 64", Formula = "", Answer = 1 });
            _calculationmodel.Add(new Model.CalculationModel() { SystemNumber = "9", LineSegment = "940 - 74", Formula = "", Answer = 1 });
            _calculationmodel.Add(new Model.CalculationModel() { SystemNumber = "10", LineSegment = "940 - 94", Formula = "", Answer = 1 });
            _calculationmodel.Add(new Model.CalculationModel() { SystemNumber = "11", LineSegment = "51 - 58", Formula = "", Answer = 1 });
            _calculationmodel.Add(new Model.CalculationModel() { SystemNumber = "12", LineSegment = "57 - 58`", Formula = "", Answer = 1 });
            _calculationmodel.Add(new Model.CalculationModel() { SystemNumber = "13", LineSegment = "58 - 52", Formula = "", Answer = 1 });
            _calculationmodel.Add(new Model.CalculationModel() { SystemNumber = "14", LineSegment = "54` - 56", Formula = "", Answer = 1 });
            _calculationmodel.Add(new Model.CalculationModel() { SystemNumber = "15", LineSegment = "72 - 78", Formula = "", Answer = 1 });
            _calculationmodel.Add(new Model.CalculationModel() { SystemNumber = "16", LineSegment = "72 - 741", Formula = "", Answer = 1 });
            _calculationmodel.Add(new Model.CalculationModel() { SystemNumber = "17", LineSegment = "76 - 741`", Formula = "", Answer = 1 });
            _calculationmodel.Add(new Model.CalculationModel() { SystemNumber = "18", LineSegment = "76 - 78`", Formula = "", Answer = 1 });
            _calculationmodel.Add(new Model.CalculationModel() { SystemNumber = "19", LineSegment = "92 - 98", Formula = "", Answer = 1 });
            _calculationmodel.Add(new Model.CalculationModel() { SystemNumber = "20", LineSegment = "92 - 941", Formula = "", Answer = 1 });
            _calculationmodel.Add(new Model.CalculationModel() { SystemNumber = "21", LineSegment = "96 - 941`", Formula = "", Answer = 1 });
            _calculationmodel.Add(new Model.CalculationModel() { SystemNumber = "22", LineSegment = "96 - 98", Formula = "", Answer = 1 });
            _calculationmodel.Add(new Model.CalculationModel() { SystemNumber = "23", LineSegment = "41 - 470", Formula = "", Answer = 1 });
            _calculationmodel.Add(new Model.CalculationModel() { SystemNumber = "31", LineSegment = "68 - 681", Formula = "", Answer = 1 });
            _calculationmodel.Add(new Model.CalculationModel() { SystemNumber = "32.2", LineSegment = "681 - 512", Formula = "", Answer = 1 });
            _calculationmodel.Add(new Model.CalculationModel() { SystemNumber = "34.2", LineSegment = "68` - 57", Formula = "", Answer = 1 });
            _calculationmodel.Add(new Model.CalculationModel() { SystemNumber = "35", LineSegment = "470 - 47 (dt)", Formula = "", Answer = 1 });
            _calculationmodel.Add(new Model.CalculationModel() { SystemNumber = "38", LineSegment = "441 - 420", Formula = "", Answer = 1 });
            _calculationmodel.Add(new Model.CalculationModel() { SystemNumber = "38.1", LineSegment = "441 - 442", Formula = "", Answer = 1 });
            _calculationmodel.Add(new Model.CalculationModel() { SystemNumber = "39", LineSegment = "47 - 471", Formula = "", Answer = 1 });
            _calculationmodel.Add(new Model.CalculationModel() { SystemNumber = "40", LineSegment = "411 - 421", Formula = "", Answer = 1 });
            _calculationmodel.Add(new Model.CalculationModel() { SystemNumber = "40.1", LineSegment = "421 - 521", Formula = "", Answer = 1 });
            _calculationmodel.Add(new Model.CalculationModel() { SystemNumber = "40.2", LineSegment = "421 - 422", Formula = "", Answer = 1 });
            _calculationmodel.Add(new Model.CalculationModel() { SystemNumber = "40.3", LineSegment = "421 - 422", Formula = "", Answer = 1 });
            _calculationmodel.Add(new Model.CalculationModel() { SystemNumber = "41", LineSegment = "411 - 43", Formula = "", Answer = 1 });
            _calculationmodel.Add(new Model.CalculationModel() { SystemNumber = "41.1", LineSegment = "43 - 531", Formula = "", Answer = 1 });
            _calculationmodel.Add(new Model.CalculationModel() { SystemNumber = "41.2", LineSegment = "43 - 431", Formula = "", Answer = 1 });
            _calculationmodel.Add(new Model.CalculationModel() { SystemNumber = "41.3", LineSegment = "43 - 431`", Formula = "", Answer = 1 });
            _calculationmodel.Add(new Model.CalculationModel() { SystemNumber = "42", LineSegment = "46 - 561", Formula = "", Answer = 1 });
            _calculationmodel.Add(new Model.CalculationModel() { SystemNumber = "42.1", LineSegment = "46 - 461", Formula = "", Answer = 1 });
            _calculationmodel.Add(new Model.CalculationModel() { SystemNumber = "42.2", LineSegment = "46 - 461`", Formula = "", Answer = 1 });
        }
        #endregion

        #region Public Properties
        public ObservableCollection<CalculationModel> CalculationModel
        {
            get { return _calculationmodel; }
            set
            {
                _calculationmodel = value;
                OnPropertyChanged("CalculationModel");
            }
        }
        #endregion

        #region Events
        public event PropertyChangedEventHandler PropertyChanged;
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
