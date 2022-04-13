using System;
using System.Collections.Generic;
using System.Text;

namespace DateTime_DirecTory
{
    public class Meeting
    {
        public Meeting()
        {
            if (FromDate>ToDate)
            {
                Console.WriteLine("Bele meeting obyekti yaradila bilmez!");
            }
        }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string Name { get; set; }
    }
}
