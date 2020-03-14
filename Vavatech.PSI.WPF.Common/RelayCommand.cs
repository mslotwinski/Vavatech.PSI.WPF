using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Vavatech.PSI.WPF.Common
{
    public class RelayCommand:ICommand
    {
        private readonly Action<object> execute;
        //private Func<bool> canExecute; 
        private readonly Predicate<object> canExecute;

        public RelayCommand(Action<object> execute, Predicate<object> canExecute=null)
        {
            this.execute = execute;
            this.canExecute = canExecute;
        }

        public bool CanExecute(object parameter)
        {
            return canExecute?.Invoke(parameter) ?? true;
        }

        public void Execute(object parameter)
        {
            execute?.Invoke(parameter);
        }

        public event EventHandler CanExecuteChanged
        {
            //wywołuje się cały czas. Kosztowne. Nie działa z wieloma wątkami.
            add => CommandManager.RequerySuggested += value;
            remove { CommandManager.RequerySuggested -= value; }
        }
    }
}
