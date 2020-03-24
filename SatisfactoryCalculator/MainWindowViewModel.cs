using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SatisfactoryCalculator
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        #region " Constructor "

        public MainWindowViewModel()
        {
        }

        #endregion

        #region " Properties "

        #endregion

        #region " Methods "

        #endregion

        #region " Commands "

        #endregion

        #region " INotifyPropertyChanged "

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        #endregion
    }
}
