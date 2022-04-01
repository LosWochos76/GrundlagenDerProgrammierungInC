class Program
{
    public static void MinutenAddieren()
    {
        int now_hour = 16;
        int now_minute = 40;
        int add_minutes = 1784;

        int then = now_hour * 60 + now_minute + add_minutes;
        int then_hour = (then / 60) % 24;
        int then_minute = then % 60;
        Console.WriteLine("Es ist {0}:{1} Uhr", then_hour, then_minute);
    }

    public static void ZahlenBis100()
    {
        int a = 1;
        while (a <= 100)
        {
            Console.WriteLine(a);
            a++;
        }
    }

    public static void SummeBis100()
    {
        int z = 1;
        int summe = 0;

        while (z <= 100)
        {
            summe += z;
            z++;
        }

        Console.WriteLine(summe);
    }

    public static void SummeTeilbar3oder5Bis100()
    {
        int z = 1;
        int summe = 0;

        while (z <= 100)
        {
            if (z % 3 == 0 || z % 5 == 0)
                summe += z;
                
            z++;
        }

        Console.WriteLine(summe);
    }

    public static void Main()
    {
        // Hier die Methoden wieder einkommentiern, wenn man etwas ausprobieren möchte.
        //MinutenAddieren();
        //Schleife1();
        //SummeBis100();
        SummeTeilbar3oder5Bis100();
    }
}