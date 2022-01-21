namespace Time
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtJam = new System.Windows.Forms.Label();
            this.txtMenit = new System.Windows.Forms.Label();
            this.txtDetik = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(318, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aplikasi Jam Digital";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Jam : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(209, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Menit : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(209, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Detik : ";
            // 
            // txtJam
            // 
            this.txtJam.AutoSize = true;
            this.txtJam.Location = new System.Drawing.Point(261, 118);
            this.txtJam.Name = "txtJam";
            this.txtJam.Size = new System.Drawing.Size(16, 17);
            this.txtJam.TabIndex = 4;
            this.txtJam.Text = "0";
            // 
            // txtMenit
            // 
            this.txtMenit.AutoSize = true;
            this.txtMenit.Location = new System.Drawing.Point(269, 153);
            this.txtMenit.Name = "txtMenit";
            this.txtMenit.Size = new System.Drawing.Size(16, 17);
            this.txtMenit.TabIndex = 5;
            this.txtMenit.Text = "0";
            // 
            // txtDetik
            // 
            this.txtDetik.AutoSize = true;
            this.txtDetik.Location = new System.Drawing.Point(267, 190);
            this.txtDetik.Name = "txtDetik";
            this.txtDetik.Size = new System.Drawing.Size(16, 17);
            this.txtDetik.TabIndex = 6;
            this.txtDetik.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtDetik);
            this.Controls.Add(this.txtMenit);
            this.Controls.Add(this.txtJam);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txtJam;
        private System.Windows.Forms.Label txtMenit;
        private System.Windows.Forms.Label txtDetik;
        private System.Windows.Forms.Timer timer1;
    }
}

