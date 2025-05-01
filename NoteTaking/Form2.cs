using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteTaking
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
        }

        public void Start(string title, string message)
        {
            textTitle.Text = title;
            textMessage.Text = message;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
