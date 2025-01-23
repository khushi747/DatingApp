using API.Entities;
using Microsoft.AspNetCore.Mvc;
namespace API;

[ApiContoller]
[Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        public UserController(){

        }
        
        [HttpGet]
        public ActionResult <IEnumerable <AppUser>> GetUsers(){
            
        }
    }
