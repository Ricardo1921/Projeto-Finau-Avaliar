using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_de_Nascimento2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Class1 cunha = new Class1();
        private void Button1_Click(object sender, EventArgs e)
        {
            cunha.recebe = textBox1.Text;
            label2.Text = cunha.envia;
            cunha.recebe = textBox1.Text;
            label1.Text = cunha.envia;
            cunha.recebe = textBox1.Text;
            label3.Text = cunha.envia;
        }
    }
}
