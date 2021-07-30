using DisneyWorld.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DisneyWorld.Dal
{
    public class UserDal
    {
        public string SaveUser(User user)
        {
            string txtName = @"C:\DisneyWorld\User.txt";
            string userpass = user.Username + "," + user.Password + Environment.NewLine;
            List<string> users = new List<string>();
            users.Add(userpass);

            if (File.Exists(txtName))
            {
                File.AppendAllText(txtName, userpass);
            }
            else
            {
                File.WriteAllLines(txtName, users);
            }

            return "se guardo el usuario";

        }
        public bool ValidateUser(User user)
        {
            
            string txtName = @"c:\DisneyWorld\User.txt";

            
            if (File.Exists(txtName))
            {
               
                string[] Users = File.ReadAllLines(txtName);

                
                string usrPass;
                string usrName;

               
                foreach (var usr in Users)
                {
                  
                    try
                    {
                      
                        usrPass = usr.Substring(user.Username.Length+1);
                  
                        usrName = usr.Substring(0, user.Username.Length);
                    }
                    catch (Exception)
                    {

                        return false;

                    }

                  
                    if (usrName == user.Username && usrPass == user.Password)
                    {

                        return true;
                    }
                }


            }
            else
            {
                return false;
            }

            return false;

        }
    }
}
