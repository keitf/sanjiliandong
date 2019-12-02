using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sanjiliandong
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbsheng.Items.Add("山东省");
            lbsheng.Items.Add("河北省");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string address = "";
            address += lbsheng.Text+" ";
            address += lbshi.Text + " ";
            address += lbxian.Text + " ";
            txtb.Text = address;
    }

        private void lbsheng_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbsheng.Text == "山东省")
            {
                lbshi.Items.Clear();
                lbxian.Items.Clear();
                lbshi.Items.Add("济南市");
                lbshi.Items.Add("青岛市");
                lbshi.Items.Add("烟台市");
                
            }
            else if (lbsheng.Text =="河北省")
            {
                lbshi.Items.Clear();
                lbxian.Items.Clear();
                lbshi.Items.Add("石家庄");
                lbshi.Items.Add("唐山市");
                lbshi.Items.Add("廊坊市");
            }
        }

        private void lbshi_SelectedIndexChanged(object sender, EventArgs e)
        {
             if (lbshi.Text == "济南市")
             {
                 lbxian.Items.Clear();
                 lbxian.Items.Add("长清区");
                 lbxian.Items.Add("历下区");
                 lbxian.Items.Add("市中区");
            }
            else if (lbshi.Text == "青岛市")
            {
                lbxian.Items.Clear();
                lbxian.Items.Add("市南区");
                lbxian.Items.Add("市北区");
                lbxian.Items.Add("黄岛区");
            }
            else if (lbshi.Text == "烟台市")
            {
                lbxian.Items.Clear();
                lbxian.Items.Add("烟台市");
                lbxian.Items.Add("烟台高新技术产业开发区");
                lbxian.Items.Add("烟台经济技术开发区");
            }
            if (lbshi.Text == "石家庄")
            {
                lbxian.Items.Clear();
                lbxian.Items.Add("长安区");
                lbxian.Items.Add("桥西区");
                lbxian.Items.Add("新华区");
            }
            else if (lbshi.Text == "唐山市")
            {
                lbxian.Items.Clear();
                lbxian.Items.Add("路南区");
                lbxian.Items.Add("路北区");
                lbxian.Items.Add("古冶区");
            }
            else if (lbshi.Text == "廊坊市")
            {
                lbxian.Items.Clear();
                lbxian.Items.Add("广阳区");
                lbxian.Items.Add("安次区");
                lbxian.Items.Add("霸州市");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
