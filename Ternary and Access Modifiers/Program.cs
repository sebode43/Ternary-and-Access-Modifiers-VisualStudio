using System;

namespace Ternary_and_Access_Modifiers {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine(Customer.PrintNextID());
            Console.WriteLine($"The cube of 17 is {Cubed(17)}");

            var cust1 = new Customer ( "Max Technical Training" );
            var cust2 = new Customer("Amazon");
            var cust3 = new Customer("Target");
            cust1.NationalAccount("yes");
            Console.WriteLine(cust1);
            Console.WriteLine(cust2);
            Console.WriteLine(cust3);

            Console.WriteLine();
            var order1 = new Order {Amount = 1000, Customer = cust1 };
            var order2 = new Order {Amount = 25000, Customer = cust2 };
            var order3 = new Order { Amount = 15000, Customer = cust3 };
            Console.WriteLine(order1);
            Console.WriteLine(order2);
            Console.WriteLine(order3);

        }

        static int Cubed(int nbr) {
            return nbr * nbr * nbr;
        }

    }
}
