using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace NoteTakingAssignment
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
            public MainPageViewModel()
            {

            }

            public event PropertyChangedEventHandler PropertyChanged;

            private string theNote;
            public string TheNote
            {
                get => theNote;
                set
                {

                }
            }

    }
    
}
