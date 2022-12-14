using KyhArrayListDemos.Model;
using Newtonsoft.Json;

namespace KyhArrayListDemos;

public class App
{
    //public int CalcilateSalary()
    //{

    //}
    public void ShowMenu()
    {
        Console.WriteLine("1. Lista alla spelare");
        Console.WriteLine("2. Skapa ny spelare");
        Console.WriteLine("3. Ta bort spelare");
        Console.WriteLine("4. Ändra spelare");
        Console.WriteLine("5. Exit");
    }

    public int GetIntInput(string prompt, int minValue, int maxValue)
    {
        while (true)
        {
            Console.Write(prompt);
            try
            {
                int sel = Convert.ToInt32(Console.ReadLine());
                if (sel < minValue || sel > maxValue)
                    Console.WriteLine($"Mata in ett tal mellan {minValue} och {maxValue} tack");
                else
                    return sel;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Mata in siffror tack");
            }
        }
    }

    public void ListAllPlayers(List<HockeyPlayer> list)
    {
        foreach (var hockeyPlayer in list)
        {
            Console.WriteLine($"{hockeyPlayer.JerseyNumber} {hockeyPlayer.Namn}");
        }
    }

    public HockeyPlayer GetNewPlayer()
    {
        Console.Write("Ange namn på nya spelaren:");
        string namn = Console.ReadLine();
        Console.Write("Ange age :");
        int age= Convert.ToInt32(Console.ReadLine());
        Console.Write("Ange jersey :");
        int jerseye = Convert.ToInt32(Console.ReadLine());
        var player = new HockeyPlayer();
        player.JerseyNumber = jerseye;
        player.Namn = namn;
        player.Age = age;
        return player;
    }

    public void FileDemos()
    {
        var allLines = File.ReadAllLines("SwedishCountiies.txt");
        foreach (var line in allLines)
            Console.WriteLine(line);

        using (var file = File.CreateText("spelare111.txt"))
        {
            file.WriteLine("Foppa");
            file.WriteLine("Mats");
            file.WriteLine("Stefan");
        }


        var lines = File.ReadLines("SwedishCountiies.txt");
        foreach (var line in lines)
            Console.WriteLine(line);
    }

    public void SaveAllPlayers(List<HockeyPlayer> listan)
    {
        var text = JsonConvert.SerializeObject(listan);
        using (var file = File.CreateText("playersjson.txt"))
            file.Write(text);

    }

    public List<HockeyPlayer> GetFromFile()
    {
        var listan = new List<HockeyPlayer>();
        if (!File.Exists("playersjson.txt")) return listan;

        var text = File.ReadAllText("playersjson.txt");
        listan = JsonConvert.DeserializeObject<List<HockeyPlayer>>(text);

        return listan;
    }

