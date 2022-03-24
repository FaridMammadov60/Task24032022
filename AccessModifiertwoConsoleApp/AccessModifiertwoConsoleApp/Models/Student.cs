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
                if (value < 0)
                {
                    Console.WriteLine("Point mənfi ola bilmez");
                    return;
                }
                else if (value > 100)
                {
                    Console.WriteLine("Yüzdən çox ola bilmez");
                    return;
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
