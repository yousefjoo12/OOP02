using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOP02
{
	internal class employees
	{
		#region attrbuties

		private int id;
		private string name;
		private int security_level;
		private double salary;
		private hire_date hire_date;
		private string gender;

		#endregion
		#region properties
		public string Gender
		{
			get { return gender; }
			set { gender = value; }
		}


		public hire_date Hire_date
		{
			get { return hire_date; }
			set { hire_date = value; }
		}

		public double Salary
		{
			get { return salary; }
			set { salary = value; }
		}


		public int Security_level
		{
			get { return security_level; }
			set { security_level = value; }
		}

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		public int Id
		{
			get { return id; }
			set { id = value; }
		}

		#endregion
		public override string ToString()
		{
			return $" Id : {id}\n name : {name}\n security level : {security_level}\n salary : {salary}\n hire_date : {hire_date}\n gender : {gender}";
		}
		public employees(int _id, string _name, int _security_level, double _salary, hire_date _hire_date, string _gender)
		{
			id = _id;
			name = _name;
			security_level = _security_level;
			salary = _salary;
			hire_date = _hire_date;

			if (_gender == "M" || _gender == "F" || _gender == "Male" || _gender == "Female")
			{

				gender = _gender;

			}


			else
			{
				gender = "No gender";
			}
		}



	}
}
