namespace Practica_w11
{
    partial class PracticaW11
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.trkbAmplitud = new System.Windows.Forms.TrackBar();
            this.panelDibujo = new System.Windows.Forms.Panel();
            this.lbAmplitude = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbNumCiclos = new System.Windows.Forms.Label();
            this.lbOffset = new System.Windows.Forms.Label();
            this.lbDesfase = new System.Windows.Forms.Label();
            this.nudCiclos = new System.Windows.Forms.NumericUpDown();
            this.nudDesfase = new System.Windows.Forms.NumericUpDown();
            this.nudOffset = new System.Windows.Forms.NumericUpDown();
            this.Trazo = new System.Windows.Forms.GroupBox();
            this.cbGrosor = new System.Windows.Forms.ComboBox();
            this.lbGrosor = new System.Windows.Forms.Label();
            this.lbColor = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.gbFondo = new System.Windows.Forms.GroupBox();
            this.chbRojo = new System.Windows.Forms.CheckBox();
            this.chbVerde = new System.Windows.Forms.CheckBox();
            this.chbAzul = new System.Windows.Forms.CheckBox();
            this.chbNegro = new System.Windows.Forms.CheckBox();
            this.chbBlanco = new System.Windows.Forms.CheckBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnDibujar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trkbAmplitud)).BeginInit();
            this.panelDibujo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCiclos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDesfase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOffset)).BeginInit();
            this.Trazo.SuspendLayout();
            this.gbFondo.SuspendLayout();
            this.SuspendLayout();
            // 
            // trkbAmplitud
            // 
            this.trkbAmplitud.LargeChange = 10;
            this.trkbAmplitud.Location = new System.Drawing.Point(23, 28);
            this.trkbAmplitud.Maximum = 250;
            this.trkbAmplitud.Name = "trkbAmplitud";
            this.trkbAmplitud.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trkbAmplitud.Size = new System.Drawing.Size(45, 250);
            this.trkbAmplitud.TabIndex = 0;
            this.trkbAmplitud.Tag = "";
            // 
            // panelDibujo
            // 
            this.panelDibujo.BackColor = System.Drawing.Color.White;
            this.panelDibujo.Controls.Add(this.label1);
            this.panelDibujo.Location = new System.Drawing.Point(74, 35);
            this.panelDibujo.Name = "panelDibujo";
            this.panelDibujo.Size = new System.Drawing.Size(800, 500);
            this.panelDibujo.TabIndex = 1;
            // 
            // lbAmplitude
            // 
            this.lbAmplitude.AutoSize = true;
            this.lbAmplitude.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAmplitude.Location = new System.Drawing.Point(23, 13);
            this.lbAmplitude.Name = "lbAmplitude";
            this.lbAmplitude.Size = new System.Drawing.Size(61, 12);
            this.lbAmplitude.TabIndex = 2;
            this.lbAmplitude.Text = "Amplitude";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-19, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "0";
            // 
            // lbNumCiclos
            // 
            this.lbNumCiclos.AutoSize = true;
            this.lbNumCiclos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumCiclos.Location = new System.Drawing.Point(12, 323);
            this.lbNumCiclos.Name = "lbNumCiclos";
            this.lbNumCiclos.Size = new System.Drawing.Size(53, 12);
            this.lbNumCiclos.TabIndex = 3;
            this.lbNumCiclos.Text = "N. Ciclos";
            // 
            // lbOffset
            // 
            this.lbOffset.AutoSize = true;
            this.lbOffset.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOffset.Location = new System.Drawing.Point(12, 466);
            this.lbOffset.Name = "lbOffset";
            this.lbOffset.Size = new System.Drawing.Size(39, 12);
            this.lbOffset.TabIndex = 4;
            this.lbOffset.Text = "Offset";
            this.lbOffset.Click += new System.EventHandler(this.lbOffset_Click);
            // 
            // lbDesfase
            // 
            this.lbDesfase.AutoSize = true;
            this.lbDesfase.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDesfase.Location = new System.Drawing.Point(12, 390);
            this.lbDesfase.Name = "lbDesfase";
            this.lbDesfase.Size = new System.Drawing.Size(50, 12);
            this.lbDesfase.TabIndex = 5;
            this.lbDesfase.Text = "Desfase";
            // 
            // nudCiclos
            // 
            this.nudCiclos.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudCiclos.Location = new System.Drawing.Point(15, 340);
            this.nudCiclos.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudCiclos.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudCiclos.Name = "nudCiclos";
            this.nudCiclos.Size = new System.Drawing.Size(45, 20);
            this.nudCiclos.TabIndex = 6;
            this.nudCiclos.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudDesfase
            // 
            this.nudDesfase.Location = new System.Drawing.Point(15, 408);
            this.nudDesfase.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.nudDesfase.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.nudDesfase.Name = "nudDesfase";
            this.nudDesfase.Size = new System.Drawing.Size(45, 20);
            this.nudDesfase.TabIndex = 7;
            // 
            // nudOffset
            // 
            this.nudOffset.Location = new System.Drawing.Point(15, 482);
            this.nudOffset.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.nudOffset.Minimum = new decimal(new int[] {
            250,
            0,
            0,
            -2147483648});
            this.nudOffset.Name = "nudOffset";
            this.nudOffset.Size = new System.Drawing.Size(45, 20);
            this.nudOffset.TabIndex = 8;
            // 
            // Trazo
            // 
            this.Trazo.Controls.Add(this.label2);
            this.Trazo.Controls.Add(this.lbColor);
            this.Trazo.Controls.Add(this.lbGrosor);
            this.Trazo.Controls.Add(this.cbGrosor);
            this.Trazo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Trazo.Location = new System.Drawing.Point(880, 51);
            this.Trazo.Name = "Trazo";
            this.Trazo.Size = new System.Drawing.Size(93, 139);
            this.Trazo.TabIndex = 9;
            this.Trazo.TabStop = false;
            this.Trazo.Text = "Trazo";
            // 
            // cbGrosor
            // 
            this.cbGrosor.DisplayMember = "2,5";
            this.cbGrosor.FormattingEnabled = true;
            this.cbGrosor.Items.AddRange(new object[] {
            "1",
            "1,5",
            "2",
            "2,5",
            "3",
            "3,5",
            "4",
            "4,5",
            "5"});
            this.cbGrosor.Location = new System.Drawing.Point(16, 46);
            this.cbGrosor.MaxDropDownItems = 10;
            this.cbGrosor.Name = "cbGrosor";
            this.cbGrosor.Size = new System.Drawing.Size(69, 23);
            this.cbGrosor.TabIndex = 0;
            this.cbGrosor.Text = "2,5";
            this.cbGrosor.ValueMember = "2,5";
            // 
            // lbGrosor
            // 
            this.lbGrosor.AutoSize = true;
            this.lbGrosor.Location = new System.Drawing.Point(16, 26);
            this.lbGrosor.Name = "lbGrosor";
            this.lbGrosor.Size = new System.Drawing.Size(52, 15);
            this.lbGrosor.TabIndex = 1;
            this.lbGrosor.Text = "Grosor";
            // 
            // lbColor
            // 
            this.lbColor.AutoSize = true;
            this.lbColor.Location = new System.Drawing.Point(16, 81);
            this.lbColor.Name = "lbColor";
            this.lbColor.Size = new System.Drawing.Size(43, 15);
            this.lbColor.TabIndex = 2;
            this.lbColor.Text = "Color";
            // 
            // gbFondo
            // 
            this.gbFondo.Controls.Add(this.chbBlanco);
            this.gbFondo.Controls.Add(this.chbNegro);
            this.gbFondo.Controls.Add(this.chbAzul);
            this.gbFondo.Controls.Add(this.chbVerde);
            this.gbFondo.Controls.Add(this.chbRojo);
            this.gbFondo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFondo.Location = new System.Drawing.Point(880, 207);
            this.gbFondo.Name = "gbFondo";
            this.gbFondo.Size = new System.Drawing.Size(93, 173);
            this.gbFondo.TabIndex = 10;
            this.gbFondo.TabStop = false;
            this.gbFondo.Text = "Fondo";
            // 
            // chbRojo
            // 
            this.chbRojo.BackColor = System.Drawing.Color.Red;
            this.chbRojo.Location = new System.Drawing.Point(11, 81);
            this.chbRojo.Name = "chbRojo";
            this.chbRojo.Size = new System.Drawing.Size(71, 19);
            this.chbRojo.TabIndex = 0;
            this.chbRojo.Text = "Rojo";
            this.chbRojo.UseVisualStyleBackColor = false;
            this.chbRojo.CheckedChanged += new System.EventHandler(this.cbRojo_CheckedChanged);
            // 
            // chbVerde
            // 
            this.chbVerde.BackColor = System.Drawing.Color.Green;
            this.chbVerde.Location = new System.Drawing.Point(11, 109);
            this.chbVerde.Name = "chbVerde";
            this.chbVerde.Size = new System.Drawing.Size(71, 19);
            this.chbVerde.TabIndex = 1;
            this.chbVerde.Text = "Verde";
            this.chbVerde.UseVisualStyleBackColor = false;
            // 
            // chbAzul
            // 
            this.chbAzul.BackColor = System.Drawing.Color.Blue;
            this.chbAzul.Location = new System.Drawing.Point(11, 136);
            this.chbAzul.Name = "chbAzul";
            this.chbAzul.Size = new System.Drawing.Size(71, 19);
            this.chbAzul.TabIndex = 2;
            this.chbAzul.Text = "Azul";
            this.chbAzul.UseVisualStyleBackColor = false;
            // 
            // chbNegro
            // 
            this.chbNegro.BackColor = System.Drawing.Color.Black;
            this.chbNegro.ForeColor = System.Drawing.SystemColors.Control;
            this.chbNegro.Location = new System.Drawing.Point(11, 54);
            this.chbNegro.Name = "chbNegro";
            this.chbNegro.Size = new System.Drawing.Size(71, 19);
            this.chbNegro.TabIndex = 3;
            this.chbNegro.Text = "Negro";
            this.chbNegro.UseVisualStyleBackColor = false;
            // 
            // chbBlanco
            // 
            this.chbBlanco.AutoSize = true;
            this.chbBlanco.BackColor = System.Drawing.Color.White;
            this.chbBlanco.Checked = true;
            this.chbBlanco.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbBlanco.Location = new System.Drawing.Point(11, 27);
            this.chbBlanco.Name = "chbBlanco";
            this.chbBlanco.Size = new System.Drawing.Size(71, 19);
            this.chbBlanco.TabIndex = 4;
            this.chbBlanco.Text = "Blanco";
            this.chbBlanco.UseVisualStyleBackColor = false;
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Location = new System.Drawing.Point(891, 408);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(77, 29);
            this.btnBorrar.TabIndex = 11;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnDibujar
            // 
            this.btnDibujar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnDibujar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDibujar.Location = new System.Drawing.Point(887, 455);
            this.btnDibujar.Name = "btnDibujar";
            this.btnDibujar.Size = new System.Drawing.Size(86, 33);
            this.btnDibujar.TabIndex = 12;
            this.btnDibujar.Text = "Dibujar";
            this.btnDibujar.UseVisualStyleBackColor = false;
            this.btnDibujar.Click += new System.EventHandler(this.btnDibujar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // PracticaW11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 646);
            this.Controls.Add(this.btnDibujar);
            this.Controls.Add(this.nudOffset);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.nudDesfase);
            this.Controls.Add(this.gbFondo);
            this.Controls.Add(this.nudCiclos);
            this.Controls.Add(this.Trazo);
            this.Controls.Add(this.lbDesfase);
            this.Controls.Add(this.lbOffset);
            this.Controls.Add(this.lbNumCiclos);
            this.Controls.Add(this.lbAmplitude);
            this.Controls.Add(this.panelDibujo);
            this.Controls.Add(this.trkbAmplitud);
            this.Name = "PracticaW11";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trkbAmplitud)).EndInit();
            this.panelDibujo.ResumeLayout(false);
            this.panelDibujo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCiclos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDesfase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOffset)).EndInit();
            this.Trazo.ResumeLayout(false);
            this.Trazo.PerformLayout();
            this.gbFondo.ResumeLayout(false);
            this.gbFondo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TrackBar trkbAmplitud;
        private System.Windows.Forms.Panel panelDibujo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbAmplitude;
        private System.Windows.Forms.Label lbNumCiclos;
        private System.Windows.Forms.Label lbOffset;
        private System.Windows.Forms.Label lbDesfase;
        private System.Windows.Forms.GroupBox Trazo;
        private System.Windows.Forms.NumericUpDown nudCiclos;
        private System.Windows.Forms.NumericUpDown nudDesfase;
        private System.Windows.Forms.NumericUpDown nudOffset;
        private System.Windows.Forms.ComboBox cbGrosor;
        private System.Windows.Forms.Label lbGrosor;
        private System.Windows.Forms.Label lbColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.GroupBox gbFondo;
        private System.Windows.Forms.CheckBox chbBlanco;
        private System.Windows.Forms.CheckBox chbNegro;
        private System.Windows.Forms.CheckBox chbAzul;
        private System.Windows.Forms.CheckBox chbVerde;
        private System.Windows.Forms.CheckBox chbRojo;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnDibujar;
        private System.Windows.Forms.Label label2;
    }
}

