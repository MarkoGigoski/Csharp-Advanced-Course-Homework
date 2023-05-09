using Modesl_Exercise_1.Interfaces;
using System.Xml.Linq;

namespace Modesl_Exercise_1
{
    public class Student : User, IStudent
    {
        public List<int> Grades { get; set; }
        public Student(int id, string name, string username, string password, List<int> grades) :
            base(id,name,username,password)
        {
            Grades = grades;
        }

        public override string PrintUser()
        {
            return "* Student: " + base.PrintUser() +  $" Average grade: [{Grades.Average()}]";
        }
    }
}
