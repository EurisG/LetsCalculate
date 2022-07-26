using System;

namespace MyProgram{

    class calc {

        static void Main(string[] args){
            try {
                 Console.WriteLine("Lets Calculate (+, -, * And /)");
            Console.WriteLine("Write the first number..");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write the second number..");
            int second = Convert.ToInt32(Console.ReadLine());

            int mult = first * second;
            int add = first + second;
            int sub = first - second;
            int div = first / second;

            Console.WriteLine("Multiplication : " + mult);
            Console.WriteLine("Addition : " + add);
            Console.WriteLine("Subtraction : " + sub);
            Console.WriteLine("Division : " + div);

            }
            catch(Exception e) {
                Console.WriteLine(e.Message);
            }
            finally{
                    Console.ReadKey();
            }
           



        }
    }
}
