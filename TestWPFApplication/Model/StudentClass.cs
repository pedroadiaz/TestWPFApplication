using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestWPFApplication.Model
{
    public class StudentClass
    {
        public int ID { get; set; }

        [ForeignKey("Class")]
        public int ClassID { get; set; }

        [ForeignKey("Student")]
        public int StudentID { get; set; }

        public virtual Student Student { get; set; }
        public virtual Class Class { get; set; }
    }
}
