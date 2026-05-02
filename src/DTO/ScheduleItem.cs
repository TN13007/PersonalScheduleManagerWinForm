using System;
using System.Collections.Generic;
using System.Text;
namespace DTO
{
    public abstract class ScheduleItem
    {
        private int _id;
        private string _title;
        private DateTime _startDate;
        private DateTime _endDate;
        private TaskStatus _status;
        private Priority _priority;
        private bool _isDone;

        //public abstract void ShowInformation();

        abstract public ScheduleItem showInformation();
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }


        


        public DateTime StartDate
        {
            get { return _startDate; }
            set { _startDate = value; }
        }

        public DateTime EndDate
        {
            get { return _endDate; }
            set { _endDate = value; }
        }


        public TaskStatus Status
        {
            get { return _status; }
            set { _status = value; }
        }

        public Priority Priority
        {
            get { return _priority; }
            set { _priority = value; }
        }




        /// cái này có thể không cần thiết vì đã có TaskStatus để quản lý trạng thái công việc.
        public bool IsDone
        {
            get { return _isDone; }
            set { _isDone = value; }
        }
        // 1. Constructor không tham số: BẮT BUỘC phải có để thư viện JSON có thể hoạt động
        public ScheduleItem()
        {
        }

        // 2. Constructor có tham số: Dùng để các lớp con gọi qua từ khóa 'base'
        public ScheduleItem(string title, DateTime startDate, DateTime endDate, Priority priority)
        {
            this._title = title;
            this._startDate = startDate;
            this._endDate = endDate;
            this._priority = priority;
            this._isDone = false; // Mặc định khi tạo mới là chưa xong
            this._status = TaskStatus.Review; // Gán mặc định là Review khi vừa tạo mới
        }
    }
}

