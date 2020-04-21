using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio4__MatiasLeguer
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IMachineInfo> listaMaquinas = new List<IMachineInfo>() { new Recepcion("Recepción de piezas"), new Almacenar("Almacenamiento"), new Ensamblaje("Ensamblaje del objeto"), new Verificar("Verificación de calidad"), new Empaque("Empaque")};
            ComputadorCentral centralPC = new ComputadorCentral();
            centralPC.EncendidoMaquina(listaMaquinas);
            Console.WriteLine("------------------------------------------------\n");
            Random rnd = new Random();

            int i = 0;
            int random = 0;
            string yesOrNo = "n";
            while (i < 120)
            {
                random = rnd.Next(0, listaMaquinas.Count);
                centralPC.ActualizarMemoria(listaMaquinas[random]);
                Console.WriteLine("Memoria de la maquina " + listaMaquinas[random].NombreMaquina + ": " + listaMaquinas[random].Memoria);
                if (listaMaquinas[random].ReinicioReq == true) 
                {
                    Console.Write("Una máquina necesita reinicio, quiere activar el modo de reinicio manual? (y/n): ");
                    yesOrNo = Console.ReadLine();
                    centralPC.ReinicioMaquina(listaMaquinas, yesOrNo);
                }
                i++;
            }

            Console.WriteLine("------------------------------------------------\n");
            centralPC.ApagadoMaquina(listaMaquinas);

        }
    }
}
