

    class Program
    {
        static void Main(string[] args)
        {

  
             var racun = new BankovniRacun(2000m);

              Console.WriteLine($"Početno stanje računa: {racun.StanjeRacuna}");

        racun.Uplata(200m);
        racun.Uplata(100m);
        racun.Uplata(600m);
        racun.Uplata(300m);
        racun.Uplata(200m);

        racun.IspisiTransakcije();

        Console.WriteLine($"Završno stanje računa: {racun.StanjeRacuna:C}");
    }
    }

