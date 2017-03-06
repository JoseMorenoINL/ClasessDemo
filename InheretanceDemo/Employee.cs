namespace InheretanceDemo
{
    public class Employee
    {
        public string Name { get; set; }
        protected double vacationDays;
        public virtual void TakeVacation() { }

        public Employee(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return $"[Employee: Name = {Name}]";
        }


    }
}