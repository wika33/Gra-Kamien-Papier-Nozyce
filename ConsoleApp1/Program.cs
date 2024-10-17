class Gra
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        int wybor_komputera = rnd.Next(3);

        Console.WriteLine("Witaj w grze kamien papier nozyce! Zmierz sie naszym komputerem!");
        Console.Write("co wybierasz: kamien (k) papier (p) nozyce (n): "); 
        string wybor_gracza = Console.ReadLine();

        int wybor_gracza_int;
        switch(wybor_gracza)
        {
            case "k":
                {
                    wybor_gracza_int = 0;
                    break;
                }
            case "p":
                {
                    wybor_gracza_int = 1;
                    break;
                }
            case "n":
                {
                    wybor_gracza_int = 2;
                    break;
                }
                default:
                {
                    Console.WriteLine("zla odpowiedz");
                    break;

                }
        }
    }
}