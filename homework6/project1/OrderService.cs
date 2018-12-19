using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Text.RegularExpressions;

namespace project1
{
    [Serializable]
    public class OrderService
    {
        List<Order> orderList = new List<Order>();
        public delegate bool OrderEventHandler(object sender, OrderEventArgs e);
        public event OrderEventHandler Change;
        public Order this[string key]   //以订单号(ID)作为关键字的索引器
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
            for (int i = 0; i < orderList.Count; i++)
            {
                if (orderList[i].ID == key) return i;
            }
            return -1;
        }
        bool addOpr()
        {
            string product, client;
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
            Order a = new Order(product, client, price, number);
            orderList.Add(a);
            Console.WriteLine("\n你已经成功创建了一个订单！\n");
            a.showOrder();
            Console.WriteLine("\n");
            return true;
        }
        bool delOpr()
        {
            bool flag = false;
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
            catch (System.ArgumentOutOfRangeException e)
            {
                Console.Write("请输入正确的订单号！可以在主界面通过查询功能查询订单号！输入-0返回主界面\n请输入订单号:");
                string s = Console.ReadLine();
                if (s == "-0") flag = false;
                else goto outer;
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
        bool serOpr()
        {
            string ID, client, product;
            string totalPrice;
            Console.WriteLine("\n你正在查找某一个或多个订单！请输入订单号，商品名称，客户名称，总金额中的至少一个！输入回车键可跳过某一信息的输入");
            Console.Write("订单号：");
            ID = Console.ReadLine();
            Console.Write("商品名称：");
            product = Console.ReadLine();
            Console.Write("客户名称：");
            client = Console.ReadLine();
            Console.Write("总金额大于多少：");
            totalPrice = Console.ReadLine();
            Console.WriteLine("\n");
            var m = from n in orderList where ((ID == "" || n.ID == ID) && (product == "" || n.Product == product) && (client == "" || n.orderDetails.client == client) && (totalPrice == "" || n.TotalPrice > int.Parse(totalPrice))) select n;
            int k = 0;
            foreach (var n in m)
            {
                n.showOrder();
                Console.WriteLine("\n");
                k++;
            }
            Console.WriteLine("共找到" + k + "条结果。按回车键返回主菜单\n");
            Console.ReadLine();
            if (k != 0) return true;
            else return false;
        }
        bool repOpr()
        //应做到可复原性
        {
            bool flag;
            string oprID, client, product, s;
            int number = 0;
            double price;
            Console.WriteLine("\n你正在尝试着修改某一个订单！\n请输入你想要修改的订单的订单号：");
            oprID = Console.ReadLine();
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
                s = Console.ReadLine();
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
                if (number >= 0) this[oprID].orderDetails.number = number;
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
            catch (System.FormatException e)
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

        //为测试用例编写带参数的增删查改程序
        //为了查看错误输入导致的单元测试结果，四个带参数的成员函数均未使用try..catch..finally异常处理机制

        public bool addOpr(string product,string client,double price, int number)
        {
            Order a = new Order(product, client, price, number);
            orderList.Add(a);
         //   Console.WriteLine("您已经创建了一个新的订单！");
            return true;
        }
        public bool delOpr(string ID)
        {
            orderList.Remove(this[ID]);
            return true;
        }
        public bool serOpr(string ID,string product,string client,double totalPriceLowBound)
        {
            var m = from n in orderList where ((ID == "" || n.ID == ID) && (product == "" || n.Product == product) && (client == "" || n.orderDetails.client == client) && (n.TotalPrice > totalPriceLowBound)) select n;
            int k = 0;
            foreach (var n in m)
            {
                n.showOrder();
                Console.WriteLine("\n");
                k++;
            }
            Console.WriteLine("共找到" + k + "条结果。\n");
            return true;
        }
        public bool repOpr(string ID,string product,string client,double price,int number)
        {
            if (product != "") this[ID].Product = product;
            if (client != "") this[ID].orderDetails.client = client;
            if (price >= 0) this[ID].orderDetails.price = price;
            if (number >= 0) this[ID].orderDetails.number = number;
            this[ID].TotalPrice = this[ID].orderDetails.price * this[ID].orderDetails.number;
            return true;
        }


        bool OrderProgress(object sender, OrderEventArgs e)
        {
            if (e.operate == "-1") return addOpr();
            if (e.operate == "-2") return delOpr();
            if (e.operate == "-3") return serOpr();
            if (e.operate == "-4") return repOpr();
            if (e.operate == "-5") return import();
            if (e.operate == "-6") return export();
            return false;
        }
        bool export()
        {
            XmlSerializer xmlser = new XmlSerializer(typeof(List<Order>));
            string xmlFileName = "s.xml";
            XmlSerialize(xmlser, xmlFileName, orderList);
            Console.WriteLine("保存成功！\n");
            //显示XML文本
            /*
            string xml = File.ReadAllText(xmlFileName);
            Console.WriteLine(xml);
            */
            return true;
        }
        static void XmlSerialize(XmlSerializer ser,string fileName, object obj)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create);
            ser.Serialize(fs, obj);
            fs.Close();
        }
        bool import()
        {
            XmlSerializer xmlser = new XmlSerializer(typeof(List<Order>));
            string xmlFileName = "s.xml";
            XmlDeserialize(xmlser, xmlFileName, orderList);
            //更新之后产生的订单的订单号            
            Order.totalID =0;
            string nowTime= "" + DateTime.Now.Year + DateTime.Now.Month + DateTime.Now.Day;
            var n = from m in orderList where (Regex.IsMatch(m.ID,"^"+nowTime)) select m;   //使用Linq语句和正则表达式进行查找今日的订单
            foreach(var m in n)
            {
               if (int.Parse(m.ID.Substring(8,4))>=Order.totalID)
                {
                    Order.totalID = int.Parse(m.ID.Substring(8, 4));
                }
            }
            Console.WriteLine(xmlFileName + "已加载成功！\n");            
            return true;
        }
        void XmlDeserialize(XmlSerializer ser,string fileName,object obj)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open);
            this.orderList=(List<Order>)ser.Deserialize(fs);
            fs.Close(); 
        }
        public static void Main()
        {           
            OrderService orderService = new OrderService();
            orderService.Change += orderService.OrderProgress;
            string s;
            do
            {
                Console.WriteLine("订单管理系统1.0");
                Console.WriteLine("请输入你想执行的操作\n-1 增加一个订单\n-2 删除一个订单\n-3 查找一个订单\n-4 修改一个订单\n-5 加载已有订单\n-6 保存修改到文件\n-0 退出");
                s = Console.ReadLine();
                OrderEventArgs args = new OrderEventArgs();
                args.operate = s;
                orderService.Change(orderService, args);
            } while (s != "-0");
            orderService.export();            
        }
    }
}