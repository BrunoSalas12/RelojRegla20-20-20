using Regla20_20_20.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regla20_20_20.Entidades
{
    public class TemporizadorLejos : ITemporizador
    {
        private int tiempoSegundos;
        private int cantidadExtra;
        private static TemporizadorLejos? _instancia;

        private readonly int[] valoresTiempoExtra = { 0, 0, 10, 10, 20, 20, 30, 30, 30, 40, 40 };
        private TemporizadorLejos()
        {
            this.tiempoSegundos = 22; //22 segundos (00:22), dos segundos de margen para movimiento
                                      //22 seconds, two seconds of margin to move
            this.cantidadExtra = 0;
        }

        public static TemporizadorLejos obtenerInstancia()
        {
            if (_instancia != null)
                return _instancia;

            _instancia = new TemporizadorLejos();
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
            this.tiempoSegundos = 22;
            this.cantidadExtra += minutosExtra;

            if (this.cantidadExtra >= 10)
                return this.tiempoSegundos += 40;

            this.tiempoSegundos += this.valoresTiempoExtra[this.cantidadExtra];
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
            this.tiempoSegundos = 22; //22 segundos (00:22), dos segundos de margen para movimiento
                                      //22 seconds, two seconds of margin to move
            this.cantidadExtra = 0;
        }
    }
}
