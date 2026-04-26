using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

abstract class ScheduleItem
    {
    private string _title;
    private DateTime _startDate;
    private DateTime _endDate;
    private TaskStatus _status;
    private Priority _priority;

    abstract public ScheduleItem showInformation();
   

    public string Title { get => _title; set => _title = value; }
    public DateTime StartDate { get => _startDate; set => _startDate = value; }
    public DateTime EndDate { get => _endDate; set => _endDate = value; }
    public TaskStatus Status { get => _status; set => _status = value; }
    public Priority Priority { get => _priority; set => _priority = value; }
}

