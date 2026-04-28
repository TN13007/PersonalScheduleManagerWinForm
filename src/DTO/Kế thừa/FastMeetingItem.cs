using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class FastMeetingItem : ScheduleItem
    {
        private DateTime _reminderTime;

        public override ScheduleItem showInformation()
        {
            throw new NotImplementedException();
        }

        public DateTime ReminderTime
        {
            get { return _reminderTime; }
            set { _reminderTime = value; }
        }

        // 1. Constructor không tham số (BẮT BUỘC có để dùng cho việc đọc/tải file JSON)
        public FastMeetingItem() : base()
        {
            // Constructor này để trống, thư viện System.Text.Json sẽ tự dùng nó.
        }

        public FastMeetingItem(string title, DateTime startDate, DateTime endDate, Priority priority, DateTime reminderTime)
            : base(title, startDate, endDate, priority) // Gọi ngược lên constructor của ScheduleItem
        {
            // Chỉ cần gán giá trị riêng của lớp FastMeetingItem
            this._reminderTime = reminderTime;
        }
    }
}

