
using System.Text.Json;
using System.Collections.Generic;
using HRWebApp.Models;

namespace HRWebApp.Persistence
{
    public class Serialize
    {
        public static void Serialization(List<User> usersList) {

            var options = new JsonSerializerOptions { IncludeFields = true };

            var userJson = JsonSerializer.Serialize<List<User>>(usersList, options);

            string fileName = @"D:\CDAC\DotNet\EmpAPI\USERSLIST.json";

            File.WriteAllText(fileName, userJson);
            
        }

        public static List<User> DeSerialization(string fileName) {

            string data = File.ReadAllText(fileName);

            List<User> userList = JsonSerializer.Deserialize<List<User>>(data);

            return userList;        
        }

        public static bool existenceChecking(string fileName) {

            if (File.Exists(fileName)) { 
            
                return true;            
            }

            return false;        
        }

    }
}
