using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;
using Vavatech.PSI.WPF.Common;
using Vavatech.PSI.WPF.IServices;
using Vavatech.PSI.WPF.MockServices;
using Vavatech.PSI.WPF.Models;

namespace Vavatech.PSI.WPF.ViewModels
{
   
    public class ActivietiesViewModel : BaseViewModel
    {
        public  IList<Activity> Activities { get; set; }
        public Activity SelectedActivity { get; set; }

        private readonly IActivietiesService activietiesService;

        public ICommand LoadCommand { get; private set; }

        public bool IsBusy { get; set; }

        public ActivietiesViewModel(IActivietiesService activietiesService)
        {
            this.activietiesService = activietiesService;
            LoadCommand =new RelayCommand(p=>LoadAsync());


           //if(Sy)

        }

        public void Load()
        {
            LoadAsync().Wait();
        }

        public ActivietiesViewModel()
        : this(new MockActivietiesService(new MockEmployeeService()))
        {

        }

        private  async Task LoadAsync()
        {
            IsBusy = true;
            Activities = await activietiesService.GetAsync();
            IsBusy = false;
        }
    }
}