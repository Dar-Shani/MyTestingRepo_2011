using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Lessons_2._4
{

    class Account
    {
        public enum type
        {
            current = 1,
            credit = 2,
            deposit = 3,
            budget = 4
        }

        private int id;
        private int balance;
        

        public int ID
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }

        public int Balance
        {
            get
            {
                return this.balance;
            }
            set
            {
                this.balance = value;
            }
        }

        /*public type Number
        {
            get
            {
                return Number;
            }
            set
            {
                this.Number = (type) value;
            }
        }*/
    }
}
