namespace ex07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 7-En un control de radar de velocitat s'estableixen tres trams de sancions
            Trams de sanció:
            80–99 km/h → 100€
            100–129 km/h → 300€
            130+ km/h → 600€ i retirada de carnet
            Informeu a partir de la velocitat (que és de tipus enter),
            quina sanció tindrà el vehicle.
            Informeu també en cas que el vehicle no tingui sanció.*/

            int velocitat;

            Console.WriteLine("Quina velocitat indica la multa?: + km/h");
            velocitat = Convert.ToInt32(Console.ReadLine);

            if (velocitat >= 80 && velocitat <= 99)
            {
                Console.WriteLine("Multa de 100€.\n Passi per caixa.");

                else if (velocitat <= 129)
                {
                    Console.WriteLine("Multa de 300€.\n S'agraeix.");
                }
                else if (velocitat > 130)
                {
                    Console.WriteLine("Multa de 600 + Retirada del carnet.\n No sap greu.");
                }
            }
        }
    }
}