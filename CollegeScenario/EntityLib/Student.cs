namespace STUD;

using CDAC;
using IACSD;

public class Student : IPlaceable, IInstitutable{

    public int rollNo;
    public string name;
    public string course;
    public int cceScore;
    public bool isDesciplined;
    public int attendance;
    public string projectName;
    public bool isProjectCompleted;

    public Student(int rollNo,string name,string course,int cceScore,bool isDesciplined,int attendance,string projectName,bool isProjectCompleted){

        this.rollNo = rollNo;
        this.name = name;
        this.course = course;
        this.cceScore = cceScore;
        this.isDesciplined = isDesciplined;
        this.attendance = attendance;
        this.projectName = projectName;
        this.isProjectCompleted = isProjectCompleted;
    }//end of constructor

    string IInstitutable.Attendance(){

        if(this.attendance > 75){
            
            return "The Student With Roll No : " +this.rollNo + " Has Good Attendance !";
        }
        else{
            
            return "The Student With Roll No : " +this.rollNo + " Has Less Attendance !";
        }

    }

    string IInstitutable.Discipline(){

        if(this.isDesciplined){

            return "The Student With Roll No : " +this.rollNo + " Has Followed Descipline Rules !";
        }
        else{
            return "The Student With Roll No : " +this.rollNo + " Has Not Followed Descipline Rules !";
        }
    }

    string IPlaceable.CCEPassing(){

        if(this.cceScore > 75){
            return "The Student With Roll No : " +this.rollNo + " Has Succesfully Passed The CCE !";
        }
        else{
            return "The Student With Roll No : " +this.rollNo + " Has Failed In The CCE Miserably !";
        }
    }
    
    string IPlaceable.ProjectClearance(){

        if(this.isProjectCompleted){
            return "The Student With Roll No : " +this.rollNo + " Has Completed The Project !";
        }else{
            return "The Student With Roll No : " +this.rollNo + " Has Not Completed The Project !";
        }
    }

    public override string ToString(){

        return " | " +this.rollNo + " | " + this.name + " | " + this.course + " | " + this.cceScore + " | " + this.isDesciplined + " | " + this.attendance + " | " + this.projectName + " | " + this.isProjectCompleted + " | ";
    }//end of ToString

}