using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kianwaters_s00187504;

namespace Databse
{
    class Program
    {
        static void Main(string[] args)
        {
            Phone db = new Phone();

            using (db)
            {
                Phones phones1 = new Phones(1, "Samsung S20", 500, "Android", "/images/android.png", "/images/s20.jpg");
                Phones phones2 = new Phones(2, "iPhone 11", 600, "IOS", "/images/apple.png", "/images/iphone11.jpg");
                    
                db.Phones.Add(phones1);
                db.Phones.Add(phones2);

                db.SaveChanges();
            }
        }
    }
}
