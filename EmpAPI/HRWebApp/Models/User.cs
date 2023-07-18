using System.Globalization;

namespace HRWebApp.Models;

[Serializable]
public class User
{
    public string fullname { get; set; }
    public string address { get; set; }
    public string contact { get; set; }
    public DateTime dob { get; set; }
    public string email { get; set; }
    public string password { get; set; }

    public User(string fullname, string address, string contact, DateTime dob, string email, string password) { 
    
        this.fullname = fullname;
        this.address = address;
        this.contact = contact;
        this.dob = dob;
        this.email = email;
        this.password = password;
    }

    public override string ToString() {

        return " | " + this.fullname + " | " + this.address + " | " + this.contact + " | " + this.email
            + " | " + this.dob + " | ";
    }




}
