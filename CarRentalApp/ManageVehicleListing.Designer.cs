namespace CarRentalApp
{
    partial class ManageVehicleListing
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
            this.gvVehicleListing = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btAddCar = new System.Windows.Forms.Button();
            this.btEditCar = new System.Windows.Forms.Button();
            this.btDeleteCar = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvVehicleListing)).BeginInit();
            this.SuspendLayout();
            // 
            // gvVehicleListing
            // 
            this.gvVehicleListing.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.gvVehicleListing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvVehicleListing.Location = new System.Drawing.Point(12, 182);
            this.gvVehicleListing.Name = "gvVehicleListing";
            this.gvVehicleListing.RowHeadersWidth = 62;
            this.gvVehicleListing.RowTemplate.Height = 28;
            this.gvVehicleListing.Size = new System.Drawing.Size(911, 238);
            this.gvVehicleListing.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(633, 91);
            this.label1.TabIndex = 1;
            this.label1.Text = "Manage Vehicle Listing";
            // 
            // btAddCar
            // 
            this.btAddCar.Location = new System.Drawing.Point(12, 439);
            this.btAddCar.Name = "btAddCar";
            this.btAddCar.Size = new System.Drawing.Size(189, 49);
            this.btAddCar.TabIndex = 2;
            this.btAddCar.Text = "Add New Car";
            this.btAddCar.UseVisualStyleBackColor = true;
            this.btAddCar.Click += new System.EventHandler(this.btAddCar_Click);
            // 
            // btEditCar
            // 
            this.btEditCar.Location = new System.Drawing.Point(373, 439);
            this.btEditCar.Name = "btEditCar";
            this.btEditCar.Size = new System.Drawing.Size(189, 49);
            this.btEditCar.TabIndex = 3;
            this.btEditCar.Text = "Edit Car";
            this.btEditCar.UseVisualStyleBackColor = true;
            this.btEditCar.Click += new System.EventHandler(this.btEditCar_Click);
            // 
            // btDeleteCar
            // 
            this.btDeleteCar.Location = new System.Drawing.Point(734, 439);
            this.btDeleteCar.Name = "btDeleteCar";
            this.btDeleteCar.Size = new System.Drawing.Size(189, 49);
            this.btDeleteCar.TabIndex = 4;
            this.btDeleteCar.Text = "Delete Car";
            this.btDeleteCar.UseVisualStyleBackColor = true;
            this.btDeleteCar.Click += new System.EventHandler(this.btDeleteCar_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(12, 102);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(189, 49);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // ManageVehicleListing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(936, 505);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btDeleteCar);
            this.Controls.Add(this.btEditCar);
            this.Controls.Add(this.btAddCar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gvVehicleListing);
            this.Name = "ManageVehicleListing";
            this.Text = "ManageVehicleListing";
            this.Load += new System.EventHandler(this.ManageVehicleListing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvVehicleListing)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvVehicleListing;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btAddCar;
        private System.Windows.Forms.Button btEditCar;
        private System.Windows.Forms.Button btDeleteCar;
        private System.Windows.Forms.Button btnRefresh;
    }
}