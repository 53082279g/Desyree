using System.Media;
using WMPLib;

namespace Xat
{
    internal class ProgramS
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola, en què et puc ajudar?");
            string text = Console.ReadLine();
    
            if (text.Contains("poema")){
                Console.WriteLine("Aquí tens un poema:");
                Console.WriteLine("Estiu,sabem que arribes, volem veure’t, ho saben les onades que també vindran a rebre’t.");
            }

            if (text.Contains("música")){
                /*Habilitar WindowsMediaPlayer :               
                En el Explorador de soluciones, 
                nos ponemos encima del proyecto
                clic derecho en References
                Selecciona Add Reference…
                Ve a la pestaña COM
                Busca Windows Media Player*/
                WindowsMediaPlayer player = new WindowsMediaPlayer();
                //l'arxiu mp3 ha d'estar guardar en la subcarpeta que el projecte \bin\Debug
                string rutaMp3 = @"tu-vuo-fa-l-americano.mp3";
                player.URL = rutaMp3;

                // Reproduïr MP3
                Console.WriteLine("Reproduint MP3...");
                player.controls.play();
            }

            //Això espera que es polsi la tecla intro, és per fer una pausa
            Console.ReadLine();

        }
    }
}
