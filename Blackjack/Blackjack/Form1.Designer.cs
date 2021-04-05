
namespace Blackjack
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lbl_Legendas = new System.Windows.Forms.Label();
            this.lbl_Pontos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(77, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 254);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(54, 362);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "Jogar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(202, 362);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 33);
            this.button2.TabIndex = 2;
            this.button2.Text = "Reiniciar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbl_Legendas
            // 
            this.lbl_Legendas.AutoSize = true;
            this.lbl_Legendas.Location = new System.Drawing.Point(28, 419);
            this.lbl_Legendas.Name = "lbl_Legendas";
            this.lbl_Legendas.Size = new System.Drawing.Size(47, 15);
            this.lbl_Legendas.TabIndex = 3;
            this.lbl_Legendas.Text = "Pontos:";
            this.lbl_Legendas.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_Pontos
            // 
            this.lbl_Pontos.AutoSize = true;
            this.lbl_Pontos.Location = new System.Drawing.Point(77, 419);
            this.lbl_Pontos.Name = "lbl_Pontos";
            this.lbl_Pontos.Size = new System.Drawing.Size(12, 15);
            this.lbl_Pontos.TabIndex = 4;
            this.lbl_Pontos.Text = "_";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 446);
            this.Controls.Add(this.lbl_Pontos);
            this.Controls.Add(this.lbl_Legendas);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "BlackJack (Versão 1.0)";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbl_Legendas;
        private System.Windows.Forms.Label lbl_Pontos;
    }
}

