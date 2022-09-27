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


            foreach (var filePath in Directory.GetFiles("c:\\transactions","*.txt"))
            {
                var fileName =  Path.GetFileName(filePath);
                if (fileName.StartsWith("deposit"))
                    Console.WriteLine("Hittat en insättning");
                if (fileName.StartsWith("withdrawal"))
                    Console.WriteLine("Hittat ett uttag");
                //Hör kör algoritm för att hitta ev pengatvättstransaktioner

                var fileInfo = new FileInfo(filePath);
                Console.WriteLine($"{fileName} is {fileInfo.Length} bytes");



                File.Delete(filePath);

            }


        }
    }
}
