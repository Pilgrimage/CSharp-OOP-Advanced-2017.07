using System.Collections.Generic;

public class WeeklyCalendar
{
    public WeeklyCalendar()
    {
        this.WeeklySchedule = new List<WeeklyEntry>();
    }

    public List<WeeklyEntry> WeeklySchedule { get;  }

    public void AddEntry(string weekDay, string notes)
    {
        this.WeeklySchedule.Add(new WeeklyEntry(weekDay, notes));
    }

}
