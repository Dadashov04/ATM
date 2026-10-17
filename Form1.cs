using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace BANKOMAT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
         int []a={200,100,50,20,10,5,1};//Den ed
   int []b={5,10,7,8,14,15,21};  //V nalichii
   int i,n,k;
   int s;
  
        public SqlConnection con = new SqlConnection("data source=DESKTOP-OI9V01D\\SQLEXPRESS; initial catalog= Bankomat; integrated security= SSPI");
        SqlCommand com;

        public void otr(string s)
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(s, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            con.Close();
            dataGridView1.DataSource = ds.Tables[0];
        }

        public void Otr(string s)
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(s, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            con.Close();
            dataGridView2.DataSource = ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
  
            s=Convert.ToInt16(textBox1.Text);
   i=0;
   while(s>0)
   {
     k=s%a[i];
     n=s/a[i];
     if(n<=b[i])
	       {
	       b[i]-=n;
	       s-=n*a[i];
	       listBox1.Items.Add(a[i].ToString()+"-" + n.ToString());
	       }
	   else {
		 s-=b[i]*a[i];
	       listBox1.Items.Add(a[i].ToString()+"-" + b[i].ToString());
		 b[i]=0;
		}

	i++;
   }

}

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bankomatDataSet3.Dataa' table. You can move, or remove it, as needed.
            this.dataaTableAdapter.Fill(this.bankomatDataSet3.Dataa);
            
            // TODO: This line of code loads data into the 'bankomatDataSet1.t1' table. You can move, or remove it, as needed.
            this.t1TableAdapter1.Fill(this.bankomatDataSet1.t1);
            
            dataGridView1.Sort(dataGridView1.Columns[1], ListSortDirection.Descending);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int R = dataGridView1.Rows.Count - 2;
            s = Convert.ToInt16(textBox1.Text);
            i = 0;
            while (s > 0 || i<=R)
            {
                b[i]=Convert.ToInt16(dataGridView1[2,i].Value.ToString());
                a[i] = Convert.ToInt16(dataGridView1[1, i].Value.ToString());
                k = s % a[i];// datagrdview[2,i].value.tostring();
                n = s / a[i];// datagrdview[1,i].value.tostring();
                if (n <= b[i])
                {
                    b[i] -= n;
                    s -= n * a[i];
                    listBox1.Items.Add(a[i].ToString() + "-" + n.ToString());
                }
                else
                {
                    s -= b[i] * a[i];
                    listBox1.Items.Add(a[i].ToString() + "-" + b[i].ToString());
                    b[i] = 0;
                }

                i++; if (i > R) break;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            con.Open();
            com = new SqlCommand("insert into t1(Tovar, Cena, Kol)values('" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')", con);
            com.ExecuteNonQuery();
            con.Close();
            otr("select * from t1");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            com = new SqlCommand("insert into Dataa(Tovar, Tarix, Cena, Kol)values('" + textBox2.Text + "','"+ dateTimePicker1.Value.ToShortDateString() +"','" + textBox3.Text + "','" + textBox4.Text + "')", con);
            com.ExecuteNonQuery();
            con.Close();
            Otr("select * from Dataa");
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
            int R = dataGridView2.Rows.Count - 2;
            s = Convert.ToInt16(textBox1.Text);
            i = 0;
            while (s > 0 || i <= R)
            {
                b[i] = Convert.ToInt16(dataGridView2[3, i].Value.ToString());
                a[i] = Convert.ToInt16(dataGridView2[2, i].Value.ToString());
                k = s % a[i];
                n = s / a[i];
                if (n <= b[i])
                {
                    b[i] -= n;
                    s -= n * a[i];
                    listBox1.Items.Add(a[i].ToString() + "-" + n.ToString());
                }
                else
                {
                    s -= b[i] * a[i];
                    listBox1.Items.Add(a[i].ToString() + "-" + b[i].ToString());
                    b[i] = 0;
                }

                i++; if (i > R) break;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Otr("select * from Dataa order by Tarix desc");
        }

        }
    }

