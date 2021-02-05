using InterfaceAbstractDemo.Concrete;
using System;

namespace InterfaceAbstractDemo.Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new NeroCustomerManager();
            customerManager.Save(new Customer { DateOfBirth = new DateTime(1985, 1, 6), FirstName = "Engin", LastName = "Demiroğ", NationalityId = "2626262626" });
            Console.ReadLine();

        }
    }
}
