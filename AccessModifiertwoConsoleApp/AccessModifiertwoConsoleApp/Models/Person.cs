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

                if (IlkHerf(value) && value.Length >= 3 && value.Length <= 30)
                {
                    _name = value;
                }
                else
                {
                L1: Console.Write("İlk hərfi böyük, uzunluğu minumum 3 maksimum 30 simvollu ad daxil edin:");

                    string ad = Console.ReadLine();
                    value = ad;
                    if (IlkHerf(value) && value.Length >= 3 && value.Length <= 30)
                    {
                        _name = value;
                    }
                    else
                    {
                        goto L1;
                    }
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
                if (IlkHerf(value) && value.Length >= 3 && value.Length <= 35)
                {
                    _surname = value;
                }
                else
                {
                L2: Console.Write("İlk hərfi böyük, uzunluğu minumum 3 maksimum 30 simvollu soyad daxil edin:");

                    string soyad = Console.ReadLine();
                    value = soyad;
                    if (IlkHerf(value) && value.Length >= 3 && value.Length <= 30)
                    {
                        _surname = value;
                    }
                    else
                    {
                        goto L2;
                    }
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

                if (value < 0 || value > 150)
                {
                    Console.WriteLine("Yaşı doğru daxil edin: ");
                L3: string yasi = Console.ReadLine();
                    byte yas = Convert.ToByte(yasi);
                    value = yas;
                    if (value < 0 && value > 150)
                    {
                        Console.WriteLine("Yaşı doğru daxil edin: ");
                        goto L3;
                    }
                    else
                    {
                        _age = value;
                    }
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
                Console.WriteLine("Diqqət ilk herf boyuk deyil");
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
