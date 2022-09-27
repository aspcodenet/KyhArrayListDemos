using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace KyhArrayListDemos.MoneyLaundry
{
    public class MoneyLaundryJob
    {
        public void Run()
        {
            // skapa en folder c:\transactions
            Directory.CreateDirectory("c:\\transactions");


            foreach (var filePath in Directory.GetFiles("c:\\transactions"))
            {
                Console.WriteLine(filePath);
            }


        }
    }
}
