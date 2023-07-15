using System.ComponentModel.DataAnnotations;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLib
{
    [Serializable]
    public class Company
    {
        private string companyName;

        private string licNo;

        private List<Employee> empList;

        public string COMPANYNAME { get {  return companyName; } set {  companyName = value; } }
        public string LICNO { get { return licNo; } set { licNo = value; } }
        public List<Employee> EmpList { get {  return empList; } set {  empList = value; } }       

        public Company(string companyName, string licNo) { 
        
            this.companyName=companyName;
            this.licNo=licNo;
            this.empList=new List<Employee> ();              
                
        }

        public override string ToString()
        {
            return " | Company Name : " +this.companyName + " | Lic No : " + this.licNo ;
        }

    }
}
