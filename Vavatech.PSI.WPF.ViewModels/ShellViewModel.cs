using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Vavatech.PSI.WPF.Common;

namespace Vavatech.PSI.WPF.ViewModels
{
    public class ShellViewModel:BaseViewModel
    {
        public ShellViewModel()
        {
            SelectedViewModel = new EmployeesViewModel();
            ShowActivietiesCommand = new RelayCommand(p=> ShowActivieties(), p=>CanShowActivieties);
            ShowEmployeesCommand = new RelayCommand(p => ShowEmployees(), p => CanShowEmployees);
            ShowKeyboaradCommand = new RelayCommand(p => ShowKeyboard(), p => CanShowKeyboard);
        }

        public BaseViewModel SelectedViewModel { get; set; }

        //public BaseViewModel SelectedViewModel
        //{
        //    get { return _selectedViewModel; }
        //    set
        //    {
        //        _selectedViewModel = value;
        //        //OnPropertyChanged();
        //    }
        //}

        public void ShowActivieties()
        {
            SelectedViewModel = new ActivietiesViewModel();
        }

        public bool CanShowActivieties => true;

        public ICommand ShowActivietiesCommand { get; private set; }

        public void ShowEmployees()
        {
            SelectedViewModel = new EmployeesViewModel();
        }


        public bool CanShowEmployees => true;

        public ICommand ShowEmployeesCommand { get; private set; }


        public void ShowKeyboard()
        {
            SelectedViewModel = new KeyboardViewModel();
        }

        public bool CanShowKeyboard => true;

        public ICommand ShowKeyboaradCommand { get; private set; }
    }
}
