using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGridBinding
{
    class MainViewModel : ChangeNotifier
    {
        private int _selectedIndex;
        private string _selectedItem;

        private List<string> _items;

        private DateTimeOffset _selectedDate;

        public MainViewModel()
        {
            _selectedIndex = -1;
            _selectedItem = "";
            _items = new List<string>()
            {
                "one",
                "two",
                "three"
            };
            _selectedDate = DateTime.Now;
        }

        public DateTimeOffset SelectedDate
        {
            get => _selectedDate;
            set { _selectedDate = value; NotifyPropertyChanged(); NotifyPropertyChanged(nameof(SelectedIndexMessage)); }
        }

        public int SelectedIndex
        {
            get => _selectedIndex;
            set { _selectedIndex = value; NotifyPropertyChanged(); NotifyPropertyChanged(nameof(SelectedIndexMessage)); }
        }

        public string SelectedItem
        {
            get => _selectedItem;
            set { _selectedItem = value; NotifyPropertyChanged(); }
        }


        public string SelectedIndexMessage
        {
            get =>"Date is " + _selectedDate.ToString();
        }

        public List<string> Items
        {
            get => _items;
            set { _items = value; NotifyPropertyChanged(); }
        }
    }
}
