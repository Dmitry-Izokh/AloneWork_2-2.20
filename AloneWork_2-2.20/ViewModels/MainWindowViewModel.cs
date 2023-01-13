using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
// подключаю пространство имен (папку Models)
using AloneWork_2_2._20.Models;

namespace AloneWork_2_2._20.ViewModels
{
    // Неведомая и непонятная штука из урока 19, остается без изменения. Что-то связанное с передачей значения свойств от разных других штук у кого есть ссылка на что-то из того что напишу ниже.
        class MainWindowViewModel : INotifyPropertyChanged
        {
            public event PropertyChangedEventHandler PropertyChanged;

            void OnPropertyChaged([CallerMemberName] string PropertyName = null)   //событие через метод Invoke
        {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
            }

        // Создаю свойства
        // строка = текст. написал текст его и принимаем за текст, всем кто связан с этим свойством отдаем то что написали в текст.
        private string text;
        public string Text
        {                      
            get => text;
            set
            {
                text = value;
                OnPropertyChaged();
            }
        }

        // result это то что получилось в результате выполнения операции, всем кто имеет ссылку и связан с результатом отдаем то что получилось.
        private string result;
        public string Result
        {
            get => result;
            set
            {
                result = value;
                OnPropertyChaged();
            }
        }
        // Создаю команды.
        // На каждую команду в синтаксисе есть 2 строки и уникальное имя с харрактерными словами.
        // После в фигурных скобках пишу Текст из публичного свойства += и какой-то знак.
        // (Оператор += создает новую строку, которая содержит объединенное содержимое.
        // В данном случае после набора нового знака новая строка будет включать в себя все что было до и этот самый знак.
        // в кавычках "_" записываем именно строку а не знак. Тоесть содаем новую строку из старой и новой строк).
        
        public ICommand OnCommand_But_0 { get; }
        private void OnCommand_But_0_Execute(object p)
        { Text += "0"; }

        public ICommand OnCommand_But_1 { get; }
        private void OnCommand_But_1_Execute(object p)
        { Text += "1"; }

        public ICommand OnCommand_But_2 { get; }
        private void OnCommand_But_2_Execute(object p)
        { Text += "2"; }

        public ICommand OnCommand_But_3 { get; }
        private void OnCommand_But_3_Execute(object p)
        { Text += "3"; }

        public ICommand OnCommand_But_4 { get; }
        private void OnCommand_But_4_Execute(object p)
        { Text += "4"; }

        public ICommand OnCommand_But_5 { get; }
        private void OnCommand_But_5_Execute(object p)
        { Text += "5"; }

        public ICommand OnCommand_But_6 { get; }
        private void OnCommand_But_6_Execute(object p)
        { Text += "6"; }

        public ICommand OnCommand_But_7 { get; }
        private void OnCommand_But_7_Execute(object p)
        { Text += "7"; }

        public ICommand OnCommand_But_8 { get; }
        private void OnCommand_But_8_Execute(object p)
        { Text += "8"; }

        public ICommand OnCommand_But_9 { get; }
        private void OnCommand_But_9_Execute(object p)
        { Text += "9"; }

        // Аналогично команды для знаков операций.
        // Видимо метод из папки Models работает как конвертор строки операцию распознания и выполнения
        // математического выражения, но это не точно.
        
        public ICommand OnCommand_But_Div { get; }
        private void OnCommand_But_Div_Execute(object p) 
        { Text += "/"; }

        public ICommand OnCommand_But_Mult { get; }
        private void OnCommand_But_Mult_Execute(object p)
        { Text += "*"; }

        public ICommand OnCommand_But_Minus { get; }
        private void OnCommand_But_Minus_Execute(object p)
        { Text += "-"; }

        public ICommand OnCommand_But_Plus { get; }
        private void OnCommand_But_Plus_Execute(object p)
        { Text += "+"; }

        // Теперь пишу команды на логические операции. Синтаксис тот же, но в фигурных скобках добавляю проверку if{}

        //Команда очистки
        public ICommand Command_Clear { get; }
        private void OnCommand_Clear_Execute(object p)
        {
            if (Text.Length > 0)
            {
                Text = Text.Remove(0);
            }    
        }

        //Команда результата
        public ICommand Command_Result { get; }
        private void OnCommand_Result_Execute(object p)
        {
            // Вот это по ходу и есть встроенный системный метод,
            // который волшебным способом рассчитывает строку как математическое выражение.
            // Видимо мы в команде вызываем выпонение статического системного метода
            Result = Calculation.GetResult(Text);
            //Тут мы пишем нестандартную подачу материала на экране, сохраняем все что было написано до и прибавляем строку"=Result" к предыдущей строке.
            Text += "=" + Result;
        }

        // Видимо дальше написана строка которая работает на все команды выше. Смысл ее я не улавливаю,
        // но видимо это что-то связано с необходимостью уточнить о возможности выполнить команды.
        // На что мы дали ответ true (да, правда, это сделать можно). 
        
        private bool OnAddCanExecuted(object p)
        {
            return true;
         
        }


        // Cоздаем конструктор который оствечает за соответствие того,
        // что написано в привязке {Binding Path=} на кнопке к конкретным командам указанным выше.
        // Название этого конструктора как-то связано с названием этого класса и файла.
        // Вначале пишу название команды или привязки - они названы одинаково (то что будет написано в Binding = новый экземпляр класса RelayCommand
        // (это стандартная обертка которая вероятна универсальна и без изменения может подойти для множества задач).
        // В скобках вначале пишу команду отвечающую за что-то конкретное (выше)
        // а потом команду отвечающую за разрешение запуска (ниже). 

        public MainWindowViewModel()
        {
            Command_Result = new RelayCommand(OnCommand_Result_Execute, OnAddCanExecuted);
            Command_Clear = new RelayCommand(OnCommand_Clear_Execute, OnAddCanExecuted);

            OnCommand_But_0 = new RelayCommand(OnCommand_But_0_Execute, OnAddCanExecuted);
            OnCommand_But_1 = new RelayCommand(OnCommand_But_1_Execute, OnAddCanExecuted);
            OnCommand_But_2 = new RelayCommand(OnCommand_But_2_Execute, OnAddCanExecuted);
            OnCommand_But_3 = new RelayCommand(OnCommand_But_3_Execute, OnAddCanExecuted);
            OnCommand_But_4 = new RelayCommand(OnCommand_But_4_Execute, OnAddCanExecuted);
            OnCommand_But_5 = new RelayCommand(OnCommand_But_5_Execute, OnAddCanExecuted);
            OnCommand_But_6 = new RelayCommand(OnCommand_But_6_Execute, OnAddCanExecuted);
            OnCommand_But_7 = new RelayCommand(OnCommand_But_7_Execute, OnAddCanExecuted);
            OnCommand_But_8 = new RelayCommand(OnCommand_But_8_Execute, OnAddCanExecuted);
            OnCommand_But_9 = new RelayCommand(OnCommand_But_9_Execute, OnAddCanExecuted);

            OnCommand_But_Div = new RelayCommand(OnCommand_But_Div_Execute, OnAddCanExecuted);
            OnCommand_But_Mult = new RelayCommand(OnCommand_But_Mult_Execute, OnAddCanExecuted);
            OnCommand_But_Minus = new RelayCommand(OnCommand_But_Minus_Execute, OnAddCanExecuted);
            OnCommand_But_Plus = new RelayCommand(OnCommand_But_Plus_Execute, OnAddCanExecuted);         
            
        }
        }
}
