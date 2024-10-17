using System;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();

            Console.WriteLine("Enter Student First Name:");
            student.FirstName = Console.ReadLine();

            Console.WriteLine("Enter Student Last Name:");
            student.LastName = Console.ReadLine();

            Console.WriteLine("Enter Student Age:");
            student.Age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Enrollment Date (yyyy-MM-dd):");
            student.EnrollmentDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine($"Time left until graduation: {student.TimeLeft().TotalDays} days");
            Console.WriteLine($"Time left until graduation in years: {student.TimeLeftInYears():F2} years");

            Teacher teacher = new Teacher();

            Console.WriteLine("Enter Teacher First Name:");
            teacher.FirstName = Console.ReadLine();

            Console.WriteLine("Enter Teacher Last Name:");
            teacher.LastName = Console.ReadLine();

            Console.WriteLine("Is the Teacher Certified? (yes/no):");
            string certifiedInput = Console.ReadLine();
            teacher.IsCertified = certifiedInput.Equals("yes", StringComparison.OrdinalIgnoreCase);

            string subject = student.GetRandomSubject();
            Console.WriteLine($"Random subject selected: {subject}");

            string response = teacher.ReturnMessageBasedOnSubject(subject);
            Console.WriteLine($"Message from teacher for {subject}: {response}");


        }
    }
}
