using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResturantSimulation
{
    class Program
    {
        struct customer
        {
            int customer_number;
            int value_of_order;
            DateTime time_of_enter;
            int leave_queue;
        }

        struct order
        {
            int prepar_time;
            int customer_number;
        }


        void customer_enter_to_resturant(customer new_customer)
        {
            Queue <customer> enter_billing_queue= new Queue<customer>();
            
        }

        static void Main(string[] args)
        {
            //igor is very big gay
        }
    }
}
