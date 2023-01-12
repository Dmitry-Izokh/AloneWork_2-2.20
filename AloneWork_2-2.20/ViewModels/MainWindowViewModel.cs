//using AloneWork_2_2._20.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AloneWork_2_2._20.ViewModels
{
    
        class MainWindowViewModel : INotifyPropertyChanged
        {
            public event PropertyChangedEventHandler PropertyChanged;

            void OnPropertyChaged([CallerMemberName] string PropertyName = null)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
            }

        //private double radius;
        //public double Radius
        //{
        //    get => radius;
        //    set
        //    {
        //        radius = value;
        //        OnPropertyChaged();
        //    }
        //}

        //private double circumference;
        //public double Сircumference
        //{
        //    get => circumference;
        //    set
        //    {
        //        circumference = value;
        //        OnPropertyChaged();
        //    }
        //}

        public ICommand AddCommand { get; }
        private void OnAddCommandExecute(object p)
        {
            //Сircumference = CircumferenceСalculation.Сalculation(Radius);
        }

        private bool CanAddCommandExecuted(object p)
        {
            //if (radius != 0)
                return true;
            //else
            //    return false;
        }
        public MainWindowViewModel()
            {
                AddCommand = new RelayCommand(OnAddCommandExecute, CanAddCommandExecuted);
            }
        }
}
