using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace Presentation
{
    public partial class Doing : Form
    {
        private ToolTip toolTip;
        private Timer fadeTimer;
        private bool hasChanges = false;
        private ScheduleService scheduleService = ScheduleService.Instance;

        public Doing()
        {
            InitializeComponent();
            ApplyGoogleCalendarTheme();
            SetupUXEnhancements();
            ApplyFadeInEffect();
        }

        private void ApplyGoogleCalendarTheme()
        {
            // Form styling
            this.BackColor = ColorTranslator.FromHtml("#F8FAFC");
            this.Font = new Font("Segoe UI", 9F);
            this.MinimumSize = new Size(450, 600);

            // Labels styling
            foreach (Control control in this.Controls)
            {
                if (control is Label)
                {
                    control.Font = new Font("Segoe UI", 9F);
                    control.ForeColor = ColorTranslator.FromHtml("#202124");
                }
                else if (control is TextBox tb)
                {
                    tb.Font = new Font("Segoe UI", 9F);
                    tb.BorderStyle = BorderStyle.FixedSingle;
                    SetupTextBoxFocusEffect(tb);
                }
                else if (control is DateTimePicker)
                {
                    control.Font = new Font("Segoe UI", 9F);
                }
                else if (control is RadioButton)
                {
                    control.Font = new Font("Segoe UI", 9F);
                    control.ForeColor = ColorTranslator.FromHtml("#202124");
                }
            }

            // TextBox heights
            txtTitle.Height = 28;
            txtStartTime.Height = 28;
            txtEndTime.Height = 28;

            // Placeholders
            SetPlaceholder(txtTitle, "Nhập tiêu đề công việc...");
            SetPlaceholder(txtStartTime, "HH:mm");
            SetPlaceholder(txtEndTime, "HH:mm");
            SetPlaceholder(txtDescription, "Mô tả chi tiết công việc...");

            // Button styling
            btnAdd.BackColor = ColorTranslator.FromHtml("#4285F4");
            btnAdd.ForeColor = Color.White;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.Height = 36;

            // Hover effect
            Color btnColor = btnAdd.BackColor;
            btnAdd.MouseEnter += (s, e) => btnAdd.BackColor = LightenColor(btnColor, 20);
            btnAdd.MouseLeave += (s, e) => btnAdd.BackColor = btnColor;
        }

        private void SetupUXEnhancements()
        {
            // ToolTip
            toolTip = new ToolTip
            {
                AutoPopDelay = 5000,
                InitialDelay = 500,
                ReshowDelay = 100,
                ShowAlways = true
            };

            toolTip.SetToolTip(txtTitle, "Nhập tiêu đề cho công việc");
            toolTip.SetToolTip(dtpStartDate, "Chọn ngày bắt đầu");
            toolTip.SetToolTip(txtStartTime, "Nhập giờ bắt đầu (VD: 09:00)");
            toolTip.SetToolTip(dtpEndDate, "Chọn ngày kết thúc");
            toolTip.SetToolTip(txtEndTime, "Nhập giờ kết thúc (VD: 17:00)");
            toolTip.SetToolTip(txtDescription, "Mô tả chi tiết về công việc");
            toolTip.SetToolTip(rdoImportant, "Đánh dấu công việc quan trọng");
            toolTip.SetToolTip(rdoNormal, "Công việc bình thường");
            toolTip.SetToolTip(btnAdd, "Thêm công việc mới (Ctrl+S)");

            // Track changes
            foreach (Control control in this.Controls)
            {
                if (control is TextBox || control is DateTimePicker || control is RadioButton)
                {
                    control.TextChanged += (s, e) => hasChanges = true;
                }
            }

            // Auto-focus first input
            this.Shown += (s, e) => txtTitle.Focus();

            // Tab order
            SetTabOrder();

            // Keyboard shortcuts
            this.KeyPreview = true;
        }

        private void SetTabOrder()
        {
            int tabIndex = 0;
            txtTitle.TabIndex = tabIndex++;
            dtpStartDate.TabIndex = tabIndex++;
            txtStartTime.TabIndex = tabIndex++;
            dtpEndDate.TabIndex = tabIndex++;
            txtEndTime.TabIndex = tabIndex++;
            txtDescription.TabIndex = tabIndex++;
            rdoImportant.TabIndex = tabIndex++;
            rdoNormal.TabIndex = tabIndex++;
            btnAdd.TabIndex = tabIndex++;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.S))
            {
                btnAdd.PerformClick();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void SetupTextBoxFocusEffect(TextBox tb)
        {
            tb.Enter += (s, e) =>
            {
                tb.BackColor = ColorTranslator.FromHtml("#E8F0FE");
            };
            tb.Leave += (s, e) =>
            {
                tb.BackColor = Color.White;
            };
        }

        private void SetPlaceholder(TextBox tb, string placeholder)
        {
            tb.Text = placeholder;
            tb.ForeColor = ColorTranslator.FromHtml("#5F6368");

            tb.Enter += (s, e) =>
            {
                if (tb.Text == placeholder)
                {
                    tb.Text = "";
                    tb.ForeColor = ColorTranslator.FromHtml("#202124");
                }
            };

            tb.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(tb.Text))
                {
                    tb.Text = placeholder;
                    tb.ForeColor = ColorTranslator.FromHtml("#5F6368");
                }
            };
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
            if (hasChanges)
            {
                var result = MessageBox.Show(
                    "Bạn có thay đổi chưa lưu. Bạn có muốn thoát?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                    return;
                }
            }

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

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                DoingItem newItem = new DoingItem
                {
                    Title = txtTitle.Text,
                    StartDate = dtpStartDate.Value.Date + TimeSpan.Parse(txtStartTime.Text),
                    EndDate = dtpEndDate.Value.Date + TimeSpan.Parse(txtEndTime.Text),
                    Description = txtDescription.Text,
                    Priority = rdoImportant.Checked ? Priority.Important : Priority.Normal

                };
                bool isAdded = scheduleService.AddTask(newItem);

                if (isAdded)
                {
                    MessageBox.Show("Công việc đã được thêm thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra khi thêm công việc. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Định dạng thời gian không hợp lệ. Vui lòng nhập theo định dạng HH:mm.", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
