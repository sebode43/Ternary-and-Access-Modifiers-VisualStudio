using System;
using System.Collections.Generic;
using System.Text;

namespace Ternary_and_Access_Modifiers {
    public class Customer {

        public string Name { get; set; }
        public int ID { get; private set; }
        private bool IsNationalAccount { get; set; }
        private static int NextID = 1;

        static Customer() {
            //read file to get the next id to be assigned
            NextID = 4;
        }

        public override string ToString() {
            return $"ID = {this.ID}; Name = {this.Name}, NACCT = {this.IsNationalAccount}";
        }

        public void NationalAccount(string YesOrNo) {
            this.IsNationalAccount = YesOrNo.Equals("yes")? true : false;
        }

        public static string PrintNextID() {
            return $"Next ID is {NextID}";
        }

        public Customer(string Name) {
            this.ID = NextID;
            this.Name = Name;
            NextID++;

        }

    }
}
