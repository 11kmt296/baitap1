using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace baitap1.C_
{
    class Student
    {
        /**
         * Name
         * Họ và Tên
         * Name string
         */
        private string _name;
        public string Name
        {
            get
            {
                return "Sinh viên " + this._name;
            }
            set
            {
                this._name = value;
            }
        }
        /**
         * password
         * password để đăng nhập
         * @password string
         */
        private string _password;
        public string password
        {

            get
            {
                return this._password; 
            }
            set
            {
                HashAlgorithm hassword = new MD5CryptoServiceProvider();

                byte[] hassbyte = hassword.ComputeHash(Encoding.UTF8.GetBytes(value));

                this._password = Convert.ToBase64String(hassbyte);
            }

        }
        
    }
}
