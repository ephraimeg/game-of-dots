namespace Clustering
{
    partial class ClusteringView
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
            this.btnSpawn = new System.Windows.Forms.Button();
            this.pnlMap = new System.Windows.Forms.Panel();
            this.tbxDots = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSpawn
            // 
            this.btnSpawn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpawn.ForeColor = System.Drawing.Color.Lime;
            this.btnSpawn.Location = new System.Drawing.Point(1, 473);
            this.btnSpawn.Name = "btnSpawn";
            this.btnSpawn.Size = new System.Drawing.Size(56, 23);
            this.btnSpawn.TabIndex = 2;
            this.btnSpawn.Text = "Spawn";
            this.btnSpawn.UseVisualStyleBackColor = true;
            this.btnSpawn.Click += new System.EventHandler(this.btnSpawn_Click);
            // 
            // pnlMap
            // 
            this.pnlMap.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlMap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMap.Location = new System.Drawing.Point(1, 2);
            this.pnlMap.Name = "pnlMap";
            this.pnlMap.Size = new System.Drawing.Size(522, 435);
            this.pnlMap.TabIndex = 0;
            // 
            // tbxDots
            // 
            this.tbxDots.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbxDots.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxDots.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDots.ForeColor = System.Drawing.Color.Lime;
            this.tbxDots.Location = new System.Drawing.Point(1, 443);
            this.tbxDots.MaxLength = 2;
            this.tbxDots.Name = "tbxDots";
            this.tbxDots.Size = new System.Drawing.Size(56, 26);
            this.tbxDots.TabIndex = 1;
            this.tbxDots.Text = "5";
            // 
            // ClusteringView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(524, 522);
            this.Controls.Add(this.tbxDots);
            this.Controls.Add(this.btnSpawn);
            this.Controls.Add(this.pnlMap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ClusteringView";
            this.ShowIcon = false;
            this.Text = "Clustering";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSpawn;
        private System.Windows.Forms.Panel pnlMap;
        private System.Windows.Forms.TextBox tbxDots;
    }
}

