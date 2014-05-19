using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
    }
}
