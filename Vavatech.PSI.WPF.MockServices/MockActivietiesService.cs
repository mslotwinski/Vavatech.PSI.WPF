using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Vavatech.PSI.WPF.IServices;
using Vavatech.PSI.WPF.Models;

namespace Vavatech.PSI.WPF.MockServices
{
    public class MockActivietiesService : IActivietiesService
    {

        private IList<Activity> entieties = new List<Activity>();

        public MockActivietiesService(IEmployeesService employeesService)
        {
            Random random = new Random();

            entieties = Enumerable.Range(1, 100)
                .Select(i => new Activity(i,
                    DateTime.Today.AddHours(random.Next(0, 8)),
                    DateTime.Today.AddHours(random.Next(0, 8)),
                    employeesService.Get(random.Next(1,1000)),
                    (ActivityType)random.Next(0,3),
                    new Location(random.Next(0,1000),random.Next(0,400))))
                .ToList();
        }

        public IList<Activity> Get()
        {
            //Thread.Sleep(TimeSpan.FromSeconds(3));
            return entieties;
        }
        public Activity Get(int id) => entieties.SingleOrDefault(a => a.Id == id);
        public void Add(Activity entity) => entieties.Add(entity);
        public void Update(Activity entity) => throw new NotImplementedException();
        public void Remove(Activity entity) => entieties.Remove(entity);
        public Task<IList<Activity>> GetAsync()
        {
            return Task.Run(() => Get());
        }

        public IList<Activity> Get(Employee assigned)
        {
            return entieties.Where(e => e.Assigned == assigned).ToList();
        }
    }
}
