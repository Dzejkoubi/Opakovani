// See https://aka.ms/new-console-template for more information
string vstup = "0";
long cislo  = 0;
while (vstup != "n")
{
    vstup = Console.ReadLine();
    if (vstup != "n")
    {
        cislo = long.Parse(vstup);
            for (int i = 0; i < cislo; i++)
            {
                Console.WriteLine("Cyklus: " + i);
            }
    }
}


Console.ReadKey();