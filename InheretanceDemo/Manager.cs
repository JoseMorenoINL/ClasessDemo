namespace InheretanceDemo
{
    class Manager : Employee
    {

        public bool CompanyCar { get; set; }
         public Manager( string name, bool hasCar)
            :base (name)

        {
            CompanyCar = hasCar;
        }

        public override void TakeVacation()
        {
            vacationDays += 15;
        }

        
        public override string ToString()
        {
            return
               $"[Manager. Name={Name} CompanyCar={CompanyCar}, Vacation={vacationDays}]";
        }
    }
}
