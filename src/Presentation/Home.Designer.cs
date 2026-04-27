namespace Presentation
{
    partial class Home
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
            this.cboTaskTypeFilter = new System.Windows.Forms.ComboBox();
            this.lblPriority = new System.Windows.Forms.Label();
            this.lblFilter = new System.Windows.Forms.Label();
            this.grpFilter = new System.Windows.Forms.GroupBox();
            this.btnApplyFilter = new System.Windows.Forms.Button();
            this.chkOverdue = new System.Windows.Forms.CheckBox();
            this.chkInProgress = new System.Windows.Forms.CheckBox();
            this.chkDone = new System.Windows.Forms.CheckBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.chkNormal = new System.Windows.Forms.CheckBox();
            this.chkImportant = new System.Windows.Forms.CheckBox();
            this.lblTaskType = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.dtpEndDateFilter = new System.Windows.Forms.DateTimePicker();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.dtpStartDateFilter = new System.Windows.Forms.DateTimePicker();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblCreateTask = new System.Windows.Forms.Label();
            this.cboTaskTypeCreate = new System.Windows.Forms.ComboBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnSaveJSON = new System.Windows.Forms.Button();
            this.lblTaskList = new System.Windows.Forms.Label();
            this.dgvTasks = new System.Windows.Forms.DataGridView();
            this.btnLoadJSON = new System.Windows.Forms.Button();
            this.grpFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).BeginInit();
            this.SuspendLayout();
            // 
            // cboTaskTypeFilter
            // 
            this.cboTaskTypeFilter.FormattingEnabled = true;
            this.cboTaskTypeFilter.Items.AddRange(new object[] {
            "Việc cần làm",
            "Sự kiện",
            "Lên lịch hẹn"});
            this.cboTaskTypeFilter.Location = new System.Drawing.Point(10, 55);
            this.cboTaskTypeFilter.Name = "cboTaskTypeFilter";
            this.cboTaskTypeFilter.Size = new System.Drawing.Size(185, 24);
            this.cboTaskTypeFilter.TabIndex = 20;
            this.cboTaskTypeFilter.Text = "Lựa chọn  ";
            // 
            // lblPriority
            // 
            this.lblPriority.AutoSize = true;
            this.lblPriority.Location = new System.Drawing.Point(10, 99);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(51, 16);
            this.lblPriority.TabIndex = 30;
            this.lblPriority.Text = "Mức độ";
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilter.Location = new System.Drawing.Point(118, 18);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(42, 20);
            this.lblFilter.TabIndex = 33;
            this.lblFilter.Text = "Lọc ";
            // 
            // grpFilter
            // 
            this.grpFilter.Controls.Add(this.btnApplyFilter);
            this.grpFilter.Controls.Add(this.chkOverdue);
            this.grpFilter.Controls.Add(this.chkInProgress);
            this.grpFilter.Controls.Add(this.chkDone);
            this.grpFilter.Controls.Add(this.lblStatus);
            this.grpFilter.Controls.Add(this.chkNormal);
            this.grpFilter.Controls.Add(this.chkImportant);
            this.grpFilter.Controls.Add(this.lblTaskType);
            this.grpFilter.Controls.Add(this.cboTaskTypeFilter);
            this.grpFilter.Controls.Add(this.lblEndDate);
            this.grpFilter.Controls.Add(this.dtpEndDateFilter);
            this.grpFilter.Controls.Add(this.lblStartDate);
            this.grpFilter.Controls.Add(this.lblPriority);
            this.grpFilter.Controls.Add(this.dtpStartDateFilter);
            this.grpFilter.Controls.Add(this.lblFilter);
            this.grpFilter.Location = new System.Drawing.Point(32, 137);
            this.grpFilter.Name = "grpFilter";
            this.grpFilter.Size = new System.Drawing.Size(289, 332);
            this.grpFilter.TabIndex = 21;
            this.grpFilter.TabStop = false;
            // 
            // btnApplyFilter
            // 
            this.btnApplyFilter.Location = new System.Drawing.Point(89, 292);
            this.btnApplyFilter.Name = "btnApplyFilter";
            this.btnApplyFilter.Size = new System.Drawing.Size(106, 34);
            this.btnApplyFilter.TabIndex = 48;
            this.btnApplyFilter.Text = "Lọc";
            this.btnApplyFilter.UseVisualStyleBackColor = true;
            // 
            // chkOverdue
            // 
            this.chkOverdue.AutoSize = true;
            this.chkOverdue.Location = new System.Drawing.Point(168, 170);
            this.chkOverdue.Name = "chkOverdue";
            this.chkOverdue.Size = new System.Drawing.Size(87, 20);
            this.chkOverdue.TabIndex = 45;
            this.chkOverdue.Text = "Quá hạn";
            this.chkOverdue.UseVisualStyleBackColor = true;
            // 
            // chkInProgress
            // 
            this.chkInProgress.AutoSize = true;
            this.chkInProgress.Location = new System.Drawing.Point(168, 144);
            this.chkInProgress.Name = "chkInProgress";
            this.chkInProgress.Size = new System.Drawing.Size(86, 20);
            this.chkInProgress.TabIndex = 44;
            this.chkInProgress.Text = "Đang làm";
            this.chkInProgress.UseVisualStyleBackColor = true;
            // 
            // chkDone
            // 
            this.chkDone.AutoSize = true;
            this.chkDone.Location = new System.Drawing.Point(168, 118);
            this.chkDone.Name = "chkDone";
            this.chkDone.Size = new System.Drawing.Size(71, 20);
            this.chkDone.TabIndex = 43;
            this.chkDone.Text = "Đã làm";
            this.chkDone.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(165, 99);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(67, 16);
            this.lblStatus.TabIndex = 42;
            this.lblStatus.Text = "Trạng thái";
            // 
            // chkNormal
            // 
            this.chkNormal.AutoSize = true;
            this.chkNormal.Location = new System.Drawing.Point(13, 144);
            this.chkNormal.Name = "chkNormal";
            this.chkNormal.Size = new System.Drawing.Size(98, 20);
            this.chkNormal.TabIndex = 41;
            this.chkNormal.Text = "Bình thường";
            this.chkNormal.UseVisualStyleBackColor = true;
            // 
            // chkImportant
            // 
            this.chkImportant.AutoSize = true;
            this.chkImportant.Location = new System.Drawing.Point(13, 118);
            this.chkImportant.Name = "chkImportant";
            this.chkImportant.Size = new System.Drawing.Size(94, 20);
            this.chkImportant.TabIndex = 40;
            this.chkImportant.Text = "Quan trọng";
            this.chkImportant.UseVisualStyleBackColor = true;
            // 
            // lblTaskType
            // 
            this.lblTaskType.AutoSize = true;
            this.lblTaskType.Location = new System.Drawing.Point(10, 36);
            this.lblTaskType.Name = "lblTaskType";
            this.lblTaskType.Size = new System.Drawing.Size(97, 16);
            this.lblTaskType.TabIndex = 20;
            this.lblTaskType.Text = "Loại công việc ";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(10, 233);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(88, 16);
            this.lblEndDate.TabIndex = 37;
            this.lblEndDate.Text = "Ngày kết thúc";
            // 
            // dtpEndDateFilter
            // 
            this.dtpEndDateFilter.Location = new System.Drawing.Point(10, 252);
            this.dtpEndDateFilter.Name = "dtpEndDateFilter";
            this.dtpEndDateFilter.Size = new System.Drawing.Size(273, 22);
            this.dtpEndDateFilter.TabIndex = 36;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(10, 183);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(88, 16);
            this.lblStartDate.TabIndex = 35;
            this.lblStartDate.Text = "Ngày bắt đầu";
            // 
            // dtpStartDateFilter
            // 
            this.dtpStartDateFilter.Location = new System.Drawing.Point(10, 202);
            this.dtpStartDateFilter.Name = "dtpStartDateFilter";
            this.dtpStartDateFilter.Size = new System.Drawing.Size(273, 22);
            this.dtpStartDateFilter.TabIndex = 34;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(1256, 475);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(106, 34);
            this.btnEdit.TabIndex = 39;
            this.btnEdit.Text = "Chỉnh sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1368, 475);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(106, 34);
            this.btnDelete.TabIndex = 38;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // lblCreateTask
            // 
            this.lblCreateTask.AutoSize = true;
            this.lblCreateTask.Location = new System.Drawing.Point(31, 23);
            this.lblCreateTask.Name = "lblCreateTask";
            this.lblCreateTask.Size = new System.Drawing.Size(96, 16);
            this.lblCreateTask.TabIndex = 39;
            this.lblCreateTask.Text = "Tạo công việc ";
            // 
            // cboTaskTypeCreate
            // 
            this.cboTaskTypeCreate.FormattingEnabled = true;
            this.cboTaskTypeCreate.Items.AddRange(new object[] {
            "Việc cần làm",
            "Sự kiện",
            "Lên lịch hẹn"});
            this.cboTaskTypeCreate.Location = new System.Drawing.Point(31, 42);
            this.cboTaskTypeCreate.Name = "cboTaskTypeCreate";
            this.cboTaskTypeCreate.Size = new System.Drawing.Size(185, 24);
            this.cboTaskTypeCreate.TabIndex = 40;
            this.cboTaskTypeCreate.Text = "Lựa chọn  ";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(222, 36);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(106, 34);
            this.btnCreate.TabIndex = 39;
            this.btnCreate.Text = "Tạo";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btnSaveJSON
            // 
            this.btnSaveJSON.Location = new System.Drawing.Point(334, 36);
            this.btnSaveJSON.Name = "btnSaveJSON";
            this.btnSaveJSON.Size = new System.Drawing.Size(106, 34);
            this.btnSaveJSON.TabIndex = 43;
            this.btnSaveJSON.Text = "Lưu JSON";
            this.btnSaveJSON.UseVisualStyleBackColor = true;
            // 
            // lblTaskList
            // 
            this.lblTaskList.AutoSize = true;
            this.lblTaskList.Location = new System.Drawing.Point(324, 126);
            this.lblTaskList.Name = "lblTaskList";
            this.lblTaskList.Size = new System.Drawing.Size(132, 16);
            this.lblTaskList.TabIndex = 44;
            this.lblTaskList.Text = "Danh sách công việc";
            // 
            // dgvTasks
            // 
            this.dgvTasks.AllowUserToAddRows = false;
            this.dgvTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTasks.Location = new System.Drawing.Point(327, 145);
            this.dgvTasks.Name = "dgvTasks";
            this.dgvTasks.RowHeadersWidth = 51;
            this.dgvTasks.RowTemplate.Height = 24;
            this.dgvTasks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTasks.Size = new System.Drawing.Size(1147, 324);
            this.dgvTasks.TabIndex = 46;
            // 
            // btnLoadJSON
            // 
            this.btnLoadJSON.Location = new System.Drawing.Point(446, 36);
            this.btnLoadJSON.Name = "btnLoadJSON";
            this.btnLoadJSON.Size = new System.Drawing.Size(106, 34);
            this.btnLoadJSON.TabIndex = 47;
            this.btnLoadJSON.Text = "Load JSON";
            this.btnLoadJSON.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1502, 563);
            this.Controls.Add(this.btnLoadJSON);
            this.Controls.Add(this.dgvTasks);
            this.Controls.Add(this.lblTaskList);
            this.Controls.Add(this.btnSaveJSON);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblCreateTask);
            this.Controls.Add(this.cboTaskTypeCreate);
            this.Controls.Add(this.grpFilter);
            this.Name = "Home";
            this.Text = "Form1";
            this.grpFilter.ResumeLayout(false);
            this.grpFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private System.Windows.Forms.ComboBox cboTaskTypeFilter;
        private System.Windows.Forms.GroupBox grpFilter;
        private System.Windows.Forms.Label lblPriority;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.DateTimePicker dtpEndDateFilter;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.DateTimePicker dtpStartDateFilter;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblCreateTask;
        private System.Windows.Forms.ComboBox cboTaskTypeCreate;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label lblTaskType;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.CheckBox chkNormal;
        private System.Windows.Forms.CheckBox chkImportant;
        private System.Windows.Forms.Button btnSaveJSON;
        public System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.Label lblTaskList;
        private System.Windows.Forms.DataGridView dgvTasks;
        private System.Windows.Forms.Button btnLoadJSON;
        private System.Windows.Forms.CheckBox chkOverdue;
        private System.Windows.Forms.CheckBox chkInProgress;
        private System.Windows.Forms.CheckBox chkDone;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnApplyFilter;
    }
}

