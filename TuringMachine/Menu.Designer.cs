namespace TuringMachine
{
    partial class Menu
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
            this.btnPalindromos = new System.Windows.Forms.Button();
            this.btnCopia = new System.Windows.Forms.Button();
            this.btnMultiplicacion = new System.Windows.Forms.Button();
            this.btnSuma = new System.Windows.Forms.Button();
            this.btnResta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPalindromos
            // 
            this.btnPalindromos.Location = new System.Drawing.Point(312, 35);
            this.btnPalindromos.Name = "btnPalindromos";
            this.btnPalindromos.Size = new System.Drawing.Size(192, 73);
            this.btnPalindromos.TabIndex = 2;
            this.btnPalindromos.Text = "Palíndromos";
            this.btnPalindromos.UseVisualStyleBackColor = true;
            this.btnPalindromos.Click += new System.EventHandler(this.btnPalindromos_Click);
            // 
            // btnCopia
            // 
            this.btnCopia.Location = new System.Drawing.Point(312, 130);
            this.btnCopia.Name = "btnCopia";
            this.btnCopia.Size = new System.Drawing.Size(192, 73);
            this.btnCopia.TabIndex = 3;
            this.btnCopia.Text = "Copia";
            this.btnCopia.UseVisualStyleBackColor = true;
            this.btnCopia.Click += new System.EventHandler(this.btnCopia_Click);
            // 
            // btnMultiplicacion
            // 
            this.btnMultiplicacion.Location = new System.Drawing.Point(312, 226);
            this.btnMultiplicacion.Name = "btnMultiplicacion";
            this.btnMultiplicacion.Size = new System.Drawing.Size(192, 73);
            this.btnMultiplicacion.TabIndex = 4;
            this.btnMultiplicacion.Text = "Multiplicación Unaria";
            this.btnMultiplicacion.UseVisualStyleBackColor = true;
            this.btnMultiplicacion.Click += new System.EventHandler(this.btnMultiplicacion_Click);
            // 
            // btnSuma
            // 
            this.btnSuma.Location = new System.Drawing.Point(312, 320);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(192, 73);
            this.btnSuma.TabIndex = 5;
            this.btnSuma.Text = "Suma";
            this.btnSuma.UseVisualStyleBackColor = true;
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
            // 
            // btnResta
            // 
            this.btnResta.Location = new System.Drawing.Point(312, 419);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(192, 73);
            this.btnResta.TabIndex = 6;
            this.btnResta.Text = "Resta";
            this.btnResta.UseVisualStyleBackColor = true;
            this.btnResta.Click += new System.EventHandler(this.btnResta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(325, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Pick a Turing Machine:";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(800, 518);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnResta);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.btnMultiplicacion);
            this.Controls.Add(this.btnCopia);
            this.Controls.Add(this.btnPalindromos);
            this.Name = "Menu";
            this.Text = "Turing Machine Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPalindromos;
        private System.Windows.Forms.Button btnCopia;
        private System.Windows.Forms.Button btnMultiplicacion;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.Button btnResta;
        private System.Windows.Forms.Label label1;
    }
}

