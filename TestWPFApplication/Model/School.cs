using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;


namespace TestWPFApplication.Model
{
    public class School
    {
        public int ID { get; set; }
        public string SchoolName { get; set; }
        public string Address { get; set; }
        public string CityName { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string PhoneNumber { get; set; }
    }
}
