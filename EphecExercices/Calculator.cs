﻿namespace EphecExercices
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
                return salary + salary * taxRate;
            }
        }

        private string _text1;
        public string Text1
        {
            get { return _text1; }
            set { _text1 = value; }
        }

        private string _text2;
        public string Text2
        {
            get { return _text2; }
            set { _text2 = value; }
        }
    }
}
