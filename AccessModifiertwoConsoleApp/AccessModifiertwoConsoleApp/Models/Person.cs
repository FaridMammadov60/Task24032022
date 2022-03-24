using System;
using System.Text.RegularExpressions;

namespace AccessModifiertwoConsoleApp.Models
{
    internal class Person
    {
        #region Fields
        string _name;
        string _surname;
        byte _age;
        #endregion

        #region Construction
        public Person(string name, byte age)
        {
            this.Name = name;
            this.Age = age;
        }
        #endregion

        #region Property
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (IlkHerf(value) == true && value.Length >= 3 && value.Length <= 30)
                {
                    _name = value;
                }                
                else
                {
                    Console.WriteLine("sehv");
                    return;
                }
            }
        }
        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                if (IlkHerf(value) == true && value.Length >= 3 && value.Length <= 35)
                {
                    _surname = value;
                }
                else
                {
                    Console.WriteLine("sehv");
                    return;
                }
            }
        }
        public byte Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Yaş mənfi ola bilmez");
                    return;
                }
                else if (value > 255)
                {
                    Console.WriteLine("Yaş bu qədər ola bilmez");
                    return;
                }
                else
                {
                    _age = value;
                }
            }
        }
        #endregion

        #region Method
        private bool IlkHerf(string word)
        {
            char a = 'a';
            for (int i = 0; i < word.Length; i++)
            {
                a = word[0];
            }
            string name = Convert.ToString(a);
            int upperCount = Regex.Matches(name, @"[A-Z]").Count;
            if (upperCount == 0)
            {
                return false;
            }
            return true;
        }
        #endregion

        public override string ToString()
        {
            return $"Adamın adı: {Name}\n" +
                $"Adamın soyadı: {Surname}\n" +
                $"Yaşı: {Age}";
        }
    }
}
