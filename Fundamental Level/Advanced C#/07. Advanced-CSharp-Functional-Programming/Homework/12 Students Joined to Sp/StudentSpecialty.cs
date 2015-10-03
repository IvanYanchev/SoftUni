using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Students_Joined_to_Specialties
{
    public class StudentSpecialty
    {
        public StudentSpecialty(string specialtyName, int facultyNumber)
        {
            this.SpecialtyName = specialtyName;
            this.FacultyNumber = facultyNumber;
        }
        public string SpecialtyName { get; set; }
        public int FacultyNumber { get; set; }
    }
}
