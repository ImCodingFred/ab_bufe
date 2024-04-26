using MySql.Data;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Crmf;
using System;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ab_bufe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            betoltes();
            rb_uj.Checked = true;
        }

        string server;
        string database;
        string usern;
        string pw;
        string kapcs;
        string lekerdezes;

        private void betoltes()
        {
            DGV.Rows.Clear();
            server = "linsql.verebely.dc";
            database = "diak36";
            usern = "diak36";
            pw = "BXGERT";
            string kapcs = $"SERVER={server};DATABASE={database};UID={usern};PASSWORD={pw}";
            MySqlConnection con = new MySqlConnection(kapcs);
            con.Open();
            lekerdezes = "SELECT * FROM forgalom";
            MySqlCommand command = new MySqlCommand(lekerdezes, con);
            MySqlDataReader mdr = command.ExecuteReader();
            DGV.Columns[2].DefaultCellStyle.Format = "yyyy-MM-dd";
            while (mdr.Read())
            {
                DGV.Rows.Add(mdr[0], mdr[2], mdr[5], mdr[1], mdr[3], mdr[4], (int)mdr[3] * (int)mdr[4]);
            }
            con.Close();
        }

        private void tb_keres_TextChanged(object sender, EventArgs e)
        {
            DGV.Rows.Clear();
            server = "linsql.verebely.dc";
            database = "diak36";
            usern = "diak36";
            pw = "BXGERT";
            string kapcs = $"SERVER={server};DATABASE={database};UID={usern};PASSWORD={pw}";
            MySqlConnection con = new MySqlConnection(kapcs);
            con.Open();
            lekerdezes = $"SELECT * FROM forgalom WHERE vevo LIKE '%{tb_keres.Text}%'";
            MySqlCommand command = new MySqlCommand(lekerdezes, con);
            MySqlDataReader mdr = command.ExecuteReader();
            DGV.Columns[2].DefaultCellStyle.Format = "yyyy-MM-dd";
            while (mdr.Read())
            {
                DGV.Rows.Add(mdr[0], mdr[2], mdr[5], mdr[1], mdr[3], mdr[4], (int)mdr[3] * (int)mdr[4]);
            }
            con.Close();
        }

        private void btn_ment_Click(object sender, EventArgs e)
        {
            string cname = null;
            foreach (Control c in panel.Controls)
            {
                if (c.Text == "")
                {
                    cname = c.Name; break;
                }
            }
            if (cname != null)
            {
                MessageBox.Show("Adjon meg értéket!");
                panel.Controls[cname].Focus();
                panel.Controls[cname].BackColor = Color.Red;
            }
            //if (tb_sorszam.TextLength == 0)
            //{
            //    MessageBox.Show("Adjon meg értéket!");
            //    tb_sorszam.Focus();
            //}
            //else if (tb_vnev.TextLength == 0)
            //{
            //    MessageBox.Show("Adjon meg értéket!");
            //    tb_vnev.Focus();
            //}
            //else if (tb_termek.TextLength == 0)
            //{
            //    MessageBox.Show("Adjon meg értéket!");
            //    tb_termek.Focus();
            //}
            //else if (tb_mennyiseg.TextLength == 0)
            //{
            //    MessageBox.Show("Adjon meg értéket!");
            //    tb_mennyiseg.Focus();
            //}
            //else if (tb_egysegar.TextLength == 0)
            //{
            //    MessageBox.Show("Adjon meg értéket!");
            //    tb_egysegar.Focus();
            //}
            else
            {
                if (rb_uj.Checked)
                {
                    try
                    {
                        server = "linsql.verebely.dc";
                        database = "diak36";
                        usern = "diak36";
                        pw = "BXGERT";
                        string kapcs = $"SERVER={server};DATABASE={database};UID={usern};PASSWORD={pw}";
                        MySqlConnection con = new MySqlConnection(kapcs);
                        con.Open();
                        lekerdezes = $"INSERT INTO forgalom(sorszam,termek, vevo, menny, brutto, datum)" +
                            $"VALUES ('{tb_sorszam.Text}','{tb_termek.Text}','{tb_vnev.Text}','{tb_mennyiseg.Text}','{tb_egysegar.Text}','{dtp.Value.ToString("yyyy-MM-dd")}')";
                        MySqlCommand command = new MySqlCommand(lekerdezes, con);
                        MySqlDataReader mdr = command.ExecuteReader();
                        con.Close();
                        betoltes();
                    }
                    catch
                    {
                        MessageBox.Show("Hibás sorszám!");
                    }
                }
                else
                {
                    try
                    {
                        server = "linsql.verebely.dc";
                        database = "diak36";
                        usern = "diak36";
                        pw = "BXGERT";
                        string kapcs = $"SERVER={server};DATABASE={database};UID={usern};PASSWORD={pw}";
                        MySqlConnection con = new MySqlConnection(kapcs);
                        con.Open();
                        lekerdezes = $"UPDATE forgalom SET termek = '{tb_termek.Text}', vevo = '{tb_vnev.Text}', menny = '{tb_mennyiseg.Text}', brutto = '{tb_egysegar.Text}', datum = '{dtp.Value.ToString("yyyy-MM-dd")}' WHERE sorszam = {tb_sorszam.Text}";
                        MySqlCommand command = new MySqlCommand(lekerdezes, con);
                        MySqlDataReader mdr = command.ExecuteReader();
                        con.Close();
                        betoltes();
                    }
                    catch
                    {
                        MessageBox.Show("Hibás bevitel");
                    }
                }
            }
        }

        private void tb_sorszam_TextChanged(object sender, EventArgs e)
        {
            if (tb_sorszam.TextLength > 0)
            {
                jo("tb_sorszam");
                try
                {
                    int a = int.Parse(tb_sorszam.Text);
                }
                catch
                {
                    MessageBox.Show("Számot adjon meg!");
                    tb_sorszam.Clear();
                    tb_sorszam.Focus();
                    tb_sorszam.BackColor = Color.Red;
                }
            }
        }

        private void jo(string s)
        {
            foreach (Control control in panel.Controls)
            {
                if (control.Name == s)
                {
                    control.BackColor = Color.White;
                }
            }
        }

        private void tb_mennyiseg_TextChanged(object sender, EventArgs e)
        {
            if (tb_mennyiseg.TextLength > 0)
            {
                jo("tb_mennyiseg");
                try
                {
                    int a = int.Parse(tb_mennyiseg.Text);
                    if (tb_egysegar.TextLength > 0)
                    {
                        l_fiz.Text = $"{int.Parse(tb_egysegar.Text) * int.Parse(tb_mennyiseg.Text)} Ft";
                    }
                }
                catch
                {
                    MessageBox.Show("Számot adjon meg!");
                    tb_mennyiseg.Clear();
                    tb_mennyiseg.Focus();
                    tb_sorszam.BackColor = Color.Red;

                }
            }
        }

        private void tb_egysegar_TextChanged(object sender, EventArgs e)
        {
            if (tb_egysegar.TextLength > 0)
            {
                jo("tb_egysegar");
                try
                {
                    int a = int.Parse(tb_egysegar.Text);
                    if (tb_mennyiseg.TextLength > 0)
                    {
                        l_fiz.Text = $"{int.Parse(tb_egysegar.Text) * int.Parse(tb_mennyiseg.Text)} Ft";
                    }
                }
                catch
                {
                    MessageBox.Show("Számot adjon meg!");
                    tb_egysegar.Clear();
                    tb_egysegar.Focus();
                    tb_sorszam.BackColor = Color.Red;

                }
            }
        }

        private void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (rb_modosit.Checked)
            {
                panel.Visible = true;
                int index = DGV.SelectedCells[0].RowIndex;
                tb_sorszam.Text = DGV.Rows[index].Cells[0].Value.ToString();
                tb_vnev.Text = DGV.Rows[index].Cells[1].Value.ToString();
                dtp.Value = Convert.ToDateTime(DGV.Rows[index].Cells[2].Value);
                tb_termek.Text = DGV.Rows[index].Cells[3].Value.ToString();
                tb_mennyiseg.Text = DGV.Rows[index].Cells[4].Value.ToString();
                tb_egysegar.Text = DGV.Rows[index].Cells[5].Value.ToString();
            }
        }

        private void rb_modosit_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_modosit.Checked)
            {
                tb_sorszam.Enabled = false;
                panel.Visible = false;
            }
        }

        private void rb_uj_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_uj.Checked)
            {
                tb_sorszam.Enabled = true;
                panel.Visible = true;
                foreach (Control c in panel.Controls)
                {
                    if (c is TextBox)
                    {
                        c.Text = null;
                    }
                }
            }
        }

        private void btn_elvetes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("biztos törli az értékeket?", "elvetés", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.Yes)
            {
                tb_sorszam.Clear();
                tb_vnev.Clear();
                tb_termek.Clear();
                tb_mennyiseg.Clear();
                tb_egysegar.Clear();
            }
        }

        private void tb_vnev_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
