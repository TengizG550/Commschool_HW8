namespace Task1
{
    internal class Company
    {
        public bool IsLocal { get; set; }

        public decimal GovernmentGets(decimal salary)
        {
            return IsLocal ? salary * 0.18m : salary * 0.05m;
        }
    }

}
