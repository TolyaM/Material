using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Material.Model
{

    public class Skirt : INotifyPropertyChanged
    {
        public Skirt(string header, string inputData)
        {
            _header = header;
            _inputdata = inputData;
        }


        private string _header;
        public string Header
        {
            get
            {
                return _header;
            }
            set
            {
                _header = value;
                OnPropertyChanged(nameof(Header));
            }
        }

        private string _inputdata;
        public string InputData
        {
            get
            {
                return _inputdata;
            }
            set
            {
                _inputdata = value;
                OnPropertyChanged(nameof(InputData));
            }
        }

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
