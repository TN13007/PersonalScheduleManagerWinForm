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

    public string Description { get => _description; set => _description = value; }
}
