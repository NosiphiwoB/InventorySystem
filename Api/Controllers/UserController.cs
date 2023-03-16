using Api.Models;
using Api.DatabaseRepo;
namespace Api.Controllers
{
    public class UserController
    {    
        //Everything that has to do with user
        /**
        Create user


        Read user data
        Update user data
        Delete user will come later
        */

        public bool addUser(User userDetails){
            Console.WriteLine("test: "+ userDetails);
            var databaseRepo = new Database();
            return databaseRepo.createUser(userDetails);
        } 
    }
}