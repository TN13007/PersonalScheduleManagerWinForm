using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;


namespace Presentation
{
    public partial class Home : Form
    {
        private ToolTip toolTip;
        private Timer fadeTimer;
        private Dictionary<Button, Color> buttonColors;

        private ScheduleService scheduleService = ScheduleService.Instance;

        public Home()
        {
            InitializeComponent();
            ApplyGoogleCalendarTheme();
            SetupUXEnhancements();
            ApplyFadeInEffect();

            scheduleService.OnDataChanged += HienThiDanhSach;

            HienThiDanhSach();
        }

        private void HienThiDanhSach()
        {
            dgvTasks.DataSource = null;
            dgvTasks.DataSource = scheduleService.LayListHienTai();
        }
        private void ApplyGoogleCalendarTheme()
        {
            // Form styling
            this.BackColor = ColorTranslator.FromHtml("#F8FAFC");
            this.Font = new Font("Segoe UI", 9F);
            this.MinimumSize = new Size(1200, 600);

            // GroupBox Filter styling
            grpFilter.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            grpFilter.ForeColor = ColorTranslator.FromHtml("#202124");
            grpFilter.Font = new Font("Segoe UI", 9F);
            grpFilter.Padding = new Padding(12);

            // Labels styling
            foreach (Control control in this.Controls)
            {
                if (control is Label)
                {
                    control.Font = new Font("Segoe UI", 9F);
                    control.ForeColor = ColorTranslator.FromHtml("#202124");
                }
            }

            foreach (Control control in grpFilter.Controls)
            {
                if (control is Label)
                {
                    control.Font = new Font("Segoe UI", 9F);
                    control.ForeColor = ColorTranslator.FromHtml("#202124");
                }
            }

            // ComboBox styling
            cboTaskTypeFilter.Font = new Font("Segoe UI", 9F);
            cboTaskTypeFilter.Height = 28;
            cboTaskTypeCreate.Font = new Font("Segoe UI", 9F);
            cboTaskTypeCreate.Height = 28;

            // DateTimePicker styling
            dtpStartDateFilter.Font = new Font("Segoe UI", 9F);
            dtpStartDateFilter.Height = 28;
            dtpEndDateFilter.Font = new Font("Segoe UI", 9F);
            dtpEndDateFilter.Height = 28;

            // Button styling
            buttonColors = new Dictionary<Button, Color>();
            StyleButton(btnCreate, "#4285F4", "Tạo công việc mới (Ctrl+N)");
            StyleButton(btnSaveJSON, "#34A853", "Lưu dữ liệu ra file JSON (Ctrl+S)");
            StyleButton(btnLoadJSON, "#4285F4", "Tải dữ liệu từ file JSON (Ctrl+O)");
            StyleButton(btnEdit, "#FBBC05", "Chỉnh sửa công việc đã chọn (Ctrl+E)");
            StyleButton(btnDelete, "#EA4335", "Xóa công việc đã chọn (Delete)");
            StyleButton(btnApplyFilter, "#4285F4", "Áp dụng bộ lọc (Ctrl+F)");

            // DataGridView styling
            dgvTasks.BackgroundColor = ColorTranslator.FromHtml("#FFFFFF");
            dgvTasks.BorderStyle = BorderStyle.None;
            dgvTasks.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvTasks.GridColor = ColorTranslator.FromHtml("#DADCE0");
            dgvTasks.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            dgvTasks.DefaultCellStyle.ForeColor = ColorTranslator.FromHtml("#202124");
            dgvTasks.DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#E8F0FE");
            dgvTasks.DefaultCellStyle.SelectionForeColor = ColorTranslator.FromHtml("#202124");
            dgvTasks.DefaultCellStyle.Font = new Font("Segoe UI", 9F);
            dgvTasks.DefaultCellStyle.Padding = new Padding(4);
            dgvTasks.RowTemplate.Height = 32;

            dgvTasks.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#E8F0FE");
            dgvTasks.ColumnHeadersDefaultCellStyle.ForeColor = ColorTranslator.FromHtml("#202124");
            dgvTasks.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dgvTasks.ColumnHeadersDefaultCellStyle.Padding = new Padding(4);
            dgvTasks.ColumnHeadersHeight = 36;
            dgvTasks.EnableHeadersVisualStyles = false;

            dgvTasks.AlternatingRowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#F8FAFC");

            // CheckBox styling
            foreach (Control control in grpFilter.Controls)
            {
                if (control is CheckBox)
                {
                    control.Font = new Font("Segoe UI", 9F);
                    control.ForeColor = ColorTranslator.FromHtml("#202124");
                }
            }
        }

        private void StyleButton(Button btn, string colorHex, string tooltip = "")
        {
            Color color = ColorTranslator.FromHtml(colorHex);
            btn.BackColor = color;
            btn.ForeColor = Color.White;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn.Cursor = Cursors.Hand;
            btn.Height = 32;

            buttonColors[btn] = color;

            // Hover effects
            btn.MouseEnter += (s, e) => btn.BackColor = LightenColor(color, 20);
            btn.MouseLeave += (s, e) => btn.BackColor = color;

            // ToolTip
            if (!string.IsNullOrEmpty(tooltip) && toolTip != null)
            {
                toolTip.SetToolTip(btn, tooltip);
            }
        }

