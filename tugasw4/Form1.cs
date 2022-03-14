using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tugasw4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string isiTextNama = "";
        public static string isiTextAlamat = "";
        public static string isiTextTelp = "";
        public static int counter = 0;
        public DataTable kumpulanData = new DataTable();
        private void Form1_Load(object sender, EventArgs e)
        {
            kumpulanData.Columns.Add("Nama");
            kumpulanData.Columns.Add("Alamat");
            kumpulanData.Columns.Add("Telp");

            buttonNext.Visible = false;
            buttonPrev.Visible = false;
            buttonKembali.Visible = false;
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            if (kumpulanData.Rows.Count < 10)
            {
                kumpulanData.Rows.Add(textBoxNama.Text, textBoxAlamat.Text, textBoxTelp.Text);
                textBoxNama.Text = isiTextNama;
                textBoxAlamat.Text = isiTextAlamat;
                textBoxTelp.Text = isiTextTelp;
            }
            else
                MessageBox.Show("Data telah penuh!");
        }

        private void buttonLihat_Click(object sender, EventArgs e)
        {
            textBoxNama.Text = kumpulanData.Rows[counter][0].ToString();
            textBoxAlamat.Text = kumpulanData.Rows[counter][1].ToString();
            textBoxTelp.Text = kumpulanData.Rows[counter][2].ToString();

            textBoxNama.Enabled = false;
            textBoxAlamat.Enabled = false;
            textBoxTelp.Enabled = false;

            buttonNext.Visible = true;
            buttonPrev.Visible = true;
            buttonKembali.Visible = true;
            buttonLihat.Visible = false;
            this.Text = "Form Tampilan Data";
        }

        private void buttonKembali_Click(object sender, EventArgs e)
        {
            textBoxNama.Text = "";
            textBoxAlamat.Text = "";
            textBoxTelp.Text = "";

            textBoxNama.ReadOnly = false;
            textBoxAlamat.ReadOnly = false;
            textBoxTelp.ReadOnly = false;

            buttonNext.Visible = false;
            buttonPrev.Visible = false;
            buttonKembali.Visible = false;
            buttonLihat.Visible = true;
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            buttonLihat.Visible = false;
            if ((counter - 1) >= 0)
            {
                counter--;
                textBoxNama.Text = kumpulanData.Rows[counter][0].ToString();
                textBoxAlamat.Text = kumpulanData.Rows[counter][1].ToString();
                textBoxTelp.Text = kumpulanData.Rows[counter][2].ToString();
            }
            else
            {
                MessageBox.Show("Data sudah data pertama");
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            buttonLihat.Visible = false;
            if ((counter + 1) != kumpulanData.Rows.Count)
            {
                counter++;
                textBoxNama.Text = kumpulanData.Rows[counter][0].ToString();
                textBoxAlamat.Text = kumpulanData.Rows[counter][1].ToString();
                textBoxTelp.Text = kumpulanData.Rows[counter][2].ToString();
            }
            else
            {
                MessageBox.Show("Data sudah data terakhir");
            }
        }
    }
}
