using Microsoft.VisualBasic.CompilerServices;
using System;

namespace LabOne
{
    public class student
    {
        private string Name;
        private string Subject;
        private string EnergyLevel;
        private string CaffeineCapacity;
        private string University;
        private string Grades;

        public string getName()
        {
            return Name;
        }

        public void setName(string name_)
        {
            this.Name = name_;
        }

        public string getSubject()
        {
            return Subject;
        }

        public void setSubject( string subject_)
        {
            this.Subject = subject_;
        }

        public void Listen()
        {

        }

        public void TakeTest(int hours)
        {
            Console.WriteLine("{0} takes {1} with C# test for {2} hours", Name, Subject,hours);
        }

        public void AttendLectures ()
        {

        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            student student = new student();
            student.setName ("Innocent");
            student.setSubject("Programming");

            Console.WriteLine(student.getName() == "Innocent");
            Console.WriteLine(student.getSubject() == "Programming");

            student.TakeTest(2);
        }
    }
}
