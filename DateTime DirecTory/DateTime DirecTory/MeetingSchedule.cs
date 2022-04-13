using System;
using System.Collections.Generic;
using System.Text;

namespace DateTime_DirecTory
{
    public class MeetingSchedule
    {
        public List<Meeting> Meetings = new List<Meeting>();

        public void SetMeeting(string fullname, DateTime from, DateTime to)
        {
            foreach (var item in Meetings)
            {
                if ((from < item.FromDate && to < item.FromDate) || (item.ToDate < from && item.ToDate<to))
                {
                    Meeting meeting = new Meeting();
                    meeting.Name = fullname;
                    meeting.FromDate = from;
                    meeting.ToDate = to;

                    Meetings.Add(meeting);
                }
                else
                    throw new Exception();
            }
        }
        public int FindMeetingsCount(DateTime time)
        {
            int Count = 0;
            foreach (var item in Meetings)
            {
                if (item.FromDate>time)
                    Count++;
            }
            return Count;
        }
        public bool IsExistsMeetingByName(string name)
        {
            return Meetings.Exists(x=>x.Name==name);
        }
        public List<Meeting> GetExistMeetings(string name)
        {
            return Meetings.FindAll(x => x.Name == name);
        }
        public void GetInfo()
        {
            foreach (var item in Meetings)
            {
                Console.WriteLine(item.Name + " - " + item.FromDate + " - " + item.ToDate);
            }
        }
    }
}
