using System;
using System.Collections.Generic;
using System.Text;

namespace Ternary_and_Access_Modifiers {
    public class Order {

        public int ID { get; private set; }
        public double Amount { get; set; }
        public Customer Customer { get; set; }
        private static int NextID = 0;

        public void setCustomer(Customer customer) {
        }

        public Order() {
            this.ID = NextID += 7;
        }

        public static string PrintNextID() {
            return $"Next ID is {NextID}";
        }

        public override string ToString() {
            return $"ID = {this.ID}; Amount = {Amount}, Customer = {Customer.Name}";
        }
    }
}
