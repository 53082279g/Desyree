namespace AnyNaixement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escriu un missatge per pantalla (Sortida)
            Console.WriteLine("Entra la teva edat:");

            //Això és un comentari
            //Llegim un valor del teclat (entrada)
            //i es posa en una variable anomenada edat
            double edat = Convert.ToDouble(Console.ReadLine());

            //Escriu un missatge per pantalla (Sortida)
            Console.WriteLine("Entra l'any actual");

            //Llegim un valor del teclat (entrada)
            //i es posa en una variable anomenada anyactual
            double any_actual = Convert.ToDouble(Console.ReadLine());

            //Fa un càlcul
            double any_naixement = any_actual - edat;

            //Escriu un missatge per pantalla (Sortida)
            Console.WriteLine("Vares nèixer el: "+any_naixement);
          
        }
    }
}
