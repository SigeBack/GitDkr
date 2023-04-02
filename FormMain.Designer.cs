namespace WindowsForms_Yalovoy_AttendanceJournal
{
    partial class FormMain
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
            this.dataGridJournals = new System.Windows.Forms.DataGridView();
            this.btnEditJournal = new System.Windows.Forms.Button();
            this.btnDeleteJournal = new System.Windows.Forms.Button();
            this.btnAddJournal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridJournals)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridJournals
            // 
            this.dataGridJournals.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridJournals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridJournals.Location = new System.Drawing.Point(28, 23);
            this.dataGridJournals.Name = "dataGridJournals";
            this.dataGridJournals.RowHeadersWidth = 62;
            this.dataGridJournals.RowTemplate.Height = 28;
            this.dataGridJournals.Size = new System.Drawing.Size(1400, 400);
            this.dataGridJournals.TabIndex = 0;
            // 
            // btnEditJournal
            // 
            this.btnEditJournal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditJournal.Location = new System.Drawing.Point(897, 453);
            this.btnEditJournal.Name = "btnEditJournal";
            this.btnEditJournal.Size = new System.Drawing.Size(133, 53);
            this.btnEditJournal.TabIndex = 2;
            this.btnEditJournal.Text = "Изменить";
            this.btnEditJournal.UseVisualStyleBackColor = true;
            this.btnEditJournal.Click += new System.EventHandler(this.btnEditJournal_Click);
            // 
            // btnDeleteJournal
            // 
            this.btnDeleteJournal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteJournal.Location = new System.Drawing.Point(1073, 453);
            this.btnDeleteJournal.Name = "btnDeleteJournal";
            this.btnDeleteJournal.Size = new System.Drawing.Size(133, 53);
            this.btnDeleteJournal.TabIndex = 3;
            this.btnDeleteJournal.Text = "Удалить";
            this.btnDeleteJournal.UseVisualStyleBackColor = true;
            this.btnDeleteJournal.Click += new System.EventHandler(this.btnDeleteJournal_Click);
            // 
            // btnAddJournal
            // 
            this.btnAddJournal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddJournal.Location = new System.Drawing.Point(712, 453);
            this.btnAddJournal.Name = "btnAddJournal";
            this.btnAddJournal.Size = new System.Drawing.Size(133, 53);
            this.btnAddJournal.TabIndex = 5;
            this.btnAddJournal.Text = "Добавить";
            this.btnAddJournal.UseVisualStyleBackColor = true;
            this.btnAddJournal.Click += new System.EventHandler(this.btnAddJournal_Click_1);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 544);
            this.Controls.Add(this.btnAddJournal);
            this.Controls.Add(this.btnDeleteJournal);
            this.Controls.Add(this.btnEditJournal);
            this.Controls.Add(this.dataGridJournals);
            this.MinimumSize = new System.Drawing.Size(700, 300);
            this.Name = "FormMain";
            this.Text = "Журнал посещаемости";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridJournals)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridJournals;
        private System.Windows.Forms.Button btnEditJournal;
        private System.Windows.Forms.Button btnDeleteJournal;
        private System.Windows.Forms.Button btnAddJournal;
    }
}