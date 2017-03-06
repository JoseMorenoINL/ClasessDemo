namespace Constructors
{
    public class Employee
    {

        public int YearsOfService { get; set; }
        public int Office { get; set; }

        public Employee(int years, int office)
        {
            YearsOfService = years;
            Office = office;

        }

        public Employee()
        {
            YearsOfService = 20;
            Office = 301;
        }
    }
}
