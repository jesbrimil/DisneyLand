using DisneyWorld.Dal;
using DisneyWorld.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DisneyWorld.Controllers
{
    public class UserController : ApiController
    {
        public string Register([FromBody] User user)
        {
            UserDal dal = new UserDal();
            return dal.SaveUser(user);
        }

        public string Login([FromBody] User user)
        {
            
            UserDal dal = new UserDal();
           
            if (dal.ValidateUser(user))
            {
                return "se ha logeado correctamente";

            }
           
            return "no se ha encontrado el usuario";

        }
    }
}
