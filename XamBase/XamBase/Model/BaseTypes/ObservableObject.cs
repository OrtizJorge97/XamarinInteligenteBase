using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace XamBase.Model.BaseTypes
{
    public class ObservableObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        public void OnPropertyChanged([CallerMemberName]string name = "")
        {
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public void SetProperty<T>(ref T backingField, T value, [CallerMemberName] string name = "")
        {
            backingField = value;
            OnPropertyChanged(name);
        }
    }
}
