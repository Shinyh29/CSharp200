using System;
using System.Windows.Forms;

namespace A149_DateTimePicker
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
    {
      DateTime today = DateTime.Today;
      DateTime birthDay = dateTimePicker1.Value;

      txtDates.Text = today.Subtract(birthDay).TotalDays.ToString("0") +"Offset";
      
    }

        private void txtDates_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
