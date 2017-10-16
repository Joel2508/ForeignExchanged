using ForeignExchanged2.Models;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ForeignExchanged2.ViewModel
{
    public class MainViewModel
    {
        #region Properties
        public Rates SourceRate { get; set; }
        public Rates TargerRate { get; set; }
        public ObservableCollection<Rates> Rates { get; set; }

        public string Result { get; set; }
        public string Amount { get; set; }
        public bool IsRunning { get; set; }
        public bool IsEnabled { get; set; }
        #endregion

        public MainViewModel()
        {
            Rates = new ObservableCollection<Rates>();
        }

        #region Command
        public ICommand ConvertsCommand { get { return new RelayCommand(Converts); } }

        private void Converts()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}


