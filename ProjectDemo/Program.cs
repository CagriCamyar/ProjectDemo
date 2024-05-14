using System;

namespace ProjectDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager (new MernisServiceAdapter());
            customerManager.Save(new Customer {DateOfBirth = new DateTime(1995,11,01), Name = "Furkan Çağrı" , Surname = "Çamyar", NationalityId ="21593567558"}) ; 
        } 
    }
}