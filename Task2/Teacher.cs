namespace Task2
{
    internal class Teacher
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsCertified { get; set; }
        private static readonly Random random = new Random();


        public string ReturnMessageBasedOnSubject(string subject)
        {
            switch (subject.ToLower())
            {
                case "math":
                    {
                        int number1 = random.Next();
                        int number2 = random.Next();
                        return (number1 + number2).ToString();
                    }
                case "chemistry":
                    {
                        string[] chemicals = { "H₂O", "CO₂", "NaCl", "C₆H₁₂O₆", "NH₃", "CH₄", "H₂SO₄", "C₂H₅OH", "CaCO₃", "HCl" };
                        int randomIndex = random.Next(0, chemicals.Length);
                        return chemicals[randomIndex];
                    }
                case "English":
                    {
                        return "This is a random sentence";
                    }

                default:
                    {
                        return "The teacher is not competent is such subject";
                    }
            }
        }
    }
}
