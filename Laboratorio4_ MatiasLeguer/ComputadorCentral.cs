using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio4__MatiasLeguer
{
    class ComputadorCentral
    {

        public void ApagadoMaquina(List<IMachineInfo> listaMaquinas)
        {
            foreach (IMachineInfo maquina in listaMaquinas) 
            {
                if (maquina.EstadoEncendido)
                {
                    maquina.EstadoEncendido = false;
                    Console.WriteLine("La maquina de " + maquina.NombreMaquina + " Se ha apagado!");
                }
                else
                {
                    Console.WriteLine("La maquina de " + maquina.NombreMaquina + " ya se encuentra apagada!");
                }

            }

        }

        public void EncendidoMaquina(List<IMachineInfo> listaMaquinas)
        {
            foreach (IMachineInfo maquina in listaMaquinas)
            {
                if(maquina.EstadoEncendido == false)
                {
                    maquina.EstadoEncendido = true;
                    Console.WriteLine("La maquina de " + maquina.NombreMaquina + " Se ha encendido!");
                }
                else
                {
                    Console.WriteLine("La maquina de " + maquina.NombreMaquina + " ya se encuentra encendida!");
                }
            }
        }

        public void ActualizarMemoria(IMachineInfo maquina)
        {
            if (maquina.Memoria == 10)
            {
                maquina.ReinicioReq = true;
                
            }
            else
            {
                maquina.Memoria++;
            }
        }
    


        public void ReinicioMaquina(List<IMachineInfo> listaMaquinas, string yesOrNo)
        {
            if (yesOrNo == "y")
            {
                Console.WriteLine("Porfavor escoga una máquina de las 5 máquinas. (Recepción = 1, Almacenar = 2, Ensamblaje = 3, Verificar = 4, Empaque = 5)");
                int index = int.Parse(Console.ReadLine()) - 1;
                listaMaquinas[index].Memoria = 0;
                Console.WriteLine("Se ha reinicia la maquina de " + listaMaquinas[index].NombreMaquina + "!");
                listaMaquinas[index].ReinicioReq = false;
            }
            else if (yesOrNo == "n") 
            {
                foreach (IMachineInfo maquina in listaMaquinas)
                {
                    if (maquina.ReinicioReq == true || maquina.Memoria == 10)
                    {
                        maquina.Memoria = 0;
                        Console.WriteLine("Se ha reiniciado la maquina de " + maquina.NombreMaquina + "!");
                        maquina.ReinicioReq = false;
                    }
                }
            }
            else
            {
                Console.WriteLine("Porfavor escriba un y o un n");
            }
        }
    }
}
