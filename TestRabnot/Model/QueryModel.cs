using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TestRabnot.Model.QyeryService;

namespace TestRabnot.Model
{
    internal class QueryModel
    {
        public string Day { get; set; }
        public string Month { get; set; }
        public int DayInMonth { get; set; }
        public string Year { get; set; }

        public string Res
        {
            get
            {
                return $"{GetDay(Day)} {GetDayInMonth(DayInMonth)} {GetMonth(Month, DayInMonth)} {GetYear(Year)} ";
            }
        }


       


    }
}
