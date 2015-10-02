namespace Pract2SisOpe
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxListos = new System.Windows.Forms.TextBox();
            this.textBoxNuevos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxBloque = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTerminados = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxEjecuta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonBlock = new System.Windows.Forms.Button();
            this.buttonError = new System.Windows.Forms.Button();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.textBoxSalida = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Listos";
            // 
            // textBoxListos
            // 
            this.textBoxListos.Location = new System.Drawing.Point(16, 39);
            this.textBoxListos.Multiline = true;
            this.textBoxListos.Name = "textBoxListos";
            this.textBoxListos.Size = new System.Drawing.Size(151, 169);
            this.textBoxListos.TabIndex = 1;
            // 
            // textBoxNuevos
            // 
            this.textBoxNuevos.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxNuevos.Location = new System.Drawing.Point(16, 256);
            this.textBoxNuevos.Multiline = true;
            this.textBoxNuevos.Name = "textBoxNuevos";
            this.textBoxNuevos.Size = new System.Drawing.Size(124, 169);
            this.textBoxNuevos.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nuevos";
            // 
            // textBoxBloque
            // 
            this.textBoxBloque.Location = new System.Drawing.Point(207, 256);
            this.textBoxBloque.Multiline = true;
            this.textBoxBloque.Name = "textBoxBloque";
            this.textBoxBloque.Size = new System.Drawing.Size(150, 169);
            this.textBoxBloque.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(204, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Bloqueados";
            // 
            // textBoxTerminados
            // 
            this.textBoxTerminados.Location = new System.Drawing.Point(519, 256);
            this.textBoxTerminados.Multiline = true;
            this.textBoxTerminados.Name = "textBoxTerminados";
            this.textBoxTerminados.Size = new System.Drawing.Size(124, 169);
            this.textBoxTerminados.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(516, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Terminados";
            // 
            // textBoxEjecuta
            // 
            this.textBoxEjecuta.Location = new System.Drawing.Point(193, 39);
            this.textBoxEjecuta.Multiline = true;
            this.textBoxEjecuta.Name = "textBoxEjecuta";
            this.textBoxEjecuta.Size = new System.Drawing.Size(252, 169);
            this.textBoxEjecuta.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(190, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ejecucion";
            // 
            // buttonBlock
            // 
            this.buttonBlock.Location = new System.Drawing.Point(519, 39);
            this.buttonBlock.Name = "buttonBlock";
            this.buttonBlock.Size = new System.Drawing.Size(138, 35);
            this.buttonBlock.TabIndex = 10;
            this.buttonBlock.Text = "Bloquear";
            this.buttonBlock.UseVisualStyleBackColor = true;
            this.buttonBlock.Click += new System.EventHandler(this.buttonBlock_Click);
            // 
            // buttonError
            // 
            this.buttonError.Location = new System.Drawing.Point(519, 91);
            this.buttonError.Name = "buttonError";
            this.buttonError.Size = new System.Drawing.Size(138, 35);
            this.buttonError.TabIndex = 11;
            this.buttonError.Text = "Error";
            this.buttonError.UseVisualStyleBackColor = true;
            this.buttonError.Click += new System.EventHandler(this.buttonError_Click);
            // 
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(519, 144);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(138, 35);
            this.buttonSalir.TabIndex = 12;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(416, 400);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 13;
            this.buttonStart.Text = "Comenzar";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // textBoxSalida
            // 
            this.textBoxSalida.Location = new System.Drawing.Point(63, 13);
            this.textBoxSalida.Multiline = true;
            this.textBoxSalida.Name = "textBoxSalida";
            this.textBoxSalida.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxSalida.Size = new System.Drawing.Size(410, 434);
            this.textBoxSalida.TabIndex = 14;
            this.textBoxSalida.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 459);
            this.Controls.Add(this.textBoxSalida);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.buttonError);
            this.Controls.Add(this.buttonBlock);
            this.Controls.Add(this.textBoxEjecuta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxTerminados);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxBloque);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxNuevos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxListos);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBoxListos;
        public System.Windows.Forms.TextBox textBoxNuevos;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox textBoxBloque;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox textBoxTerminados;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox textBoxEjecuta;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Button buttonBlock;
        public System.Windows.Forms.Button buttonError;
        public System.Windows.Forms.Button buttonSalir;
        public System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.TextBox textBoxSalida;

    }
}

