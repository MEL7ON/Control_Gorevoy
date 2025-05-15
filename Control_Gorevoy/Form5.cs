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
    public partial class Form5 : Form
    {
        public Model1 db { get; set; }
        public Order ord1 { get; set; }

        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ord1.Date = DateTime.Parse(textBox2.Text);
            ord1.Salesperson_ID = int.Parse(textBox3.Text);
            ord1.Customer_ID = int.Parse(textBox4.Text);
            ord1.Boat_ID = int.Parse(textBox5.Text);
            ord1.DeliveryAddress = textBox6.Text;
            ord1.City = textBox7.Text;
            // теперь пытаемся сохранить измененный объект в БД
            try
            {
                // сохраняем изменения, сделанные в объектах коллекции в БД
                db.SaveChanges();
                // задаем свойство DialogResult, чтобы закрыть форму
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {  // если произошла ошибка - сообщаем
                MessageBox.Show(ex.InnerException.InnerException.Message);
            }

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            textBox1.Text = ord1.Order_ID.ToString();
            textBox2.Text = ord1.Date.ToString();
            textBox3.Text = ord1.Salesperson_ID.ToString();
            textBox4.Text = ord1.Customer_ID.ToString();
            textBox5.Text = ord1.Boat_ID.ToString();
            textBox6.Text = ord1.DeliveryAddress;
            textBox7.Text = ord1.City;
        }
    }
}
