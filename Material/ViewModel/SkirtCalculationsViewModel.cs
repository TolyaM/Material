using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Material.Model;
using System.ComponentModel;
using System.Collections.ObjectModel;
using GalaSoft.MvvmLight.Messaging;

namespace Material.ViewModel
{
    class SkirtCalculationsViewModel : INotifyPropertyChanged 
    {
        #region Private Variables
        private ObservableCollection<CalculationModel> _calculationmodel;
        public Skirt _curSkirt;
        #endregion

        //static SkirtViewModel ObjectSkirtVM;
        //ObservableCollection<Skirt> s = ObjectSkirtVM.SkirtT;
        
        #region Constructor
        public SkirtCalculationsViewModel()
        {

            #region AddItems
            _calculationmodel = new ObservableCollection<Model.CalculationModel>();
            _calculationmodel.Add(new Model.CalculationModel() { SystemNumber = "1", LineSegment = "41 - 91", Formula = "", Answer = 1 });
            _calculationmodel.Add(new Model.CalculationModel() { SystemNumber = "2", LineSegment = "41 - 51", Formula = "", Answer = 1 });
            _calculationmodel.Add(new Model.CalculationModel() { SystemNumber = "3", LineSegment = "51 - 57", Formula = "", Answer = 1 });
            _calculationmodel.Add(new Model.CalculationModel() { SystemNumber = "4", LineSegment = "51 - 54", Formula = "", Answer = 1 });
            _calculationmodel.Add(new Model.CalculationModel() { SystemNumber = "5", LineSegment = "94 - 441", Formula = "", Answer = 1 });
            _calculationmodel.Add(new Model.CalculationModel() { SystemNumber = "6", LineSegment = "97 - 47", Formula = "", Answer = 1 });
            _calculationmodel.Add(new Model.CalculationModel() { SystemNumber = "7", LineSegment = "41 - 470", Formula = "", Answer = 1 });
            _calculationmodel.Add(new Model.CalculationModel() { SystemNumber = "7.1", LineSegment = "470 - 47 (dt)", Formula = "", Answer = 1 });
            _calculationmodel.Add(new Model.CalculationModel() { SystemNumber = "8", LineSegment = "41 - 420", Formula = "", Answer = 1 });
            _calculationmodel.Add(new Model.CalculationModel() { SystemNumber = "9", LineSegment = "47 - 460", Formula = "", Answer = 1 });
            _calculationmodel.Add(new Model.CalculationModel() { SystemNumber = "10", LineSegment = "441 - 442", Formula = "", Answer = 1 });
            _calculationmodel.Add(new Model.CalculationModel() { SystemNumber = "10.1", LineSegment = "441 - 442`", Formula = "", Answer = 1 });
            _calculationmodel.Add(new Model.CalculationModel() { SystemNumber = "11", LineSegment = "41 - 42", Formula = "", Answer = 1 });
            _calculationmodel.Add(new Model.CalculationModel() { SystemNumber = "11.1", LineSegment = "42 - 521", Formula = "", Answer = 1 });
            _calculationmodel.Add(new Model.CalculationModel() { SystemNumber = "11.2", LineSegment = "42 - 421`", Formula = "", Answer = 1 });
            _calculationmodel.Add(new Model.CalculationModel() { SystemNumber = "11.3", LineSegment = "42 - 421", Formula = "", Answer = 1 });
            _calculationmodel.Add(new Model.CalculationModel() { SystemNumber = "12", LineSegment = "47 - 46", Formula = "", Answer = 1 });
            _calculationmodel.Add(new Model.CalculationModel() { SystemNumber = "12.1", LineSegment = "46 - 561", Formula = "", Answer = 1 });
            _calculationmodel.Add(new Model.CalculationModel() { SystemNumber = "12.2", LineSegment = "46 - 461", Formula = "", Answer = 1 });
            _calculationmodel.Add(new Model.CalculationModel() { SystemNumber = "12.3", LineSegment = "46 - 461`", Formula = "", Answer = 1 });
            _calculationmodel.Add(new Model.CalculationModel() { SystemNumber = "12.4", LineSegment = "41 - 42", Formula = "", Answer = 1 });
            _calculationmodel.Add(new Model.CalculationModel() { SystemNumber = "12.5", LineSegment = "41 - 43", Formula = "", Answer = 1 });
            _calculationmodel.Add(new Model.CalculationModel() { SystemNumber = "12.6", LineSegment = "47 - 45", Formula = "", Answer = 1 });
            _calculationmodel.Add(new Model.CalculationModel() { SystemNumber = "12.7", LineSegment = "42 - 421`", Formula = "", Answer = 1 });
            _calculationmodel.Add(new Model.CalculationModel() { SystemNumber = "12.8", LineSegment = "42 - 421", Formula = "", Answer = 1 });
            _calculationmodel.Add(new Model.CalculationModel() { SystemNumber = "12.9", LineSegment = "42 - 521", Formula = "", Answer = 1 });
            _calculationmodel.Add(new Model.CalculationModel() { SystemNumber = "12.10", LineSegment = "43 - 431", Formula = "", Answer = 1 });
            _calculationmodel.Add(new Model.CalculationModel() { SystemNumber = "12.11", LineSegment = "43 - 431`", Formula = "", Answer = 1 });
            _calculationmodel.Add(new Model.CalculationModel() { SystemNumber = "12.12", LineSegment = "43 - 531", Formula = "", Answer = 1 });
            _calculationmodel.Add(new Model.CalculationModel() { SystemNumber = "12.13", LineSegment = "45 - 451", Formula = "", Answer = 1 });
            _calculationmodel.Add(new Model.CalculationModel() { SystemNumber = "12.14", LineSegment = "45 - 451`", Formula = "", Answer = 1 });
            _calculationmodel.Add(new Model.CalculationModel() { SystemNumber = "12.15", LineSegment = "45 - 551", Formula = "", Answer = 1 });
            #endregion
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
