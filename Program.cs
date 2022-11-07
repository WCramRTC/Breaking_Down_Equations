using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breaking_Down_Equations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // PEMDAS - Math Order of Operations
            // Parentheses Exponents
            // Multiplation Division

            // Addition Subtraction

            // symbolab.com
            // 34 + 22 / 33 * 45 - 18 * 199

            Console.ReadKey();
        }

        

        public static void Eqution_HandWritten()
        {
            // How to breakdown a math problem
            // 34 + 22 / 33 * 45 - 18 * 199
            // Result -3518

            // PEDMAS - Order of Operations
            // Parentheses Exponent
            // Divide Multi
            // Add Subtract

            // 34 +  (22 / 33) * 45 - 18 * 199
            // First: 22 / 33 = .66

            // 34 + (.66 * 45) - 18 * 199
            // Second: .66 * 45 = 29.7 or 30

            // 34 + 30 - (18 * 199)
            // Third: 18 * 199 = 3582

            // (34 + 30) - 3582
            // Fourth: 34 + 30 = 64

            // 64 - 3582
            // Final: 64 - 3582 = -3518

            // symbolab.com

            // ---------------------------
        } // Eqution_HandWritten

        public static void Equation_MathOperators()
        {
            // Math Operators

            // 34 + (22 / 33) * 45 - 18 * 199
            double first = 22 / 33.0; // .66
            Console.WriteLine(first);

            // 34 + (.66 * 45) - 18 * 199
            // 34 +  (first * 45) - 18 * 199
            double second = first * 45; // 30
            Console.WriteLine(second);

            // 34 + 30 - (18 * 199)
            // 34 + second - (18 * 199)
            double third = 18 * 199; // 3582
            Console.WriteLine(third);

            // (34 + 30) - 3582
            // (34 + second) - third
            double fourth = 34 + second; // 64
            Console.WriteLine(fourth);

            // 64 - 3582
            // fourth - third
            double final = fourth - third; // -3518
            Console.WriteLine(final);
        } // Equation_MathOperators

        public static void Equation_Methods()
        {

            // ----------------------------------------
            Console.WriteLine("Method");

            //// 34 + (22 / 33) * 45 - 18 * 199
            //double mFirst = Divide(22, 33);
            //Console.WriteLine(mFirst);

            //// 34 + .66 * 45 - 18 * 199
            //// 34 + (mFirst * 45) - 18 * 199
            //double mSecond = Multi(mFirst, 45);
            //Console.WriteLine(mSecond);

            //// 34 + 30 - (18 * 199)
            //// 34 + mSecond - (18 * 199)
            //double mThird = Multi(18, 199);
            //Console.WriteLine(mThird);

            //// (34 + 30) - 3582
            //// (34 + mSecond) - mThird
            //double mFourth = Add(34, mSecond);
            //Console.WriteLine(mFourth);

            //// 64 - 3582
            //// mFourth - mThird
            //double mFinal = Minus(mFourth, mThird);
            //Console.WriteLine(mFinal);
        } // Equation_Methods

        public static double Add(double num1, double num2)
        {
            return num1 + num2;
        }

        public static double Subtract(double num1, double num2)
        {
            return num1 - num2;
        }

        public static double Multi(double num1, double num2)
        {
            return num1 * num2;
        }

        public static double Divide(double num1, double num2)
        {
            return num1 / num2;
        }

    }
}
