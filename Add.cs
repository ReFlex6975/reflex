using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SessionGLEB
{
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e) //кнопка добавления данных о продукте
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `product` ( `ProductArticleNumber`, `ProductName`, `ProductDescription`, `ProductCategory`, `ProductPhoto`, `ProductManufacturer`, `ProductCost`, `ProductDiscountAmount`, `ProductQuantityInStock`, `ProductUnit`, `ProductDiscountMax`, `ProductProvider`) VALUES( @ProductArticleNumber, @ProductName, @ProductDescription, @ProductCategory, @ProductPhoto, @ProductManufacturer, @ProductCost, @ProductDiscountAmount, @ProductQuantityInStock, @ProductUnit, @ProductDiscountMax, @ProductProvider)", db.GetConnection());
            command.Parameters.Add("@ProductArticleNumber", MySqlDbType.VarChar).Value = q1.Text;
            command.Parameters.Add("@ProductName", MySqlDbType.VarChar).Value = q2.Text;
            command.Parameters.Add("@ProductDescription", MySqlDbType.VarChar).Value = q3.Text;
            command.Parameters.Add("@ProductCategory", MySqlDbType.VarChar).Value = q4.Text;
            command.Parameters.Add("@ProductPhoto", MySqlDbType.VarChar).Value = q5.Text;
            command.Parameters.Add("@ProductManufacturer", MySqlDbType.VarChar).Value = q6.Text;
            command.Parameters.Add("@ProductCost", MySqlDbType.VarChar).Value = q7.Text;
            command.Parameters.Add("@ProductDiscountAmount", MySqlDbType.VarChar).Value = q8.Text;
            command.Parameters.Add("@ProductQuantityInStock", MySqlDbType.VarChar).Value = q9.Text;
            command.Parameters.Add("@ProductUnit", MySqlDbType.VarChar).Value = q10.Text;
            command.Parameters.Add("@ProductDiscountMax", MySqlDbType.VarChar).Value = q11.Text;
            command.Parameters.Add("@ProductProvider", MySqlDbType.VarChar).Value = q12.Text;

            
            
            
                 db.openConnection();
            if (q1.Text == "" || q2.Text == "" || q3.Text == "" || q4.Text == "" || q5.Text == "" || q6.Text == "" || q7.Text == "" || q8.Text == "" || q9.Text == "" || q10.Text == "" || q11.Text == "" || q12.Text == "")
            {
                MessageBox.Show("Неправильные данные");
                return;
            }
            if (command.ExecuteNonQuery() == 0)
             {
                     MessageBox.Show("Ошибка");
             }
                     else
                     {
                        MessageBox.Show("Добавление завершено");
                        this.Close();
                
                        Adminn MainG = new Adminn(Name, ProductName);
                        MainG.Show();                       
                     }      
          
             
            
            
        }
    }
}
