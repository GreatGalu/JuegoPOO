
namespace JuegoPOO
{
    partial class Form1
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
            lblJugador = new Label();
            lblVidaJugador = new Label();
            lblVidaEnemigo = new Label();
            cmbPersonaje = new ComboBox();
            btnCrear = new Button();
            btnAtacar = new Button();
            btnEspecial = new Button();
            pbVidaJugador = new ProgressBar();
            pbVidaEnemigo = new ProgressBar();
            txtLog = new TextBox();
            btnCurar = new Button();
            lblEnemigo = new Label();
            pbxEnemigo = new PictureBox();
            pbxJugador = new PictureBox();
            btnSubirImagen = new Button();
            lblVictorias = new Label();
            ttInfoPersonaje = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)pbxEnemigo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxJugador).BeginInit();
            SuspendLayout();
            // 
            // lblJugador
            // 
            lblJugador.AutoSize = true;
            lblJugador.Font = new Font("Helvetica", 9F, FontStyle.Bold);
            lblJugador.ForeColor = Color.FromArgb(234, 234, 234);
            lblJugador.Location = new Point(380, 290);
            lblJugador.Name = "lblJugador";
            lblJugador.Size = new Size(54, 15);
            lblJugador.TabIndex = 0;
            lblJugador.Text = "Jugador";
            lblJugador.Click += lblJugador_Click;
            // 
            // lblVidaJugador
            // 
            lblVidaJugador.AutoSize = true;
            lblVidaJugador.ForeColor = Color.FromArgb(234, 234, 234);
            lblVidaJugador.Location = new Point(435, 290);
            lblVidaJugador.Name = "lblVidaJugador";
            lblVidaJugador.Size = new Size(75, 15);
            lblVidaJugador.TabIndex = 1;
            lblVidaJugador.Text = "Vida Jugador";
            // 
            // lblVidaEnemigo
            // 
            lblVidaEnemigo.AutoSize = true;
            lblVidaEnemigo.ForeColor = Color.FromArgb(234, 234, 234);
            lblVidaEnemigo.Location = new Point(87, 290);
            lblVidaEnemigo.Name = "lblVidaEnemigo";
            lblVidaEnemigo.Size = new Size(80, 15);
            lblVidaEnemigo.TabIndex = 2;
            lblVidaEnemigo.Text = "Vida Enemigo";
            // 
            // cmbPersonaje
            // 
            cmbPersonaje.BackColor = SystemColors.ScrollBar;
            cmbPersonaje.FlatStyle = FlatStyle.Popup;
            cmbPersonaje.Font = new Font("Helvetica", 9F, FontStyle.Bold);
            cmbPersonaje.ForeColor = Color.FromArgb(22, 33, 62);
            cmbPersonaje.FormattingEnabled = true;
            cmbPersonaje.Items.AddRange(new object[] { "Guerrero", "Mago", "Arquero" });
            cmbPersonaje.Location = new Point(27, 25);
            cmbPersonaje.Name = "cmbPersonaje";
            cmbPersonaje.Size = new Size(253, 23);
            cmbPersonaje.TabIndex = 3;
            cmbPersonaje.Text = "Opciones";
            cmbPersonaje.SelectedIndexChanged += cmbPersonaje_SelectedIndexChanged;
            // 
            // btnCrear
            // 
            btnCrear.BackColor = Color.FromArgb(233, 69, 96);
            btnCrear.FlatStyle = FlatStyle.Popup;
            btnCrear.Font = new Font("CocogooseProTrial Bold", 8.25F, FontStyle.Bold);
            btnCrear.ForeColor = Color.MistyRose;
            btnCrear.Location = new Point(693, 72);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(75, 23);
            btnCrear.TabIndex = 4;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = false;
            btnCrear.Click += btnCrear_Click;
            // 
            // btnAtacar
            // 
            btnAtacar.BackColor = Color.FromArgb(233, 69, 96);
            btnAtacar.FlatStyle = FlatStyle.Popup;
            btnAtacar.Font = new Font("CocogooseProTrial Bold", 8.25F, FontStyle.Bold);
            btnAtacar.ForeColor = Color.MistyRose;
            btnAtacar.Location = new Point(693, 122);
            btnAtacar.Name = "btnAtacar";
            btnAtacar.Size = new Size(75, 23);
            btnAtacar.TabIndex = 5;
            btnAtacar.Text = "Atacar";
            btnAtacar.UseVisualStyleBackColor = false;
            btnAtacar.Click += btnAtacar_Click;
            // 
            // btnEspecial
            // 
            btnEspecial.BackColor = Color.FromArgb(233, 69, 96);
            btnEspecial.FlatStyle = FlatStyle.Popup;
            btnEspecial.Font = new Font("CocogooseProTrial Bold", 8.25F, FontStyle.Bold);
            btnEspecial.ForeColor = Color.MistyRose;
            btnEspecial.Location = new Point(693, 170);
            btnEspecial.Name = "btnEspecial";
            btnEspecial.Size = new Size(75, 44);
            btnEspecial.TabIndex = 6;
            btnEspecial.Text = "Ataque Especial";
            btnEspecial.UseVisualStyleBackColor = false;
            btnEspecial.Click += btnEspecial_Click;
            // 
            // pbVidaJugador
            // 
            pbVidaJugador.Location = new Point(380, 308);
            pbVidaJugador.Name = "pbVidaJugador";
            pbVidaJugador.Size = new Size(253, 23);
            pbVidaJugador.TabIndex = 7;
            // 
            // pbVidaEnemigo
            // 
            pbVidaEnemigo.Location = new Point(27, 308);
            pbVidaEnemigo.Name = "pbVidaEnemigo";
            pbVidaEnemigo.Size = new Size(253, 23);
            pbVidaEnemigo.Style = ProgressBarStyle.Continuous;
            pbVidaEnemigo.TabIndex = 8;
            // 
            // txtLog
            // 
            txtLog.BackColor = SystemColors.ScrollBar;
            txtLog.Font = new Font("Segoe UI", 16F);
            txtLog.ForeColor = Color.FromArgb(22, 33, 62);
            txtLog.Location = new Point(27, 362);
            txtLog.Multiline = true;
            txtLog.Name = "txtLog";
            txtLog.ScrollBars = ScrollBars.Vertical;
            txtLog.Size = new Size(741, 119);
            txtLog.TabIndex = 9;
            // 
            // btnCurar
            // 
            btnCurar.BackColor = Color.FromArgb(233, 69, 96);
            btnCurar.FlatStyle = FlatStyle.Popup;
            btnCurar.Font = new Font("CocogooseProTrial Bold", 8.25F, FontStyle.Bold);
            btnCurar.ForeColor = Color.MistyRose;
            btnCurar.Location = new Point(693, 241);
            btnCurar.Name = "btnCurar";
            btnCurar.Size = new Size(75, 23);
            btnCurar.TabIndex = 10;
            btnCurar.Text = "Curar";
            btnCurar.UseVisualStyleBackColor = false;
            btnCurar.Click += btnCurar_Click;
            // 
            // lblEnemigo
            // 
            lblEnemigo.AutoSize = true;
            lblEnemigo.Font = new Font("Helvetica", 9F, FontStyle.Bold);
            lblEnemigo.ForeColor = Color.FromArgb(234, 234, 234);
            lblEnemigo.Location = new Point(27, 290);
            lblEnemigo.Name = "lblEnemigo";
            lblEnemigo.Size = new Size(58, 15);
            lblEnemigo.TabIndex = 11;
            lblEnemigo.Text = "Enemigo";
            // 
            // pbxEnemigo
            // 
            pbxEnemigo.Location = new Point(27, 71);
            pbxEnemigo.Name = "pbxEnemigo";
            pbxEnemigo.Size = new Size(253, 192);
            pbxEnemigo.SizeMode = PictureBoxSizeMode.Zoom;
            pbxEnemigo.TabIndex = 12;
            pbxEnemigo.TabStop = false;
            // 
            // pbxJugador
            // 
            pbxJugador.Location = new Point(380, 72);
            pbxJugador.Name = "pbxJugador";
            pbxJugador.Size = new Size(253, 192);
            pbxJugador.SizeMode = PictureBoxSizeMode.Zoom;
            pbxJugador.TabIndex = 13;
            pbxJugador.TabStop = false;
            // 
            // btnSubirImagen
            // 
            btnSubirImagen.BackColor = Color.FromArgb(233, 69, 96);
            btnSubirImagen.Cursor = Cursors.Hand;
            btnSubirImagen.FlatStyle = FlatStyle.Popup;
            btnSubirImagen.Font = new Font("CocogooseProTrial Bold", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubirImagen.ForeColor = Color.MistyRose;
            btnSubirImagen.Location = new Point(300, 25);
            btnSubirImagen.Name = "btnSubirImagen";
            btnSubirImagen.Size = new Size(219, 23);
            btnSubirImagen.TabIndex = 14;
            btnSubirImagen.Text = "Subir imagen del personaje";
            btnSubirImagen.UseVisualStyleBackColor = false;
            btnSubirImagen.Click += btnSubirImagen_Click;
            // 
            // lblVictorias
            // 
            lblVictorias.AutoSize = true;
            lblVictorias.Font = new Font("Helvetica", 9F, FontStyle.Bold);
            lblVictorias.ForeColor = Color.FromArgb(234, 234, 234);
            lblVictorias.Location = new Point(611, 29);
            lblVictorias.Name = "lblVictorias";
            lblVictorias.Size = new Size(111, 15);
            lblVictorias.TabIndex = 15;
            lblVictorias.Text = "Batallas ganadas:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 26, 46);
            ClientSize = new Size(797, 509);
            Controls.Add(lblVictorias);
            Controls.Add(btnSubirImagen);
            Controls.Add(pbxJugador);
            Controls.Add(pbxEnemigo);
            Controls.Add(lblEnemigo);
            Controls.Add(btnCurar);
            Controls.Add(txtLog);
            Controls.Add(pbVidaEnemigo);
            Controls.Add(pbVidaJugador);
            Controls.Add(btnEspecial);
            Controls.Add(btnAtacar);
            Controls.Add(btnCrear);
            Controls.Add(cmbPersonaje);
            Controls.Add(lblVidaEnemigo);
            Controls.Add(lblVidaJugador);
            Controls.Add(lblJugador);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load_1;
            ((System.ComponentModel.ISupportInitialize)pbxEnemigo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxJugador).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblJugador;
        private Label lblVidaJugador;
        private Label lblVidaEnemigo;
        private ComboBox cmbPersonaje;
        private Button btnCrear;
        private Button btnAtacar;
        private Button btnEspecial;
        private ProgressBar pbVidaJugador;
        private ProgressBar pbVidaEnemigo;
        private TextBox txtLog;
        private Button btnCurar;
        private Label lblEnemigo;
        private PictureBox pbxEnemigo;
        private PictureBox pbxJugador;
        private Button btnSubirImagen;
        private Label lblVictorias;
        private ToolTip ttInfoPersonaje;
    }
}
