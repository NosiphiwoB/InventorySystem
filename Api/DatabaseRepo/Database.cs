using Api.Models;
namespace Api.DatabaseRepo
{
    public class Database
    {
        /***
        1. database connection.
        2. create all database queriers here.

        getProductsByWarehouse(string warehouseName){
            return db.InventoryManagement.where((val)=>val=== warehouseName)
        }(in future)


        List warehouses = [{id:'1',warehouseName:'walmart'},{id:'2',warehouseName:'game'}]
        List products = [{id:'1',warehouseId:'1', productName:'Max Bicycle', price:'1200', currency:'Rands'},{id:'2',warehouseId:'1', productName:'USN WHEY chocolate',price:'700', currency:'Rands'},{id:'3',warehouseId:'2', productName:'Max Bicycle', price:'1200', currency:'Rands'},{id:'4',warehouseId:'2', productName:'USN WHEY chocolate',price:'700', currency:'Rands'}]
        List order = [{}]

        */
        private readonly List<User> users = new(){
            new User {Id=1, Name="Mark", Role="Admin"},
            new User {Id=2, Name="Noxolo", Role="Manager"}
        };

        public Boolean createUser(User details){
            users.Add(details);
            return true;
        }
    }
}