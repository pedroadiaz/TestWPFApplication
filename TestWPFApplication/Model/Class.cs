using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestWPFApplication.Model
{
    public class Class
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string TimeOfDay { get; set; }
        public int ClassLength { get; set; }
        public List<WeekDay> DaysOfWeek { get; set; }

        [ForeignKey("Teacher")]
        public int TeacherID { get; set; }

        [ForeignKey("School")]
        public int SchoolID { get; set; }
    }

    public enum WeekDay
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
}
