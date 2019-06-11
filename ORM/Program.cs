using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace ORM
{
    class Program
    {
        static void Main(string[] args)
        {         
           using (TøjButikEntities tøjButik = new TøjButikEntities())
            {
                            
                var shopping = tøjButik.Customers.Join(
                 tøjButik.Products,
                 c => c.CustomerId,
                 p => p.ProductId,

                 (c, p) => (((c.CustomerName + " bought a ") + "------") + p.ProductName));

                foreach (var item in shopping)
                {
                    Console.WriteLine(item);
                }
            
                Console.ReadKey();
               

                //foreach (Customer cc in tøjButik.Customers)

                //    foreach (Product pp in tøjButik.Products)
                //    {
                //        if (pp.ProductId == cc.CustomerId)
                //        {
                //            if (pp.ProductCost>100)
                //            {
                //                Console.WriteLine(cc.CustomerName + " spent   " + pp.ProductName +" price "+pp.ProductCost + "   "+"high");
                //            }
                //            if (pp.ProductCost < 100)
                //            {
                //                Console.WriteLine(cc.CustomerName + " spent   " + pp.ProductName + " price " + pp.ProductCost +"   "+ "medium");
                //            }

                //        }

                //    }


                Console.ReadKey();

                // Another SQL round-trip


                //Customer customer = tøjButik.Customers.FirstOrDefault();
                //Customer customer = tøjButik.Customers.FirstOrDefault(x => x.CustomerName == "atmar");

                //Console.WriteLine(customer.CustomerName);

                // var d = tøjButik.FindCustomerByPhone("4545454");
                //var d= from c in tøjButik.Customers
                // where c.CustomerName.Contains("b")
                // orderby c.CustomerName.Length
                // select c.CustomerName.ToUpper();

                // foreach (var item in d)
                // {
                //     Console.WriteLine(item);
                // }
                // Console.ReadKey();



                // IEnumerable<string> query = tøjButik.Customers
                //     .Where(n => n.CustomerName.Contains("a"))
                //     .OrderBy(n => n.CustomerName.Length)
                //     .Select(n => n.CustomerName.ToUpper());
                // foreach (var item in query)
                // {
                //     Console.WriteLine(item);
                // }
                // Console.ReadKey();


            }


        }
    }
}
