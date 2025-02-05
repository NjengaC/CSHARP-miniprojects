using System;

namespace MyFirstApp
{
    public class MathOperations
    {
        //Properties
        public int Num1 { get; private set;}
        public int Num2 { get; private set; }

        //Constuctor
        public MathOperations(int num1, int num2)
        {
            Num1 = num1;
            Num2 = num2;
        }

        public int Subtract()
        {
            return Num1 - Num2;
        }

        public int Add()
        {
            return Num1 + Num2;
        }

        public int Multiply()
        {
            return Num1 * Num2;
        }

        public double Divide()
        {
            if(Num2 == 0)
            {
                throw new DivideByZeroException("Cannot divide by Zero");
            }
            return (double)Num1 / Num2;
        }
    }
}
