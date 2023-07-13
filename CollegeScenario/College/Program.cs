

using STUD;
using IACSD;
using CDAC;

Console.WriteLine("Hello World, This Is Somesh Prem, Live From Planet Earth ...");

//int rollNo,string name,string course,int cceScore,bool isDesciplined,int attendance,string projectName,bool isProjectCompleted3557

Student S1 = new Student(1,"XYZ","DAC",89,true,78,"Java",true);
IInstitutable Ins1 = S1;
IPlaceable Plc1 = S1;

Console.WriteLine(Ins1.Attendance());
Console.WriteLine(Ins1.Discipline());
Console.WriteLine(Plc1.CCEPassing());
Console.WriteLine(Plc1.ProjectClearance());

Console.WriteLine(" ");

Student S2 = new Student(2,"ABC","DBDA",42,true,78,"Java",false);
IInstitutable Ins2 = S2;
IPlaceable Plc2 = S2;

Console.WriteLine(Ins2.Attendance());
Console.WriteLine(Ins2.Discipline());
Console.WriteLine(Plc2.CCEPassing());
Console.WriteLine(Plc2.ProjectClearance());