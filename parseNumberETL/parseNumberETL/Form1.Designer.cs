namespace parseNumberETL
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
            this.bt_opencsv = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_mean = new System.Windows.Forms.Button();
            this.bt_sd = new System.Windows.Forms.Button();
            this.bt_distribution = new System.Windows.Forms.Button();
            this.ofd_opencsv = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // bt_opencsv
            // 
            this.bt_opencsv.Location = new System.Drawing.Point(157, 31);
            this.bt_opencsv.Name = "bt_opencsv";
            this.bt_opencsv.Size = new System.Drawing.Size(115, 23);
            this.bt_opencsv.TabIndex = 0;
            this.bt_opencsv.Text = "OpenCSVFile";
            this.bt_opencsv.UseVisualStyleBackColor = true;
            this.bt_opencsv.Click += new System.EventHandler(this.bt_opencsv_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Open File";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select Functions";
            // 
            // bt_mean
            // 
            this.bt_mean.Enabled = false;
            this.bt_mean.Location = new System.Drawing.Point(157, 91);
            this.bt_mean.Name = "bt_mean";
            this.bt_mean.Size = new System.Drawing.Size(115, 23);
            this.bt_mean.TabIndex = 3;
            this.bt_mean.Text = "Get Mean";
            this.bt_mean.UseVisualStyleBackColor = true;
            this.bt_mean.Click += new System.EventHandler(this.bt_mean_Click);
            // 
            // bt_sd
            // 
            this.bt_sd.Enabled = false;
            this.bt_sd.Location = new System.Drawing.Point(157, 145);
            this.bt_sd.Name = "bt_sd";
            this.bt_sd.Size = new System.Drawing.Size(115, 23);
            this.bt_sd.TabIndex = 4;
            this.bt_sd.Text = "Get SD";
            this.bt_sd.UseVisualStyleBackColor = true;
            this.bt_sd.Click += new System.EventHandler(this.bt_sd_Click);
            // 
            // bt_distribution
            // 
            this.bt_distribution.Enabled = false;
            this.bt_distribution.Location = new System.Drawing.Point(157, 200);
            this.bt_distribution.Name = "bt_distribution";
            this.bt_distribution.Size = new System.Drawing.Size(115, 23);
            this.bt_distribution.TabIndex = 5;
            this.bt_distribution.Text = "Get Distribution";
            this.bt_distribution.UseVisualStyleBackColor = true;
            this.bt_distribution.Click += new System.EventHandler(this.bt_distribution_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.bt_distribution);
            this.Controls.Add(this.bt_sd);
            this.Controls.Add(this.bt_mean);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_opencsv);
            this.Name = "Form1";
            this.Text = "Solution Program";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_opencsv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_mean;
        private System.Windows.Forms.Button bt_sd;
        private System.Windows.Forms.Button bt_distribution;
        private System.Windows.Forms.OpenFileDialog ofd_opencsv;
    }
}

