namespace Api.Controllers
{
    public class WarehouseController
    {
        //Everything that has to do with warehouse
        /**
        Create Warehouse
        Read warehouse data
        Update warehouse data
        Delete warehouse will come later
        */

        public bool addWarehouse(warehouse addWarehouse){
            Console.WriteLine("test: "+ addWarehouse);
            var databaseRepo = new Database();
            return databaseRepo.createUser(addWarehouse);
        } 
    }
}