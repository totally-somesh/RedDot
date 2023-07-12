namespace SMS;

public partial class Student{

    public int id;
    
    // public override string ToString(){

    //     string StudentData = String.Format("{0},{1},{2},{3},{4},{5},{6},{7}", this.id,this.name,this.address,this.email,this.age,this.dob,this.qualification,this.percentage
    //     ); 

    //     return StudentData;
    // }

    public override string ToString(){

        return this.id + " | " + this.name + " | " + this.address + " | " + this.email + " | " + this.age + " | " + this.dob + " | " + this.qualification + " | " + this.percentage + " | ";
    }

    // public Student(int id){

    //     this.id = id;
    // }

    // public int ID{
    //     get{return this.id;}
    //     set{this.id = value;}
    // }

    // public string ToString(){

    //     return this.id;
    // } 



}  