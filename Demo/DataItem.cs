using System.Collections.ObjectModel;
using System.ComponentModel;

namespace Demo
{
    public class DataItem
    {
        public DataItem()
        {
            Options = new ObservableCollection<string>();
        }

        public ObservableCollection<string> Options
        {
            get; private set;
        }

        #region Name

        private string _name = null;

        /// <summary>
        /// Gets or sets the Name property. This observable property 
        /// indicates ....
        /// </summary>
        public string Name
        {
            get { return _name; }
            set
            {
                if (_name != value)
                {
                    _name = value;
                    RaisePropertyChanged("Name");
                }
            }
        }

        #endregion

        #region SelectedOption

        private string _selectedOption = null;

        /// <summary>
        /// Gets or sets the SelectedOption property. This observable property 
        /// indicates ....
        /// </summary>
        public string SelectedOption
        {
            get { return _selectedOption; }
            set
            {
                if (_selectedOption != value)
                {
                    _selectedOption = value;
                    RaisePropertyChanged("SelectedOption");
                }
            }
        }

        #endregion

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;
        protected void RaisePropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(name));
        }

        #endregion

    }
}
