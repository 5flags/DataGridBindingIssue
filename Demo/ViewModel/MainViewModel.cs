using System.Data;
using GalaSoft.MvvmLight;

namespace Demo.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add(new DataColumn("Name") { DataType = typeof(string) });
            dt.Columns.Add(new DataColumn("Option") { DataType = typeof(DataItem) });

            for (int i = 0; i < 5; i++)
            {
                var newRow = dt.NewRow();
                var dataItem = new DataItem();
                dataItem.Name = "Data Item " + i;

                for (int j = 0; j < 5; j++)
                {
                    dataItem.Options.Add(dataItem.Name + " Option 1");
                }

                newRow[0] = dataItem.Name;
                newRow[1] = dataItem;

                dt.Rows.Add(newRow);
            }

            Data = dt.DefaultView;
        }

        #region Data

        private DataView _data = null;

        /// <summary>
        /// Gets or sets the Data property. This observable property 
        /// indicates ....
        /// </summary>
        public DataView Data
        {
            get { return _data; }
            set
            {
                if (_data != value)
                {
                    _data = value;
                    RaisePropertyChanged(() => Data);
                }
            }
        }

        #endregion

        
    }
}