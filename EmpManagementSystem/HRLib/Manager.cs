namespace MNG;

using EMP;

public class Manager:Employee{

    private double TAllowance;
    private double HInsurance;

//int id,string name,double salary,string email,string address

    public Manager(double TAllowance,double HInsurance,int EmpId,string EmpName,double EmpSalary,string EmpEmail,string EmpAddress):base(EmpId,EmpName,EmpSalary,EmpEmail,EmpAddress){

        this.TAllowance = TAllowance;
        this.HInsurance = HInsurance;
    }

    public double TALLOWANCE{
        get{return this.TAllowance;}
        set{this.TAllowance = value;}
    }

    public double HINSURANCE{
        get{return this.HInsurance;}
        set{this.HInsurance = value;}
    }

    public override string ToString(){

        string DataFromParent = base.ToString();
        return DataFromParent + this.TAllowance + " | " + this.HInsurance + " | ";    
    }

    public override double ComputeSalary(){

        double BaseSalary = base.ComputeSalary();
        return BaseSalary + this.TAllowance + this.HInsurance;
    }

}