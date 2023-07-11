namespace EMP;

public class Employee{

    private int EmpId;
    private string EmpName;
    private double EmpSalary;
    private string EmpEmail;
    private string EmpAddress;

    public Employee(int EmpId,string EmpName,double EmpSalary,string EmpEmail,string EmpAddress){

        this.EmpId = EmpId;
        this.EmpName = EmpName;
        this.EmpSalary = EmpSalary;
        this.EmpEmail = EmpEmail;
        this.EmpAddress = EmpAddress;
    }

    public int EMPID {
        get{return this.EmpId;}
        set{this.EmpId = value;}
    }

    public string EMPNAME{
        get{return this.EmpName;}
        set{this.EmpName = value;}
    }

    public double EMPSALARY{
        get{return this.EmpSalary;}
        set{this.EmpSalary = value;}
    }

    public string EMPEMAIL{
        get{return this.EmpEmail;}
        set{this.EmpEmail = value;}
    }

    public string ADDRESS{
        get{return this.EmpAddress;}
        set{this.EmpAddress = value;}
    }

    public override string ToString(){

        return this.EmpId + " | " + this.EmpName + " | " + this.EmpSalary + " | " + this.EmpEmail
        + " | " + this.EmpAddress + " | ";
    } 

    public virtual double ComputeSalary(){

        return this.EmpSalary;
    }
    
}