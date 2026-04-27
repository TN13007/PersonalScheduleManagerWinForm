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
    private bool _isDone;

    abstract public ScheduleItem showInformation();
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

    public bool IsDone
    {
        get { return _isDone; }
        set { _isDone = value; }
    }
}

