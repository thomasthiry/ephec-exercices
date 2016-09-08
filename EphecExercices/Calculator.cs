namespace EphecExercices
{
    public class Calculator
    {
        public decimal CalculateCost1()
        {
            return 42;
        }

        public decimal CalculateCost2(decimal salary)
        {
            if (salary < 1000)
            {
                return 1000;
            }
            else
            {
                return salary;
            }
        }

        public decimal CalculateCost3(decimal salary, decimal taxRate)
        {
            if (salary < 1000)
            {
                return 1000;
            }
            else
            {
                var taxes = salary*taxRate;
                return salary + taxes;
            }
        }
    }
}
