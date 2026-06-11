namespace Regla20_20_20
{
    partial class PantallaPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblTemporizador = new Label();
            groupBox1 = new GroupBox();
            cmbSonidoAviso = new ComboBox();
            timerSegundero = new System.Windows.Forms.Timer(components);
            btnActivarPausar = new FontAwesome.Sharp.IconButton();
            btnReiniciar = new FontAwesome.Sharp.IconButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTemporizador
            // 
            lblTemporizador.AutoSize = true;
            lblTemporizador.Font = new Font("Arial Rounded MT Bold", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTemporizador.Location = new Point(13, 9);
            lblTemporizador.Margin = new Padding(4, 0, 4, 0);
            lblTemporizador.Name = "lblTemporizador";
            lblTemporizador.Size = new Size(305, 111);
            lblTemporizador.TabIndex = 1;
            lblTemporizador.Text = "00:00";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbSonidoAviso);
            groupBox1.Font = new Font("Arial Rounded MT Bold", 9F);
            groupBox1.Location = new Point(13, 124);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(286, 46);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "sonido aviso";
            // 
            // cmbSonidoAviso
            // 
            cmbSonidoAviso.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSonidoAviso.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbSonidoAviso.FormattingEnabled = true;
            cmbSonidoAviso.Items.AddRange(new object[] { "Ninguno", "Ding", "BeepBeep" });
            cmbSonidoAviso.Location = new Point(58, 12);
            cmbSonidoAviso.Margin = new Padding(4);
            cmbSonidoAviso.Name = "cmbSonidoAviso";
            cmbSonidoAviso.Size = new Size(206, 26);
            cmbSonidoAviso.TabIndex = 0;
            cmbSonidoAviso.SelectedIndexChanged += cmbSonidoAviso_SelectedIndexChanged;
            // 
            // timerSegundero
            // 
            timerSegundero.Interval = 1000;
            timerSegundero.Tick += timerSegundero_Tick;
            // 
            // btnActivarPausar
            // 
            btnActivarPausar.IconChar = FontAwesome.Sharp.IconChar.Pause;
            btnActivarPausar.IconColor = Color.Black;
            btnActivarPausar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnActivarPausar.IconSize = 100;
            btnActivarPausar.Location = new Point(307, 12);
            btnActivarPausar.Name = "btnActivarPausar";
            btnActivarPausar.Size = new Size(154, 109);
            btnActivarPausar.TabIndex = 4;
            btnActivarPausar.UseVisualStyleBackColor = true;
            btnActivarPausar.Click += btnActivarPausar_Click;
            // 
            // btnReiniciar
            // 
            btnReiniciar.IconChar = FontAwesome.Sharp.IconChar.ArrowRotateLeft;
            btnReiniciar.IconColor = Color.Black;
            btnReiniciar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnReiniciar.IconSize = 30;
            btnReiniciar.Location = new Point(307, 127);
            btnReiniciar.Name = "btnReiniciar";
            btnReiniciar.Size = new Size(154, 40);
            btnReiniciar.TabIndex = 5;
            btnReiniciar.UseVisualStyleBackColor = true;
            btnReiniciar.Click += btnReiniciar_Click;
            // 
            // PantallaPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(470, 175);
            Controls.Add(btnReiniciar);
            Controls.Add(btnActivarPausar);
            Controls.Add(groupBox1);
            Controls.Add(lblTemporizador);
            Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "PantallaPrincipal";
            StartPosition = FormStartPosition.Manual;
            Text = "Regla 20-20-20";
            Load += Principal_Load;
            KeyDown += PantallaPrincipal_KeyDown;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblTemporizador;
        private GroupBox groupBox1;
        private ComboBox cmbSonidoAviso;
        private System.Windows.Forms.Timer timerSegundero;
        private FontAwesome.Sharp.IconButton btnActivarPausar;
        private FontAwesome.Sharp.IconButton btnReiniciar;
    }
}
