
namespace NASAForm
{
    partial class NasaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NasaForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.objectLabel = new System.Windows.Forms.Label();
            this.approachLabel = new System.Windows.Forms.Label();
            this.updatedLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.asteroidLabel = new System.Windows.Forms.Label();
            this.orbitLabel = new System.Windows.Forms.Label();
            this.hazardousLabel = new System.Windows.Forms.Label();
            this.speedLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.earthImage = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.earthImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(65)))), ((int)(((byte)(140)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.exitButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(895, 33);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "NASA Asteroid Information";
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(61)))), ((int)(((byte)(33)))));
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(854, 0);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(41, 33);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "X";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.Exit_Click);
            // 
            // objectLabel
            // 
            this.objectLabel.AutoSize = true;
            this.objectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.objectLabel.ForeColor = System.Drawing.Color.White;
            this.objectLabel.Location = new System.Drawing.Point(4, 36);
            this.objectLabel.Name = "objectLabel";
            this.objectLabel.Size = new System.Drawing.Size(217, 20);
            this.objectLabel.TabIndex = 2;
            this.objectLabel.Text = "Near Earth Object Count |";
            // 
            // approachLabel
            // 
            this.approachLabel.AutoSize = true;
            this.approachLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.approachLabel.ForeColor = System.Drawing.Color.White;
            this.approachLabel.Location = new System.Drawing.Point(218, 36);
            this.approachLabel.Name = "approachLabel";
            this.approachLabel.Size = new System.Drawing.Size(189, 20);
            this.approachLabel.TabIndex = 3;
            this.approachLabel.Text = "Close Approach Count";
            // 
            // updatedLabel
            // 
            this.updatedLabel.AutoSize = true;
            this.updatedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatedLabel.ForeColor = System.Drawing.Color.White;
            this.updatedLabel.Location = new System.Drawing.Point(418, 36);
            this.updatedLabel.Name = "updatedLabel";
            this.updatedLabel.Size = new System.Drawing.Size(118, 20);
            this.updatedLabel.TabIndex = 4;
            this.updatedLabel.Text = "Last Updated";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(405, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "|";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(0, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(895, 10);
            this.panel2.TabIndex = 6;
            // 
            // asteroidLabel
            // 
            this.asteroidLabel.AutoSize = true;
            this.asteroidLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asteroidLabel.ForeColor = System.Drawing.Color.White;
            this.asteroidLabel.Location = new System.Drawing.Point(4, 91);
            this.asteroidLabel.Name = "asteroidLabel";
            this.asteroidLabel.Size = new System.Drawing.Size(76, 20);
            this.asteroidLabel.TabIndex = 7;
            this.asteroidLabel.Text = "Asteroid";
            // 
            // orbitLabel
            // 
            this.orbitLabel.AutoSize = true;
            this.orbitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orbitLabel.ForeColor = System.Drawing.Color.White;
            this.orbitLabel.Location = new System.Drawing.Point(4, 137);
            this.orbitLabel.Name = "orbitLabel";
            this.orbitLabel.Size = new System.Drawing.Size(48, 20);
            this.orbitLabel.TabIndex = 8;
            this.orbitLabel.Text = "Orbit";
            // 
            // hazardousLabel
            // 
            this.hazardousLabel.AutoSize = true;
            this.hazardousLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hazardousLabel.ForeColor = System.Drawing.Color.White;
            this.hazardousLabel.Location = new System.Drawing.Point(4, 230);
            this.hazardousLabel.Name = "hazardousLabel";
            this.hazardousLabel.Size = new System.Drawing.Size(250, 20);
            this.hazardousLabel.TabIndex = 9;
            this.hazardousLabel.Text = "Potenially Hazardous Asteroid";
            // 
            // speedLabel
            // 
            this.speedLabel.AutoSize = true;
            this.speedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speedLabel.ForeColor = System.Drawing.Color.White;
            this.speedLabel.Location = new System.Drawing.Point(3, 183);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(49, 20);
            this.speedLabel.TabIndex = 10;
            this.speedLabel.Text = "Km/h";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(0, 274);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(895, 10);
            this.panel3.TabIndex = 7;
            // 
            // earthImage
            // 
            this.earthImage.Location = new System.Drawing.Point(244, 290);
            this.earthImage.Name = "earthImage";
            this.earthImage.Size = new System.Drawing.Size(419, 394);
            this.earthImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.earthImage.TabIndex = 11;
            this.earthImage.TabStop = false;
            // 
            // NasaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(895, 696);
            this.Controls.Add(this.earthImage);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.speedLabel);
            this.Controls.Add(this.hazardousLabel);
            this.Controls.Add(this.orbitLabel);
            this.Controls.Add(this.asteroidLabel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.updatedLabel);
            this.Controls.Add(this.approachLabel);
            this.Controls.Add(this.objectLabel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NasaForm";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.earthImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label objectLabel;
        private System.Windows.Forms.Label approachLabel;
        private System.Windows.Forms.Label updatedLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label asteroidLabel;
        private System.Windows.Forms.Label orbitLabel;
        private System.Windows.Forms.Label hazardousLabel;
        private System.Windows.Forms.Label speedLabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox earthImage;
    }
}

