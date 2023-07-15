using EntityLib;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

// See https://aka.ms/new-console-template for more information
Console.WriteLine(" ---< Welcome To TransFlower Pvt. Ltd. >--- ");
Console.WriteLine(" ");


Company TransFlower = new Company("TransFlower Pvt. Ltd.","IND-123/Pune");

bool exit = false;

List<Employee> MainList = new List<Employee>();

string DfileName = @"D:\List123.json";

string dataForSerialization = File.ReadAllText(DfileName);

List<Employee> EmpList = JsonSerializer.Deserialize<List<Employee>>(dataForSerialization);
Console.WriteLine(" ---< Congratulations, DeSerialization Completed Succesfully ! >--- ");
Console.WriteLine(" ");

Console.WriteLine(" ");

MainList = EmpList;

Console.WriteLine(" ");

while (!exit) {

    Console.WriteLine("Press 1 :To Add New Employee | 2.To Check List Of Employees " +
        "| 3.Default Employees | 4.Default Managers | 5.To Check List Of Managers |" +
        " 6.Sort By EmpType | 7. Serialize  | 8. DeSerialize | 9.Exit ");

    string choice = Console.ReadLine();

    switch (choice) {

        case "1":

            Console.WriteLine(" ---< Please Enter : ID | Name | Basic Pay | Joining Date | Emp Type >--- ");

            int newId = Convert.ToInt32(Console.ReadLine());
            string newName = Console.ReadLine();
            double newBasicPay = Convert.ToDouble(Console.ReadLine());
            DateTime newJDate = DateTime.Parse(Console.ReadLine());
            EmpType newEmpType = Enum.Parse<EmpType>(Console.ReadLine());

            Employee newEmp = new Employee(newId, newName, newBasicPay, newJDate, newEmpType);

            MainList.Add(newEmp);

            Console.WriteLine("  ");
            break;

        case "2":

            Console.WriteLine(" ---< TransFlower's Employee List >--- ");
            //List<Employee> EList = TransFlower.EmpList;

            foreach (var E in MainList)
            {
                if (E.GetType() == typeof(Employee))
                {
                    Console.WriteLine(E);
                }
            }

            Console.WriteLine("  ");
            break;

        case "3":

            Employee EMP1 = new Employee(1, "XYZ", 10000, new DateTime(2022, 01, 01), Enum.Parse<EmpType>("TEMPORARY"));
            Employee EMP2 = new Employee(2, "ABC", 10000, new DateTime(2020, 01, 01), Enum.Parse<EmpType>("PERMENANT"));
            Employee EMP3 = new Employee(3, "LMN", 10000, new DateTime(2021, 06, 01), Enum.Parse<EmpType>("TEMPORARY"));
            Employee EMP4 = new Employee(4, "DEF", 10000, new DateTime(2019, 01, 01), Enum.Parse<EmpType>("PERMENANT"));
            Employee EMP5 = new Employee(5, "PQR", 10000, new DateTime(2020, 06, 01), Enum.Parse<EmpType>("TEMPORARY"));

            MainList.Add(EMP1);
            MainList.Add(EMP2);
            MainList.Add(EMP3);
            MainList.Add(EMP4);
            MainList.Add(EMP5);

            Console.WriteLine(" ---< Default Employees Added To The Company Succesfully ! >--- ");

            Console.WriteLine("  ");
            break;

        case "4":

            //double TAllowance, double HInsurance, int managerId, 
            //string managerName, double managerBasicPay, DateTime joiningDate, 
            //EmpType empType) :base(managerId, managerName, managerBasicPay,
            //joiningDate, empType

            Manager M1 = new Manager(5000, 5000, 201, "XYZ", 20000, new DateTime(2023, 01, 01), Enum.Parse<EmpType>("TEMPORARY"));
            Manager M2 = new Manager(5000, 5000, 202, "PQR", 20000, new DateTime(2022, 01, 01), Enum.Parse<EmpType>("TEMPORARY"));
            Manager M3 = new Manager(5000, 5000, 203, "ABC", 20000, new DateTime(2020, 01, 01), Enum.Parse<EmpType>("PERMENANT"));
            Manager M4 = new Manager(5000, 5000, 204, "DEF", 20000, new DateTime(2021, 06, 01), Enum.Parse<EmpType>("TEMPORARY"));
            Manager M5 = new Manager(5000, 5000, 205, "LMN", 20000, new DateTime(2019, 01, 01), Enum.Parse<EmpType>("PERMENANT"));

            MainList.Add(M1);
            MainList.Add(M2);
            MainList.Add(M3);
            MainList.Add(M4);
            MainList.Add(M5);

            Console.WriteLine(" ---< Default Managers Added To The Company Succesfully ! >--- ");

            Console.WriteLine("  ");
            break;

        case "5":

            Console.WriteLine(" ---< TransFlower's Managers List >--- ");
    
            foreach (var E in MainList)
            {
                if (E.GetType() == typeof(Manager))
                {
                    Console.WriteLine(E);
                }
            }

            Console.WriteLine("  ");
            break;

        case "6":

            Console.WriteLine(" ---< Welcome To Transflower Pvt. Ltd.>--- ");

            Console.WriteLine(" ");
            Console.WriteLine(" Employees Are Divided Into 2 Types : PERMENANT  |  TEMPORARY ");
            Console.WriteLine(" ");
            
            Console.WriteLine("Please Press : | 1. PERMENANT Employees | 2. TEMPORARY Employees " +
                "| 3. Cancel ");
            string empTypeChoice = Console.ReadLine();
            Console.WriteLine(" ");

            List<Employee> SList = TransFlower.EmpList;
            bool whileCheck = false;
            while (!whileCheck) {
                switch (empTypeChoice) {

                    case "1":

                        Console.WriteLine(" ---< TransFlower's Permenant Employees' List >--- ");

                        foreach (Employee E in SList) {

                            string EnumType = EmpType.PERMENANT.ToString();
                            string parsedEnum = E.EMPTYPE.ToString();

                            if (parsedEnum == EnumType) {

                                Console.WriteLine(E);
                            }//end of if
                        }//end of foreach loop

                        whileCheck = true;
                        break;

                    case "2":

                        Console.WriteLine(" ---< TransFlower's Temporary Employees' List >--- ");

                        foreach (Employee E in SList)
                        {

                            string EnumType = EmpType.TEMPORARY.ToString();
                            string parsedEnum = E.EMPTYPE.ToString();

                            if (parsedEnum == EnumType)
                            {

                                Console.WriteLine(E);
                            }//end of if
                        }//end of foreach loop

                        whileCheck = true;
                        break;

                    case "3":

                        Console.WriteLine(" ---< Going To Main Menu >--- ");
                        whileCheck = true;

                        break;

                    default:

                      Console.WriteLine(" ---< Invalid Choice ! Please Enter A Valid Choice : 1 | 2 >--- ");
                        
                    break;

                }//end of switch

            }//end of while

            Console.WriteLine("  ");
            break;


        case "7":

           
            //Serialization
            var options = new JsonSerializerOptions { IncludeFields = true };

            var empListJSON = JsonSerializer.Serialize<List<Employee>>(MainList, options);

            string SfileName = @"D:\List123.json";

            File.WriteAllText(SfileName, empListJSON);

            Console.WriteLine(" ---< Congratulations, Serialization Completed Succesfully ! >--- ");

            break;

        case "8":
            string DfileName1 = @"D:\List123.json";

            string dataForSerialization1 = File.ReadAllText(DfileName1);

            List<Employee> EmpList1 = JsonSerializer.Deserialize<List<Employee>>(dataForSerialization1);
            Console.WriteLine(" ---< Congratulations, DeSerialization Completed Succesfully ! >--- ");
            Console.WriteLine(" ");

            break;

        case "9":

            Console.WriteLine(" ---< All Employees Of TransFlower Pvt. Ltd. >--- ");
            Console.WriteLine("");

            foreach (Employee E in MainList) {

                Console.WriteLine(E);
            }

            break;










        default:

            exit = true;

            break; }
}//end of while

Console.WriteLine(" ---< Thank You ! Please Visit Again ! >--- ");