
namespace herencia
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
            this.sumar = new System.Windows.Forms.Button();
            this.restar = new System.Windows.Forms.Button();
            this.multiplicar = new System.Windows.Forms.Button();
            this.dividir = new System.Windows.Forms.Button();
            this.borrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.valor1 = new System.Windows.Forms.TextBox();
            this.valor2 = new System.Windows.Forms.TextBox();
            this.resultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // sumar
            // 
            this.sumar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sumar.Location = new System.Drawing.Point(417, 29);
            this.sumar.Name = "sumar";
            this.sumar.Size = new System.Drawing.Size(80, 34);
            this.sumar.TabIndex = 0;
            this.sumar.Text = "Sumar";
            this.sumar.UseVisualStyleBackColor = true;
            this.sumar.Click += new System.EventHandler(this.sumar_Click);
            // 
            // restar
            // 
            this.restar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restar.Location = new System.Drawing.Point(417, 69);
            this.restar.Name = "restar";
            this.restar.Size = new System.Drawing.Size(91, 34);
            this.restar.TabIndex = 1;
            this.restar.Text = "Restar";
            this.restar.UseMnemonic = false;
            this.restar.UseVisualStyleBackColor = true;
            this.restar.Click += new System.EventHandler(this.restar_Click);
            // 
            // multiplicar
            // 
            this.multiplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplicar.Location = new System.Drawing.Point(417, 109);
            this.multiplicar.Name = "multiplicar";
            this.multiplicar.Size = new System.Drawing.Size(122, 34);
            this.multiplicar.TabIndex = 2;
            this.multiplicar.Text = "Multiplicar";
            this.multiplicar.UseVisualStyleBackColor = true;
            this.multiplicar.Click += new System.EventHandler(this.multiplicar_Click);
            // 
            // dividir
            // 
            this.dividir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dividir.Location = new System.Drawing.Point(417, 149);
            this.dividir.Name = "dividir";
            this.dividir.Size = new System.Drawing.Size(87, 34);
            this.dividir.TabIndex = 3;
            this.dividir.Text = "Dividir";
            this.dividir.UseVisualStyleBackColor = true;
            // 
            // borrar
            // 
            this.borrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrar.Location = new System.Drawing.Point(417, 189);
            this.borrar.Name = "borrar";
            this.borrar.Size = new System.Drawing.Size(87, 34);
            this.borrar.TabIndex = 4;
            this.borrar.Text = "Borrar";
            this.borrar.UseVisualStyleBackColor = true;
            this.borrar.Click += new System.EventHandler(this.borrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Valor 1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Valor 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Resultado";
            // 
            // valor1
            // 
            this.valor1.Location = new System.Drawing.Point(154, 50);
            this.valor1.Name = "valor1";
            this.valor1.Size = new System.Drawing.Size(180, 20);
            this.valor1.TabIndex = 8;
            this.valor1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // valor2
            // 
            this.valor2.Location = new System.Drawing.Point(154, 137);
            this.valor2.Name = "valor2";
            this.valor2.Size = new System.Drawing.Size(180, 20);
            this.valor2.TabIndex = 9;
            // 
            // resultado
            // 
            this.resultado.Location = new System.Drawing.Point(154, 228);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(180, 20);
            this.resultado.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 302);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.valor2);
            this.Controls.Add(this.valor1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.borrar);
            this.Controls.Add(this.dividir);
            this.Controls.Add(this.multiplicar);
            this.Controls.Add(this.restar);
            this.Controls.Add(this.sumar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sumar;
        private System.Windows.Forms.Button restar;
        private System.Windows.Forms.Button multiplicar;
        private System.Windows.Forms.Button dividir;
        private System.Windows.Forms.Button borrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox valor1;
        private System.Windows.Forms.TextBox valor2;
        private System.Windows.Forms.TextBox resultado;
    }
}

