using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regla20_20_20.Interfaces
{
    public interface ITemporizador
    {
        int getTiempoSegundos();
        int getCantidadExtra();
        int agregarTiempo(int minutosExtra);
        int tick();
        void reiniciar();
    }
}
