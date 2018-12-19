using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace project1
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            OrderService orderService = new OrderService();
            orderService.Change += orderService.OrderProgress;
            orderService.import();
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID", typeof(string));
            dataTable.Columns.Add("product", typeof(string));
            dataTable.Columns.Add("client", typeof(string));
            dataTable.Columns.Add("number", typeof(int));
            dataTable.Columns.Add("price", typeof(double));
            dataTable.Columns.Add("totalPrice", typeof(double));
            int k = 0;
            foreach (Order n in orderService.orderList)
            {
                DataRow row = dataTable.NewRow();
                row["ID"] = n.ID;
                row["product"] = n.Product;
                row["client"] = n.orderDetails.client;
                row["number"] = n.orderDetails.number;
                row["price"] = n.orderDetails.price;
                row["totalPrice"] = n.TotalPrice;
                dataTable.Rows.Add(row);
            }           
            foreach(DataRow row in dataTable.Rows)
            {
                foreach(object field in row.ItemArray)
                {
                    Console.WriteLine(field);
                }
            }
            ListForm listForm = new ListForm();
            listForm.dataSet1.Tables.Add(dataTable);
            listForm.dataGridView1.DataSource = dataTable;
            Application.Run(listForm);
        }
    }
}
