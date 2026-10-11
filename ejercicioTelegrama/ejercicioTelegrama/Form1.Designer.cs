namespace ejercicioTelegrama
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
            txtPrecio = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtTelegrama = new TextBox();
            btnCalcular = new Button();
            rbOrdinario = new RadioButton();
            rbUrgente = new RadioButton();
            SuspendLayout();
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(149, 381);
            txtPrecio.Margin = new Padding(4, 3, 4, 3);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(181, 23);
            txtPrecio.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(94, 384);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 2;
            label1.Text = "Coste:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(94, 82);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 3;
            label2.Text = "Texto";
            // 
            // txtTelegrama
            // 
            txtTelegrama.Location = new Point(98, 117);
            txtTelegrama.Margin = new Padding(4, 3, 4, 3);
            txtTelegrama.Multiline = true;
            txtTelegrama.Name = "txtTelegrama";
            txtTelegrama.Size = new Size(640, 144);
            txtTelegrama.TabIndex = 4;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(520, 347);
            btnCalcular.Margin = new Padding(4, 3, 4, 3);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(218, 57);
            btnCalcular.TabIndex = 5;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click_1;
            // 
            // rbOrdinario
            // 
            rbOrdinario.AutoSize = true;
            rbOrdinario.Location = new Point(302, 324);
            rbOrdinario.Name = "rbOrdinario";
            rbOrdinario.Size = new Size(75, 19);
            rbOrdinario.TabIndex = 6;
            rbOrdinario.TabStop = true;
            rbOrdinario.Text = "Ordinario";
            rbOrdinario.UseVisualStyleBackColor = true;
            // 
            // rbUrgente
            // 
            rbUrgente.AutoSize = true;
            rbUrgente.Location = new Point(417, 325);
            rbUrgente.Name = "rbUrgente";
            rbUrgente.Size = new Size(67, 19);
            rbUrgente.TabIndex = 7;
            rbUrgente.TabStop = true;
            rbUrgente.Text = "Urgente";
            rbUrgente.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(rbUrgente);
            Controls.Add(rbOrdinario);
            Controls.Add(btnCalcular);
            Controls.Add(txtTelegrama);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPrecio);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbUrgente;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTelegrama;
        private System.Windows.Forms.Button btnCalcular;
        private RadioButton rbOrdinario;
        private RadioButton rbUrgente;
    }
}

