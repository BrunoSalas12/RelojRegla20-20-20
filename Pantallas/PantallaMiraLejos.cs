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
    }
}
