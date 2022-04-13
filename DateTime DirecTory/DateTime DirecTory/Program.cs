using System;

namespace DateTime_DirecTory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Meeting meeting1 = new Meeting();
            meeting1.Name = "Date1";
            meeting1.FromDate = new DateTime(2020, 12, 4, 14, 55, 00);
            meeting1.ToDate = new DateTime(2020, 12, 4, 18, 00, 00);

            Meeting meeting2 = new Meeting();
            meeting2.Name = "Date2";
            meeting2.FromDate = new DateTime(2021, 12, 4, 15, 55, 00);
            meeting2.ToDate = new DateTime(2021, 12, 4, 17, 00, 00);

            Meeting meeting3 = new Meeting();
            meeting3.Name = "Date3";
            meeting3.FromDate = new DateTime(2019, 12, 4, 14, 55, 00);
            meeting3.ToDate = new DateTime(2019, 12, 4, 18, 00, 00);

            MeetingSchedule meetingSchedule = new MeetingSchedule();

            meetingSchedule.Meetings.Add(meeting1);
            meetingSchedule.Meetings.Add(meeting2);
            meetingSchedule.Meetings.Add(meeting3);

            DateTime from = new DateTime(2021, 12, 4, 16, 00, 00);
            DateTime to = new DateTime(2021, 12, 4, 17, 00, 00);

            DateTime from2 = new DateTime(2022, 12, 4, 16, 00, 00);
            DateTime to2 = new DateTime(2022, 12, 4, 17, 00, 00);



            //try
            //{
            //    meetingSchedule.SetMeeting("Date 5", from2, to2);
            //    //meetingSchedule.SetMeeting("Date 4", from, to);
            //}
            //catch (Exception)
            //{

            //    Console.WriteLine("Xeta bas verdi."); ;
            //}

            Console.WriteLine(meetingSchedule.IsExistsMeetingByName("Date2"));

            foreach (var item in meetingSchedule.GetExistMeetings("Date3"))
            {
                Console.WriteLine(item.FromDate + " - " + item.ToDate);
            }

        }
    }
}
