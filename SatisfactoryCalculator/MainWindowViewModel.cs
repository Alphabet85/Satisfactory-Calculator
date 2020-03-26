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
            
        }

        #endregion

        #region " Properties "

        private string _outputPerMinute;
        public string OutputPerMinute
        {
            get { return _outputPerMinute; }
            set 
            { 
                _outputPerMinute = value;
                OnPropertyChanged("OutputPerMinute");
            }
        }

        private string _inputPerMinute;
        public string InputPerMinute
        {
            get { return _inputPerMinute; }
            set
            {
                _inputPerMinute = value;
                OnPropertyChanged("InputPerMinute");
            }
        }

        private string _numberOfResourcesNeeded;
        public string NumberOfResourcesNeeded
        {
            get { return _numberOfResourcesNeeded; }
            set
            {
                _numberOfResourcesNeeded = value;
                OnPropertyChanged("NumberOfResourcesNeeded");
            }
        }

        private string _sourceProductionTimePerUnit;
        public string SourceProductionTimePerUnit
        {
            get { return _sourceProductionTimePerUnit; }
            set
            {
                _sourceProductionTimePerUnit = value;
                OnPropertyChanged("SourceProductionTimePerUnit");
            }
        }

        private string _destinationProductionTimePerUnit;
        public string DestinationProductionTimePerUnit
        {
            get { return _destinationProductionTimePerUnit; }
            set
            {
                _destinationProductionTimePerUnit = value;
                OnPropertyChanged("DestinationProductionTimePerUnit");
            }
        }

        private bool _isCalculateButtonEnabled;
        public bool IsCalculateButtonEnabled
        {
            get { return _isCalculateButtonEnabled; }
            set 
            {
                _isCalculateButtonEnabled = value;
                OnPropertyChanged("IsCalculateButtonEnabled");
            }
        }

        #region " Command Properties "

        private ICommand _calculateCommand;
        public ICommand CalculateCommand
        {
            get 
            {
                _calculateCommand = new RelayCommand(o => { Calculate(); }, o => CheckFields());
                return _calculateCommand; 
            }
            set 
            { 
                _calculateCommand = value;
                OnPropertyChanged("CalculateCommand");
            }
        }

        private ICommand _resetCommand;
        public ICommand ResetCommand
        {
            get 
            {
                _resetCommand = new RelayCommand(o => { Reset(); }, o => true);
                return _resetCommand; 
            }
            set
            {
                _resetCommand = value;
                OnPropertyChanged("ResetCommand");
            }
        }

        #endregion

        #endregion

        #region " Methods "

        #region " Command Methods "

        private void Calculate()
        {
            Console.WriteLine("Calculate Entries");
            Console.WriteLine(OutputPerMinute + " / " + InputPerMinute + " / " + NumberOfResourcesNeeded + " / " + SourceProductionTimePerUnit + " / " + DestinationProductionTimePerUnit);

        }

        private void Reset()
        {
            OutputPerMinute = "";
            InputPerMinute = "";
            NumberOfResourcesNeeded = "";
            SourceProductionTimePerUnit = "";
            DestinationProductionTimePerUnit = "";

        }

        private bool CheckFields()
        {
            return !string.IsNullOrEmpty(OutputPerMinute) && !string.IsNullOrEmpty(InputPerMinute) && !string.IsNullOrEmpty(NumberOfResourcesNeeded) && !string.IsNullOrEmpty(DestinationProductionTimePerUnit) && !string.IsNullOrEmpty(SourceProductionTimePerUnit);
        }

        #endregion

        #endregion
    }
}
