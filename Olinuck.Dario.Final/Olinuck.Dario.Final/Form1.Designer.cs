namespace Olinuck.Dario.Final
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
            this.btn01 = new System.Windows.Forms.Button();
            this.btn02 = new System.Windows.Forms.Button();
            this.btn03 = new System.Windows.Forms.Button();
            this.btn04 = new System.Windows.Forms.Button();
            this.btn05 = new System.Windows.Forms.Button();
            this.btn06 = new System.Windows.Forms.Button();
            this.btn07 = new System.Windows.Forms.Button();
            this.btn08 = new System.Windows.Forms.Button();
            this.btn09 = new System.Windows.Forms.Button();
            this.btn10 = new System.Windows.Forms.Button();
            this.btn11 = new System.Windows.Forms.Button();
            this.btn12 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn01
            // 
            this.btn01.Location = new System.Drawing.Point(21, 25);
            this.btn01.Name = "btn01";
            this.btn01.Size = new System.Drawing.Size(102, 23);
            this.btn01.TabIndex = 0;
            this.btn01.Text = "Creo Mascota";
            this.btn01.UseVisualStyleBackColor = true;
            this.btn01.Click += new System.EventHandler(this.CreoMascota);
            // 
            // btn02
            // 
            this.btn02.Location = new System.Drawing.Point(150, 25);
            this.btn02.Name = "btn02";
            this.btn02.Size = new System.Drawing.Size(104, 23);
            this.btn02.TabIndex = 1;
            this.btn02.Text = "Creo Perro";
            this.btn02.UseVisualStyleBackColor = true;
            this.btn02.Click += new System.EventHandler(this.CreoPerro);
            // 
            // btn03
            // 
            this.btn03.Location = new System.Drawing.Point(283, 25);
            this.btn03.Name = "btn03";
            this.btn03.Size = new System.Drawing.Size(102, 23);
            this.btn03.TabIndex = 2;
            this.btn03.Text = "Guardar Archivo";
            this.btn03.UseVisualStyleBackColor = true;
            this.btn03.Click += new System.EventHandler(this.GuardarBinario);
            // 
            // btn04
            // 
            this.btn04.Location = new System.Drawing.Point(21, 74);
            this.btn04.Name = "btn04";
            this.btn04.Size = new System.Drawing.Size(102, 23);
            this.btn04.TabIndex = 3;
            this.btn04.Text = "Traer Archivo";
            this.btn04.UseVisualStyleBackColor = true;
            this.btn04.Click += new System.EventHandler(this.TraerArchivoBinario);
            // 
            // btn05
            // 
            this.btn05.Location = new System.Drawing.Point(156, 74);
            this.btn05.Name = "btn05";
            this.btn05.Size = new System.Drawing.Size(98, 23);
            this.btn05.TabIndex = 4;
            this.btn05.Text = "Emitir Sonido";
            this.btn05.UseVisualStyleBackColor = true;
            // 
            // btn06
            // 
            this.btn06.Location = new System.Drawing.Point(283, 74);
            this.btn06.Name = "btn06";
            this.btn06.Size = new System.Drawing.Size(104, 23);
            this.btn06.TabIndex = 5;
            this.btn06.Text = "Mostrar";
            this.btn06.UseVisualStyleBackColor = true;
            this.btn06.Click += new System.EventHandler(this.FuncionMostar);
            // 
            // btn07
            // 
            this.btn07.Location = new System.Drawing.Point(21, 125);
            this.btn07.Name = "btn07";
            this.btn07.Size = new System.Drawing.Size(102, 23);
            this.btn07.TabIndex = 6;
            this.btn07.Text = "Quitar A ";
            this.btn07.UseVisualStyleBackColor = true;
            // 
            // btn08
            // 
            this.btn08.Location = new System.Drawing.Point(156, 125);
            this.btn08.Name = "btn08";
            this.btn08.Size = new System.Drawing.Size(98, 23);
            this.btn08.TabIndex = 7;
            this.btn08.Text = "Guardar SQL";
            this.btn08.UseVisualStyleBackColor = true;
            this.btn08.Click += new System.EventHandler(this.FuncionGuardarSQL);
            // 
            // btn09
            // 
            this.btn09.Location = new System.Drawing.Point(283, 125);
            this.btn09.Name = "btn09";
            this.btn09.Size = new System.Drawing.Size(104, 23);
            this.btn09.TabIndex = 8;
            this.btn09.Text = "Traer Base";
            this.btn09.UseVisualStyleBackColor = true;
            this.btn09.Click += new System.EventHandler(this.FuncionLeerSQL);
            // 
            // btn10
            // 
            this.btn10.Location = new System.Drawing.Point(21, 167);
            this.btn10.Name = "btn10";
            this.btn10.Size = new System.Drawing.Size(108, 23);
            this.btn10.TabIndex = 9;
            this.btn10.Text = "Fin de ladrido";
            this.btn10.UseVisualStyleBackColor = true;
            // 
            // btn11
            // 
            this.btn11.Location = new System.Drawing.Point(156, 167);
            this.btn11.Name = "btn11";
            this.btn11.Size = new System.Drawing.Size(104, 23);
            this.btn11.TabIndex = 10;
            this.btn11.Text = "Emitir Sonido";
            this.btn11.UseVisualStyleBackColor = true;
            // 
            // btn12
            // 
            this.btn12.Location = new System.Drawing.Point(281, 167);
            this.btn12.Name = "btn12";
            this.btn12.Size = new System.Drawing.Size(104, 23);
            this.btn12.TabIndex = 11;
            this.btn12.Text = "Cerrar";
            this.btn12.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 262);
            this.Controls.Add(this.btn12);
            this.Controls.Add(this.btn11);
            this.Controls.Add(this.btn10);
            this.Controls.Add(this.btn09);
            this.Controls.Add(this.btn08);
            this.Controls.Add(this.btn07);
            this.Controls.Add(this.btn06);
            this.Controls.Add(this.btn05);
            this.Controls.Add(this.btn04);
            this.Controls.Add(this.btn03);
            this.Controls.Add(this.btn02);
            this.Controls.Add(this.btn01);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn01;
        private System.Windows.Forms.Button btn02;
        private System.Windows.Forms.Button btn03;
        private System.Windows.Forms.Button btn04;
        private System.Windows.Forms.Button btn05;
        private System.Windows.Forms.Button btn06;
        private System.Windows.Forms.Button btn07;
        private System.Windows.Forms.Button btn08;
        private System.Windows.Forms.Button btn09;
        private System.Windows.Forms.Button btn10;
        private System.Windows.Forms.Button btn11;
        private System.Windows.Forms.Button btn12;
    }
}

