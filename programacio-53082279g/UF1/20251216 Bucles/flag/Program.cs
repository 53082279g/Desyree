namespace flag
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int mitjana, acumuladorNotes = 0, nota, notesEntrades = 0;

            Console.WriteLine("Entra les notes per a realitzar la mitjana.");
            Console.WriteLine("Si la nota és negativa o major de 10 no contarà.");
            Console.Write($"nota (notesEntrades + 1): ");
            nota = Convert.ToInt32(Console.ReadLine());

            while (nota != -1)
            {
                if (nota >= 0 && nota <= 10)
                {
                    acumuladorNotes = acumuladorNotes + nota;
                    notesEntrades++;
                }
                else
                    Console.WriteLine("Aquesta nota és incorrecta");

                Console.Write($"nota {notesEntrades + }: ");
                nota = Convert.ToInt32(Console.ReadLine());
            }
            mitjana = acumuladorNotes / notesEntrades;

            Console.WriteLine($"Has entrat {notesEntrades}");
            Console.WriteLine($"La mitjana és {mitjana}");
        }
    }
}