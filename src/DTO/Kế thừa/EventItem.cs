using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class EventItem : ScheduleItem
    {
        private string _location;
        private string _description;

        public override ScheduleItem showInformation()
        {
            throw new NotImplementedException();
        }
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        public string Location
        {
            get { return _location; }
            set { _location = value; }
        }
        // 1. Constructor không tham số (BẮT BUỘC có để thư viện JSON có thể đọc/tải dữ liệu lên)
        public EventItem() : base()
        {
        }

        // 2. Constructor đầy đủ tham số (Dùng để nhận dữ liệu từ Form)
        public EventItem(string title, DateTime startDate, DateTime endDate, Priority priority, string location, string description)
            : base(title, startDate, endDate, priority) // Gọi constructor của lớp cha ScheduleItem
        {
            this._location = location;
            this._description = description;
        }
    }
}