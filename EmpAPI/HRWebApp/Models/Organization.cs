using System.Globalization;

namespace HRWebApp.Models
{
    public class Organization
    {
        public string orgname { get; set; }

        public List<User> userList { get; set; }

        public Organization(string orgname) {

            this.orgname = orgname;
            this.userList = new List<User>();
        }

    }
}
