namespace SMS;

public partial class Student{

    private string name;
    public string address;
    public string email;
    public int age;
    public DateTime dob;

    public string NAME{
        get{return this.name;}
        set{this.name = value;}
    }

    // public string NAME{
    //     get{return this.name;}
    //     set{this.name = value;}
    // }

    // public string ADDRESS{
    //     get{return this.address;}
    //     set{this.addresss = value;}
    // }

    // public string EMAIL{
    //     get{return this.email;}
    //     set{this.email = value;}
    // }

    // public int AGE{
    //     get{return this.age;}
    //     set{this.age = value;}
    //  }

    // public DateTime DOB{
    //     get{return this.dob;}
    //     set{this.dob = value;}
    //  }



}