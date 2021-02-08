using System;

namespace ExceptionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int b, result;
            int coffee = 0;
            int a = 42;
            while(true)
            {
                try
                {
                    if (coffee < 1) throw new NeedMoreCoffeeException("Need more coffee!", 2);

                    Console.Write("Enter a number: ");
                    b = int.Parse(Console.ReadLine());

                    result = a / b;
                    Console.WriteLine($"The result is {result}");
                    Console.WriteLine("Ready");
                    break;
                }
                catch  (Exception error) // Catch all exceptions
                {
                    Console.WriteLine("First stage of error handling");

                    try // Do something general for all errors
                    {
                        Console.WriteLine("Second stage of error handling");
                        throw error; // Rethrow error
                    }
                    catch (NeedMoreCoffeeException e)
                    {
                        Console.WriteLine(e.Message);
                        Console.Write("Please give me some coffee: ");
                        coffee = int.Parse(Console.ReadLine());
                        Console.WriteLine("Thank you! Now continue");
                    }
                    catch (DivideByZeroException) // Handle divide by zero exception
                    {
                        Console.WriteLine("Divide by zero error");
                    }
                    catch (Exception e) // Handle the rest
                    {
                        Console.WriteLine($"Something else went wrong: {e.Message}");
                    } 
                    finally
                    {
                        Console.WriteLine("Try again!\n\n");
                    }
                }

            }

        }
    }
}
