using System.ComponentModel.DataAnnotations;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accounts;



public enum EmpType { PERMENANT, TEMPORARY };

namespace EntityLib
{

    [Serializable]
    public class Employee : ISalareable
    {
        private int id;
        private string name;
        private double basicPay;
        private DateTime joiningDate;
        private EmpType empType;

        public Employee(int id, string name, double basicPay, DateTime joiningDate, EmpType empType) { 

            this.id = id;
            this.name = name;
            this.basicPay = basicPay;
            this.joiningDate = joiningDate;
            this.empType = empType;
        }

        public int ID{
            get{return this.id;}
            set{this.id = value; }
        }
        public string NAME
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public double BASICPAY
        {
            get { return this.basicPay; }
            set { this.basicPay = value; }
        }
        public DateTime JOININGDATE
        {
            get { return this.joiningDate; }
            set { this.joiningDate = value; }
        }
        public EmpType EMPTYPE
        {
            get { return this.empType; }
            set { this.empType = value; }
        }

        public double computeSalary()
        {
            double totalSalary = this.basicPay + 2000;

            return totalSalary;           
        }

        public override string ToString()
        {
            return " | ID : " + this.id + " | Name : " + this.name + " | Salary : " + this.computeSalary()
                + " | Joining Date : " + this.joiningDate + " | Type : " + this.empType +" | ";
        }

    }
}
