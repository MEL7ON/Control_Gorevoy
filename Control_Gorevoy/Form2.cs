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
    public partial class Form2 : Form
    {
        Model1 db = new Model1();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "yacht_YardDataSet.Order". При необходимости она может быть перемещена или удалена.
            this.orderTableAdapter.Fill(this.yacht_YardDataSet.Order);
            orderBindingSource.DataSource = db.Order.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 frm = new Form4();
            frm.db = db;
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
            { 
                orderBindingSource.DataSource = db.Order.ToList();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 frm = new Form5();
            Order ord1 = (Order)orderBindingSource.Current;
            frm.db = db;
            frm.ord1 = ord1;
            DialogResult dr = frm.ShowDialog();  
            if (dr == DialogResult.OK)
            {
                orderBindingSource.DataSource = db.Order.ToList();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Order ord1 = (Order)orderBindingSource.Current;
            DialogResult dr = MessageBox.Show(
                "Вы действительно хотите удалить заказ - " + ord1.Order_ID.ToString(),
                "Удаление заказа", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                // удаление записи из базы данных
                db.Order.Remove(ord1);
                try
                {
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                orderBindingSource.DataSource = db.Order.ToList();
            }

        }
    }
}
