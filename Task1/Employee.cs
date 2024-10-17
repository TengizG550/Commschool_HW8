namespace Task1
{
    internal enum Position
    {
        Manager = 1,
        Developer,
        Tester,
        Other
    }

    internal class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Position position { get; set; }
        public int[] WorkedHoursInTheWeek { get; set; }

        public decimal theWeekSalary()
        {

            var standardHourlyPay = position switch
            {
                Position.Manager => 40m,
                Position.Developer => 30m,
                Position.Tester => 20m,
                Position.Other => 10m,
                _ => throw new ArgumentOutOfRangeException(nameof(position), $"Invalid position value: {position}")
            };

            decimal regularHourMoney = 0, overtimeHourMoney = 0, weekendHourMoney = 0;
            for (int i = 1; i < 8; i++)
            {
                int hour = Convert.ToInt32(this.WorkedHoursInTheWeek[i - 1]);
                if (i < 6 && hour < 9)
                {
                    regularHourMoney += hour * standardHourlyPay;
                }
                else if (i >= 6)
                {
                    weekendHourMoney += hour * standardHourlyPay  * 2;
                }
                else
                {
                    overtimeHourMoney = hour * (standardHourlyPay + 5);
                }
            }

            decimal totalMoney = regularHourMoney + weekendHourMoney + overtimeHourMoney;
            if (WorkedHoursInTheWeek.Sum() > 50) totalMoney += totalMoney * 0.2m;

            return totalMoney;
        }
    }

 

}
