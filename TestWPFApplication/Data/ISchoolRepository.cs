using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TestWPFApplication.Model;

namespace TestWPFApplication.Data
{
    public interface ISchoolRepository
    {
        void AddSchool(School school);
        List<School> AllSchools();
        School GetSchool(int schoolID);

    }
}
