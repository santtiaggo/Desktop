namespace PdD.Vistas
{
    partial class Form2
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
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnBrowse1 = new System.Windows.Forms.Button();
            this.txtUbicacion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSegundoDeInicio = new System.Windows.Forms.Label();
            this.lblCantidadDeSegundos = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnCargar3 = new System.Windows.Forms.Button();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.btnCargar2 = new System.Windows.Forms.Button();
            this.btnCargar1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(371, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 0);
            this.label1.MinimumSize = new System.Drawing.Size(133, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(743, 347);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(100, 28);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnBrowse1
            // 
            this.btnBrowse1.Location = new System.Drawing.Point(687, 72);
            this.btnBrowse1.Margin = new System.Windows.Forms.Padding(4);
            this.btnBrowse1.Name = "btnBrowse1";
            this.btnBrowse1.Size = new System.Drawing.Size(100, 28);
            this.btnBrowse1.TabIndex = 3;
            this.btnBrowse1.Text = "browse";
            this.btnBrowse1.UseVisualStyleBackColor = true;
            this.btnBrowse1.Click += new System.EventHandler(this.btnBrowse1_Click);
            // 
            // txtUbicacion
            // 
            this.txtUbicacion.Location = new System.Drawing.Point(119, 72);
            this.txtUbicacion.Margin = new System.Windows.Forms.Padding(4);
            this.txtUbicacion.Name = "txtUbicacion";
            this.txtUbicacion.Size = new System.Drawing.Size(525, 22);
            this.txtUbicacion.TabIndex = 9;
            this.txtUbicacion.TextChanged += new System.EventHandler(this.txtUbicacion_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(116, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Ubicación del Video";
            // 
            // lblSegundoDeInicio
            // 
            this.lblSegundoDeInicio.AutoSize = true;
            this.lblSegundoDeInicio.ForeColor = System.Drawing.Color.Red;
            this.lblSegundoDeInicio.Location = new System.Drawing.Point(137, 134);
            this.lblSegundoDeInicio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSegundoDeInicio.Name = "lblSegundoDeInicio";
            this.lblSegundoDeInicio.Size = new System.Drawing.Size(112, 17);
            this.lblSegundoDeInicio.TabIndex = 14;
            this.lblSegundoDeInicio.Text = "Cambiar formato";
            // 
            // lblCantidadDeSegundos
            // 
            this.lblCantidadDeSegundos.AutoSize = true;
            this.lblCantidadDeSegundos.ForeColor = System.Drawing.Color.Red;
            this.lblCantidadDeSegundos.Location = new System.Drawing.Point(455, 134);
            this.lblCantidadDeSegundos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidadDeSegundos.Name = "lblCantidadDeSegundos";
            this.lblCantidadDeSegundos.Size = new System.Drawing.Size(92, 17);
            this.lblCantidadDeSegundos.TabIndex = 16;
            this.lblCantidadDeSegundos.Text = "Extraer audio";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnCargar3
            // 
            this.btnCargar3.BackColor = System.Drawing.Color.Chartreuse;
            this.btnCargar3.Location = new System.Drawing.Point(636, 178);
            this.btnCargar3.Name = "btnCargar3";
            this.btnCargar3.Size = new System.Drawing.Size(107, 37);
            this.btnCargar3.TabIndex = 18;
            this.btnCargar3.Text = "Ejemplo1";
            this.btnCargar3.UseVisualStyleBackColor = false;
            this.btnCargar3.Click += new System.EventHandler(this.btnCargar3_Click);
            // 
            // btnCargar2
            // 
            this.btnCargar2.BackColor = System.Drawing.Color.Chartreuse;
            this.btnCargar2.Location = new System.Drawing.Point(449, 178);
            this.btnCargar2.Name = "btnCargar2";
            this.btnCargar2.Size = new System.Drawing.Size(107, 37);
            this.btnCargar2.TabIndex = 21;
            this.btnCargar2.Text = "Ejemplo1";
            this.btnCargar2.UseVisualStyleBackColor = false;
            this.btnCargar2.Click += new System.EventHandler(this.btnCargar2_Click);
            // 
            // btnCargar1
            // 
            this.btnCargar1.BackColor = System.Drawing.Color.Chartreuse;
            this.btnCargar1.Location = new System.Drawing.Point(12, 203);
            this.btnCargar1.Name = "btnCargar1";
            this.btnCargar1.Size = new System.Drawing.Size(107, 37);
            this.btnCargar1.TabIndex = 22;
            this.btnCargar1.Text = "AVI";
            this.btnCargar1.UseVisualStyleBackColor = false;
            this.btnCargar1.Click += new System.EventHandler(this.btnCargar1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(633, 134);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "Convertir en gif";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Chartreuse;
            this.button1.Location = new System.Drawing.Point(636, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 37);
            this.button1.TabIndex = 25;
            this.button1.Text = "Ejemplo3";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Chartreuse;
            this.button2.Location = new System.Drawing.Point(636, 236);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 37);
            this.button2.TabIndex = 26;
            this.button2.Text = "Ejemplo2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Chartreuse;
            this.button3.Location = new System.Drawing.Point(449, 303);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 37);
            this.button3.TabIndex = 27;
            this.button3.Text = "Ejemplo3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Chartreuse;
            this.button4.Location = new System.Drawing.Point(449, 236);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(107, 37);
            this.button4.TabIndex = 28;
            this.button4.Text = "Ejemplo2";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Chartreuse;
            this.button5.Location = new System.Drawing.Point(12, 316);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(107, 37);
            this.button5.TabIndex = 29;
            this.button5.Text = "FLV";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Chartreuse;
            this.button6.Location = new System.Drawing.Point(12, 264);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(107, 37);
            this.button6.TabIndex = 30;
            this.button6.Text = "MPEG";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Chartreuse;
            this.button7.Location = new System.Drawing.Point(142, 264);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(107, 37);
            this.button7.TabIndex = 33;
            this.button7.Text = "MPEG";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Chartreuse;
            this.button8.Location = new System.Drawing.Point(142, 316);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(107, 37);
            this.button8.TabIndex = 32;
            this.button8.Text = "FLV";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Chartreuse;
            this.button9.Location = new System.Drawing.Point(142, 203);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(107, 37);
            this.button9.TabIndex = 31;
            this.button9.Text = "AVI";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Chartreuse;
            this.button10.Location = new System.Drawing.Point(276, 264);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(107, 37);
            this.button10.TabIndex = 36;
            this.button10.Text = "MPEG";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.Chartreuse;
            this.button11.Location = new System.Drawing.Point(276, 316);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(107, 37);
            this.button11.TabIndex = 35;
            this.button11.Text = "FLV";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.Chartreuse;
            this.button12.Location = new System.Drawing.Point(276, 203);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(107, 37);
            this.button12.TabIndex = 34;
            this.button12.Text = "AVI";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(34, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 37;
            this.label4.Text = "Ejemplo 1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(296, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 17);
            this.label5.TabIndex = 38;
            this.label5.Text = "Ejemplo 3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(162, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 17);
            this.label6.TabIndex = 39;
            this.label6.Text = "Ejemplo 2";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(845, 378);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCargar1);
            this.Controls.Add(this.btnCargar2);
            this.Controls.Add(this.btnCargar3);
            this.Controls.Add(this.lblCantidadDeSegundos);
            this.Controls.Add(this.lblSegundoDeInicio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUbicacion);
            this.Controls.Add(this.btnBrowse1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Text = "Conversor de video";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnBrowse1;
        private System.Windows.Forms.TextBox txtUbicacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSegundoDeInicio;
        private System.Windows.Forms.Label lblCantidadDeSegundos;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnCargar3;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
        private System.Windows.Forms.Button btnCargar2;
        private System.Windows.Forms.Button btnCargar1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}