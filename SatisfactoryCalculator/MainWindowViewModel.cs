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

        private object _currentViewModel;
        public object CurrentViewModel
        {
            get { return _currentViewModel; }
            set 
            {
                _currentViewModel = value;
                OnPropertyChanged("CurrentViewModel");
            }
        }

        private AddBuildingViewModel _addBuildingViewModel;
        public AddBuildingViewModel AddBuildingViewModel
        {
            get { return _addBuildingViewModel; }
            set 
            { 
                _addBuildingViewModel = value;
                OnPropertyChanged("AddBuildingViewModel");
            }
        }

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

        #endregion

        #region " Commands "

        private void OpenAddBuildingView()
        {
            Console.WriteLine("Add Building Command Initiated");
            AddBuildingViewModel _addBuildingViewModel = new AddBuildingViewModel();
            CurrentViewModel = _addBuildingViewModel;
        }

        #endregion
    }
}
