using Modesl_Exercise_1.Interfaces;

namespace Modesl_Exercise_1
{
    public class Teacher : User, ITeacher
    {
        public string Subject { get; set; }
        public Teacher(int id, string name, string username, string password, string subject) :
            base(id, name, username, password)
        {
            Subject = subject;
        }
        public override string PrintUser()
        {
            return "* Teacher: " + base.PrintUser() + $"Subject: [{Subject}]";
        }

    }
}
