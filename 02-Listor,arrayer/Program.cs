// string[] leksaker = new string[5];
// leksaker[0] = "Rubiks kuber";
// leksaker[1] = "Legobitar";
// leksaker[2]= "Fidget spinners";
// leksaker[3] = "Fotbollskort";
// leksaker[4] = "Nerf pistoler";

// string[] klasskamrater = new string[5];
// klasskamrater[0] = "Dino";
// klasskamrater[1] = "Albin";
// klasskamrater[2] = "Axel";
// klasskamrater[3] = "Kabbe";
// klasskamrater[4] = "Eijvan";

// int[] värden = new int[5];
// värden[0] = 2;
// värden[1] = 4;
// värden[2] = 6;
// värden[3] = 8;
// värden[4] = 10;

// for (int i = 0; i < leksaker.Length; i++ )
// {
//     Console.WriteLine($"{klasskamrater[i]} har {värden[i]} {leksaker[i]}");
// }


List<String> cities = new List<string>();

Console.WriteLine("Skriv en stad");

while (true)
{
    string city = Console.ReadLine();


    if (city.ToLower() == "exit")
    {
        break;
    }

    cities.Add(city);
    Console.WriteLine($"{city} har lagts till i listan");

}

foreach (string c in cities)
{
    Console.WriteLine(c);
}





Console.ReadLine();