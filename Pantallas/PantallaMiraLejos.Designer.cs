namespace Regla20_20_20.Pantallas
{
    partial class PantallaMiraLejos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaMiraLejos));
            timerSegundero = new System.Windows.Forms.Timer(components);
            lblTemporizador = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // timerSegundero
            // 
            timerSegundero.Interval = 1000;
            timerSegundero.Tick += timerSegundero_Tick;
            // 
            // lblTemporizador
            // 
            lblTemporizador.Anchor = AnchorStyles.None;
            lblTemporizador.AutoSize = true;
            lblTemporizador.Font = new Font("Arial Rounded MT Bold", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTemporizador.Location = new Point(162, 160);
            lblTemporizador.Margin = new Padding(5, 0, 5, 0);
            lblTemporizador.Name = "lblTemporizador";
            lblTemporizador.Size = new Size(305, 68);
            lblTemporizador.TabIndex = 2;
            lblTemporizador.Text = "00:00";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 27F);
            label1.Location = new Point(99, 118);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(430, 42);
            label1.TabIndex = 3;
            label1.Text = "Mira lejos de la pantalla";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 20F);
            label2.Location = new Point(174, 246);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(280, 32);
            label2.TabIndex = 4;
            label2.Text = "Al menos a 6 metros";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 27F);
            label3.Location = new Point(251, 296);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(126, 42);
            label3.TabIndex = 5;
            label3.Text = "(⚆ _ ⚆)";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.ControlDark;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(label3, 0, 3);
            tableLayoutPanel1.Controls.Add(label2, 0, 2);
            tableLayoutPanel1.Controls.Add(lblTemporizador, 0, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            tableLayoutPanel1.Size = new Size(629, 459);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // PantallaMiraLejos
            // 
            AutoScaleDimensions = new SizeF(8F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(629, 459);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PantallaMiraLejos";
            Opacity = 0.85D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mira Lejos";
            WindowState = FormWindowState.Maximized;
            Load += PantallaMiraLejos_Load;
            KeyDown += PantallaMiraLejos_KeyDown;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer timerSegundero;
        private Label lblTemporizador;
        private Label label1;
        private Label label2;
        private Label label3;
        private TableLayoutPanel tableLayoutPanel1;
    }
}