using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using System.ComponentModel;

namespace Material.Model
{
    public class CalculationModel : INotifyPropertyChanged
    {

        //public CalculationModel(string systemNumber, string lineSegment)
        //{
        //    _SystemNumber = systemNumber;
        //    _LineSegment = lineSegment;
        //}

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(property));
        }

        #region PropertyCalculationsModel
        /// <summary>
        /// Номер системы
        /// </summary>
        private string _SystemNumber;
        public string SystemNumber
        {
            get
            {
                return _SystemNumber;
            }
            set
            {
                _SystemNumber = value;
                OnPropertyChanged("SystemNumber");
            }
        }

        /// <summary>
        /// Отрезок
        /// </summary>
        private string _LineSegment;
        public string LineSegment
        {
            get
            {
                return _LineSegment;
            }
            set
            {
                _LineSegment = value;
                OnPropertyChanged("LineSegment");
            }
        }

        /// <summary>
        /// Формула
        /// </summary>
        private string _Formula;
        public string Formula
        {
            get
            {
                return _Formula;
            }
            set
            {
                _Formula = value;
                OnPropertyChanged("Formula");
            }
        }

        /// <summary>
        /// Ответ
        /// </summary>
        private double _Answer;
        public double Answer
        {
            get
            {
                return _Answer;
            }
            set
            {
                _Answer = value;
                OnPropertyChanged("Answer");
            }
        }
        #endregion 

    }
}
