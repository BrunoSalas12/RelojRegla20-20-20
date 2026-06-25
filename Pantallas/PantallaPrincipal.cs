using Regla20_20_20.Entidades;
using Regla20_20_20.Logica;

namespace Regla20_20_20
{
    public partial class PantallaPrincipal : Form
    {
        private ControladorTemporizadores _controlador;
        private bool activado = true;

        private readonly bool principal = true;
        public PantallaPrincipal()
        {
            this._controlador = new ControladorTemporizadores(this);
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            lblTemporizador.Text = _controlador.obtenerTiempoTemporizador(principal);
            cmbSonidoAviso.SelectedItem = "Ding";
            this.activarSegundero();
            this.posicionarEnEsquinaInferiorDerecha();
        }

        private void btnActivarPausar_Click(object sender, EventArgs e)
        {
            this.activado = !this.activado;
            if (activado)
            {
                btnActivarPausar.IconChar = FontAwesome.Sharp.IconChar.Pause;
                this.activarSegundero();
            }
            else
            {
                btnActivarPausar.IconChar = FontAwesome.Sharp.IconChar.Play;
                this.detenerSegundero();
            }
            this.controlarTopMost();
        }

        public void activarSegundero() { timerSegundero.Start(); }

        public void detenerSegundero() { timerSegundero.Stop(); }

        private void timerSegundero_Tick(object sender, EventArgs e)
        {
            _controlador.tickTemporizador(principal);
            lblTemporizador.Text = _controlador.obtenerTiempoTemporizador(principal);
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            _controlador.reiniciarTemporizadores();
            lblTemporizador.Text = _controlador.obtenerTiempoTemporizador(principal);
        }

        private void posicionarEnEsquinaInferiorDerecha()
        {
            //Obtener el área de trabajo (excluye la barra de tareas)
            Rectangle areaTrabajo = Screen.PrimaryScreen.WorkingArea;

            //Calcular la posición exacta
            int x = areaTrabajo.Width - this.Width;
            int y = areaTrabajo.Height - this.Height;

            //Asignar la nueva ubicación
            this.Location = new Point(x, y);
        }

        private void cmbSonidoAviso_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sonidoSeleccionado = cmbSonidoAviso.Text;
            _controlador.setSonido(sonidoSeleccionado);
        }

        private void PantallaPrincipal_KeyDown(object sender, KeyEventArgs e)
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
                lblTemporizador.Text = _controlador.obtenerTiempoTemporizador(principal);
            }
        }

        private void chbVisiblePausado_CheckedChanged(object sender, EventArgs e)
        {
            this.controlarTopMost();
        }

        private void controlarTopMost()
        {
            if (chbVisiblePausado.Checked && !activado)
            {
                this.TopMost = true;
                this.MinimizeBox = false;
                this.BringToFront();
            }
            else
            {
                this.TopMost = false;
                this.MinimizeBox= true;
            }
        }
    }
}
