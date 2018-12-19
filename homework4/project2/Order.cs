using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2
{
    class Order
    {
        public string ID { get; }
        public string Product { set; get; } = "";
        public double TotalPrice { set; get; }
        public OrderDetails orderDetails;
        public class OrderDetails
        {
            public string client = "";
            public double price;
            public int number;
            public OrderDetails(string client,double price,int number)
            {
                this.client = client;
                this.price = price;
                this.number = number;
            }
        }
        static int totalID = 0;
        static public string makeID()
        {
            totalID++;
            return (""+DateTime.Now.Year+DateTime.Now.Month+DateTime.Now.Day+totalID.ToString().PadLeft(4,'0'));
        }
        public Order()
        {
        }
        public Order(string product,string client,double price,int number)
        {
            ID = makeID();
            Product = product;
            orderDetails = new OrderDetails(client,price,number);
            TotalPrice = orderDetails.price * orderDetails.number;
        }
       
        public void showOrder()
        {
            Console.WriteLine("订单号：" + ID);
            Console.WriteLine("商品名：" + Product);
            Console.WriteLine("客户名称：" + orderDetails.client); 
            Console.WriteLine("商品单价：" + orderDetails.price);
            Console.WriteLine("商品数目：" + orderDetails.number);
            Console.WriteLine("商品总价：" + TotalPrice);
        }
    }
}
