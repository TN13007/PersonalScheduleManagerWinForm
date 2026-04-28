using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class EventItem : ScheduleItem
    {
        private string _location;
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
        public string Location
        {
            get { return _location; }
            set { _location = value; }
        }
    }
}