namespace KyhArrayListDemos;

public class App
{
    public void Run()
    {
        int age = 12;
        age = age + 12;

        while (age > 15)
        {
            Console.WriteLine("Hello");
            age = age + 1;
        }
        Console.WriteLine("sasdasda");

        var allaTal = new List<int>();
        while (true)
        {
            Console.Write("mata in ett tal:");
            string inmatningen = Console.ReadLine();
            if (inmatningen.ToLower() == "n")
                break;
            int talet = Convert.ToInt32(inmatningen);
            allaTal.Add(talet);
            //om n eller N break

            // annars stoppa in i listan
        }



        //List<string> allLegendaryPlayers = new List<string>();
        var allLegendaryPlayers = new List<string>();
        
        while (true)
        {
            Console.WriteLine("1. Lista alla spelare");
            Console.WriteLine("2. Skapa ny spelare");
            Console.WriteLine("3. Ta bort spelare");
            Console.WriteLine("4. Ändra spelare");
            Console.WriteLine("5. Exit");
            Console.Write("Ange val:");
            var sel = Console.ReadLine();
            if (sel == "1")
            {
                foreach (string namn in allLegendaryPlayers)
                {
                    Console.WriteLine(namn);
                }
            }
            if (sel == "2")
            {
                Console.Write("Ange namn på nya spelaren:");
                var namn = Console.ReadLine();
                allLegendaryPlayers.Add(namn);
            }

            if (sel == "3")
            {
                var index = 0;
                foreach (var namn in allLegendaryPlayers)
                {
                    index++;
                    Console.WriteLine($"{index} {namn}");
                }
                Console.Write("Skriv in nummer på spelaren du vill ta bort:");
                var nummer = Convert.ToInt32( Console.ReadLine() );
                allLegendaryPlayers.RemoveAt(nummer-1);
            }

            if (sel == "4")
            {
                var index = 0;
                foreach (var namn in allLegendaryPlayers)
                {
                    index++;
                    Console.WriteLine($"{index} {namn}");
                }
                Console.Write("Skriv in nummer på spelaren du vill ändra:");
                var nummer = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ange namn:");
                var nyttNamn = Console.ReadLine();
                allLegendaryPlayers[nummer - 1] = nyttNamn;

            }


        }



        var number = 12;
        int[] numbers = new int[4];
        numbers[0] = 90;
        numbers[1] = 99;
        numbers[2] = 100;
        numbers[3] = 2;
        numbers[3] = numbers[3] + 22;
        numbers[3] += 123;

        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }



        //Loopa igenom alla nummer och summera ihop
        // 4 eller Length?


        string[] weekDays = new []{ "Monday", "Tuesday", "Wednesday", "Thursday", "Friday","Saturday", "Sunday"    };

        while (true)
        {
            Console.Write("Ange dagnummer (1-7):");
            int dagNummer = Convert.ToInt32(Console.ReadLine());
            string weekDayName = weekDays[dagNummer-1];
            Console.WriteLine($"Dag nummer {dagNummer} är {weekDayName}");
        }
        
    }
}