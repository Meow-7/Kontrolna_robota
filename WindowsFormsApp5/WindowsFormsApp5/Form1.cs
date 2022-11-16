using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(label9.Text);
            Address adr1 = new Address(textBox1.Text, Convert.ToInt32(textBox2.Text));
            Human Alex = new Human(textBox3.Text, textBox4.Text, Convert.ToInt32(textBox5.Text), adr1);
  
            treeView1.Nodes.Add(textBox4.Text);
            treeView1.Nodes[i].Nodes.Add(textBox1.Text);
            if (i == 0)
            {
                dataGridView1.Rows[i].Cells[0].Value = (textBox3.Text);
                dataGridView1.Rows[i].Cells[1].Value = (textBox5.Text);
                dataGridView1.Rows[i].Cells[2].Value = (textBox1.Text);
            }
            else
                dataGridView1.Rows.Add(textBox3.Text, textBox5.Text, textBox1.Text);

            chart1.Palette = ChartColorPalette.SeaGreen;
            Series series = chart1.Series.Add(textBox4.Text);
            series.Points.Add(Convert.ToDouble(textBox5.Text));
            
            label9.Text = Convert.ToString(Convert.ToInt32(label9.Text) + 1);
            textBox1.Clear(); textBox2.Clear(); textBox3.Clear();
            textBox4.Clear(); textBox5.Clear();

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("column1", "Прізвище");
            dataGridView1.Columns.Add("column2", "Вік");
            dataGridView1.Columns.Add("column3", "Вулиця");
            chart1.Series.RemoveAt(0);
            chart1.Titles.Add("Вік людини");
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
