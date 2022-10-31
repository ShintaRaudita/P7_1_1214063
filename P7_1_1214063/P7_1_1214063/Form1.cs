using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace P7_1_1214063
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(660,330);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (rbKuri2014.Checked)
            {
                //kenapa yg disabled mtk sm penglog
                cbMTK.Enabled = false; cbMTK.Checked = false;
                cbPemrog1.Enabled = true;
                cbPemrog2.Enabled = true;
                cbPemrog3.Enabled = true;
                cbPemrog4.Enabled = true;
                cbPemrog5.Enabled = true;
                cbPemrog6.Enabled = true;
                cbPemrog7.Enabled = true;
                cbPengLog.Enabled = true;
                cbJarKom.Enabled = true;
                cbSO.Enabled = true;
                cbPasok.Enabled = false; cbPasok.Checked = false;
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btPilihMatkul_Click(object sender, EventArgs e)
        {
            if (tbNIM.Text != "")
            {
                if (tbNama.Text != "")
                {
                    if (tbAlamat.Text != "")
                    {
                        if (tbTA.Text != "")
                        {
                            if (tbSemester.Text != "")
                            {
                                if (rbLaki.Checked || rbPerem.Checked)
                                {
                                    if (cbProdi.Text != "")
                                    {
                                        MessageBox.Show
                                        ("Lengkap!",
                                        "informsi data submit",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                                        //after klik button ok, seluruh form muncul
                                        this.Size = new Size(784, 577);
                                    }
                                    else //prodi
                                    {
                                        MessageBox.Show
                                        ("prodi belum diisi!",
                                        "informsi data submit",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                }
                                else //jk
                                {
                                    MessageBox.Show
                                    ("jk belum diisi!",
                                    "informsi data submit",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                              
                            }
                            else //smt
                            {
                                MessageBox.Show
                                ("smt belum diisi!",
                                "informsi data submit",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else //ta
                        {
                            MessageBox.Show
                            ("ta belum diisi!",
                            "informsi data submit",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else //alamat
                    {
                        MessageBox.Show
                        ("alamat belum diisi!",
                        "informsi data submit",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else //nama
                {
                    MessageBox.Show
                    ("nama belum diisi!",
                    "informsi data submit",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else //nim
            {
                MessageBox.Show
                    ("NIM belum diisi!",
                    "informsi data submit",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }//end private void btPilihMatkul_Click(object sender, EventArgs e)

        private void tbTA_TextChanged(object sender, EventArgs e)
        {
            if (tbTA.Text == "")
            {
                epTA.SetError(tbTA, "");
            }
            else
            {
                if (Regex.IsMatch(tbTA.Text, @"^\d{4}/\d{4}$"))
                {
                    epTA.SetError(tbTA, "");
                }
                else
                {
                    epTA.SetError(tbTA, "format tahun akademik salah!");
                }
            }
        }

        private void tbSemester_TextChanged(object sender, EventArgs e)
        {

        }

        private void rbKuri2006_CheckedChanged(object sender, EventArgs e)
        {
            if (rbKuri2006.Checked)
            {
                cbMTK.Enabled = true;
                cbPemrog1.Enabled = true;
                cbPemrog2.Enabled = true;
                cbPemrog3.Enabled = true;
                cbPemrog4.Enabled = true;
                cbPemrog5.Enabled = true;
                cbPemrog6.Enabled = true;
                cbPemrog7.Enabled = true;
                cbPengLog.Enabled = false; cbPengLog.Checked = false;
                cbJarKom.Enabled = true;
                cbSO.Enabled = true;
                cbPasok.Enabled = false; cbPasok.Checked = false;
            }
            /*
            if (rbKuri2010.Checked)
            {
                cbMTK.Enabled = false; cbMTK.Checked = false;
                cbPemrog1.Enabled = true; 
                cbPemrog2.Enabled = true;
                cbPemrog3.Enabled = true;
                cbPemrog4.Enabled = true;
                cbPemrog5.Enabled = true;
                cbPemrog6.Enabled = true;
                cbPemrog7.Enabled = true;
                cbPengLog.Enabled = false; cbPengLog.Checked = false;
                cbJarKom.Enabled = true;
                cbSO.Enabled = true;
                cbPasok.Enabled = true;
            }
            if (rbKuri2014.Checked)
            {
                //kenapa yg disabled mtk sm penglog => setiap rb punya if sendiri
                cbMTK.Enabled = false; cbMTK.Checked = false;
                cbPemrog1.Enabled = true; 
                cbPemrog2.Enabled = true;
                cbPemrog3.Enabled = true;
                cbPemrog4.Enabled = true;
                cbPemrog5.Enabled = true;
                cbPemrog6.Enabled = true;
                cbPemrog7.Enabled = true;
                cbPengLog.Enabled = true;
                cbJarKom.Enabled = true;
                cbSO.Enabled = true;
                cbPasok.Enabled = false; cbPasok.Checked = false;
            }
            */
        }//end private void rbKuri2006_CheckedChanged(object sender, EventArgs e)

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show
                (
                "NIM : " + tbNIM.Text +
                "\nNama : " + tbNama.Text +
                "\nJenis Kelamin : " + 
                "\nAlamat : " + tbAlamat.Text +
                "\nProgram Studi : " + cbProdi.Text +
                "\nTahun Akademik : " + tbTA +
                "\nSemester : " + tbSemester +
                "\n=====================================" +
                "\nKurikulum : " +
                "\nMataKuliah : "
                //MessageBoxButtons.OK, MessageBoxIcon.Information
                );
        }

        private void btBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbKuri2010_CheckedChanged(object sender, EventArgs e)
        {
            if (rbKuri2010.Checked)
            {
                cbMTK.Enabled = false; cbMTK.Checked = false;
                cbPemrog1.Enabled = true;
                cbPemrog2.Enabled = true;
                cbPemrog3.Enabled = true;
                cbPemrog4.Enabled = true;
                cbPemrog5.Enabled = true;
                cbPemrog6.Enabled = true;
                cbPemrog7.Enabled = true;
                cbPengLog.Enabled = false; cbPengLog.Checked = false;
                cbJarKom.Enabled = true;
                cbSO.Enabled = true;
                cbPasok.Enabled = true;
            }
        }//end private void rbKuri2010_CheckedChanged(object sender, EventArgs e)

    }
}
