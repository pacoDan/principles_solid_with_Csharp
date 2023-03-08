namespace OpenClose
{
    public class EmployeeFullTime : Employee
    {
        public EmployeeFullTime(string fullname, int hoursWorked)
        {
            Fullname = fullname;
            HoursWorked = hoursWorked;
        }

        // public string Fullname { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        // public int HoursWorked { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override decimal CalculateSalaryMonthly()
        {
            decimal hourValue = 30000M;
            decimal salary = hourValue * HoursWorked;
            return salary;
        }

        // public override decimal CalculateSalaryMonthly()
        // {
        //     decimal hourValue = 30000M;
        //     decimal salary = hourValue * HoursWorked;
        //     return salary;
        // }
    }
}