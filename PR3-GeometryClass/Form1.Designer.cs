namespace PR3_GeometryClass
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
            this.lblTriangulo = new System.Windows.Forms.Label();
            this.lblRectangulo = new System.Windows.Forms.Label();
            this.lblCirculo = new System.Windows.Forms.Label();
            this.txtCateto1 = new System.Windows.Forms.TextBox();
            this.txtCateto2 = new System.Windows.Forms.TextBox();
            this.txtLado1 = new System.Windows.Forms.TextBox();
            this.txtLado2 = new System.Windows.Forms.TextBox();
            this.txtRadio = new System.Windows.Forms.TextBox();
            this.btnCalcularTriangulo = new System.Windows.Forms.Button();
            this.btnCalcularRectangulo = new System.Windows.Forms.Button();
            this.btnCalcularCirculo = new System.Windows.Forms.Button();
            this.lblBase = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblLado1 = new System.Windows.Forms.Label();
            this.lblLado2 = new System.Windows.Forms.Label();
            this.lblRadio = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTriangulo
            // 
            this.lblTriangulo.AutoSize = true;
            this.lblTriangulo.Location = new System.Drawing.Point(51, 9);
            this.lblTriangulo.Name = "lblTriangulo";
            this.lblTriangulo.Size = new System.Drawing.Size(51, 13);
            this.lblTriangulo.TabIndex = 0;
            this.lblTriangulo.Text = "Triángulo";
            // 
            // lblRectangulo
            // 
            this.lblRectangulo.AutoSize = true;
            this.lblRectangulo.Location = new System.Drawing.Point(202, 9);
            this.lblRectangulo.Name = "lblRectangulo";
            this.lblRectangulo.Size = new System.Drawing.Size(62, 13);
            this.lblRectangulo.TabIndex = 1;
            this.lblRectangulo.Text = "Rectángulo";
            // 
            // lblCirculo
            // 
            this.lblCirculo.AutoSize = true;
            this.lblCirculo.Location = new System.Drawing.Point(119, 193);
            this.lblCirculo.Name = "lblCirculo";
            this.lblCirculo.Size = new System.Drawing.Size(41, 13);
            this.lblCirculo.TabIndex = 2;
            this.lblCirculo.Text = "Círculo";
            // 
            // txtCateto1
            // 
            this.txtCateto1.Location = new System.Drawing.Point(27, 25);
            this.txtCateto1.Name = "txtCateto1";
            this.txtCateto1.Size = new System.Drawing.Size(100, 20);
            this.txtCateto1.TabIndex = 3;
            this.txtCateto1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCateto1_KeyPress);
            // 
            // txtCateto2
            // 
            this.txtCateto2.Location = new System.Drawing.Point(27, 52);
            this.txtCateto2.Name = "txtCateto2";
            this.txtCateto2.Size = new System.Drawing.Size(100, 20);
            this.txtCateto2.TabIndex = 4;
            this.txtCateto2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCateto1_KeyPress);
            // 
            // txtLado1
            // 
            this.txtLado1.Location = new System.Drawing.Point(180, 25);
            this.txtLado1.Name = "txtLado1";
            this.txtLado1.Size = new System.Drawing.Size(100, 20);
            this.txtLado1.TabIndex = 5;
            this.txtLado1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCateto1_KeyPress);
            // 
            // txtLado2
            // 
            this.txtLado2.Location = new System.Drawing.Point(180, 51);
            this.txtLado2.Name = "txtLado2";
            this.txtLado2.Size = new System.Drawing.Size(100, 20);
            this.txtLado2.TabIndex = 6;
            this.txtLado2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCateto1_KeyPress);
            // 
            // txtRadio
            // 
            this.txtRadio.Location = new System.Drawing.Point(91, 209);
            this.txtRadio.Name = "txtRadio";
            this.txtRadio.Size = new System.Drawing.Size(100, 20);
            this.txtRadio.TabIndex = 7;
            this.txtRadio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCateto1_KeyPress);
            // 
            // btnCalcularTriangulo
            // 
            this.btnCalcularTriangulo.Location = new System.Drawing.Point(41, 78);
            this.btnCalcularTriangulo.Name = "btnCalcularTriangulo";
            this.btnCalcularTriangulo.Size = new System.Drawing.Size(75, 23);
            this.btnCalcularTriangulo.TabIndex = 9;
            this.btnCalcularTriangulo.Text = "calcular";
            this.btnCalcularTriangulo.UseVisualStyleBackColor = true;
            this.btnCalcularTriangulo.Click += new System.EventHandler(this.btnCalcularTriangulo_Click);
            // 
            // btnCalcularRectangulo
            // 
            this.btnCalcularRectangulo.Location = new System.Drawing.Point(189, 77);
            this.btnCalcularRectangulo.Name = "btnCalcularRectangulo";
            this.btnCalcularRectangulo.Size = new System.Drawing.Size(75, 23);
            this.btnCalcularRectangulo.TabIndex = 10;
            this.btnCalcularRectangulo.Text = "calcular";
            this.btnCalcularRectangulo.UseVisualStyleBackColor = true;
            this.btnCalcularRectangulo.Click += new System.EventHandler(this.btnCalcularRectangulo_Click);
            // 
            // btnCalcularCirculo
            // 
            this.btnCalcularCirculo.Location = new System.Drawing.Point(104, 235);
            this.btnCalcularCirculo.Name = "btnCalcularCirculo";
            this.btnCalcularCirculo.Size = new System.Drawing.Size(75, 23);
            this.btnCalcularCirculo.TabIndex = 11;
            this.btnCalcularCirculo.Text = "calcular";
            this.btnCalcularCirculo.UseVisualStyleBackColor = true;
            this.btnCalcularCirculo.Click += new System.EventHandler(this.btnCalcularCirculo_Click);
            // 
            // lblBase
            // 
            this.lblBase.AutoSize = true;
            this.lblBase.Location = new System.Drawing.Point(8, 32);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(13, 13);
            this.lblBase.TabIndex = 12;
            this.lblBase.Text = "b";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(8, 59);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(13, 13);
            this.lblAltura.TabIndex = 13;
            this.lblAltura.Text = "h";
            // 
            // lblLado1
            // 
            this.lblLado1.AutoSize = true;
            this.lblLado1.Location = new System.Drawing.Point(159, 28);
            this.lblLado1.Name = "lblLado1";
            this.lblLado1.Size = new System.Drawing.Size(15, 13);
            this.lblLado1.TabIndex = 14;
            this.lblLado1.Text = "l1";
            // 
            // lblLado2
            // 
            this.lblLado2.AutoSize = true;
            this.lblLado2.Location = new System.Drawing.Point(159, 51);
            this.lblLado2.Name = "lblLado2";
            this.lblLado2.Size = new System.Drawing.Size(15, 13);
            this.lblLado2.TabIndex = 15;
            this.lblLado2.Text = "l2";
            // 
            // lblRadio
            // 
            this.lblRadio.AutoSize = true;
            this.lblRadio.Location = new System.Drawing.Point(75, 212);
            this.lblRadio.Name = "lblRadio";
            this.lblRadio.Size = new System.Drawing.Size(10, 13);
            this.lblRadio.TabIndex = 16;
            this.lblRadio.Text = "r";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(75, 114);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 13);
            this.lblResultado.TabIndex = 17;
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblRadio);
            this.Controls.Add(this.lblLado2);
            this.Controls.Add(this.lblLado1);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.lblBase);
            this.Controls.Add(this.btnCalcularCirculo);
            this.Controls.Add(this.btnCalcularRectangulo);
            this.Controls.Add(this.btnCalcularTriangulo);
            this.Controls.Add(this.txtRadio);
            this.Controls.Add(this.txtLado2);
            this.Controls.Add(this.txtLado1);
            this.Controls.Add(this.txtCateto2);
            this.Controls.Add(this.txtCateto1);
            this.Controls.Add(this.lblCirculo);
            this.Controls.Add(this.lblRectangulo);
            this.Controls.Add(this.lblTriangulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTriangulo;
        private System.Windows.Forms.Label lblRectangulo;
        private System.Windows.Forms.Label lblCirculo;
        private System.Windows.Forms.TextBox txtCateto1;
        private System.Windows.Forms.TextBox txtCateto2;
        private System.Windows.Forms.TextBox txtLado1;
        private System.Windows.Forms.TextBox txtLado2;
        private System.Windows.Forms.TextBox txtRadio;
        private System.Windows.Forms.Button btnCalcularTriangulo;
        private System.Windows.Forms.Button btnCalcularRectangulo;
        private System.Windows.Forms.Button btnCalcularCirculo;
        private System.Windows.Forms.Label lblBase;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblLado1;
        private System.Windows.Forms.Label lblLado2;
        private System.Windows.Forms.Label lblRadio;
        private System.Windows.Forms.Label lblResultado;
    }
}

