namespace _1.Probabilidad_de_ocurrencia
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnArchivo = new System.Windows.Forms.Button();
            this.rtxTexto = new System.Windows.Forms.RichTextBox();
            this.lbxConcurrencia = new System.Windows.Forms.ListBox();
            this.lbxProbabilidad = new System.Windows.Forms.ListBox();
            this.lblTotalSimb = new System.Windows.Forms.Label();
            this.lblTotalAnalizados = new System.Windows.Forms.Label();
            this.lblEntropia = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnArchivo
            // 
            this.btnArchivo.BackColor = System.Drawing.Color.Transparent;
            this.btnArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArchivo.ForeColor = System.Drawing.Color.White;
            this.btnArchivo.Location = new System.Drawing.Point(119, 24);
            this.btnArchivo.Name = "btnArchivo";
            this.btnArchivo.Size = new System.Drawing.Size(105, 50);
            this.btnArchivo.TabIndex = 0;
            this.btnArchivo.Text = "Cargar documento";
            this.btnArchivo.UseVisualStyleBackColor = false;
            this.btnArchivo.Click += new System.EventHandler(this.btnArchivo_Click);
            // 
            // rtxTexto
            // 
            this.rtxTexto.BackColor = System.Drawing.Color.LightSteelBlue;
            this.rtxTexto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxTexto.ForeColor = System.Drawing.Color.Black;
            this.rtxTexto.Location = new System.Drawing.Point(21, 94);
            this.rtxTexto.Name = "rtxTexto";
            this.rtxTexto.Size = new System.Drawing.Size(300, 264);
            this.rtxTexto.TabIndex = 2;
            this.rtxTexto.Text = " ";
            // 
            // lbxConcurrencia
            // 
            this.lbxConcurrencia.BackColor = System.Drawing.Color.SteelBlue;
            this.lbxConcurrencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbxConcurrencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxConcurrencia.ForeColor = System.Drawing.Color.White;
            this.lbxConcurrencia.FormattingEnabled = true;
            this.lbxConcurrencia.ItemHeight = 20;
            this.lbxConcurrencia.Location = new System.Drawing.Point(343, 94);
            this.lbxConcurrencia.Name = "lbxConcurrencia";
            this.lbxConcurrencia.Size = new System.Drawing.Size(100, 262);
            this.lbxConcurrencia.TabIndex = 4;
            // 
            // lbxProbabilidad
            // 
            this.lbxProbabilidad.BackColor = System.Drawing.Color.SteelBlue;
            this.lbxProbabilidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbxProbabilidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxProbabilidad.ForeColor = System.Drawing.Color.White;
            this.lbxProbabilidad.FormattingEnabled = true;
            this.lbxProbabilidad.ItemHeight = 20;
            this.lbxProbabilidad.Location = new System.Drawing.Point(458, 94);
            this.lbxProbabilidad.Name = "lbxProbabilidad";
            this.lbxProbabilidad.Size = new System.Drawing.Size(100, 262);
            this.lbxProbabilidad.TabIndex = 5;
            this.lbxProbabilidad.SelectedIndexChanged += new System.EventHandler(this.lbxProbabilidad_SelectedIndexChanged);
            // 
            // lblTotalSimb
            // 
            this.lblTotalSimb.AutoSize = true;
            this.lblTotalSimb.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalSimb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSimb.ForeColor = System.Drawing.Color.White;
            this.lblTotalSimb.Location = new System.Drawing.Point(323, 397);
            this.lblTotalSimb.Name = "lblTotalSimb";
            this.lblTotalSimb.Size = new System.Drawing.Size(159, 18);
            this.lblTotalSimb.TabIndex = 6;
            this.lblTotalSimb.Text = "Cantidad de simbolos: ";
            // 
            // lblTotalAnalizados
            // 
            this.lblTotalAnalizados.AutoSize = true;
            this.lblTotalAnalizados.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalAnalizados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAnalizados.ForeColor = System.Drawing.Color.White;
            this.lblTotalAnalizados.Location = new System.Drawing.Point(323, 424);
            this.lblTotalAnalizados.Name = "lblTotalAnalizados";
            this.lblTotalAnalizados.Size = new System.Drawing.Size(191, 16);
            this.lblTotalAnalizados.TabIndex = 7;
            this.lblTotalAnalizados.Text = "Total de simbolos analizados: ";
            // 
            // lblEntropia
            // 
            this.lblEntropia.AutoSize = true;
            this.lblEntropia.BackColor = System.Drawing.Color.Transparent;
            this.lblEntropia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntropia.ForeColor = System.Drawing.Color.Transparent;
            this.lblEntropia.Location = new System.Drawing.Point(18, 396);
            this.lblEntropia.Name = "lblEntropia";
            this.lblEntropia.Size = new System.Drawing.Size(209, 100);
            this.lblEntropia.TabIndex = 9;
            this.lblEntropia.Text = "ENTROPÍA DE LA FUENTE\r\n\r\nH(S) =\r\n\r\n\r\n";
            this.lblEntropia.Click += new System.EventHandler(this.lblEntropia_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(358, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Concurrencia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(476, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Probabilidad";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(420, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "- SIMBOLOS -";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(580, 482);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEntropia);
            this.Controls.Add(this.lblTotalAnalizados);
            this.Controls.Add(this.lblTotalSimb);
            this.Controls.Add(this.lbxProbabilidad);
            this.Controls.Add(this.lbxConcurrencia);
            this.Controls.Add(this.rtxTexto);
            this.Controls.Add(this.btnArchivo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Probabilidad de ocurrencia";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnArchivo;
        private System.Windows.Forms.RichTextBox rtxTexto;
        private System.Windows.Forms.ListBox lbxConcurrencia;
        private System.Windows.Forms.ListBox lbxProbabilidad;
        private System.Windows.Forms.Label lblTotalSimb;
        private System.Windows.Forms.Label lblTotalAnalizados;
        private System.Windows.Forms.Label lblEntropia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

