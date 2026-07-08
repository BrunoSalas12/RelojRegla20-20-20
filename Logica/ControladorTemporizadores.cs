using Regla20_20_20.Entidades;
using Regla20_20_20.Interfaces;
using Regla20_20_20.Pantallas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Regla20_20_20.Logica
{
    public class ControladorTemporizadores
    {
        private PantallaPrincipal pantallaPrincipal;
        private PantallaMiraLejos pantallaMiraLejos;
        private ITemporizador[] _temporizadores = new ITemporizador[2];
        private string sonido = "Ding";
        public ControladorTemporizadores(PantallaPrincipal pantallaPrincipal) 
        {
            this.pantallaPrincipal = pantallaPrincipal;
            this.pantallaMiraLejos = new PantallaMiraLejos(this);
            this._temporizadores[0] = TemporizadorPantalla.obtenerInstancia();
            this._temporizadores[1] = TemporizadorLejos.obtenerInstancia();
        }

        public void setSonido(string sonido)
        {
            this.sonido = sonido;
        }

        public void tickTemporizador(bool principal)
        {
            int index = principal ? 0 : 1;
            int tiempoRestante = _temporizadores[index].tick();

            this.reproducirSonido(tiempoRestante);
            if(tiempoRestante == 0)
            {
                if (principal)
                {
                    _temporizadores[1].agregarTiempo(_temporizadores[0].getCantidadExtra());
                    this.cambiarAPantallaMirarLejos();

                }
                else 
                {
                    this.reiniciarTemporizadores();
                    this.cambiarAPantallaPrincipal();

                }

            }
        }

        public void agregarTiempoTemporizador(int tiempoExtra, bool principal)
        {
            int sumoTiempo = _temporizadores[0].agregarTiempo(tiempoExtra);

            if (!principal && sumoTiempo != 0)
            {
                this.cambiarAPantallaPrincipal();
                _temporizadores[1].reiniciar();
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

        private void cambiarAPantallaPrincipal() 
        {
            pantallaMiraLejos.detenerSegundero();
            pantallaMiraLejos.TopMost = false;
            pantallaMiraLejos.Hide();

            pantallaPrincipal.Show();
            pantallaPrincipal.activarSegundero();
        }

        private void cambiarAPantallaMirarLejos()
        {
            pantallaPrincipal.detenerSegundero();
            pantallaPrincipal.Hide();

            pantallaMiraLejos.Show();
            pantallaMiraLejos.BringToFront();
            pantallaMiraLejos.Activate();
            pantallaMiraLejos.TopMost = true;
            pantallaMiraLejos.activarSegundero();
        }

        public void cancelarMirarLejos()
        {
            _temporizadores[0].reiniciar();
            _temporizadores[1].reiniciar();

            pantallaMiraLejos.detenerSegundero();
            pantallaMiraLejos.TopMost = false;
            pantallaMiraLejos.Hide();

            pantallaPrincipal.Show();
            
            pantallaPrincipal.pausar();
        }

        private string convertirIntSegundosATiempoTexto(int tiempoSegundos)
        {
            int minutos = tiempoSegundos/ 60;
            int segundos = tiempoSegundos % 60;

            return string.Format("{0:D2}:{1:D2}", minutos, segundos);
        }

        private void reproducirSonido(int tiempoRestante)
        {
            SoundPlayer sp;
            switch (tiempoRestante)
            {
                case 3:
                    sp = new SoundPlayer(Properties.Resources.tickEfectoSonidoReloj);
                    sp.Play();
                    break;
                case 2:
                    sp = new SoundPlayer(Properties.Resources.tackEfectoSonidoReloj);
                    sp.Play();
                    break;
                case 1: 
                    sp = new SoundPlayer(Properties.Resources.tickEfectoSonidoReloj);
                    sp.Play();
                    break;
                case 0:
                    switch (sonido) 
                    {
                        case "Ding":
                            sp = new SoundPlayer(Properties.Resources.dingEfectoSonido);
                            sp.Play();
                            break;
                        case "BeepBeep":
                            sp = new SoundPlayer(Properties.Resources.beepbeepEfectoSonido);
                            sp.Play();
                            break;
                    }
                    break;
                
             }
             
        }



    }
}
