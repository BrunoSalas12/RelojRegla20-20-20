using Regla20_20_20.Entidades;
using Regla20_20_20.Interfaces;
using Regla20_20_20.Pantallas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regla20_20_20.Logica
{
    public class ControladorTemporizadores
    {
        private PantallaPrincipal pantallaPrincipal;
        private PantallaMiraLejos pantallaMiraLejos;
        private ITemporizador[] _temporizadores = new ITemporizador[2];
        public ControladorTemporizadores(PantallaPrincipal pantallaPrincipal) 
        {
            this.pantallaPrincipal = pantallaPrincipal;
            this.pantallaMiraLejos = new PantallaMiraLejos(this);
            this._temporizadores[0] = TemporizadorPantalla.obtenerInstancia();
            this._temporizadores[1] = TemporizadorLejos.obtenerInstancia();
        }

        public void tickTemporizador(bool principal)
        {
            int index = principal ? 0 : 1;
            int tiempoRestante = _temporizadores[index].tick();

            if(tiempoRestante == 0)
            {
                if (principal)
                {
                    pantallaPrincipal.detenerSegundero();
                    pantallaPrincipal.Hide();

                    _temporizadores[1].agregarTiempo(_temporizadores[0].getCantidadExtra());

                    pantallaMiraLejos.activarSegundero();
                    pantallaMiraLejos.Show();
                    pantallaMiraLejos.TopMost = true;
                    pantallaMiraLejos.Activate();
                    pantallaMiraLejos.Focus();
                }
                else 
                {
                    this.reiniciarTemporizadores();

                    pantallaMiraLejos.detenerSegundero();
                    pantallaMiraLejos.TopMost = false;
                    pantallaMiraLejos.Hide();

                    pantallaPrincipal.activarSegundero();
                    pantallaPrincipal.Show();
                }

            }
        }

        public string obtenerTiempoTemporizador(bool principal)
        {
            int index = principal ? 0 : 1;
            return this.convertirIntSegundosATiempoTexto(_temporizadores[index].getTiempoSegundos());
        }

        public void reiniciarTemporizadores()
        {
            _temporizadores[0].reiniciar();
            _temporizadores[1].reiniciar();
        }

        private string convertirIntSegundosATiempoTexto(int tiempoSegundos)
        {
            int minutos = tiempoSegundos/ 60;
            int segundos = tiempoSegundos % 60;

            return string.Format("{0:D2}:{1:D2}", minutos, segundos);
        }




    }
}
