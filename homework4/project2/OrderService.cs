using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2
{
    class OrderService
    {
        List<Order> orderList = new List<Order>();
        public delegate bool OrderEventHandler(object sender, OrderEventArgs e);
        public event OrderEventHandler Change;
        public Order this[string key]
        {
            set
            {
                int idx = FindKey(key);
                orderList[idx] = value;
            }
            get
            {
                return orderList[FindKey(key)];
            }
        }
        private int FindKey(string key)
        {
            for (int i = 0; i <orderList.Count;i++)
            {
                if (orderList[i].ID == key) return i;
            }
            return -1;
        }
        bool addOpr()
        {
            string product,client;
            int number;
            double price;
            Console.Write("您正在创建一个新的订单！\n请输入商品名：");
            product = Console.ReadLine();
            Console.Write("请输入客户名：");
            client = Console.ReadLine();
            Console.Write("请输入商品数目：");
            number = int.Parse(Console.ReadLine());
            Console.Write("请输入商品单价：");
            price = double.Parse(Console.ReadLine());
            Order a = new Order(product,client,price,number);
            orderList.Add(a);
            Console.WriteLine("\n你已经成功创建了一个订单！\n");
            a.showOrder();
            Console.WriteLine("\n");
            return true;
        }
        bool delOpr()
        {
            bool flag=false;
            string oprID;
            Console.WriteLine("您正在删除某个订单！\n请输入订单号：");
            oprID = Console.ReadLine();
            outer: try
            {
                this[oprID].showOrder();
                Console.WriteLine("你确定想要删除这个订单吗？输入-1确定删除，输入-0返回主界面\n");
                string s = Console.ReadLine();
                if (s == "-0")
                {
                    flag = false;
                }
                else
                {
                    orderList.Remove(this[oprID]);
                    Console.WriteLine("该订单已删除.程序即将返回主界面\n");
                    flag = true;
                }
            }
            catch(System.ArgumentOutOfRangeException e)
            {
                Console.Write("请输入正确的订单号！可以在主界面通过查询功能查询订单号！输入-0返回主界面\n请输入订单号:");
                string s = Console.ReadLine();
                if (s == "-0") flag = false;
                else goto outer;
            }
            catch
            {
                Console.WriteLine("系统出现了bug!即将返回主界面");
                flag=false;
            }
            finally
            {                
            }
            return flag;
        }
        bool serOpr()
        {
            string ID, client, product; 
            Console.WriteLine("\n你正在查找某一个或多个订单！请输入订单号，商品名称，客户名称中的至少一个！");
            Console.Write("订单号：");
            ID=Console.ReadLine();
            Console.Write("商品名称：");
            product = Console.ReadLine();
            Console.Write("客户名称：");
            client = Console.ReadLine();
            Console.WriteLine("\n");
            var m = from n in orderList where ((ID == "" || n.ID == ID) &&(product==""||n.Product==product)&& (client==""||n.orderDetails.client==client)) select n;
            int k = 0;
            foreach(var n in m)
            {
                n.showOrder();
                Console.WriteLine("\n");
                k++;
            }
            Console.WriteLine("\n共找到" + k + "条结果。按回车键返回主菜单");
            Console.ReadLine();
            if (k != 0) return true;
            else return false;
        }
        bool repOpr()
            //应做到可复原性
        {
            bool flag;
            string oprID,client,product,s;
            int number=0;
            double price;
            Console.WriteLine("\n你正在尝试着修改某一个订单！\n请输入你想要修改的订单的订单号：");
            oprID=Console.ReadLine();
            outer: try
            {
                this[oprID].showOrder();
                Console.WriteLine("\n你正在修改上述订单，请输入新的订单信息，如果某一项信息不需要更改请按回车跳过\n");
                Console.WriteLine("原商品名称：" + this[oprID].Product);
                Console.Write("新商品名称：");
                product = Console.ReadLine();
                Console.WriteLine("原顾客名称：" + this[oprID].orderDetails.client);
                Console.Write("新顾客名称：");
                client = Console.ReadLine();
                if (client != "") this[oprID].orderDetails.client = client;
                Console.WriteLine("原单价：" + this[oprID].orderDetails.price);
                Console.Write("新单价：");
                s=Console.ReadLine();
                if (s != "") { price = double.Parse(s); }
                else price = -1;
                Console.WriteLine("原数目：" + this[oprID].orderDetails.number);
                Console.Write("新数目：");
                s = Console.ReadLine();
                if (s != "") { number = int.Parse(s); }
                else number = -1;
                if (product != "") this[oprID].Product = product;
                if (client != "") this[oprID].orderDetails.client = client;
                if (price >= 0) this[oprID].orderDetails.price = price;
                if (number>=0)this[oprID].orderDetails.number = number;
                this[oprID].TotalPrice = this[oprID].orderDetails.price * this[oprID].orderDetails.number;
                Console.WriteLine("修改完成！新的订单为：");
                this[oprID].showOrder();
                Console.WriteLine("程序即将返回主界面：");
                flag = true;
            }
            catch (System.ArgumentOutOfRangeException e)
            {
                Console.Write("请输入正确的订单号！可以在主界面通过查询功能查询订单号！输入-0返回主界面\n请输入订单号:");
                string t = Console.ReadLine();
                if (t == "-0") flag = false;
                else goto outer;
            }
            catch(System.FormatException e)
            {
                Console.WriteLine("输入格式不正确！订单修改失败！系统将返回主菜单！");
                flag = false;
            }
            catch
            {
                Console.WriteLine("系统出现了bug!即将返回主界面");
                flag = false;
            }
           
            finally
            {
            }
            return flag;
        }
        bool OrderProgress(object sender,OrderEventArgs e)
        {
            if (e.operate == "-1") return addOpr();
            if (e.operate == "-2") return delOpr();
            if (e.operate == "-3") return serOpr();
            if (e.operate == "-4") return repOpr();
            return false;
        }
        public static void Main()
        {
            OrderService orderService=new OrderService();
            orderService.Change += orderService.OrderProgress;
            string s;
            do
            {
                Console.WriteLine("订单管理系统1.0");
                Console.WriteLine("请输入你想执行的操作\n-1 增加一个订单\n-2 删除一个订单\n-3 查找一个订单\n-4 修改一个订单\n-0 退出");
                s = Console.ReadLine();
                OrderEventArgs args = new OrderEventArgs();
                args.operate = s;
                orderService.Change(orderService,args);
            } while (s != "-0");
        }        
    }
}
