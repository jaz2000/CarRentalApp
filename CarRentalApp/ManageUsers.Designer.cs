namespace CarRentalApp
{
    partial class ManageUsers
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
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btDeactivateUser = new System.Windows.Forms.Button();
            this.btResetPassword = new System.Windows.Forms.Button();
            this.btAddUser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gvUserList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gvUserList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(19, 124);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(189, 49);
            this.btnRefresh.TabIndex = 17;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btDeactivateUser
            // 
            this.btDeactivateUser.Location = new System.Drawing.Point(718, 492);
            this.btDeactivateUser.Name = "btDeactivateUser";
            this.btDeactivateUser.Size = new System.Drawing.Size(189, 49);
            this.btDeactivateUser.TabIndex = 16;
            this.btDeactivateUser.Text = "Deactivate/Activate User";
            this.btDeactivateUser.UseVisualStyleBackColor = true;
            this.btDeactivateUser.Click += new System.EventHandler(this.btDeactivateUser_Click);
            // 
            // btResetPassword
            // 
            this.btResetPassword.Location = new System.Drawing.Point(377, 492);
            this.btResetPassword.Name = "btResetPassword";
            this.btResetPassword.Size = new System.Drawing.Size(189, 49);
            this.btResetPassword.TabIndex = 15;
            this.btResetPassword.Text = "Reset Password";
            this.btResetPassword.UseVisualStyleBackColor = true;
            this.btResetPassword.Click += new System.EventHandler(this.btResetPassword_Click);
            // 
            // btAddUser
            // 
            this.btAddUser.Location = new System.Drawing.Point(19, 492);
            this.btAddUser.Name = "btAddUser";
            this.btAddUser.Size = new System.Drawing.Size(189, 49);
            this.btAddUser.TabIndex = 14;
            this.btAddUser.Text = "Add New User";
            this.btAddUser.UseVisualStyleBackColor = true;
            this.btAddUser.Click += new System.EventHandler(this.btAddUser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(250, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 91);
            this.label1.TabIndex = 13;
            this.label1.Text = "Manage Users";
            // 
            // gvUserList
            // 
            this.gvUserList.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.gvUserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvUserList.Location = new System.Drawing.Point(15, 194);
            this.gvUserList.Name = "gvUserList";
            this.gvUserList.RowHeadersWidth = 62;
            this.gvUserList.RowTemplate.Height = 28;
            this.gvUserList.Size = new System.Drawing.Size(892, 273);
            this.gvUserList.TabIndex = 12;
            // 
            // ManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 569);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btDeactivateUser);
            this.Controls.Add(this.btResetPassword);
            this.Controls.Add(this.btAddUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gvUserList);
            this.Name = "ManageUsers";
            this.Text = "Manage Users";
            this.Load += new System.EventHandler(this.ManageUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvUserList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btDeactivateUser;
        private System.Windows.Forms.Button btResetPassword;
        private System.Windows.Forms.Button btAddUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gvUserList;
    }
}