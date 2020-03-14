using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vavatech.PSI.WPF.Models;

namespace Vavatech.PSI.WPF.IServices
{
    public interface IActivietiesService 
        : IEntietiesService<Activity>
    {
      IList<Activity> Get(Employee assigned);
    }
}
