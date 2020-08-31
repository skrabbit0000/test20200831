using System;
using System.Linq;
namespace coreDB
{
    class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Hello World!");
           var db = new iiidbtestContext();
           var items = from p in db.TCustomer
                       select p;
           foreach(var item in items)
           {
               Console.Write(item.CName+"/"+item.Tel+"/"+item.Address+"\n");
           }
           //v2
           //v3
        }
    }
}
