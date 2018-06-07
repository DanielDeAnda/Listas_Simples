namespace Listas_simples
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnElimPrim = new System.Windows.Forms.Button();
            this.btnElimUltim = new System.Windows.Forms.Button();
            this.btnRepInvers = new System.Windows.Forms.Button();
            this.btnInvLista = new System.Windows.Forms.Button();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtAño = new System.Windows.Forms.TextBox();
            this.txtTelef = new System.Windows.Forms.TextBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLista = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(12, 13);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 33);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar ";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnElimPrim
            // 
            this.btnElimPrim.Location = new System.Drawing.Point(12, 53);
            this.btnElimPrim.Name = "btnElimPrim";
            this.btnElimPrim.Size = new System.Drawing.Size(75, 39);
            this.btnElimPrim.TabIndex = 1;
            this.btnElimPrim.Text = "Eliminar Primero";
            this.btnElimPrim.UseVisualStyleBackColor = true;
            this.btnElimPrim.Click += new System.EventHandler(this.btnElimPrim_Click);
            // 
            // btnElimUltim
            // 
            this.btnElimUltim.Location = new System.Drawing.Point(12, 98);
            this.btnElimUltim.Name = "btnElimUltim";
            this.btnElimUltim.Size = new System.Drawing.Size(75, 39);
            this.btnElimUltim.TabIndex = 2;
            this.btnElimUltim.Text = "Eliminar Ultimo";
            this.btnElimUltim.UseVisualStyleBackColor = true;
            this.btnElimUltim.Click += new System.EventHandler(this.btnElimUltim_Click);
            // 
            // btnRepInvers
            // 
            this.btnRepInvers.Location = new System.Drawing.Point(12, 144);
            this.btnRepInvers.Name = "btnRepInvers";
            this.btnRepInvers.Size = new System.Drawing.Size(75, 41);
            this.btnRepInvers.TabIndex = 3;
            this.btnRepInvers.Text = "Reporte Inverso";
            this.btnRepInvers.UseVisualStyleBackColor = true;
            this.btnRepInvers.Click += new System.EventHandler(this.btnRepInvers_Click);
            // 
            // btnInvLista
            // 
            this.btnInvLista.Location = new System.Drawing.Point(12, 192);
            this.btnInvLista.Name = "btnInvLista";
            this.btnInvLista.Size = new System.Drawing.Size(75, 36);
            this.btnInvLista.TabIndex = 4;
            this.btnInvLista.Text = "Invertir Lista";
            this.btnInvLista.UseVisualStyleBackColor = true;
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(117, 44);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(100, 20);
            this.txtPlaca.TabIndex = 5;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(117, 92);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(100, 20);
            this.txtMarca.TabIndex = 6;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(117, 135);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(100, 20);
            this.txtModelo.TabIndex = 7;
            // 
            // txtAño
            // 
            this.txtAño.Location = new System.Drawing.Point(117, 178);
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(100, 20);
            this.txtAño.TabIndex = 8;
            // 
            // txtTelef
            // 
            this.txtTelef.Location = new System.Drawing.Point(117, 221);
            this.txtTelef.Name = "txtTelef";
            this.txtTelef.Size = new System.Drawing.Size(100, 20);
            this.txtTelef.TabIndex = 9;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(12, 235);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 40);
            this.btnListar.TabIndex = 11;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Placa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Marca:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Modelo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(117, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Año:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(117, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Teléfono:";
            // 
            // txtLista
            // 
            this.txtLista.Location = new System.Drawing.Point(256, 26);
            this.txtLista.Multiline = true;
            this.txtLista.Name = "txtLista";
            this.txtLista.Size = new System.Drawing.Size(214, 242);
            this.txtLista.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 300);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.txtLista);
            this.Controls.Add(this.txtTelef);
            this.Controls.Add(this.txtAño);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.btnInvLista);
            this.Controls.Add(this.btnRepInvers);
            this.Controls.Add(this.btnElimUltim);
            this.Controls.Add(this.btnElimPrim);
            this.Controls.Add(this.btnAgregar);
            this.Name = "Form1";
            this.Text = "Listas Simples";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnElimPrim;
        private System.Windows.Forms.Button btnElimUltim;
        private System.Windows.Forms.Button btnRepInvers;
        private System.Windows.Forms.Button btnInvLista;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtAño;
        private System.Windows.Forms.TextBox txtTelef;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLista;
    }
}

