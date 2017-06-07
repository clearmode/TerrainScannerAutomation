namespace Terrain_Scanner_Automation
{
    partial class AutomationDisplay
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
            this.btnSetProcessID = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbProcessID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSetProcessID
            // 
            this.btnSetProcessID.Location = new System.Drawing.Point(130, 38);
            this.btnSetProcessID.Name = "btnSetProcessID";
            this.btnSetProcessID.Size = new System.Drawing.Size(75, 23);
            this.btnSetProcessID.TabIndex = 0;
            this.btnSetProcessID.Text = "Set";
            this.btnSetProcessID.UseVisualStyleBackColor = true;
            this.btnSetProcessID.Click += new System.EventHandler(this.btnSetProcessID_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Minecraft Process ID: ";
            // 
            // tbProcessID
            // 
            this.tbProcessID.Location = new System.Drawing.Point(130, 12);
            this.tbProcessID.Name = "tbProcessID";
            this.tbProcessID.Size = new System.Drawing.Size(75, 20);
            this.tbProcessID.TabIndex = 1;
            // 
            // AutomationDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 71);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbProcessID);
            this.Controls.Add(this.btnSetProcessID);
            this.Name = "AutomationDisplay";
            this.Text = "Terrain Scanner Automator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSetProcessID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbProcessID;
    }
}

