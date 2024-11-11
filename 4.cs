using System;
class ExceptionHandlingExample
{
    static void Main()
    {
        try
        {
            
            // Code that may cause an exception
            Console.WriteLine("Enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());
            int result = 10 / number;
            Console.WriteLine("Result: " + result);
        }
        catch (FormatException ex)
        {
            // Handle format exception (e.g., input is not a number)
            Console.WriteLine("Format Exception: " + ex.Message);
        }
        catch (DivideByZeroException ex)
        {
            // Handle divide by zero exception
            Console.WriteLine("Divide By Zero Exception: " + ex.Message);
        }
        catch (Exception ex)
        {
            // Handle any other exceptions
            Console.WriteLine("Exception: " + ex.Message);
        }
        finally
        {
            // Code that will always execute, regardless of whether an exception is thrown
            Console.WriteLine("Finally block executed.");
        }
    }
}