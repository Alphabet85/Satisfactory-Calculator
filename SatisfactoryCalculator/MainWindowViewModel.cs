using SatisfactoryCalculator.Helpers;
using SatisfactoryCalculator.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SatisfactoryCalculator
{
    public class MainWindowViewModel : ViewModelBase
    {
        #region " Constructor "

        public MainWindowViewModel()
        {
            OpenAddBuildingViewCommand = new RelayCommand(o => { OpenAddBuildingView(); }, o => true);
        }

        #endregion

        #region " Properties "

        #region " Command Properties "

        private ICommand _openAddBuildingViewCommand;
        public ICommand OpenAddBuildingViewCommand
        {
            get { return _openAddBuildingViewCommand; }
            set
            {
                _openAddBuildingViewCommand = value;
                OnPropertyChanged("OpenAddBuildingViewCommand");
            }
        }

        #endregion

        #endregion

        #region " Methods "

        #region " Command Methods "

        private void OpenAddBuildingView()
        {
            Console.WriteLine("Add Building Command Initiated");
        }

        #endregion

        #endregion
    }
}
