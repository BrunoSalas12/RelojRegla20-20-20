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
    }
}
