using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteTaking
{
    public partial class Form1 : Form
    {
        DataTable table;
        Form2 secondForm = new Form2();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            table = new DataTable();
            table.Columns.Add("Title", typeof(string));
            table.Columns.Add("Messages", typeof(string));

            dataGridView1.DataSource = table;

            dataGridView1.Columns["Messages"].Visible = false;
            dataGridView1.Columns["Title"].Width = 228;
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            textTitle.Clear();
            textMessage.Clear();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            table.Rows.Add(textTitle.Text, textMessage.Text);

            textTitle.Clear();
            textMessage.Clear();
        }

        public void buttonRead_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            if (index >= 0)
            {
                string titleMsg = table.Rows[index]["Title"].ToString();
                string messageMsg = table.Rows[index]["Messages"].ToString();
                textTitle.Text = titleMsg;
                textMessage.Text = messageMsg;
                
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            if (index >= 0)
            {
                table.Rows.RemoveAt(index);
                textTitle.Clear();
                textMessage.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            secondForm.Start(textTitle.Text, textMessage.Text);
            secondForm.Show();

        }


    }
}
