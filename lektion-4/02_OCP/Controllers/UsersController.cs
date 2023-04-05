using _02_OCP.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _02_OCP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {

        [HttpGet]
        public IActionResult Get()
        {
            List<User> users = new List<User>();

            users.Add(new AdminUser() { Id = 1, UserName = "hans.mattin-lassei", RoleName = "admin", Password = "BytMig123!" });
            users.Add(new StandardUser() { Id = 2, UserName = "johan.andersson", Password = "BytMig123!", Membership = "Gold" });
            users.Add(new StandardUser() { Id = 3, UserName = "ali.Alkaan", Password = "BytMig123!", Membership = "Silver" });

            List<AdminUser> admins = new List<AdminUser>();

            foreach(var user in users)
            {
                if (user is AdminUser)
                    admins.Add((AdminUser)user);
            }

            return Ok(admins);
        }
    }
}
