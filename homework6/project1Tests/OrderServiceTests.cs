using Microsoft.VisualStudio.TestTools.UnitTesting;
using project1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1.Tests
{
    [TestClass()]
    public class OrderServiceTests
    {

        public delegate bool OrderEventHandler(object sender, OrderEventArgs e);
        [TestMethod()]
        public void addOprTest()
        {
            OrderService a = new OrderService();
            a.addOpr("水杯", "冯文翰", 20, 10);  //正确输入        
         //   a.addOpr("可口可乐", "肖劲宇", 2, 5);  //错误输入，会引起警告
            Assert.IsTrue(a["201812180001"].TotalPrice==200);
        }

        [TestMethod()]

        public void serOprTest()
        {
            OrderService a = new OrderService();
            a.addOpr("水杯", "冯文翰", 20, 10);
            Assert.IsTrue(a.serOpr("201812180001", "", "", 0));    //正确输入
        //    Assert.IsTrue(a.serOpr("201812180003", "", "", 0));    //错误输入，会引起警告
        }

        [TestMethod()]
        public void repOprTest()
        {
            OrderService a = new OrderService();
            a.addOpr("水杯", "冯文翰", 20, 10);
            //Console.WriteLine(a["201812180001"].ID);
            a.repOpr("201812180001", "鼠标", "陈志鹏", 22, 1);   //正确输入
         //   a.repOpr("201812180001", "鼠标", "陈志彭", 22, 1);   //错误输入，会引起警告
            Assert.IsTrue(a["201812180001"].orderDetails.client == "陈志鹏");
        }

        [TestMethod()]
        public void delOprTest()
        {
            OrderService a = new OrderService();
            a.addOpr("水杯", "冯文翰", 20, 10);
            try
            {
                a.delOpr("201812180001");   //正确输入
            //  a.delOpr("201812180002");   //错误输入，会引起警告
            }
            catch
            {
                Assert.Fail();
            }
        }


        [TestMethod()]
        public void MainTest()
        {
            //addOprTest();
            //Assert.Fail();
        }
    }
}