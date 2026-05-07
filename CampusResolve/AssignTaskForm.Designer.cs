namespace CampusResolve
{
    partial class AssignTaskForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblComplaintID = new System.Windows.Forms.Label();
            this.txtComplaintID = new System.Windows.Forms.TextBox();
            this.lblAssignTo = new System.Windows.Forms.Label();
            this.cmbAssignTo = new System.Windows.Forms.ComboBox();
            this.lblDeadline = new System.Windows.Forms.Label();
            this.dtpDeadline = new System.Windows.Forms.DateTimePicker();
            this.btnAssign = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Location = new System.Drawing.Point(30, 20);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(100, 16);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Assign a Task";
            // 
            // lblComplaintID
            // 
            this.lblComplaintID.AutoSize = true;
            this.lblComplaintID.Location = new System.Drawing.Point(30, 70);
            this.lblComplaintID.Name = "lblComplaintID";
            this.lblComplaintID.Size = new System.Drawing.Size(85, 16);
            this.lblComplaintID.TabIndex = 1;
            this.lblComplaintID.Text = "Complaint ID";
            // 
            // txtComplaintID
            // 
            this.txtComplaintID.Location = new System.Drawing.Point(150, 70);
            this.txtComplaintID.Name = "txtComplaintID";
            this.txtComplaintID.Size = new System.Drawing.Size(300, 22);
            this.txtComplaintID.TabIndex = 2;
            // 
            // lblAssignTo
            // 
            this.lblAssignTo.AutoSize = true;
            this.lblAssignTo.Location = new System.Drawing.Point(30, 110);
            this.lblAssignTo.Name = "lblAssignTo";
            this.lblAssignTo.Size = new System.Drawing.Size(66, 16);
            this.lblAssignTo.TabIndex = 3;
            this.lblAssignTo.Text = "Assign To";
            // 
            // cmbAssignTo
            // 
            this.cmbAssignTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAssignTo.FormattingEnabled = true;
            this.cmbAssignTo.Items.AddRange(new object[] {
            "Electrician Team",
            "Plumbing Staff",
            "IT Support",
            "Housekeeping",
            "Carpenter"});
            this.cmbAssignTo.Location = new System.Drawing.Point(150, 110);
            this.cmbAssignTo.Name = "cmbAssignTo";
            this.cmbAssignTo.Size = new System.Drawing.Size(300, 24);
            this.cmbAssignTo.TabIndex = 4;
            // 
            // lblDeadline
            // 
            this.lblDeadline.AutoSize = true;
            this.lblDeadline.Location = new System.Drawing.Point(30, 150);
            this.lblDeadline.Name = "lblDeadline";
            this.lblDeadline.Size = new System.Drawing.Size(62, 16);
            this.lblDeadline.TabIndex = 5;
            this.lblDeadline.Text = "Deadline";
            // 
            // dtpDeadline
            // 
            this.dtpDeadline.Location = new System.Drawing.Point(150, 150);
            this.dtpDeadline.Name = "dtpDeadline";
            this.dtpDeadline.Size = new System.Drawing.Size(300, 22);
            this.dtpDeadline.TabIndex = 6;
            // 
            // btnAssign
            // 
            this.btnAssign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssign.Location = new System.Drawing.Point(150, 210);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(120, 40);
            this.btnAssign.TabIndex = 7;
            this.btnAssign.Text = "Assign";
            this.btnAssign.UseVisualStyleBackColor = true;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(280, 210);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 40);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AssignTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 280);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAssign);
            this.Controls.Add(this.dtpDeadline);
            this.Controls.Add(this.lblDeadline);
            this.Controls.Add(this.cmbAssignTo);
            this.Controls.Add(this.lblAssignTo);
            this.Controls.Add(this.txtComplaintID);
            this.Controls.Add(this.lblComplaintID);
            this.Controls.Add(this.lblHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AssignTaskForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Assign Task";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblComplaintID;
        private System.Windows.Forms.TextBox txtComplaintID;
        private System.Windows.Forms.Label lblAssignTo;
        private System.Windows.Forms.ComboBox cmbAssignTo;
        private System.Windows.Forms.Label lblDeadline;
        private System.Windows.Forms.DateTimePicker dtpDeadline;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.Button btnCancel;
    }
}
