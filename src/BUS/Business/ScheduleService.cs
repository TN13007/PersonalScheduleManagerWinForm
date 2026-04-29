using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BUS
{
    public delegate void DataChangedHandler();
    public class ScheduleService
    {
        private List<ScheduleItem> danhSach;
        private ValidationService validationService;
        private StatusService statusService;

        public event DataChangedHandler OnDataChanged;

        private static ScheduleService _instance;

        public static ScheduleService Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ScheduleService();
                }
                return _instance;
            }
        }

        private ScheduleService()
        {
            danhSach = new List<ScheduleItem>();
            validationService = new ValidationService();
            statusService = new StatusService();

            // Tạo dữ liệu demo ban đầu
            TaoDuLieuDemo();
        }
        public List<ScheduleItem> TaoDuLieuDemo()
        {
            // Xóa danh sách cũ nếu có để tránh trùng lặp khi gọi lại
            danhSach.Clear();

            danhSach.Add(new DoingItem("Hoàn thành báo cáo tháng", DateTime.Now.AddDays(-1), DateTime.Now.AddHours(4), Priority.Important, "Phải gửi cho sếp trước 5h chiều"));
            danhSach.Add(new DoingItem("Đọc tài liệu C#", DateTime.Now.AddHours(-2), DateTime.Now.AddHours(1), Priority.Normal, "Chương về Serialization"));
            danhSach.Add(new DoingItem("Sửa lỗi Logic Service", DateTime.Now.AddDays(-3), DateTime.Now.AddDays(-2), Priority.Important, "Lỗi khi lưu file JSON bị trống"));
            danhSach.Add(new EventItem("Tiệc sinh nhật đồng nghiệp", DateTime.Now.AddDays(2), DateTime.Now.AddDays(2).AddHours(3), Priority.Normal, "Nhà hàng Sen Tây Hồ", "Mang theo quà tặng"));
            danhSach.Add(new EventItem("Hội nghị khách hàng", DateTime.Now.AddHours(-1), DateTime.Now.AddHours(5), Priority.Important, "Khách sạn Marriott", "Tiếp đón đối tác chiến lược"));
            danhSach.Add(new EventItem("Workshop lập trình", DateTime.Now.AddDays(10), DateTime.Now.AddDays(10).AddHours(4), Priority.Normal, "Văn phòng tầng 5", "Chia sẻ kinh nghiệm WinForms"));
            danhSach.Add(new FastMeetingItem("Họp khẩn cấp với Team", DateTime.Now.AddMinutes(15), DateTime.Now.AddMinutes(30), Priority.Important, DateTime.Now.AddMinutes(10)));
            danhSach.Add(new FastMeetingItem("Check-in sáng", DateTime.Now.AddHours(-4), DateTime.Now.AddHours(-3.5), Priority.Normal, DateTime.Now.AddHours(-4).AddMinutes(-5)));
            danhSach.Add(new FastMeetingItem("Gặp khách hàng online", DateTime.Now.AddDays(1), DateTime.Now.AddDays(1).AddMinutes(20), Priority.Important, DateTime.Now.AddDays(1).AddMinutes(-10)));
            
            int[] ids = { 45, 12, 88, 3, 27, 99, 15, 6, 50 };
            for (int i = 0; i < danhSach.Count; i++)
            {
                danhSach[i].Id = ids[i];
            }
            return danhSach;
        }

        public List<ScheduleItem> LayListHienTai()
        {
            statusService.CapNhatQuaHan(danhSach);
            return danhSach;
        }

        public bool AddTask(ScheduleItem task)
        {
            if (!validationService.CheckTask(task)) return false;

            int newId = 1;
            if (danhSach.Count > 0)
            {
                newId = danhSach.Max(x => x.Id) + 1;
            }

            task.Id = newId;

            danhSach.Add(task);
            
            if (OnDataChanged != null)
            {
                OnDataChanged();
            }

            return true;
        }
        public bool EditTask(int id, ScheduleItem newTask)
        {
            if (!validationService.CheckTask(newTask))
            {
                return false;
            }
            for (int i = 0; i < danhSach.Count; i++)
            {
                if (danhSach[i].Id == id)
                {
                    newTask.Id = id; // Giữ nguyên ID của task cũ
                    danhSach[i] = newTask;
                    return true;
                }
            }
            return false;
        }
        public bool DeleteTask(int id)
        {
            for (int i = 0; i < danhSach.Count; i++)
            {
                if (danhSach[i].Id == id)
                {
                    danhSach.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }
        //public ScheduleItem Find(int id)
        //{
        //    for (int i = 0; i < danhSach.Count; i++)
        //    {
        //        if (danhSach[i].Id == id)
        //        {
        //            return danhSach[i];
        //        }
        //    }

        //    return null;
        //}

        //public List<ScheduleItem> LayDanhSach()
        //{
        //    statusService.CapNhatQuaHan(danhSach);
        //    return danhSach;
        //}

        //public bool DanhDauDaLam(int id)
        //{
        //    ScheduleItem task = Find(id);

        //    if (task == null)
        //    {
        //        return false;
        //    }

        //    statusService.MarkDone(task);
        //    return true;
        //}

        //public void GanDanhSach(List<ScheduleItem> danhSachMoi)
        //{
        //    if (danhSachMoi == null)
        //    {
        //        danhSach = new List<ScheduleItem>();
        //    }
        //    else
        //    {
        //        danhSach = danhSachMoi;
        //    }
        //}
    }
}
