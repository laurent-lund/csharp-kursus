namespace CollectionKort
{
    class Program
    {
        static void Main(string[] args)
        {
            // Skab en ny tom bunke.
            Kort.Bunke b = new Kort.Bunke();

            // Tilføj tre kort.
            b.TilføjKort(new Kort() { Kulør = "Spar", Værdi = 2 });
            b.TilføjKort(new Kort() { Kulør = "Hjerter", Værdi = 14 });
            b.TilføjKort(new Kort() { Kulør = "Ruder", Værdi = 7 });

            // Vis hvad der er i bunken.
            b.visStak();

            // Fjern øverste kort.
            var k = b.FjernKort();

            // Vis øverste kort - ToString metoden er overloadet.
            System.Console.WriteLine();
            System.Console.WriteLine(k);
            System.Console.WriteLine();

            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }
    }
}
