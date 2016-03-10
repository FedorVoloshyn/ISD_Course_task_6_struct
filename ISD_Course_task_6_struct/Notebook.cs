using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_Course_task_6_struct
{
    struct Notebook
    {
        string brand;
        string model;
        int price;
        public Notebook(string brand, string model, int price)
        {
            this.brand = brand;
            this.model = model;
            this.price = price;
        }
        public void Show()
        {
            Console.WriteLine("Notebook.\nModel: {0}\nBrand: {1}\nPrice: {2}", model, brand, price);
        }
    }
}
