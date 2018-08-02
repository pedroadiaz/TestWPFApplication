using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using TestWPFApplication.Model;

namespace TestWPFApplication.Data
{
    public class SchoolRepository : ISchoolRepository
    {
        private DataContext _Context;

        SchoolRepository(DataContext context)
        {
            _Context = context;
        }

        public void AddSchool(School school)
        {
            _Context.Schools.Add(school);
            _Context.SaveChanges();
        }

        public List<School> AllSchools()
        {
            return _Context.Schools.ToList();
        }

        public School GetSchool(int schoolID)
        {
            return _Context.Schools.FirstOrDefault(i=> i.ID == schoolID);
        }
    }
}
