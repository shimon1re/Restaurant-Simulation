﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ResturantSimulation
{
    class Program
    {
        public static int custNum = 0;
        Random random = new Random();
        static Queue<Customer> billing_queue = new Queue<Customer>();
       public struct Customer
        {
           public int customer_number;
           public int value_of_order;
           public int time_of_enter;
           public int leave_queue;
            // Ctor for customer
           public Customer(int time_of_enter1)
            {
                Random random = new Random();
                leave_queue = random.Next(900, 2400);
                customer_number = ++custNum;
                time_of_enter = time_of_enter1;
                value_of_order = random.Next(200, 1000);
                
            }
        }
        
        

        struct Order
        {
           public int prepar_time;
           public int customer_number;
        }


        void customer_enter_to_resturant(Customer new_customer)
        {
            new_customer = new Customer();
            //STEP 1:
            //customer check if wait in the queue or leave it.

            // culculate the billing time:
            int billing_time;
            billing_time = random.Next(50,200);
            int order_recivie_time = random.Next(50, 200) ;
            int time_to_wait = (billing_time + order_recivie_time) * billing_queue.Count;
            //check if leave of stay:
            if (new_customer.leave_queue < time_to_wait)
            {
                // customer enter the queue
                billing_queue.Enqueue(new_customer);
            }

            
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
