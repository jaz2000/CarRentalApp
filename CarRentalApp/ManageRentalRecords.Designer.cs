namespace CarRentalApp
{
    partial class ManageRentalRecords
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
            this.gvRecordList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btAddRecord = new System.Windows.Forms.Button();
            this.btEditRecord = new System.Windows.Forms.Button();
            this.btDeleteRecord = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvRecordList)).BeginInit();
            this.SuspendLayout();
            // 
            // gvRecordList
            // 
            this.gvRecordList.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.gvRecordList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvRecordList.Location = new System.Drawing.Point(52, 187);
            this.gvRecordList.Name = "gvRecordList";
            this.gvRecordList.RowHeadersWidth = 62;
            this.gvRecordList.RowTemplate.Height = 28;
            this.gvRecordList.Size = new System.Drawing.Size(892, 273);
            this.gvRecordList.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(651, 91);
            this.label1.TabIndex = 7;
            this.label1.Text = "Manage Rental Records";
            // 
            // btAddRecord
            // 
            this.btAddRecord.Location = new System.Drawing.Point(52, 485);
            this.btAddRecord.Name = "btAddRecord";
            this.btAddRecord.Size = new System.Drawing.Size(189, 49);
            this.btAddRecord.TabIndex = 8;
            this.btAddRecord.Text = "Add New Record";
            this.btAddRecord.UseVisualStyleBackColor = true;
            this.btAddRecord.Click += new System.EventHandler(this.btAddRecord_Click);
            // 
            // btEditRecord
            // 
            this.btEditRecord.Location = new System.Drawing.Point(410, 485);
            this.btEditRecord.Name = "btEditRecord";
            this.btEditRecord.Size = new System.Drawing.Size(189, 49);
            this.btEditRecord.TabIndex = 9;
            this.btEditRecord.Text = "Edit Record";
            this.btEditRecord.UseVisualStyleBackColor = true;
            this.btEditRecord.Click += new System.EventHandler(this.btEditRecord_Click);
            // 
            // btDeleteRecord
            // 
            this.btDeleteRecord.Location = new System.Drawing.Point(755, 485);
            this.btDeleteRecord.Name = "btDeleteRecord";
            this.btDeleteRecord.Size = new System.Drawing.Size(189, 49);
            this.btDeleteRecord.TabIndex = 10;
            this.btDeleteRecord.Text = "Delete Record";
            this.btDeleteRecord.UseVisualStyleBackColor = true;
            this.btDeleteRecord.Click += new System.EventHandler(this.btDeleteRecord_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(52, 117);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(189, 49);
            this.btnRefresh.TabIndex = 11;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // ManageRentalRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 550);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btDeleteRecord);
            this.Controls.Add(this.btEditRecord);
            this.Controls.Add(this.btAddRecord);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gvRecordList);
            this.Name = "ManageRentalRecords";
            this.Text = "Manage Rental Records";
            this.Load += new System.EventHandler(this.ManageRentalRecords_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvRecordList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvRecordList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btAddRecord;
        private System.Windows.Forms.Button btEditRecord;
        private System.Windows.Forms.Button btDeleteRecord;
        private System.Windows.Forms.Button btnRefresh;
    }
}