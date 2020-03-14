using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vavatech.PSI.WPF.Models
{
    public struct Location
    {
        public Location(double left, double top) : this()
        {
            Left = left;
            Top = top;
        }

        public double Left { get; set; }
        public double Top { get; set; }
    }

    public class Activity : Base
    {
      
        public int Id { get; set; }
        public  DateTime StarTime { get; set; }
        public DateTime? EndTime { get; set; }
        public Employee Assigned { get; set; }
        public ActivityType Type { get; set; }
        public Location Location { get; set; }

        public Activity(int id, DateTime starTime, DateTime? endTime, Employee assigned, ActivityType type, Location location)
        {
            Id = id;
            StarTime = starTime;
            EndTime = endTime;
            Assigned = assigned;
            Type = type;
            Location = location;


        }
    }

    public enum ActivityType
    {
        [Description("Pracuje")]
        Working,
        [Description("Odpoczywa")]
        Rest,
        [Description("Delegowany")]
        Delegated
    }   
}
