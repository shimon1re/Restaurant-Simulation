﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResturantSimulation
{
    class Program
    {
        Queue<Customer> enter_billing_queue = new Queue<Customer>();
        struct Customer
        {
            int customer_number;
            int value_of_order;
            DateTime time_of_enter;
            int leave_queue;
        }

        struct Order
        {
            int prepar_time;
            int customer_number;
        }


        void customer_enter_to_resturant(Customer new_customer)
        {
            //STEP 1:
            //customer check if wait in the queue or leave it.


        }

        static void Main(string[] args)
        {
           
            int choice = 0;
            int duration = 0;
            do
            {
                Console.WriteLine("Please choose the time in day");
                Console.WriteLine("1. Morning");
                Console.WriteLine("2. Noon");
                Console.WriteLine("3. Evening");
                choice = Int32.Parse(Console.ReadLine());
                Console.WriteLine(choice);
            } while (choice != 1 && choice != 2 && choice != 3);

            do
            {
                Console.WriteLine("Please enter the duration of simulation in hours (1-4)");
                duration = Int32.Parse(Console.ReadLine());
            } while (duration == 0 || duration > 4);
            switch (choice)
            {
                case 1:
                    Console.WriteLine("--------------Morning simulation---------------");
                    break;
                case 2:
                    Console.WriteLine("---------------Noon simulation-----------------");
                    break;
                case 3:
                    Console.WriteLine("--------------Evening simulation---------------");
                    break;
                
                default:

                    break;


            }
        }
    }
}
