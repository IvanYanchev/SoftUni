namespace HumanStudentAndWorker
{
    public class Worker : Human
    {
        private int weekSalary;
        private int workHoursPerDay;

        public Worker(string firstName, string lastName, int weekSalary, int workHoursPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public int WeekSalary { get; set; }
        public int WorkHoursPerDay { get; set; }

        public double MoneyPerHour()
        {
            double money = (double)this.WeekSalary / (5.0 * this.WorkHoursPerDay);
            return money;
        }
    }
}
