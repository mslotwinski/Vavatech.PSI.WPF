using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vavatech.PSI.WPF.IServices;
using Vavatech.PSI.WPF.Models;

namespace Vavatech.PSI.WPF.MockServices
{
    public class MockEmployeeService: IEmployeesService 

    {
        private IList<Employee> employees = new List<Employee>();

        public MockEmployeeService()
        {

            employees = Enumerable.Range(1, 1000)
                .Select(i => new Employee(i, "John", "Smith"))
                .ToList();

            //for (int i = 0; i < 1000; i++)
            //{
            //    var entity = new Employee(i,"John","Smith");
            //    employees.Add(entity);
            //}
        }

        public Employee Get(int id) => employees.SingleOrDefault(e => e.Id == id);

        public void Remove(Employee entity) => employees.Remove(entity);
        public Task<IList<Employee>> GetAsync()
        {
            return Task.Run(() => Get());
        }

        public void Add(Employee employee) => employees.Add(employee);

        public IList<Employee> Get() => employees;

        public void Update(Employee employee) => throw new NotImplementedException();

      
    }
}
