
namespace SWDev_Project_Hint
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbInputFile = new System.Windows.Forms.TextBox();
            this.btBrowse = new System.Windows.Forms.Button();
            this.btOK = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.tbContent = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btTrainsetFile = new System.Windows.Forms.Button();
            this.btLoadTrainset = new System.Windows.Forms.Button();
            this.btAnalyst = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TextColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlacenameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LongitudeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LatitudeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input File";
            // 
            // tbInputFile
            // 
            this.tbInputFile.Location = new System.Drawing.Point(84, 13);
            this.tbInputFile.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbInputFile.Name = "tbInputFile";
            this.tbInputFile.Size = new System.Drawing.Size(741, 22);
            this.tbInputFile.TabIndex = 1;
            this.tbInputFile.TextChanged += new System.EventHandler(this.tbInputFile_TextChanged);
            // 
            // btBrowse
            // 
            this.btBrowse.Location = new System.Drawing.Point(848, 5);
            this.btBrowse.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btBrowse.Name = "btBrowse";
            this.btBrowse.Size = new System.Drawing.Size(63, 38);
            this.btBrowse.TabIndex = 2;
            this.btBrowse.Text = "Browse";
            this.btBrowse.UseVisualStyleBackColor = true;
            this.btBrowse.Click += new System.EventHandler(this.btBrowse_Click);
            // 
            // btOK
            // 
            this.btOK.Location = new System.Drawing.Point(449, 172);
            this.btOK.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(58, 38);
            this.btOK.TabIndex = 3;
            this.btOK.Text = "Load";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(551, 543);
            this.btExit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(141, 38);
            this.btExit.TabIndex = 4;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // tbContent
            // 
            this.tbContent.Location = new System.Drawing.Point(15, 90);
            this.tbContent.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbContent.Multiline = true;
            this.tbContent.Name = "tbContent";
            this.tbContent.Size = new System.Drawing.Size(362, 370);
            this.tbContent.TabIndex = 5;
            this.tbContent.WordWrap = false;
            this.tbContent.TextChanged += new System.EventHandler(this.tbContent_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Data";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btTrainsetFile
            // 
            this.btTrainsetFile.Location = new System.Drawing.Point(1004, 32);
            this.btTrainsetFile.Margin = new System.Windows.Forms.Padding(2);
            this.btTrainsetFile.Name = "btTrainsetFile";
            this.btTrainsetFile.Size = new System.Drawing.Size(69, 42);
            this.btTrainsetFile.TabIndex = 13;
            this.btTrainsetFile.Text = "browse";
            this.btTrainsetFile.UseVisualStyleBackColor = true;
            // 
            // btLoadTrainset
            // 
            this.btLoadTrainset.Location = new System.Drawing.Point(1076, 32);
            this.btLoadTrainset.Margin = new System.Windows.Forms.Padding(2);
            this.btLoadTrainset.Name = "btLoadTrainset";
            this.btLoadTrainset.Size = new System.Drawing.Size(96, 42);
            this.btLoadTrainset.TabIndex = 14;
            this.btLoadTrainset.Text = "Load Trainset";
            this.btLoadTrainset.UseVisualStyleBackColor = true;
            // 
            // btAnalyst
            // 
            this.btAnalyst.Location = new System.Drawing.Point(436, 215);
            this.btAnalyst.Margin = new System.Windows.Forms.Padding(2);
            this.btAnalyst.Name = "btAnalyst";
            this.btAnalyst.Size = new System.Drawing.Size(86, 38);
            this.btAnalyst.TabIndex = 15;
            this.btAnalyst.Text = "Analyst";
            this.btAnalyst.UseVisualStyleBackColor = true;
            this.btAnalyst.Click += new System.EventHandler(this.btAnalyst_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TextColumn,
            this.PlacenameColumn,
            this.LongitudeColumn,
            this.LatitudeColumn});
            this.dataGridView1.Location = new System.Drawing.Point(551, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(399, 370);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // TextColumn
            // 
            this.TextColumn.HeaderText = "Text";
            this.TextColumn.MinimumWidth = 6;
            this.TextColumn.Name = "TextColumn";
            this.TextColumn.Width = 125;
            // 
            // PlacenameColumn
            // 
            this.PlacenameColumn.HeaderText = "Place Name";
            this.PlacenameColumn.MinimumWidth = 6;
            this.PlacenameColumn.Name = "PlacenameColumn";
            this.PlacenameColumn.Width = 125;
            // 
            // LongitudeColumn
            // 
            this.LongitudeColumn.HeaderText = "Longitude";
            this.LongitudeColumn.MinimumWidth = 6;
            this.LongitudeColumn.Name = "LongitudeColumn";
            this.LongitudeColumn.Width = 125;
            // 
            // LatitudeColumn
            // 
            this.LatitudeColumn.HeaderText = "Latitude";
            this.LatitudeColumn.MinimumWidth = 6;
            this.LatitudeColumn.Name = "LatitudeColumn";
            this.LatitudeColumn.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 545);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btAnalyst);
            this.Controls.Add(this.btLoadTrainset);
            this.Controls.Add(this.btTrainsetFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbContent);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.btBrowse);
            this.Controls.Add(this.tbInputFile);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbInputFile;
		private System.Windows.Forms.Button btBrowse;
		private System.Windows.Forms.Button btOK;
		private System.Windows.Forms.Button btExit;
		private System.Windows.Forms.TextBox tbContent;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btTrainsetFile;
		private System.Windows.Forms.Button btLoadTrainset;
		private System.Windows.Forms.Button btAnalyst;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TextColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlacenameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LongitudeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LatitudeColumn;
    }
}

