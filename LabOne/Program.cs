using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Dynamic;

namespace LabOne
{
    public class student
    {
        private string Name;
        private string Subject;
        private string EnergyLevel;
        private int CaffeineCapacity;
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
            Subject = subject_;
        }

        public void setEnergyLevel(string energyLevel_)
        {
            EnergyLevel = energyLevel_;
        } 

        public string getEnergyLevel()
        {
            return EnergyLevel;
        }

        public void setCaffeineCapacity(int caffeineCapacity_)
        {
            CaffeineCapacity = caffeineCapacity_;
        }

        public int getCaffeineCapacity()
        {
            return CaffeineCapacity;
        }

        public void setUniversity(string university_)
        {
            University = university_;
        }

        public string getUniversity()
        {
            return University;
        }

        public void setGrade(string grade_)
        {
            Grades = grade_;
        }

        public string getGrade()
        {
            return Grades;
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

            Console.WriteLine("Please enter your name : ");
            student.setName(Console.ReadLine());

            Console.WriteLine("Please enter your Subject  : ");
            student.setSubject(Console.ReadLine());

            Console.WriteLine("Please enter your name : ");
            
        }
    }
}
