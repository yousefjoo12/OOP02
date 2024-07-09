using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP02
{
	internal class hire_date
	{
		private string day;
		private string month;
		private string year;

		public string Year

		{
			get { return year; }
			set { year = value; }
		}
		public string Month
		{
			get { return month; }
			set { month = value; }
		}

		public string Day
		{
			get { return day; }
			set { day = value; }
		}
        public hire_date(string _day, string _month, string _year)
        {
            day = _day;
			month = _month;
			year = _year;
        }
        public override string ToString()
		{
			return $"{day}/{month}/{year}";
		}
	}
}

