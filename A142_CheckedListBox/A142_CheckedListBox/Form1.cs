using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace A142_CheckedListBox
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      cLstBox.Items.Add("삼성전자, 005930");
      cLstBox.Items.Add("카카오, 000000");
      cLstBox.Items.Add("네이버, 000000");
      cLstBox.Items.Add("대우건설, 000000");
      cLstBox.Items.Add("씨젠, 000000");
      cLstBox.Items.Add("자이에스앤디, 000000");
      cLstBox.Items.Add("태웅로직스, 000000");
      cLstBox.Items.Add("HDC현대산업개발, 000000");
      cLstBox.Items.Add("바다로19호, 000000");
      cLstBox.Items.Add("신한알파리츠, 000000");

      lstBox.SelectionMode = SelectionMode.MultiExtended;
    }

    private void btnTo_Click(object sender, EventArgs e)
    {
      foreach (var city in cLstBox.CheckedItems)
        lstBox.Items.Add(city);
    }

    private void btnAll_Click(object sender, EventArgs e)
    {
      foreach (var city in cLstBox.Items)
        lstBox.Items.Add(city);
    }

    private void btnBack_Click(object sender, EventArgs e)
    {
      List<string> lstRemove = new List<string>();

      foreach (string city in lstBox.SelectedItems)
        lstRemove.Add(city);

      foreach (string city in lstRemove)
        lstBox.Items.Remove(city);
    }

    private void btnDelAll_Click(object sender, EventArgs e)
    {
      lstBox.Items.Clear();
    }

        private void cLstBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
