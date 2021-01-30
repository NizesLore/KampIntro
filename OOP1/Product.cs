using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    //snippet
    class Product // Entity Varlik
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        //urun birim fiyati
        public double UnitPrice { get; set; }
        //stok adedi
        public int UnitsInStock { get; set; }

        //CRUD operasyonları -Create Read Update Delete 
    }
}
