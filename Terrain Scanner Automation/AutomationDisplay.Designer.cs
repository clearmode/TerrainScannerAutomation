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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutomationDisplay));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblChunkX = new System.Windows.Forms.Label();
            this.btnNorth = new System.Windows.Forms.Button();
            this.btnEast = new System.Windows.Forms.Button();
            this.btnSouth = new System.Windows.Forms.Button();
            this.btnWest = new System.Windows.Forms.Button();
            this.btnSetStartChunk = new System.Windows.Forms.Button();
            this.tbStartChunk = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvChunkQueue = new System.Windows.Forms.DataGridView();
            this.btnRemoveChunk = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblChunkZ = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChunkQueue)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start: Numpad 7";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Stop: Numpad 8";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Current Chunk";
            // 
            // lblChunkX
            // 
            this.lblChunkX.AutoSize = true;
            this.lblChunkX.Location = new System.Drawing.Point(114, 107);
            this.lblChunkX.Name = "lblChunkX";
            this.lblChunkX.Size = new System.Drawing.Size(13, 13);
            this.lblChunkX.TabIndex = 3;
            this.lblChunkX.Text = "0";
            // 
            // btnNorth
            // 
            this.btnNorth.Location = new System.Drawing.Point(117, 66);
            this.btnNorth.Name = "btnNorth";
            this.btnNorth.Size = new System.Drawing.Size(75, 23);
            this.btnNorth.TabIndex = 4;
            this.btnNorth.Text = "North";
            this.btnNorth.UseVisualStyleBackColor = true;
            this.btnNorth.Click += new System.EventHandler(this.btnNorth_Click);
            // 
            // btnEast
            // 
            this.btnEast.Location = new System.Drawing.Point(224, 107);
            this.btnEast.Name = "btnEast";
            this.btnEast.Size = new System.Drawing.Size(75, 23);
            this.btnEast.TabIndex = 5;
            this.btnEast.Text = "East";
            this.btnEast.UseVisualStyleBackColor = true;
            this.btnEast.Click += new System.EventHandler(this.btnEast_Click);
            // 
            // btnSouth
            // 
            this.btnSouth.Location = new System.Drawing.Point(117, 146);
            this.btnSouth.Name = "btnSouth";
            this.btnSouth.Size = new System.Drawing.Size(75, 23);
            this.btnSouth.TabIndex = 6;
            this.btnSouth.Text = "South";
            this.btnSouth.UseVisualStyleBackColor = true;
            this.btnSouth.Click += new System.EventHandler(this.btnSouth_Click);
            // 
            // btnWest
            // 
            this.btnWest.Location = new System.Drawing.Point(12, 107);
            this.btnWest.Name = "btnWest";
            this.btnWest.Size = new System.Drawing.Size(75, 23);
            this.btnWest.TabIndex = 7;
            this.btnWest.Text = "West";
            this.btnWest.UseVisualStyleBackColor = true;
            this.btnWest.Click += new System.EventHandler(this.btnWest_Click);
            // 
            // btnSetStartChunk
            // 
            this.btnSetStartChunk.Location = new System.Drawing.Point(209, 27);
            this.btnSetStartChunk.Name = "btnSetStartChunk";
            this.btnSetStartChunk.Size = new System.Drawing.Size(42, 20);
            this.btnSetStartChunk.TabIndex = 8;
            this.btnSetStartChunk.Text = "Set";
            this.btnSetStartChunk.UseVisualStyleBackColor = true;
            this.btnSetStartChunk.Click += new System.EventHandler(this.btnSetStartChunk_Click);
            // 
            // tbStartChunk
            // 
            this.tbStartChunk.Location = new System.Drawing.Point(127, 27);
            this.tbStartChunk.Name = "tbStartChunk";
            this.tbStartChunk.Size = new System.Drawing.Size(76, 20);
            this.tbStartChunk.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Starting Chunk (X, Z):";
            // 
            // dgvChunkQueue
            // 
            this.dgvChunkQueue.AllowUserToAddRows = false;
            this.dgvChunkQueue.AllowUserToDeleteRows = false;
            this.dgvChunkQueue.AllowUserToResizeColumns = false;
            this.dgvChunkQueue.AllowUserToResizeRows = false;
            this.dgvChunkQueue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChunkQueue.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvChunkQueue.Location = new System.Drawing.Point(96, 195);
            this.dgvChunkQueue.MultiSelect = false;
            this.dgvChunkQueue.Name = "dgvChunkQueue";
            this.dgvChunkQueue.ReadOnly = true;
            this.dgvChunkQueue.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvChunkQueue.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChunkQueue.Size = new System.Drawing.Size(120, 151);
            this.dgvChunkQueue.TabIndex = 11;
            // 
            // btnRemoveChunk
            // 
            this.btnRemoveChunk.Location = new System.Drawing.Point(85, 352);
            this.btnRemoveChunk.Name = "btnRemoveChunk";
            this.btnRemoveChunk.Size = new System.Drawing.Size(146, 24);
            this.btnRemoveChunk.TabIndex = 12;
            this.btnRemoveChunk.Text = "Remove Selected Chunk";
            this.btnRemoveChunk.UseVisualStyleBackColor = true;
            this.btnRemoveChunk.Click += new System.EventHandler(this.btnRemoveChunk_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(93, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "X:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(93, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Z:";
            // 
            // lblChunkZ
            // 
            this.lblChunkZ.AutoSize = true;
            this.lblChunkZ.Location = new System.Drawing.Point(114, 125);
            this.lblChunkZ.Name = "lblChunkZ";
            this.lblChunkZ.Size = new System.Drawing.Size(13, 13);
            this.lblChunkZ.TabIndex = 15;
            this.lblChunkZ.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(119, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Chunk Queue";
            // 
            // AutomationDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 386);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblChunkZ);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnRemoveChunk);
            this.Controls.Add(this.dgvChunkQueue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbStartChunk);
            this.Controls.Add(this.btnSetStartChunk);
            this.Controls.Add(this.btnWest);
            this.Controls.Add(this.btnSouth);
            this.Controls.Add(this.btnEast);
            this.Controls.Add(this.btnNorth);
            this.Controls.Add(this.lblChunkX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AutomationDisplay";
            this.Text = "Terrain Scanner Automator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChunkQueue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblChunkX;
        private System.Windows.Forms.Button btnNorth;
        private System.Windows.Forms.Button btnEast;
        private System.Windows.Forms.Button btnSouth;
        private System.Windows.Forms.Button btnWest;
        private System.Windows.Forms.Button btnSetStartChunk;
        private System.Windows.Forms.TextBox tbStartChunk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvChunkQueue;
        private System.Windows.Forms.Button btnRemoveChunk;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblChunkZ;
        private System.Windows.Forms.Label label7;
    }
}

