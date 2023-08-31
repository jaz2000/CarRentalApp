using System;

namespace CarRentalApp
{
    
    partial class AddEditRentalRecord
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.typeofcar = new System.Windows.Forms.ComboBox();
            this.tbcustname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btsubmit = new System.Windows.Forms.Button();
            this.dtRent = new System.Windows.Forms.DateTimePicker();
            this.dtret = new System.Windows.Forms.DateTimePicker();
            this.tbcost = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblRecordId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe Print", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(43, 5);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(745, 127);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Add Rental Record";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Script MT Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer Name";
            // 
            // typeofcar
            // 
            this.typeofcar.FormattingEnabled = true;
            this.typeofcar.Location = new System.Drawing.Point(73, 386);
            this.typeofcar.Name = "typeofcar";
            this.typeofcar.Size = new System.Drawing.Size(202, 28);
            this.typeofcar.TabIndex = 6;
            // 
            // tbcustname
            // 
            this.tbcustname.Location = new System.Drawing.Point(73, 200);
            this.tbcustname.Name = "tbcustname";
            this.tbcustname.Size = new System.Drawing.Size(202, 26);
            this.tbcustname.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Script MT Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Rent Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Script MT Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(69, 343);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Type of Car";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Script MT Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(389, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "Date Returned";
            // 
            // btsubmit
            // 
            this.btsubmit.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btsubmit.Font = new System.Drawing.Font("Script MT Bold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsubmit.Location = new System.Drawing.Point(393, 355);
            this.btsubmit.Name = "btsubmit";
            this.btsubmit.Size = new System.Drawing.Size(202, 59);
            this.btsubmit.TabIndex = 13;
            this.btsubmit.Text = "Submit";
            this.btsubmit.UseVisualStyleBackColor = false;
            this.btsubmit.Click += new System.EventHandler(this.btsubmit_Click);
            // 
            // dtRent
            // 
            this.dtRent.Location = new System.Drawing.Point(73, 290);
            this.dtRent.Name = "dtRent";
            this.dtRent.Size = new System.Drawing.Size(200, 26);
            this.dtRent.TabIndex = 14;
            // 
            // dtret
            // 
            this.dtret.Location = new System.Drawing.Point(393, 290);
            this.dtret.Name = "dtret";
            this.dtret.Size = new System.Drawing.Size(200, 26);
            this.dtret.TabIndex = 15;
            // 
            // tbcost
            // 
            this.tbcost.Location = new System.Drawing.Point(393, 200);
            this.tbcost.Name = "tbcost";
            this.tbcost.Size = new System.Drawing.Size(202, 26);
            this.tbcost.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Script MT Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(389, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 24);
            this.label6.TabIndex = 16;
            this.label6.Text = "Cost";
            // 
            // lblRecordId
            // 
            this.lblRecordId.AutoSize = true;
            this.lblRecordId.Location = new System.Drawing.Point(124, 450);
            this.lblRecordId.Name = "lblRecordId";
            this.lblRecordId.Size = new System.Drawing.Size(0, 20);
            this.lblRecordId.TabIndex = 18;
            this.lblRecordId.Visible = false;
            // 
            // AddEditRentalRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(800, 529);
            this.Controls.Add(this.lblRecordId);
            this.Controls.Add(this.tbcost);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtret);
            this.Controls.Add(this.dtRent);
            this.Controls.Add(this.btsubmit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbcustname);
            this.Controls.Add(this.typeofcar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTitle);
            this.Name = "AddEditRentalRecord";
            this.Text = "Add Rental Record";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox typeofcar;
        private System.Windows.Forms.TextBox tbcustname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btsubmit;
        private System.Windows.Forms.DateTimePicker dtRent;
        private System.Windows.Forms.DateTimePicker dtret;
        private System.Windows.Forms.TextBox tbcost;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblRecordId;
    }
}

