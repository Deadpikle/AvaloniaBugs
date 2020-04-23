using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace StaticObjectBinding
{
    class AnObject
    {
        public static event PropertyChangedEventHandler StaticPropertyChanged;

        private static void OnStaticPropertyChanged(string propertyName)
        {
            StaticPropertyChanged?.Invoke(null, new PropertyChangedEventArgs(propertyName));
        }

        private static bool _myProperty = true;

        public static bool MyProperty
        {
            get => _myProperty;
            set
            {
                _myProperty = value;
                OnStaticPropertyChanged(nameof(MyProperty));
            }
        }
    }
}
