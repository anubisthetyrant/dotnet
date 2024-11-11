
using System;
using System.Numerics;
namespace Arithematicofcomplexnumbers
{
    class ADWIN
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Complex Numbers using all Arithmetic Operations");
                Console.Write("Enter real part of first complex number: ");
                double real1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter imaginary part of first complex number: ");
                double imag1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter real part of second complex number: ");
                double real2 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter imaginary part of second complex number: ");
                double imag2 = Convert.ToDouble(Console.ReadLine());
                Complex c1 = new Complex(real1, imag1);
                Complex c2 = new Complex(real2, imag2);
                Console.WriteLine("Choose an operation:");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Addition: " + ToString(c1 + c2));
                        break;
                    case 2:
                        Console.WriteLine("Subtraction: " + ToString(c1 - c2));
                        break;
                    case 3:
                        Console.WriteLine("Multiplication: " + ToString(c1 * c2));
                        break;
                    case 4:
                        Console.WriteLine("Division: " + ToString(c1 / c2));
                        break;
                    case 5:
                        Console.WriteLine("Exiting...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }

        static string ToString(Complex c)
        {
            if (c.Imaginary == 0)
                return c.Real.ToString();
            else if (c.Real == 0)
                return c.Imaginary.ToString() + "i";
            else
                return c.Real.ToString() + " + " + c.Imaginary.ToString() + "i";
        }
    }
}