using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_Gorevoy
{
    public partial class Form4 : Form
    {
        public Model1 db { get; set; }
        public Form4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "")
            {
                MessageBox.Show("Нужно ввести все требуемые данные!");
                return;
            }
            int id;
            bool b = int.TryParse(textBox1.Text, out id);
            if (b == false)
            {
                MessageBox.Show("Неверный формат ID - " + textBox1.Text);
                return;
            }

            Order ord1 = new Order();
            ord1.Order_ID = id;
            ord1.Date = DateTime.Parse(textBox2.Text);
            ord1.Salesperson_ID = int.Parse(textBox3.Text);
            ord1.Customer_ID = int.Parse(textBox4.Text);
            ord1.Boat_ID = int.Parse(textBox5.Text);
            ord1.DeliveryAddress = textBox6.Text;
            ord1.City = textBox7.Text;

            db.Order.Add(ord1);
            try
            {
                db.SaveChanges();
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.InnerException.InnerException.Message);
            }

        }
    }
}