        private void SetupUXEnhancements()
        {
            // Initialize ToolTip
            toolTip = new ToolTip
            {
                AutoPopDelay = 5000,
                InitialDelay = 500,
                ReshowDelay = 100,
                ShowAlways = true,
                IsBalloon = true
            };

            // ToolTips for other controls
            toolTip.SetToolTip(cboTaskTypeFilter, "Lọc theo loại công việc");
            toolTip.SetToolTip(cboTaskTypeCreate, "Chọn loại công việc để tạo mới");
            toolTip.SetToolTip(dtpStartDateFilter, "Lọc từ ngày");
            toolTip.SetToolTip(dtpEndDateFilter, "Lọc đến ngày");
            toolTip.SetToolTip(chkImportant, "Lọc công việc quan trọng");
            toolTip.SetToolTip(chkNormal, "Lọc công việc bình thường");
            toolTip.SetToolTip(chkDone, "Lọc công việc đã hoàn thành");
            toolTip.SetToolTip(chkInProgress, "Lọc công việc đang làm");
            toolTip.SetToolTip(chkOverdue, "Lọc công việc quá hạn");
            toolTip.SetToolTip(dgvTasks, "Nhấp đúp để chỉnh sửa, nhấp phải để xem menu");

            // DataGridView enhancements
            dgvTasks.CellMouseEnter += DgvTasks_CellMouseEnter;
            dgvTasks.CellMouseLeave += DgvTasks_CellMouseLeave;
            dgvTasks.DataBindingComplete += DgvTasks_DataBindingComplete;

            // Keyboard shortcuts
            this.KeyPreview = true;

            // Tab order
            SetTabOrder();
        }

        private void SetTabOrder()
        {
            int tabIndex = 0;
            cboTaskTypeCreate.TabIndex = tabIndex++;
            btnCreate.TabIndex = tabIndex++;
            btnSaveJSON.TabIndex = tabIndex++;
            btnLoadJSON.TabIndex = tabIndex++;
            cboTaskTypeFilter.TabIndex = tabIndex++;
            dtpStartDateFilter.TabIndex = tabIndex++;
            dtpEndDateFilter.TabIndex = tabIndex++;
            chkImportant.TabIndex = tabIndex++;
            chkNormal.TabIndex = tabIndex++;
            chkDone.TabIndex = tabIndex++;
            chkInProgress.TabIndex = tabIndex++;
            chkOverdue.TabIndex = tabIndex++;
            btnApplyFilter.TabIndex = tabIndex++;
            dgvTasks.TabIndex = tabIndex++;
            btnEdit.TabIndex = tabIndex++;
            btnDelete.TabIndex = tabIndex++;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Control | Keys.N:
                    btnCreate.PerformClick();
                    return true;
                case Keys.Control | Keys.S:
                    btnSaveJSON.PerformClick();
                    return true;
                case Keys.Control | Keys.O:
                    btnLoadJSON.PerformClick();
                    return true;
                case Keys.Control | Keys.E:
                    if (dgvTasks.SelectedRows.Count > 0)
                        btnEdit.PerformClick();
                    return true;
                case Keys.Delete:
                    if (dgvTasks.SelectedRows.Count > 0)
                        btnDelete.PerformClick();
                    return true;
                case Keys.Control | Keys.F:
                    btnApplyFilter.PerformClick();
                    return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void DgvTasks_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dgvTasks.Rows[e.RowIndex].DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#F1F3F4");
            }
        }

        private void DgvTasks_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.RowIndex % 2 == 0)
                    dgvTasks.Rows[e.RowIndex].DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#FFFFFF");
                else
                    dgvTasks.Rows[e.RowIndex].DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#F8FAFC");
            }
        }

        private void DgvTasks_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dgvTasks.Rows.Count == 0)
            {
                ShowEmptyState();
            }
        }

        private void ShowEmptyState()
        {
            // Simple empty state message
            lblTaskList.Text = "Danh sách công việc (Chưa có dữ liệu)";
            lblTaskList.ForeColor = ColorTranslator.FromHtml("#5F6368");
        }

        private void ApplyFadeInEffect()
        {
            this.Opacity = 0;
            fadeTimer = new Timer { Interval = 10 };
            fadeTimer.Tick += (s, e) =>
            {
                if (this.Opacity < 1)
                    this.Opacity += 0.05;
                else
                    fadeTimer.Stop();
            };
            fadeTimer.Start();
        }

        private Color LightenColor(Color color, int percent)
        {
            int r = Math.Min(255, color.R + (255 - color.R) * percent / 100);
            int g = Math.Min(255, color.G + (255 - color.G) * percent / 100);
            int b = Math.Min(255, color.B + (255 - color.B) * percent / 100);
            return Color.FromArgb(r, g, b);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (fadeTimer != null)
            {
                fadeTimer.Stop();
                fadeTimer.Dispose();
            }
            if (toolTip != null)
            {
                toolTip.Dispose();
            }
            base.OnFormClosing(e);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string selectedValue = cboTaskTypeCreate.SelectedItem?.ToString() ?? "";
            switch (selectedValue)
            {
                case "Việc cần làm":
                    new Doing().Show();
                    break;
                case "Sự kiện":
                    new Event().Show();
                    break;
                case "Lên lịch hẹn":
                    new FastMeeting().Show();
                    break;
                default:
                    MessageBox.Show("Vui lòng chọn một loại để tạo.");
                    break;
            }
        }
    }
}