    public void Run()
    {
        //FileDemos();
        //var player = new HockeyPlayer();
        //player.Namn = "Foppa";
        //player.Age = 49;
        //player.JerseyNumber = 21;

        //var player2 = new HockeyPlayer();
        //player2.Namn = "Mats Sundin";
        //player2.Age = 51;
        //player2.JerseyNumber = 13;

        var allLegendaryPlayers = GetFromFile();

        while (true)
        {
            ShowMenu();
            var sel = GetIntInput("Ange val:", 1, 5);
            if (sel == 5)
            {
                SaveAllPlayers(allLegendaryPlayers);
                return;
            }
            if (sel == 1)
                ListAllPlayers(allLegendaryPlayers);
            if (sel == 2)
            {
                var player = GetNewPlayer();
                allLegendaryPlayers.Add(player);
            }

            if (sel == 3)
            {
                var index = 0;
                foreach (var namn in allLegendaryPlayers)
                {
                    index++;
                    Console.WriteLine($"{index} {namn}");
                }

                var nummer = GetIntInput("Skriv in nummer på spelaren du vill ta bort:",
                    1, allLegendaryPlayers.Count);
                //Console.Write("Skriv in nummer på spelaren du vill ta bort:");
                //var nummer = Convert.ToInt32(Console.ReadLine());
                allLegendaryPlayers.RemoveAt(nummer - 1);
            }

            if (sel == 4)
            {
                //var index = 0;
                //foreach (var namn in allLegendaryPlayers)
                //{
                //    index++;
                //    Console.WriteLine($"{index} {namn}");
                //}

                //var nummer = GetIntInput("Skriv in nummer på spelaren du vill ändra:", 1, allLegendaryPlayers.Count);

                ////Console.Write("Skriv in nummer på spelaren du vill ändra:");
                ////var nummer = Convert.ToInt32(Console.ReadLine());
                //Console.Write("Ange namn:");
                //var nyttNamn = Console.ReadLine();
                //allLegendaryPlayers[nummer - 1] = nyttNamn;

            }



        }


        //int antalPriser = Convert.ToInt32(Console.ReadLine());
        //int[] allaPriser = new int[antalPriser];
        //Console.Write("Ange första priset:");
        //int pris = Convert.ToInt32(Console.ReadLine());
        //allaPriser[0] = pris;

        //allaPriser[0] = allaPriser[0] + 12;

        //var i323231 = 2222;

        //string[] coolPlayers ={ "Börje Salming", "Foppa", "Mats Sundin" };

        //var ages= new int[] { 12,22,456 };


        //int iiiiiii = 111;
        //var allaBarn = new List<string>();
        //allaBarn.Add("Fanny"); // INDEX 0 
        //allaBarn.Add("Josefine"); // INDEX 1
        //allaBarn.Add("Hunden"); // INDEX 2
        //allaBarn.Add("Oliver"); // INDEX 3
        //allaBarn.RemoveAt(2);
        //string namn11 = allaBarn[2];
        //allaBarn[2] = "Ollie";
        //namn11 = allaBarn[2];

        //foreach (string namn in allaBarn)
        //{
        //    if (namn[0] == 'O')
        //    {
        //        Console.WriteLine("Grattis");
        //    }
        //    Console.WriteLine($"Brev till {namn}");
        //}



        //for (int i = 0; i < allaBarn.Count; i++)
        //{
        //    if (allaBarn[i].StartsWith("O"))
        //    {
        //        Console.WriteLine("Grattis");
        //    }
        //    string namn = allaBarn[i];
        //    if (namn[0] == 'O')
        //    //if (allaBarn[i][0] == 'O')
        //    {
        //        Console.WriteLine("Grattis");
        //    }
        //    Console.WriteLine($"Brev till {allaBarn[i]}");
        //}


        //var playersInNYRangers = new List<string>();

        //var allYears = new List<int>();
        //allYears.Add(1212);
        //allYears.Add(1213);

        //foreach (int year in allYears)
        //{
        //    Console.WriteLine($"{year}");
        //}










        //int age = 12;
        //age =  13;


        //for (int i = 0; i < 10; i++)
        //{
        //    Console.WriteLine($"Talet är {i}");
        //}

        //while (age < 15)
        //{
        //    Console.WriteLine("Hello");
        //    age = age + 1;
        //}
        //Console.WriteLine("sasdasda");

        //var allaTal = new List<int>();
        //while (true)
        //{
        //    Console.Write("mata in ett tal:");
        //    string inmatningen = Console.ReadLine();
        //    if (inmatningen.ToLower() == "n")
        //        break;
        //    int talet = Convert.ToInt32(inmatningen);
        //    allaTal.Add(talet);
        //    //om n eller N break

        //    // annars stoppa in i listan
        //}



        //List<string> allLegendaryPlayers = new List<string>();



        //var number = 12;
        //int[] numbers = new int[4];
        //numbers[0] = 90;
        //numbers[1] = 99;
        //numbers[2] = 100;
        //numbers[3] = 2;
        //numbers[3] = numbers[3] + 22;
        //numbers[3] += 123;

        //int sum = 0;
        //for (int i = 0; i < numbers.Length; i++)
        //{
        //    sum += numbers[i];
        //}



        ////Loopa igenom alla nummer och summera ihop
        //// 4 eller Length?


        //string[] weekDays = new []{ "Monday", "Tuesday", "Wednesday", "Thursday", "Friday","Saturday", "Sunday"    };

        //while (true)
        //{
        //    Console.Write("Ange dagnummer (1-7):");
        //    int dagNummer = Convert.ToInt32(Console.ReadLine());
        //    string weekDayName = weekDays[dagNummer-1];
        //    Console.WriteLine($"Dag nummer {dagNummer} är {weekDayName}");
        //}

    }
}