using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BUS
{
    public class ScheduleService
    {
        private List<ScheduleItem> danhSach;
        private ValidationService validationService;
        private StatusService statusService;

        //Triển khai các phương thức
        public ScheduleService()
        {
            danhSach = new List<ScheduleItem>();
            validationService = new ValidationService();
            statusService = new StatusService();
        }
        //Thêm
        public bool AddTask(ScheduleItem task)
        {
            if (!validationService.CheckTask(task))
            {
                return false;
            }

            danhSach.Add(task);
            return true;
        }
        //Sửa
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
        //Xóa
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
