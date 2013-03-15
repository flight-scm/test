using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HelloWorld
{

    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_PreLoad(object sender, EventArgs e)
        {/*
            for (int i = 0; i < 15; i++)
                Response.Write("a" + i + " ");
            Response.Write("<br>");
          */
        }
        protected void Page_Load(object sender, EventArgs e)
        {/*
            if (Response.IsClientConnected)
            {
                Response.Write("This is Page_Load()<br>");
            }
          */
            //Response.Redirect("http://tw.yahoo.com");
            Button1.Enabled = false;
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {   
            int intTemp = 0;
            if (string.IsNullOrEmpty(TextBox1.Text))
            {
                Label1.Text = "輸入值為空!";
            }
            else if (!int.TryParse(TextBox1.Text , out intTemp))
            {
                Label1.Text = "數值A不為數字!";
            }
            else
            {
                Label1.Text = "";
                HiddenField1.Value = "*";
                Label2.Text = HiddenField1.Value + HiddenField2.Value;
                Button1.Enabled = (Label2.Text == "**") ? true : false;
            }
        }
        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {
            int intTemp = 0;
            if (string.IsNullOrEmpty(TextBox2.Text))
            {
                Label1.Text = "輸入值為空!";
            }
            else if (!int.TryParse(TextBox2.Text, out intTemp))
            {
                Label1.Text = "數值B不為數字!";
            }
            else
            {
                Label1.Text = "";
                HiddenField2.Value = "*";
                Label2.Text = HiddenField1.Value + HiddenField2.Value;
                Button1.Enabled = (Label2.Text == "**") ? true : false;
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            int sum = Convert.ToInt32(TextBox1.Text) + Convert.ToInt32(TextBox2.Text);
            Response.Write("<script>alert(" + sum + ");</script>");
        }
    }
}
