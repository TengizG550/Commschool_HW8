namespace Task2
{
    internal class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public DateTime EnrollmentDate { get; set; }

        private static readonly Random random = new Random();

        public TimeSpan TimeLeft() 
        {
           return EnrollmentDate.AddYears(4) - DateTime.Now;
        }

        public string GetRandomSubject()
        {
            string[] subjects = { "Math", "Biology", "Chemistry", "English", "Physics" };
            int randomIndex = random.Next(0, subjects.Length);
            return subjects[randomIndex];
        }
        public double TimeLeftInYears()
        {
            TimeSpan timeLeft = TimeLeft();
            return timeLeft.TotalDays / 365.25; 
        }


    }
}
