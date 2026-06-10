using Regla20_20_20.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regla20_20_20.Entidades
{
    public class TemporizadorPantalla : ITemporizador
    {
        private int tiempoSegundos;
        private int cantidadExtra;
        private static TemporizadorPantalla? _instancia;
        private TemporizadorPantalla()
        {
            this.tiempoSegundos = 1202; //20 minutos y 2 segundos (20:02)
            this.cantidadExtra = 0;
        }

        public static TemporizadorPantalla obtenerInstancia()
        {
            if(_instancia != null)
                return _instancia;

            _instancia = new TemporizadorPantalla();
            return _instancia;
        }

        public int getTiempoSegundos()
        {
            return this.tiempoSegundos;
        }

        public int getCantidadExtra()
        {
            return this.cantidadExtra;
        }

        public int agregarTiempo(int minutosExtra)
        {
            if (this.cantidadExtra >= 10)
                return this.tiempoSegundos;

            if (this.cantidadExtra + minutosExtra >= 10) 
            {
                int tiempoASumar = 10 - this.cantidadExtra;
                this.tiempoSegundos += tiempoASumar * 60;
                this.cantidadExtra += minutosExtra;
                return this.tiempoSegundos;
            }

            this.tiempoSegundos += minutosExtra*60;
            this.cantidadExtra += minutosExtra;
            return this.tiempoSegundos;
        }

        public int tick()
        {
            int segundos = this.tiempoSegundos--;
            if (segundos <= 0)
            {
                this.tiempoSegundos = 0;
                return 0;
            }
            return segundos;
        }

        public void reiniciar()
        {
            this.tiempoSegundos = 1202; //20 minutos y 2 segundos (20:02)
            this.cantidadExtra = 0;
        }

    }
}
