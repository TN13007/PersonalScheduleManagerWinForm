namespace Presentation
{
    partial class FastMeeting
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
            this.txtEndTime = new System.Windows.Forms.TextBox();
            this.txtStartTime = new System.Windows.Forms.TextBox();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNotificationTime = new System.Windows.Forms.Label();
            this.txtNotificationTime = new System.Windows.Forms.TextBox();
            this.dtpNotificationDate = new System.Windows.Forms.DateTimePicker();
            this.rdoNormal = new System.Windows.Forms.RadioButton();
            this.rdoImportant = new System.Windows.Forms.RadioButton();
            this.lblPriority = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtEndTime
            // 
            this.txtEndTime.Location = new System.Drawing.Point(57, 196);
            this.txtEndTime.Name = "txtEndTime";
            this.txtEndTime.Size = new System.Drawing.Size(85, 22);
            this.txtEndTime.TabIndex = 61;
            this.txtEndTime.Text = "00:00";
            // 
            // txtStartTime
            // 
            this.txtStartTime.Location = new System.Drawing.Point(57, 141);
            this.txtStartTime.Name = "txtStartTime";
            this.txtStartTime.Size = new System.Drawing.Size(85, 22);
            this.txtStartTime.TabIndex = 60;
            this.txtStartTime.Text = "00:00";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(157, 196);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(220, 22);
            this.dtpEndDate.TabIndex = 59;
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(55, 177);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(88, 16);
            this.lblEndDate.TabIndex = 58;
            this.lblEndDate.Text = "Ngày kết thúc";
            this.lblEndDate.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(55, 380);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(134, 40);
            this.btnAdd.TabIndex = 53;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(54, 116);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(88, 16);
            this.lblStartDate.TabIndex = 57;
            this.lblStartDate.Text = "Ngày bắt đầu";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(157, 141);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(220, 22);
            this.dtpStartDate.TabIndex = 56;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(55, 60);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(53, 16);
            this.lblTitle.TabIndex = 55;
            this.lblTitle.Text = "Tiêu đề";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(55, 79);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(197, 22);
            this.txtTitle.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 62;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblNotificationTime
            // 
            this.lblNotificationTime.AutoSize = true;
            this.lblNotificationTime.Location = new System.Drawing.Point(55, 236);
            this.lblNotificationTime.Name = "lblNotificationTime";
            this.lblNotificationTime.Size = new System.Drawing.Size(158, 16);
            this.lblNotificationTime.TabIndex = 63;
            this.lblNotificationTime.Text = "Thời gian thông báo trước";
            this.lblNotificationTime.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtNotificationTime
            // 
            this.txtNotificationTime.Location = new System.Drawing.Point(57, 255);
            this.txtNotificationTime.Name = "txtNotificationTime";
            this.txtNotificationTime.Size = new System.Drawing.Size(85, 22);
            this.txtNotificationTime.TabIndex = 65;
            this.txtNotificationTime.Text = "00:00";
            // 
            // dtpNotificationDate
            // 
            this.dtpNotificationDate.Location = new System.Drawing.Point(157, 255);
            this.dtpNotificationDate.Name = "dtpNotificationDate";
            this.dtpNotificationDate.Size = new System.Drawing.Size(220, 22);
            this.dtpNotificationDate.TabIndex = 64;
            // 
            // rdoNormal
            // 
            this.rdoNormal.AutoSize = true;
            this.rdoNormal.Location = new System.Drawing.Point(62, 344);
            this.rdoNormal.Name = "rdoNormal";
            this.rdoNormal.Size = new System.Drawing.Size(97, 20);
            this.rdoNormal.TabIndex = 69;
            this.rdoNormal.Text = "Bình thường";
            this.rdoNormal.UseVisualStyleBackColor = true;
            // 
            // rdoImportant
            // 
            this.rdoImportant.AutoSize = true;
            this.rdoImportant.Checked = true;
            this.rdoImportant.Location = new System.Drawing.Point(62, 318);
            this.rdoImportant.Name = "rdoImportant";
            this.rdoImportant.Size = new System.Drawing.Size(93, 20);
            this.rdoImportant.TabIndex = 68;
            this.rdoImportant.TabStop = true;
            this.rdoImportant.Text = "Quan trọng";
            this.rdoImportant.UseVisualStyleBackColor = true;
            // 
            // lblPriority
            // 
            this.lblPriority.AutoSize = true;
            this.lblPriority.Location = new System.Drawing.Point(59, 299);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(51, 16);
            this.lblPriority.TabIndex = 67;
            this.lblPriority.Text = "Mức độ";
            // 
            // FastMeeting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 484);
            this.Controls.Add(this.rdoNormal);
            this.Controls.Add(this.rdoImportant);
            this.Controls.Add(this.lblPriority);
            this.Controls.Add(this.txtNotificationTime);
            this.Controls.Add(this.dtpNotificationDate);
            this.Controls.Add(this.lblNotificationTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEndTime);
            this.Controls.Add(this.txtStartTime);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtTitle);
            this.Name = "FastMeeting";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Meeting_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEndTime;
        private System.Windows.Forms.TextBox txtStartTime;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNotificationTime;
        private System.Windows.Forms.TextBox txtNotificationTime;
        private System.Windows.Forms.DateTimePicker dtpNotificationDate;
        private System.Windows.Forms.RadioButton rdoNormal;
        private System.Windows.Forms.RadioButton rdoImportant;
        private System.Windows.Forms.Label lblPriority;
    }
}