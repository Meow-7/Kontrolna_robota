using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    class Human
    {
        private string _name;
        private string _surname; 
        private int _age;
        private Address _adr;

        public Human(string name, string surname, int age, Address address)
        {
            this._name = name;
            this._surname = surname;
            this._age = age;
            this._adr = address;
       
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
        public Address Adr
        {
            get { return _adr; }
            set { _adr = value; }
        }
    }
    class Address
    {
        private string _street;
        private int _house;

        public Address(string street, int house)
        {
            this._street = street;
            this._house = house;
        }
        
        public string Street
        {
            get { return _street; }
            set { _street = value; }
        }
        public int House
        {
            get { return _house; }
            set{ _house = value; }
        }
    }
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
