using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace A140_ListBox
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
            listBox1.Items.Add("삼성전자, IT");
            listBox1.Items.Add("LG화학, 화학");
            listBox1.Items.Add("카카오, 소프트웨어");
            listBox1.Items.Add("네이버, 소프트웨어");
            listBox1.Items.Add("신한알파리츠, 리츠");

            listBox2.Items.Add("삼성전자, IT");
            listBox2.Items.Add("LG화학, 화학");
            listBox2.Items.Add("카카오, 소프트웨어");
            listBox2.Items.Add("네이버, 소프트웨어");
            listBox2.Items.Add("신한알파리츠, 리츠");


            //List<String> lstGDP = new List<String> { "미국", "러시아", "중국", "영국",
            //  "독일", "프랑스", "일본", "이스라엘", "사우디아라비아", "UAE"};
            // listBox3.DataSource = lstGDP;

            List<string> lstSTOCK = new List<String> { "삼성전자", "LG화학", "네이버", "카카오" };
      listBox3.DataSource = lstSTOCK;

            //listBox1.SelectedIndex = 0;
            //listBox2.SelectedIndex = 0;
            //listBox3.SelectedIndex = 0;
        }

    private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
      ListBox lst = sender as ListBox;
      txtSIndex1.Text = lst.SelectedIndex.ToString();
      txtSItem1.Text = lst.SelectedItem.ToString();
    }

    private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
    {
      ListBox lst = sender as ListBox;
      txtSIndex2.Text = lst.SelectedIndex.ToString();
      txtSItem2.Text = lst.SelectedItem.ToString();
    }

    private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
    {
      ListBox lst = sender as ListBox;
      txtSIndex3.Text = lst.SelectedIndex.ToString();
      txtSItem3.Text = lst.SelectedItem.ToString();
    }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
