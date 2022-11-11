namespace ShopProject.Models 
{
    public class Tech 
    {
        public string name {get;set;}
        public int price {get;set;}
        public int[] range {get;set;}
        public int percent {get;set;}
    }
    public class Db 
    {
        public Tech[] db {get;set;}
    }

}