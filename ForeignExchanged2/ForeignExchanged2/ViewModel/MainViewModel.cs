using ForeignExchanged2.Models;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ForeignExchanged2.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        #region Attribute
        private bool isRunning;
        public bool isEnabled;
        #endregion

        #region Events
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        #region Properties
        public Rates SourceRate { get; set; }
        public Rates TargerRate { get; set; }
        public ObservableCollection<Rates> Rates { get; set; }

        public string Result { get; set; }
        public string Amount { get; set; }

        public bool IsRunning
        { 
            set
            {
                if (isRunning != value)
                {
                    isRunning = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(IsRunning)));
                }
            }
            get
            {
                return isRunning;
            }
        }

        public bool IsEnabled
        {
            set
            {
                if (isEnabled != value)
                {
                    isEnabled = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(IsEnabled)));
                }
            }
            get
            {
                return isEnabled;
            }
        }
        #endregion

        public MainViewModel()
        {
            Rates = new ObservableCollection<Rates>();
            LoadRates();
        }

        

        #region Methods
        private void LoadRates()
        {
            IsRunning = true;
            Result = "Loading rates...";
        } 
        #endregion

        #region Command
        public ICommand ConvertsCommand { get { return new RelayCommand(Converts); } }

        private void Converts()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}


