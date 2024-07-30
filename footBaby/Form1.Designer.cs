namespace footBaby
{
    partial class BabyFoot
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
            this.terrain = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.campA = new System.Windows.Forms.Panel();
            this.campB = new System.Windows.Forms.Panel();
            this.terrain.SuspendLayout();
            this.SuspendLayout();
            // 
            // terrain
            // 
            this.terrain.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.terrain.Controls.Add(this.campA);
            this.terrain.Location = new System.Drawing.Point(217, 12);
            this.terrain.Name = "terrain";
            this.terrain.Size = new System.Drawing.Size(316, 426);
            this.terrain.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(646, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            // 
            // campA
            // 
            this.campA.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.campA.Location = new System.Drawing.Point(100, 410);
            this.campA.Name = "campA";
            this.campA.Size = new System.Drawing.Size(99, 16);
            this.campA.TabIndex = 0;
            // 
            // campB
            // 
            this.campB.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.campB.Location = new System.Drawing.Point(317, 12);
            this.campB.Name = "campB";
            this.campB.Size = new System.Drawing.Size(99, 16);
            this.campB.TabIndex = 1;
            // 
            // BabyFoot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.campB);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.terrain);
            this.Name = "BabyFoot";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BabyFoot_KeyDown);
            this.terrain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel terrain;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel campA;
        private System.Windows.Forms.Panel campB;
    }
}

