using Regla20_20_20.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Regla20_20_20.Pantallas
{
    public partial class PantallaMiraLejos : Form
    {
        private ControladorTemporizadores _controlador;

        private readonly bool principal = false;
        public PantallaMiraLejos(ControladorTemporizadores controlador)
        {
            this._controlador = controlador;
            InitializeComponent();
        }

        private void PantallaMiraLejos_Load(object sender, EventArgs e)
        {
            lblTemporizador.Text = _controlador.obtenerTiempoTemporizador(principal);
            this.activarSegundero();
        }

        public void activarSegundero() { timerSegundero.Start(); }

        public void detenerSegundero() { timerSegundero.Stop(); }

        private void timerSegundero_Tick(object sender, EventArgs e)
        {
            _controlador.tickTemporizador(principal);
            lblTemporizador.Text = _controlador.obtenerTiempoTemporizador(principal);
        }

        private void PantallaMiraLejos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.Shift)
            { //Manejo de la combinación de teclas para agregar minutos al temporizador
                //Con los números se pueden agregar hasta 10 minutos de tiempo de pantalla
                switch (e.KeyCode)
                {
                    case Keys.D1:
                        _controlador.agregarTiempoTemporizador(1, this.principal);
                        break;
                    case Keys.D2:
                        _controlador.agregarTiempoTemporizador(2, this.principal);
                        break;
                    case Keys.D3:
                        _controlador.agregarTiempoTemporizador(3, this.principal);
                        break;
                    case Keys.D4:
                        _controlador.agregarTiempoTemporizador(4, this.principal);
                        break;
                    case Keys.D5:
                        _controlador.agregarTiempoTemporizador(5, this.principal);
                        break;
                    case Keys.D6:
                        _controlador.agregarTiempoTemporizador(6, this.principal);
                        break;
                    case Keys.D7:
                        _controlador.agregarTiempoTemporizador(7, this.principal);
                        break;
                    case Keys.D8:
                        _controlador.agregarTiempoTemporizador(8, this.principal);
                        break;
                    case Keys.D9:
                        _controlador.agregarTiempoTemporizador(9, this.principal);
                        break;
                    case Keys.D0:
                        _controlador.agregarTiempoTemporizador(10, this.principal);
                        break;
                }
            }
        }
    }
}
