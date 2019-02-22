using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadawansTask13
{
    class Employee
    {
        private string _Surname;
        private int _Age;

        public Employee()
        {
            _Surname = string.Empty;
            _Age = 0;
        }

        public Employee(string surname, int age)
        {
            if (age == 0)
            {
                throw new ArgumentNullException();
            }
            _Surname = surname ?? throw new ArgumentNullException();
            _Age = age;
        }
        public Employee(string surname1, string surname2, int age)
        {
            if (age == 0)
            {
                throw new ArgumentNullException();
            }
           string surname = surname1 + surname2;
            _Surname = surname ?? throw new ArgumentNullException();
            _Age = age;
        }
        private string GetEmployeeAge()
        {
            return _Age.ToString();
        }
        public void Set_Surname(string surname)
        {
            _Surname = surname ?? throw new ArgumentNullException();
        }
        public string Get_Employee_Information()
        {
            return ("Surname: " + this._Surname + ", Age: " + this._Age);
        }
        public string Set_New_Surname_And_Get_Employee_Info(string surname)
        {
            this._Surname = surname;
            return ("Surname: "+this._Surname+", Age: "+this._Age);
        }       //   Surname: Ivanov, Age: 25
        private string Private_Method_With_String_Return_Type()
        {
            Employee em = new Employee();
            
            return em.GetType().ToString();
        }
    }
}
