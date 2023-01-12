using AloneWork_2_2._20.Models;
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

        private double nomber1;
        public double Nomber1
        {
            //Назначение первого числа:
            //Array[i] a=new Array[];
            //i=значение клика кнопки;
            //nomber1 = Convert.ToDouble(a);
            
            get => nomber1;
            set
            {
                nomber1 =value;
                OnPropertyChaged();
            }
        }

        private double nomber2;
        public double Nomber2
        {
            get => nomber2;
            set
            {
                nomber2 = value;
                OnPropertyChaged();
            }
        }

        private double nomber3;
        public double Nomber3
        {
            get => nomber3;
            set
            {
                nomber3 = value;
                OnPropertyChaged();
            }
        }        
        //Включение AC
        public ICommand AddCommandClear { get; }
        private void OnAddCommandExecute(object p)
        {
            Nomber3 = 0;

        }
        private bool CanAddCommandExecuted(object p)
        {
            //Если в поле есть какое-то значение то при нажатии AC команда сработает, если значение 0, то команда недействительна.
            if (nomber1 != 0 || nomber2 != 0)
                return true;
            else
                return false;
        }

        //Включение +/-
        //public ICommand AddCommandSignReplacement { get; }
        //private void OnAddCommandExecute(object p)
        //{
        //    Nomber3 = -Nomber3;
        //}
        //private bool CanAddCommandExecuted(object p)
        //{
        //   return true;
            
        //}

        public MainWindowViewModel()
            {
            AddCommandClear = new RelayCommand(OnAddCommandExecute, CanAddCommandExecuted);
            //AddCommandSignReplacement = new RelayCommand(OnAddCommandExecute, CanAddCommandExecuted);
        }
        }
}
