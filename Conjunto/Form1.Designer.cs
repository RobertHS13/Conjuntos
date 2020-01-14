namespace Conjunto
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.borrarB = new System.Windows.Forms.Button();
            this.borrarA = new System.Windows.Forms.Button();
            this.borrarAlfa = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.numeroPotencia = new System.Windows.Forms.TextBox();
            this.agregarAlfa = new System.Windows.Forms.Button();
            this.alfabeto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.entradaAlfa = new System.Windows.Forms.TextBox();
            this.agregarB = new System.Windows.Forms.Button();
            this.agregarA = new System.Windows.Forms.Button();
            this.lenguajeB = new System.Windows.Forms.TextBox();
            this.lenguajeA = new System.Windows.Forms.TextBox();
            this.potencia = new System.Windows.Forms.RadioButton();
            this.producto = new System.Windows.Forms.RadioButton();
            this.complemento = new System.Windows.Forms.RadioButton();
            this.simetrica = new System.Windows.Forms.RadioButton();
            this.diferencia = new System.Windows.Forms.RadioButton();
            this.interseccion = new System.Windows.Forms.RadioButton();
            this.union = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.entradaB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.entradaA = new System.Windows.Forms.TextBox();
            this.boton = new System.Windows.Forms.Button();
            this.respuesta = new System.Windows.Forms.TextBox();
            this.r = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.CerraduraK = new System.Windows.Forms.RadioButton();
            this.CerraduraP = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // borrarB
            // 
            this.borrarB.BackColor = System.Drawing.Color.Tomato;
            this.borrarB.FlatAppearance.BorderSize = 0;
            this.borrarB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.borrarB.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrarB.ForeColor = System.Drawing.Color.White;
            this.borrarB.Location = new System.Drawing.Point(397, 265);
            this.borrarB.Name = "borrarB";
            this.borrarB.Size = new System.Drawing.Size(92, 30);
            this.borrarB.TabIndex = 50;
            this.borrarB.Text = "Borrar";
            this.borrarB.UseVisualStyleBackColor = false;
            this.borrarB.Click += new System.EventHandler(this.borrarB_Click);
            // 
            // borrarA
            // 
            this.borrarA.BackColor = System.Drawing.Color.Tomato;
            this.borrarA.FlatAppearance.BorderSize = 0;
            this.borrarA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.borrarA.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrarA.ForeColor = System.Drawing.Color.White;
            this.borrarA.Location = new System.Drawing.Point(397, 136);
            this.borrarA.Name = "borrarA";
            this.borrarA.Size = new System.Drawing.Size(92, 30);
            this.borrarA.TabIndex = 49;
            this.borrarA.Text = "Borrar";
            this.borrarA.UseVisualStyleBackColor = false;
            this.borrarA.Click += new System.EventHandler(this.borrarA_Click);
            // 
            // borrarAlfa
            // 
            this.borrarAlfa.BackColor = System.Drawing.Color.Tomato;
            this.borrarAlfa.FlatAppearance.BorderSize = 0;
            this.borrarAlfa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.borrarAlfa.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrarAlfa.ForeColor = System.Drawing.Color.White;
            this.borrarAlfa.Location = new System.Drawing.Point(396, 12);
            this.borrarAlfa.Name = "borrarAlfa";
            this.borrarAlfa.Size = new System.Drawing.Size(92, 30);
            this.borrarAlfa.TabIndex = 48;
            this.borrarAlfa.Text = "Borrar";
            this.borrarAlfa.UseVisualStyleBackColor = false;
            this.borrarAlfa.Click += new System.EventHandler(this.borrarAlfa_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(521, 213);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(165, 16);
            this.label.TabIndex = 47;
            this.label.Text = "Número de potencia:";
            // 
            // numeroPotencia
            // 
            this.numeroPotencia.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeroPotencia.Location = new System.Drawing.Point(692, 210);
            this.numeroPotencia.Name = "numeroPotencia";
            this.numeroPotencia.Size = new System.Drawing.Size(67, 23);
            this.numeroPotencia.TabIndex = 46;
            // 
            // agregarAlfa
            // 
            this.agregarAlfa.BackColor = System.Drawing.Color.PaleGreen;
            this.agregarAlfa.FlatAppearance.BorderSize = 0;
            this.agregarAlfa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agregarAlfa.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarAlfa.Location = new System.Drawing.Point(281, 13);
            this.agregarAlfa.Name = "agregarAlfa";
            this.agregarAlfa.Size = new System.Drawing.Size(92, 30);
            this.agregarAlfa.TabIndex = 45;
            this.agregarAlfa.Text = "Agregar";
            this.agregarAlfa.UseVisualStyleBackColor = false;
            this.agregarAlfa.Click += new System.EventHandler(this.agregarAlfa_Click_1);
            // 
            // alfabeto
            // 
            this.alfabeto.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alfabeto.Location = new System.Drawing.Point(13, 68);
            this.alfabeto.Name = "alfabeto";
            this.alfabeto.Size = new System.Drawing.Size(475, 31);
            this.alfabeto.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 24);
            this.label3.TabIndex = 43;
            this.label3.Text = "Alfabeto:";
            // 
            // entradaAlfa
            // 
            this.entradaAlfa.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entradaAlfa.Location = new System.Drawing.Point(152, 12);
            this.entradaAlfa.Name = "entradaAlfa";
            this.entradaAlfa.Size = new System.Drawing.Size(111, 31);
            this.entradaAlfa.TabIndex = 42;
            // 
            // agregarB
            // 
            this.agregarB.BackColor = System.Drawing.Color.PaleGreen;
            this.agregarB.FlatAppearance.BorderSize = 0;
            this.agregarB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agregarB.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarB.Location = new System.Drawing.Point(282, 265);
            this.agregarB.Name = "agregarB";
            this.agregarB.Size = new System.Drawing.Size(92, 30);
            this.agregarB.TabIndex = 41;
            this.agregarB.Text = "Agregar";
            this.agregarB.UseVisualStyleBackColor = false;
            this.agregarB.Click += new System.EventHandler(this.agregarB_Click);
            // 
            // agregarA
            // 
            this.agregarA.BackColor = System.Drawing.Color.PaleGreen;
            this.agregarA.FlatAppearance.BorderSize = 0;
            this.agregarA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agregarA.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarA.Location = new System.Drawing.Point(282, 136);
            this.agregarA.Name = "agregarA";
            this.agregarA.Size = new System.Drawing.Size(92, 30);
            this.agregarA.TabIndex = 40;
            this.agregarA.Text = "Agregar";
            this.agregarA.UseVisualStyleBackColor = false;
            this.agregarA.Click += new System.EventHandler(this.agregarA_Click_1);
            // 
            // lenguajeB
            // 
            this.lenguajeB.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lenguajeB.Location = new System.Drawing.Point(14, 316);
            this.lenguajeB.Name = "lenguajeB";
            this.lenguajeB.Size = new System.Drawing.Size(475, 31);
            this.lenguajeB.TabIndex = 39;
            // 
            // lenguajeA
            // 
            this.lenguajeA.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lenguajeA.Location = new System.Drawing.Point(14, 190);
            this.lenguajeA.Name = "lenguajeA";
            this.lenguajeA.Size = new System.Drawing.Size(475, 31);
            this.lenguajeA.TabIndex = 38;
            // 
            // potencia
            // 
            this.potencia.AutoSize = true;
            this.potencia.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.potencia.Location = new System.Drawing.Point(509, 190);
            this.potencia.Name = "potencia";
            this.potencia.Size = new System.Drawing.Size(91, 20);
            this.potencia.TabIndex = 37;
            this.potencia.TabStop = true;
            this.potencia.Text = "Potencia";
            this.potencia.UseVisualStyleBackColor = true;
            // 
            // producto
            // 
            this.producto.AutoSize = true;
            this.producto.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.producto.Location = new System.Drawing.Point(509, 164);
            this.producto.Name = "producto";
            this.producto.Size = new System.Drawing.Size(93, 20);
            this.producto.TabIndex = 36;
            this.producto.TabStop = true;
            this.producto.Text = "Producto";
            this.producto.UseVisualStyleBackColor = true;
            // 
            // complemento
            // 
            this.complemento.AutoSize = true;
            this.complemento.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.complemento.Location = new System.Drawing.Point(509, 136);
            this.complemento.Name = "complemento";
            this.complemento.Size = new System.Drawing.Size(125, 20);
            this.complemento.TabIndex = 35;
            this.complemento.TabStop = true;
            this.complemento.Text = "Complemento";
            this.complemento.UseVisualStyleBackColor = true;
            // 
            // simetrica
            // 
            this.simetrica.AutoSize = true;
            this.simetrica.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simetrica.Location = new System.Drawing.Point(509, 110);
            this.simetrica.Name = "simetrica";
            this.simetrica.Size = new System.Drawing.Size(177, 20);
            this.simetrica.TabIndex = 34;
            this.simetrica.TabStop = true;
            this.simetrica.Text = "Diferencia Simétrica";
            this.simetrica.UseVisualStyleBackColor = true;
            // 
            // diferencia
            // 
            this.diferencia.AutoSize = true;
            this.diferencia.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diferencia.Location = new System.Drawing.Point(508, 79);
            this.diferencia.Name = "diferencia";
            this.diferencia.Size = new System.Drawing.Size(101, 20);
            this.diferencia.TabIndex = 33;
            this.diferencia.TabStop = true;
            this.diferencia.Text = "Diferencia";
            this.diferencia.UseVisualStyleBackColor = true;
            // 
            // interseccion
            // 
            this.interseccion.AutoSize = true;
            this.interseccion.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.interseccion.Location = new System.Drawing.Point(509, 53);
            this.interseccion.Name = "interseccion";
            this.interseccion.Size = new System.Drawing.Size(120, 20);
            this.interseccion.TabIndex = 32;
            this.interseccion.TabStop = true;
            this.interseccion.Text = "Intersección";
            this.interseccion.UseVisualStyleBackColor = true;
            // 
            // union
            // 
            this.union.AutoSize = true;
            this.union.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.union.Location = new System.Drawing.Point(509, 27);
            this.union.Name = "union";
            this.union.Size = new System.Drawing.Size(67, 20);
            this.union.TabIndex = 31;
            this.union.TabStop = true;
            this.union.Text = "Unión";
            this.union.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 24);
            this.label2.TabIndex = 30;
            this.label2.Text = "Lenguaje B:";
            // 
            // entradaB
            // 
            this.entradaB.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entradaB.Location = new System.Drawing.Point(153, 265);
            this.entradaB.Name = "entradaB";
            this.entradaB.Size = new System.Drawing.Size(111, 31);
            this.entradaB.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 24);
            this.label1.TabIndex = 28;
            this.label1.Text = "Lenguaje A:";
            // 
            // entradaA
            // 
            this.entradaA.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entradaA.Location = new System.Drawing.Point(153, 139);
            this.entradaA.Name = "entradaA";
            this.entradaA.Size = new System.Drawing.Size(111, 31);
            this.entradaA.TabIndex = 27;
            // 
            // boton
            // 
            this.boton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.boton.FlatAppearance.BorderSize = 0;
            this.boton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton.ForeColor = System.Drawing.Color.White;
            this.boton.Location = new System.Drawing.Point(553, 300);
            this.boton.Name = "boton";
            this.boton.Size = new System.Drawing.Size(148, 30);
            this.boton.TabIndex = 53;
            this.boton.Text = "Realizar Operación";
            this.boton.UseVisualStyleBackColor = false;
            this.boton.Click += new System.EventHandler(this.boton_Click);
            // 
            // respuesta
            // 
            this.respuesta.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.respuesta.Location = new System.Drawing.Point(152, 366);
            this.respuesta.Multiline = true;
            this.respuesta.Name = "respuesta";
            this.respuesta.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.respuesta.Size = new System.Drawing.Size(595, 131);
            this.respuesta.TabIndex = 52;
            // 
            // r
            // 
            this.r.AutoSize = true;
            this.r.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r.Location = new System.Drawing.Point(9, 368);
            this.r.Name = "r";
            this.r.Size = new System.Drawing.Size(142, 26);
            this.r.TabIndex = 51;
            this.r.Text = "Respuesta:";
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // CerraduraK
            // 
            this.CerraduraK.AutoSize = true;
            this.CerraduraK.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CerraduraK.Location = new System.Drawing.Point(509, 239);
            this.CerraduraK.Name = "CerraduraK";
            this.CerraduraK.Size = new System.Drawing.Size(178, 20);
            this.CerraduraK.TabIndex = 56;
            this.CerraduraK.TabStop = true;
            this.CerraduraK.Text = "Cerradura de Kleene";
            this.CerraduraK.UseVisualStyleBackColor = true;
            // 
            // CerraduraP
            // 
            this.CerraduraP.AutoSize = true;
            this.CerraduraP.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CerraduraP.Location = new System.Drawing.Point(509, 265);
            this.CerraduraP.Name = "CerraduraP";
            this.CerraduraP.Size = new System.Drawing.Size(164, 20);
            this.CerraduraP.TabIndex = 57;
            this.CerraduraP.TabStop = true;
            this.CerraduraP.Text = "Cerradura Positiva";
            this.CerraduraP.UseVisualStyleBackColor = true;
            this.CerraduraP.CheckedChanged += new System.EventHandler(this.CerraduraP_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 509);
            this.Controls.Add(this.CerraduraP);
            this.Controls.Add(this.CerraduraK);
            this.Controls.Add(this.boton);
            this.Controls.Add(this.respuesta);
            this.Controls.Add(this.r);
            this.Controls.Add(this.borrarB);
            this.Controls.Add(this.borrarA);
            this.Controls.Add(this.borrarAlfa);
            this.Controls.Add(this.label);
            this.Controls.Add(this.numeroPotencia);
            this.Controls.Add(this.agregarAlfa);
            this.Controls.Add(this.alfabeto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.entradaAlfa);
            this.Controls.Add(this.agregarB);
            this.Controls.Add(this.agregarA);
            this.Controls.Add(this.lenguajeB);
            this.Controls.Add(this.lenguajeA);
            this.Controls.Add(this.potencia);
            this.Controls.Add(this.producto);
            this.Controls.Add(this.complemento);
            this.Controls.Add(this.simetrica);
            this.Controls.Add(this.diferencia);
            this.Controls.Add(this.interseccion);
            this.Controls.Add(this.union);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.entradaB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.entradaA);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button borrarB;
        private System.Windows.Forms.Button borrarA;
        private System.Windows.Forms.Button borrarAlfa;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox numeroPotencia;
        private System.Windows.Forms.Button agregarAlfa;
        private System.Windows.Forms.TextBox alfabeto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox entradaAlfa;
        private System.Windows.Forms.Button agregarB;
        private System.Windows.Forms.Button agregarA;
        private System.Windows.Forms.TextBox lenguajeB;
        private System.Windows.Forms.TextBox lenguajeA;
        private System.Windows.Forms.RadioButton potencia;
        private System.Windows.Forms.RadioButton producto;
        private System.Windows.Forms.RadioButton complemento;
        private System.Windows.Forms.RadioButton simetrica;
        private System.Windows.Forms.RadioButton diferencia;
        private System.Windows.Forms.RadioButton interseccion;
        private System.Windows.Forms.RadioButton union;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox entradaB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox entradaA;
        private System.Windows.Forms.Button boton;
        private System.Windows.Forms.TextBox respuesta;
        private System.Windows.Forms.Label r;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.RadioButton CerraduraP;
        private System.Windows.Forms.RadioButton CerraduraK;
    }
}

