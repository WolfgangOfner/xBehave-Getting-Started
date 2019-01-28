namespace CompanyManagement
{
    public class Employee
    {
        public Employee()
        {
            Salary = 1000;
            MonthlyWorkingHoursDuringTheWeek = 100;
        }

        public decimal Salary { get; set; }

        public int MonthlyWorkingHoursDuringTheWeek { get; set; }

        public void AddMonthlyHoursWorkedDuringTheWeek(int hours)
        {
            var differenceOfWorkedAndContractedHours = hours - MonthlyWorkingHoursDuringTheWeek;

            Salary += differenceOfWorkedAndContractedHours * 10;
        }

        public void AddMonthlyHoursWorkedOnTheWeekend(int hours)
        {
            Salary += hours * 15;
        }

        public void AddMonthlyHoursWorkedOnHolidays(int hours)
        {
            Salary += hours * 20;
        }
    }
}