using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_11_2017_interface
{

    interface IAutoShop {

        //Yevgeniy G
        string CarName { set; get; }
        int MaxSpeed { get; set; }
        int ID { set; get; }

        void ShowInfo();

        void ShowInfo(int prodID);

    }


    public class CarCity : IAutoShop
    {
        public string CarName { set; get; }
        public int MaxSpeed { get; set; }
        public int ID { set; get; }

        public void ShowInfo() { }

        public void ShowInfo(int prodID) { }

    }


    class Program
    {
        static void Main(string[] args)
        {

            IAutoShop shop = new CarCity();


        }
    }
}
