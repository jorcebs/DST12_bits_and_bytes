namespace Bits_y_Bytes
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
            this.txtNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txtFechaAjustada = new System.Windows.Forms.TextBox();
            this.btnAjustar = new System.Windows.Forms.Button();
            this.pctS1 = new System.Windows.Forms.PictureBox();
            this.pctS2 = new System.Windows.Forms.PictureBox();
            this.pctDirección = new System.Windows.Forms.PictureBox();
            this.lblTanque = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctS1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctS2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctDirección)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(98, 12);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(158, 29);
            this.txtNum.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Entrada:";
            // 
            // btnProcesar
            // 
            this.btnProcesar.AutoSize = true;
            this.btnProcesar.Location = new System.Drawing.Point(262, 10);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(95, 34);
            this.btnProcesar.TabIndex = 2;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sensores:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tanque:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(408, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Dirección:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(12, 196);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(157, 24);
            this.lblFecha.TabIndex = 6;
            this.lblFecha.Text = "Fecha de lectura:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 24);
            this.label6.TabIndex = 7;
            this.label6.Text = "Fecha:";
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(87, 252);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(169, 29);
            this.txtFecha.TabIndex = 8;
            // 
            // txtFechaAjustada
            // 
            this.txtFechaAjustada.Location = new System.Drawing.Point(351, 252);
            this.txtFechaAjustada.Name = "txtFechaAjustada";
            this.txtFechaAjustada.Size = new System.Drawing.Size(169, 29);
            this.txtFechaAjustada.TabIndex = 9;
            // 
            // btnAjustar
            // 
            this.btnAjustar.AutoSize = true;
            this.btnAjustar.Location = new System.Drawing.Point(262, 250);
            this.btnAjustar.Name = "btnAjustar";
            this.btnAjustar.Size = new System.Drawing.Size(83, 34);
            this.btnAjustar.TabIndex = 10;
            this.btnAjustar.Text = "Ajustar";
            this.btnAjustar.UseVisualStyleBackColor = true;
            this.btnAjustar.Click += new System.EventHandler(this.btnAjustar_Click);
            // 
            // pctS1
            // 
            this.pctS1.BackColor = System.Drawing.Color.Transparent;
            this.pctS1.Location = new System.Drawing.Point(28, 104);
            this.pctS1.Name = "pctS1";
            this.pctS1.Size = new System.Drawing.Size(64, 36);
            this.pctS1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctS1.TabIndex = 15;
            this.pctS1.TabStop = false;
            // 
            // pctS2
            // 
            this.pctS2.BackColor = System.Drawing.Color.Transparent;
            this.pctS2.Location = new System.Drawing.Point(105, 104);
            this.pctS2.Name = "pctS2";
            this.pctS2.Size = new System.Drawing.Size(64, 36);
            this.pctS2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctS2.TabIndex = 16;
            this.pctS2.TabStop = false;
            // 
            // pctDirección
            // 
            this.pctDirección.BackColor = System.Drawing.Color.Transparent;
            this.pctDirección.Location = new System.Drawing.Point(411, 91);
            this.pctDirección.Name = "pctDirección";
            this.pctDirección.Size = new System.Drawing.Size(90, 90);
            this.pctDirección.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctDirección.TabIndex = 18;
            this.pctDirección.TabStop = false;
            // 
            // lblTanque
            // 
            this.lblTanque.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTanque.Location = new System.Drawing.Point(197, 104);
            this.lblTanque.Name = "lblTanque";
            this.lblTanque.Size = new System.Drawing.Size(117, 24);
            this.lblTanque.TabIndex = 19;
            this.lblTanque.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 301);
            this.Controls.Add(this.lblTanque);
            this.Controls.Add(this.pctDirección);
            this.Controls.Add(this.pctS2);
            this.Controls.Add(this.pctS1);
            this.Controls.Add(this.btnAjustar);
            this.Controls.Add(this.txtFechaAjustada);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNum);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Bits y Bytes";
            ((System.ComponentModel.ISupportInitialize)(this.pctS1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctS2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctDirección)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.TextBox txtFechaAjustada;
        private System.Windows.Forms.Button btnAjustar;
        private System.Windows.Forms.PictureBox pctS1;
        private System.Windows.Forms.PictureBox pctS2;
        private System.Windows.Forms.PictureBox pctDirección;
        private System.Windows.Forms.Label lblTanque;
    }
}

