namespace Presentation
{
    partial class Doing
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
            this.rdoNormal = new System.Windows.Forms.RadioButton();
            this.rdoImportant = new System.Windows.Forms.RadioButton();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblPriority = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.txtStartTime = new System.Windows.Forms.TextBox();
            this.txtEndTime = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rdoNormal
            // 
            this.rdoNormal.AutoSize = true;
            this.rdoNormal.Location = new System.Drawing.Point(53, 405);
            this.rdoNormal.Name = "rdoNormal";
            this.rdoNormal.Size = new System.Drawing.Size(97, 20);
            this.rdoNormal.TabIndex = 29;
            this.rdoNormal.Text = "Bình thường";
            this.rdoNormal.UseVisualStyleBackColor = true;
            this.rdoNormal.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rdoImportant
            // 
            this.rdoImportant.AutoSize = true;
            this.rdoImportant.Checked = true;
            this.rdoImportant.Location = new System.Drawing.Point(53, 379);
            this.rdoImportant.Name = "rdoImportant";
            this.rdoImportant.Size = new System.Drawing.Size(93, 20);
            this.rdoImportant.TabIndex = 28;
            this.rdoImportant.TabStop = true;
            this.rdoImportant.Text = "Quan trọng";
            this.rdoImportant.UseVisualStyleBackColor = true;
            this.rdoImportant.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(48, 154);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(88, 16);
            this.lblEndDate.TabIndex = 27;
            this.lblEndDate.Text = "Ngày kết thúc";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(51, 444);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(139, 40);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(48, 104);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(88, 16);
            this.lblStartDate.TabIndex = 25;
            this.lblStartDate.Text = "Ngày bắt đầu";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(151, 129);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(220, 22);
            this.dtpStartDate.TabIndex = 24;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(48, 51);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(53, 16);
            this.lblTitle.TabIndex = 23;
            this.lblTitle.Text = "Tiêu đề";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(48, 70);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(197, 22);
            this.txtTitle.TabIndex = 22;
            // 
            // lblPriority
            // 
            this.lblPriority.AutoSize = true;
            this.lblPriority.Location = new System.Drawing.Point(50, 360);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(51, 16);
            this.lblPriority.TabIndex = 21;
            this.lblPriority.Text = "Mức độ";
            this.lblPriority.Click += new System.EventHandler(this.label1_Click);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(151, 184);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(220, 22);
            this.dtpEndDate.TabIndex = 31;
            // 
            // txtStartTime
            // 
            this.txtStartTime.Location = new System.Drawing.Point(51, 129);
            this.txtStartTime.Name = "txtStartTime";
            this.txtStartTime.Size = new System.Drawing.Size(85, 22);
            this.txtStartTime.TabIndex = 33;
            this.txtStartTime.Text = "00:00";
            // 
            // txtEndTime
            // 
            this.txtEndTime.Location = new System.Drawing.Point(51, 184);
            this.txtEndTime.Name = "txtEndTime";
            this.txtEndTime.Size = new System.Drawing.Size(85, 22);
            this.txtEndTime.TabIndex = 34;
            this.txtEndTime.Text = "00:00";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(50, 223);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(101, 16);
            this.lblDescription.TabIndex = 35;
            this.lblDescription.Text = "Mô tả công việc";
            this.lblDescription.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(53, 253);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(318, 98);
            this.txtDescription.TabIndex = 36;
            // 
            // Doing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 553);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtEndTime);
            this.Controls.Add(this.txtStartTime);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.rdoNormal);
            this.Controls.Add(this.rdoImportant);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblPriority);
            this.Name = "Doing";
            this.Text = "Doing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rdoNormal;
        private System.Windows.Forms.RadioButton rdoImportant;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblPriority;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.TextBox txtStartTime;
        private System.Windows.Forms.TextBox txtEndTime;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
    }
}