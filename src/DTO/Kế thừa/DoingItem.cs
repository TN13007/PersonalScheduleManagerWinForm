using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


class DoingItem : ScheduleItem
{
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
    // 1. Constructor không tham số (BẮT BUỘC có để đọc/lưu file JSON)
    public DoingItem() : base()
    {
    }

    // 2. Constructor đầy đủ tham số (Dùng để nhận dữ liệu từ Form)
    public DoingItem(string title, DateTime startDate, DateTime endDate, Priority priority, string description)
        : base(title, startDate, endDate, priority) // Đẩy các giá trị chung lên lớp cha xử lý
    {
        // Chỉ gán giá trị riêng của lớp DoingItem
        this._description = description;
    }
}
