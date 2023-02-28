
/*SortedList<string, string> liste = new SortedList<string, string>();
liste.Add(185, "Ironman");
liste.Add("c", "Spiderman");
liste.Add("d", "Batman");
liste.Add("f", "Messi");
liste.Add("g", "Ronaldo");

foreach(KeyValuePair<string,string> x in liste)
{
    Console.WriteLine($"Schüler: {x.Key} ist {x.Value}");
}
Console.ReadLine();

SortedList<double, string> liste = new SortedList<double, string>();
for (int i = 1; i <= 5; i++)
{
    try
    {

        Console.Write($"Geben sie den {i}ten Namen ein: ");
        string x = Console.ReadLine();
        Console.Write($"Geben sie die {i}te Grösse ein: ");
        double y = Convert.ToDouble(Console.ReadLine());
        Console.Clear();


        if (y > 0)
        {
            liste.Add(y,x);
           
        }
        else
        {
            Console.WriteLine($"falsche eingabe");
        }


    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}
foreach (KeyValuePair<double, string> b in liste)
{
    Console.WriteLine($"\nSchüler:  {b.Value} ist {b.Key}cm Gross ");

}


Stack<string> karten = new Stack<string>();
karten.Push("Herz 2");
karten.Push("Karo 3");
karten.Push("Pik 10");
karten.Push("Pik 5");
karten.Push("Kreuz Dame");

foreach (var x in karten)
{
    Console.WriteLine($"Oben steht {x}");
}

for (int i = karten.Count; i <= 0; i--)
    if(karten.Peek().Equals("Pik 10"))
    {
        break;
    }
    else
    {
        karten.Pop();
    }

Console.WriteLine($"\n---------- Die restlichen Karten----------");

foreach (var x in karten)
{
    Console.WriteLine($"Oben steht {x}");
}
*/
Queue<string> queque = new Queue<string>();
queque.Enqueue("Batman");
queque.Enqueue("Ironman");
queque.Enqueue("Spiderman");
queque.Enqueue("Messi");
queque.Enqueue("SSIO");

foreach (var x in queque)
{
    Console.WriteLine(x);
}
Console.WriteLine($"____________________");
queque.Dequeue();
foreach (var x in queque)
{
    Console.WriteLine(x);
}