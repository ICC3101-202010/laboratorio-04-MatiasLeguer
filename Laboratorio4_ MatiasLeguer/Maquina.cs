using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio4__MatiasLeguer
{
    public abstract class Maquina : IMachineInfo
    {
        protected bool estadoEncendido = false;
        protected int memoria = 0;
        protected bool reinicioReq = false;
        protected string nombreMaquina;

        public bool EstadoEncendido { get => estadoEncendido; set => estadoEncendido = value; }
        public int Memoria { get => memoria; set =>  memoria = value;}
        public bool ReinicioReq { get => reinicioReq; set => reinicioReq = value; }
        public virtual string NombreMaquina { get => nombreMaquina; }

        public Maquina() 
        {
        }

        


    }
}
