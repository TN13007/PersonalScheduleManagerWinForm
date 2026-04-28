using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DoingItem : ScheduleItem
    {
        private string _description;

        public override void ShowInformation()
        {
            throw new NotImplementedException();
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
    }
}
