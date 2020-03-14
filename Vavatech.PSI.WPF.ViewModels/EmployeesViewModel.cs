using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vavatech.PSI.WPF.Models;

namespace Vavatech.PSI.WPF.ViewModels
{
    public class EmployeesViewModel: BaseViewModel
    {
        public IList<Employee> Employees { get; set; }
    }
}
