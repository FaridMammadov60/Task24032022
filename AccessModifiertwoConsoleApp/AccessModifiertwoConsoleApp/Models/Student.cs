using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiertwoConsoleApp.Models
{
    internal class Student:Person
    {
        #region Fields
        double _point;
        #endregion
        #region Construction
        public Student(string name, byte age, double point) : base(name, age)
        {
            this.Point = point;
        }
        #endregion
        #region Propetry
        public double Point
        {
            get
            {
                return _point;
            }
            set
            {
                if (value < 0 || value >100)
                {
                L4:    Console.WriteLine("0-100 aralığında xal daxil edin: ");
                    string xal=Console.ReadLine();
                    double xall=Convert.ToDouble(xal);
                    value=xall;
                    if (value < 0 || value > 100)
                    {
                        goto L4;
                    }
                    else
                    {
                        _point = value;
                    }
                }              
                else
                {
                    _point = value;
                }
            }
        }
        #endregion

        public override string ToString()
        {
            return $"Tələbənin adı: {Name}\n" +
                $"Tələbənin soyadı: {Surname}\n" +
                $"Yaşı: {Age}\n" +
                $"Tələbənin xalı: {Point}";
        }

    }
}
