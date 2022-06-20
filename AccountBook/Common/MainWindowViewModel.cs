using AccountBook.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountBook.Common
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        #region Property
        //public string inOutTypeName { get; set; }
        //public string categoryName { get; set; }

        //public List<MainWindowViewModel> items { get; set; }
        #endregion

        #region [Event]
        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        #endregion

        private DateTime selectedDateTime = DateTime.Now;
        public DateTime SelectedDateTime
        {
            get => selectedDateTime;
            set
            {
                selectedDateTime = value;
                NotifyPropertyChanged(nameof(SelectedDateTime));
            }
        }

        public void Initialize()
        {
            
        }

    }
}
