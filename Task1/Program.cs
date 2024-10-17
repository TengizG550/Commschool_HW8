namespace Task1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Company company = new Company();
            Console.WriteLine("Is your company local?\nEnter 1 for yes, 0 for no");
            string input = Console.ReadLine();
            int isLocal = 0;
            while (true)
            {
                if (int.TryParse(input, out isLocal) && (isLocal == 0 || isLocal == 1))
                {
                    company.IsLocal = isLocal == 1;
                    break;
                }
                else
                {
                    Console.WriteLine("Enter 0 or 1");
                    input = Console.ReadLine();
                }
            }
            decimal employeeSalary = getEmployeeSalary();
            Console.WriteLine(company.GovernmentGets(employeeSalary));


        }

        private static decimal getEmployeeSalary()
        {
            Employee employee = new Employee();
            Console.WriteLine("Enter first name of the employee");
            employee.FirstName = Console.ReadLine();
            Console.WriteLine("Enter last name of the employee");
            employee.LastName = Console.ReadLine();
            Console.WriteLine("Enter age of the employee");
            string ageInput = Console.ReadLine();
            int age = 0;
            while (true)
            {
                if (int.TryParse(ageInput, out age) && age > 0)
                {
                    employee.Age = age;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input for age. Please enter a valid positive whole number.");
                    ageInput = Console.ReadLine();
                }
            }
            Console.WriteLine("Enter working position of the employee\n1 for manager\n2 for developer\n3 for tester\n4 for other");

            string positionInput = Console.ReadLine();
            int position = 0;
            while (true)
            {
                if (int.TryParse(positionInput, out position) && position > 0 && position < 5)
                {
                    employee.position = (Position)position;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input for position. Please enter a valid position");
                    positionInput = Console.ReadLine();
                }
            }

            Console.WriteLine("Enter worked hours in format: * * * * * * *");
            string inputString = Console.ReadLine();
            int[] workedHoursEachDayOfTheWeek = inputString
                .Split(" ")
                .Where(input => input != "")
                .Select(num => Convert.ToInt32(num))
                .Take(7)
                .ToArray();
            employee.WorkedHoursInTheWeek = workedHoursEachDayOfTheWeek;

            return employee.theWeekSalary();
        }
    }
}