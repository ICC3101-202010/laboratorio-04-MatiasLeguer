using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio4__MatiasLeguer
{
    public interface IMachineInfo
    {
        string NombreMaquina { get; }
        bool EstadoEncendido { get; set; }
        int Memoria { get; set; }
        bool ReinicioReq { get; set; }  
    }
}
