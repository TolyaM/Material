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
    class CoatCalculationsViewModel : INotifyPropertyChanged
    {
        #region Private Variables
        private ObservableCollection<CalculationModel> _calculationmodel;
        #endregion

        #region Constructor
        public CoatCalculationsViewModel()
        {
            _calculationmodel = new ObservableCollection<Model.CalculationModel>();
            _calculationmodel.Add(new Model.CalculationModel() { SystemNumber = "1", LineSegment = " 11 - 91 ", Formula = "", Answer = 1 });
            _calculationmodel.Add(new Model.CalculationModel() { SystemNumber = "2", LineSegment = " 11 - 21 ", Formula = "", Answer = 1 });
            _calculationmodel.Add(new Model.CalculationModel() { SystemNumber = "3", LineSegment = " 11 - 31 ", Formula = "", Answer = 1 });
            _calculationmodel.Add(new Model.CalculationModel() { SystemNumber = "4", LineSegment = " 11 - 41 ", Formula = "", Answer = 1 });
            _calculationmodel.Add(new Model.CalculationModel() { SystemNumber = "5", LineSegment = "41 - 51", Formula = "", Answer = 1 });
            _calculationmodel.Add(new Model.CalculationModel() { SystemNumber = "6", LineSegment = "31 - 33", Formula = "", Answer = 1 });
            _calculationmodel.Add(new Model.CalculationModel() { SystemNumber = "7", LineSegment = "33 - 35", Formula = "", Answer = 1 });
            _calculationmodel.Add(new Model.CalculationModel() { SystemNumber = "8", LineSegment = "35 - 37", Formula = "", Answer = 1 });
            _calculationmodel.Add(new Model.CalculationModel() { SystemNumber = "9", LineSegment = "31 - 37", Formula = "", Answer = 1 });
            _calculationmodel.Add(new Model.CalculationModel() { SystemNumber = "10", LineSegment = "37 - 37", Formula = "", Answer = 1 });
            _calculationmodel.Add(new Model.CalculationModel() { SystemNumber = "11", LineSegment = "47 - 57", Formula = "", Answer = 1 });
            _calculationmodel.Add(new Model.CalculationModel() { SystemNumber = "12", LineSegment = "47 - 97", Formula = "", Answer = 1 });
            _calculationmodel.Add(new Model.CalculationModel() { SystemNumber = "13", LineSegment = "33 - 13", Formula = "", Answer = 1 });
            _calculationmodel.Add(new Model.CalculationModel() { SystemNumber = "14", LineSegment = "35 - 15", Formula = "", Answer = 1 });
            _calculationmodel.Add(new Model.CalculationModel() { SystemNumber = "17", LineSegment = "331 - 311", Formula = "", Answer = 1 });
            _calculationmodel.Add(new Model.CalculationModel() { SystemNumber = "18", LineSegment = "351 - 311", Formula = "", Answer = 1 });
            _calculationmodel.Add(new Model.CalculationModel() { SystemNumber = "20.1", LineSegment = "R 341 - 342", Formula = "", Answer = 1 });
            _calculationmodel.Add(new Model.CalculationModel() { SystemNumber = "21", LineSegment = "351 - 352", Formula = "", Answer = 1 });
            _calculationmodel.Add(new Model.CalculationModel() { SystemNumber = "27", LineSegment = "11 - 12", Formula = "", Answer = 1 });
            _calculationmodel.Add(new Model.CalculationModel() { SystemNumber = "28", LineSegment = "11 - 112", Formula = "", Answer = 1 });
            _calculationmodel.Add(new Model.CalculationModel() { SystemNumber = "29", LineSegment = "12 - 121", Formula = "", Answer = 1 });
            _calculationmodel.Add(new Model.CalculationModel() { SystemNumber = "30", LineSegment = "13 - 14", Formula = "", Answer = 1 });
            _calculationmodel.Add(new Model.CalculationModel() { SystemNumber = "32", LineSegment = "31 - 32", Formula = "", Answer = 1 });
            _calculationmodel.Add(new Model.CalculationModel() { SystemNumber = "34", LineSegment = "∡ 122-22-122", Formula = "", Answer = 1 });
            _calculationmodel.Add(new Model.CalculationModel() { SystemNumber = "39", LineSegment = "R 121 - 114", Formula = "", Answer = 1 });
            _calculationmodel.Add(new Model.CalculationModel() { SystemNumber = "39.1", LineSegment = "R 112 - 114", Formula = "", Answer = 1 });
            _calculationmodel.Add(new Model.CalculationModel() { SystemNumber = "45", LineSegment = "47 - 46", Formula = "", Answer = 1 });
            _calculationmodel.Add(new Model.CalculationModel() { SystemNumber = "47", LineSegment = "46 - 36", Formula = "", Answer = 1 });
            _calculationmodel.Add(new Model.CalculationModel() { SystemNumber = "48", LineSegment = "36 - 371", Formula = "", Answer = 1 });
            _calculationmodel.Add(new Model.CalculationModel() { SystemNumber = "50.1", LineSegment = "372 - 372`", Formula = "", Answer = 1 });
            _calculationmodel.Add(new Model.CalculationModel() { SystemNumber = "51", LineSegment = "371` - 361", Formula = "", Answer = 1 });
            _calculationmodel.Add(new Model.CalculationModel() { SystemNumber = "52", LineSegment = "R 36 - 16", Formula = "", Answer = 1 });
            _calculationmodel.Add(new Model.CalculationModel() { SystemNumber = "54", LineSegment = "16 - 161", Formula = "", Answer = 1 });
            _calculationmodel.Add(new Model.CalculationModel() { SystemNumber = "61", LineSegment = "411 - 470", Formula = "", Answer = 1 });
            _calculationmodel.Add(new Model.CalculationModel() { SystemNumber = "62", LineSegment = "511 - 570", Formula = "", Answer = 1 });
            _calculationmodel.Add(new Model.CalculationModel() { SystemNumber = "63.1", LineSegment = "ДП", Formula = "", Answer = 1 });
            _calculationmodel.Add(new Model.CalculationModel() { SystemNumber = "63.2", LineSegment = "ПОР", Formula = "", Answer = 1 });
            _calculationmodel.Add(new Model.CalculationModel() { SystemNumber = "63.3", LineSegment = "ДОР", Formula = "", Answer = 1 });
            _calculationmodel.Add(new Model.CalculationModel() { SystemNumber = "64", LineSegment = "331 - 351", Formula = "", Answer = 1 });
            _calculationmodel.Add(new Model.CalculationModel() { SystemNumber = "65", LineSegment = "331 - 341", Formula = "", Answer = 1 });
            _calculationmodel.Add(new Model.CalculationModel() { SystemNumber = "69", LineSegment = "351 - 352", Formula = "", Answer = 1 });
            _calculationmodel.Add(new Model.CalculationModel() { SystemNumber = "70", LineSegment = "R 352 - 343", Formula = "", Answer = 1 });
            _calculationmodel.Add(new Model.CalculationModel() { SystemNumber = "70.1", LineSegment = "R 341` - 343", Formula = "", Answer = 1 });
            _calculationmodel.Add(new Model.CalculationModel() { SystemNumber = "70.2", LineSegment = "341 - 352", Formula = "", Answer = 1 });
            _calculationmodel.Add(new Model.CalculationModel() { SystemNumber = "71", LineSegment = "351 - 333 (ШОР)", Formula = "", Answer = 1 });
            _calculationmodel.Add(new Model.CalculationModel() { SystemNumber = "72", LineSegment = "333 - 13 (ВОР)", Formula = "", Answer = 1 });
            _calculationmodel.Add(new Model.CalculationModel() { SystemNumber = "90", LineSegment = "95 - 931", Formula = "", Answer = 1 });
            _calculationmodel.Add(new Model.CalculationModel() { SystemNumber = "91", LineSegment = "95 - 94", Formula = "", Answer = 1 });
            #endregion
        }

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
