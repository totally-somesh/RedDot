using System.ComponentModel.DataAnnotations;

using Accounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accounts;
namespace EntityLib
{

    [Serializable]
    public class Manager : Employee, ISalareable
    {
        private double TAllowance;
        private double HInsurance;

        public Manager(double TAllowance, double HInsurance, int managerId, 
            string managerName, double managerBasicPay, DateTime joiningDate, 
            EmpType empType) :base(managerId, managerName, managerBasicPay, 
                joiningDate, empType) {

            this.TAllowance = TAllowance;
            this.HInsurance = HInsurance;
        }

        public double TALLOWANCE { get { return this.TAllowance; } set { this.TAllowance = value; } }
        public double HINSURANCE { get { return this.HInsurance; } set { this.HInsurance = value; } }


        public double computeSalary()
        {
            double totalSalary = base.computeSalary() + 10000;

            return totalSalary;
        }

        public override string ToString()
        {
            return base.ToString() + " | Total Salary : " +this.computeSalary();
        }


    }
}
