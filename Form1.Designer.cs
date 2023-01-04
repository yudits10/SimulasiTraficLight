
namespace SimulasiTraficLight
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.star = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.mobil = new System.Windows.Forms.PictureBox();
            this.LampuHijau = new System.Windows.Forms.PictureBox();
            this.LampuKuning = new System.Windows.Forms.PictureBox();
            this.LampuMerah = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.mobil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LampuHijau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LampuKuning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LampuMerah)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // star
            // 
            this.star.Location = new System.Drawing.Point(528, 45);
            this.star.Name = "star";
            this.star.Size = new System.Drawing.Size(157, 55);
            this.star.TabIndex = 3;
            this.star.Text = "STAR";
            this.star.UseVisualStyleBackColor = true;
            this.star.Click += new System.EventHandler(this.star_Click);
            // 
            // stop
            // 
            this.stop.Location = new System.Drawing.Point(528, 148);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(157, 55);
            this.stop.TabIndex = 4;
            this.stop.Text = "STOP";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // mobil
            // 
            this.mobil.Image = global::SimulasiTraficLight.Properties.Resources.mobil;
            this.mobil.Location = new System.Drawing.Point(12, 457);
            this.mobil.Name = "mobil";
            this.mobil.Size = new System.Drawing.Size(267, 113);
            this.mobil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.mobil.TabIndex = 5;
            this.mobil.TabStop = false;
            // 
            // LampuHijau
            // 
            this.LampuHijau.Image = global::SimulasiTraficLight.Properties.Resources.hijau1;
            this.LampuHijau.Location = new System.Drawing.Point(54, 27);
            this.LampuHijau.Name = "LampuHijau";
            this.LampuHijau.Size = new System.Drawing.Size(339, 384);
            this.LampuHijau.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.LampuHijau.TabIndex = 2;
            this.LampuHijau.TabStop = false;
            // 
            // LampuKuning
            // 
            this.LampuKuning.Image = global::SimulasiTraficLight.Properties.Resources.kuning;
            this.LampuKuning.Location = new System.Drawing.Point(53, 26);
            this.LampuKuning.Name = "LampuKuning";
            this.LampuKuning.Size = new System.Drawing.Size(340, 385);
            this.LampuKuning.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.LampuKuning.TabIndex = 1;
            this.LampuKuning.TabStop = false;
            // 
            // LampuMerah
            // 
            this.LampuMerah.Image = global::SimulasiTraficLight.Properties.Resources.merah;
            this.LampuMerah.Location = new System.Drawing.Point(53, 26);
            this.LampuMerah.Name = "LampuMerah";
            this.LampuMerah.Size = new System.Drawing.Size(340, 385);
            this.LampuMerah.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.LampuMerah.TabIndex = 0;
            this.LampuMerah.TabStop = false;
            // 
            // timer2
            // 
            this.timer2.Interval = 500;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 643);
            this.Controls.Add(this.mobil);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.star);
            this.Controls.Add(this.LampuHijau);
            this.Controls.Add(this.LampuKuning);
            this.Controls.Add(this.LampuMerah);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.mobil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LampuHijau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LampuKuning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LampuMerah)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox LampuMerah;
        private System.Windows.Forms.PictureBox LampuKuning;
        private System.Windows.Forms.PictureBox LampuHijau;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button star;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.PictureBox mobil;
        private System.Windows.Forms.Timer timer2;
    }
}

