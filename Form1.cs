using System.Drawing.Printing;

namespace Lincoln_Restaurant_Management
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            lbtime.Text = DateTime.Now.ToShortDateString();
            timer1.Start();

            txtscharge.Text = "200.00";

            txtwhite.Text = "0";
            txtjollof.Text = "0";
            txtfried.Text = "0";
            txtpounded.Text = "0";
            txtsemovita.Text = "0";
            txtamala.Text = "0";

            txtcola.Text = "0";
            txtfanta.Text = "0";
            txtkunu.Text = "0";
            txtmiranda.Text = "0";
            txtsprite.Text = "0";
            txtmango.Text = "0";

            txtamala.Enabled = false;
            txtfried.Enabled = false;
            txtjollof.Enabled = false;
            txtpounded.Enabled = false;
            txtsemovita.Enabled = false;
            txtwhite.Enabled = false;

            txtcola.Enabled = false;
            txtfanta.Enabled = false;
            txtkunu.Enabled = false;
            txtmiranda.Enabled = false;
            txtsprite.Enabled = false;
            txtmango.Enabled = false;

            chfried.Checked = false;
            chjollof.Checked = false;
            chpounded.Checked = false;
            chsemovita.Checked = false;
            chwhite.Checked = false;
            chamala.Checked = false;

            chcola.Checked = false;
            chfanta.Checked = false;
            chkunu.Checked = false;
            chmiranda.Checked = false;
            chsprite.Checked = false;
            chmango.Checked = false;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbtime.Text = DateTime.Now.ToLongDateString();
            lbdate.Text = DateTime.Now.ToLongTimeString();
        }

        private void chmango_CheckedChanged(object sender, EventArgs e)
        {
            if (chmango.Checked == true)
            {
                txtmango.Enabled = true;
            }
            else if (chmango.Checked == false)
            {
                txtmango.Enabled = false;
                txtmango.Text = "0";
            }
        }

        private void chfanta_CheckedChanged(object sender, EventArgs e)
        {
            if (chfanta.Checked == true)
            {
                txtfanta.Enabled = true;
            }
            else if (chfanta.Checked == false)
            {
                txtfanta.Enabled = false;
                txtfanta.Text = "0";
            }
        }

        private void chsprite_CheckedChanged(object sender, EventArgs e)
        {
            if (chsprite.Checked == true)
            {
                txtsprite.Enabled = true;
            }
            else if (chsprite.Checked == false)
            {
                txtsprite.Enabled = false;
                txtsprite.Text = "0";
            }
        }

        private void chkunu_CheckedChanged(object sender, EventArgs e)
        {
            if (chkunu.Checked == true)
            {
                txtkunu.Enabled = true;
            }
            else if (chkunu.Checked == false)
            {
                txtkunu.Enabled = false;
                txtkunu.Text = "0";
            }
        }

        private void chcola_CheckedChanged(object sender, EventArgs e)
        {
            if (chcola.Checked == true)
            {
                txtcola.Enabled = true;
            }
            else if (chcola.Checked == false)
            {
                txtcola.Enabled = false;
                txtcola.Text = "0";
            }
        }

        private void chmiranda_CheckedChanged(object sender, EventArgs e)
        {
            if (chmiranda.Checked == true)
            {
                txtmiranda.Enabled = true;
            }
            else if (chmiranda.Checked == false)
            {
                txtmiranda.Enabled = false;
                txtmiranda.Text = "0";
            }
        }

        private void chwhite_CheckedChanged(object sender, EventArgs e)
        {
            if (chwhite.Checked == true)
            {
                txtwhite.Enabled = true;
            }
            else if (chwhite.Checked == false)
            {
                txtwhite.Enabled = false;
                txtwhite.Text = "0";
            }
        }

        private void chjollof_CheckedChanged(object sender, EventArgs e)
        {
            if (chjollof.Checked == true)
            {
                txtjollof.Enabled = true;
            }
            else if (chjollof.Checked == false)
            {
                txtjollof.Enabled = false;
                txtjollof.Text = "0";
            }
        }

        private void chfried_CheckedChanged(object sender, EventArgs e)
        {
            if (chfried.Checked == true)
            {
                txtfried.Enabled = true;
            }
            else if (chfried.Checked == false)
            {
                txtfried.Enabled = false;
                txtfried.Text = "0";
            }
        }

        private void chpounded_CheckedChanged(object sender, EventArgs e)
        {
            if (chpounded.Checked == true)
            {
                txtpounded.Enabled = true;
            }
            else if (chpounded.Checked == false)
            {
                txtpounded.Enabled = false;
                txtpounded.Text = "0";
            }
        }

        private void chamala_CheckedChanged(object sender, EventArgs e)
        {
            if (chamala.Checked == true)
            {
                txtamala.Enabled = true;
            }
            else if (chamala.Checked == false)
            {
                txtamala.Enabled = false;
                txtamala.Text = "0";
            }
        }

        private void chsemovita_CheckedChanged(object sender, EventArgs e)
        {
            if (chsemovita.Checked == true)
            {
                txtsemovita.Enabled = true;
            }
            else if (chsemovita.Checked == false)
            {
                txtsemovita.Enabled = false;
                txtsemovita.Text = "0";
            }
        }

        private void btntotal_Click(object sender, EventArgs e)
        {
            if (txtfried.Text == "0" &&
                txtjollof.Text == "0" &&
                txtpounded.Text == "0" &&
                txtamala.Text == "0" &&
                txtsemovita.Text == "0" &&
                txtwhite.Text == "0" &&
                txtmango.Text == "0" &&
                txtkunu.Text == "0" &&
                txtfanta.Text == "0" &&
                txtcola.Text == "0" &&
                txtmiranda.Text == "0" &&
                txtsprite.Text == "0")
            {
                MessageBox.Show("Make a purchase first");
            }
            else
            {
                double tax = 0.2;
                double fried = 400, jollof = 300, pounded = 500, amala = 300, semovita = 300, white = 300;
                double mango = 200, kunu = 100, fanta = 150, cola = 150, miranda = 150, sprite = 150;

                double vfried = Convert.ToDouble(txtfried.Text);
                double vjollof = Convert.ToDouble(txtjollof.Text);
                double vpounded = Convert.ToDouble(txtpounded.Text);
                double vamala = Convert.ToDouble(txtamala.Text);
                double vsemovita = Convert.ToDouble(txtsemovita.Text);
                double vwhite = Convert.ToDouble(txtwhite.Text);

                double vmango = Convert.ToDouble(txtmango.Text);
                double vkunu = Convert.ToDouble(txtkunu.Text);
                double vfanta = Convert.ToDouble(txtfanta.Text);
                double vcola = Convert.ToDouble(txtcola.Text);
                double vmiranda = Convert.ToDouble(txtmiranda.Text);
                double vsprite = Convert.ToDouble(txtsprite.Text);

                double costfood = (vfried * fried) + (vjollof * jollof) + (vpounded * pounded) + (vsemovita * semovita) + (vamala * amala) + (vwhite * white);
                double costdrinks = (vmango * mango) + (vkunu * kunu) + (vfanta * fanta) + (vcola * cola) + (vmiranda * miranda) + (vsprite * sprite);

                double sCharge = 200;
                double subtotal = costdrinks + costfood + sCharge;
                double itax = ((costdrinks + costfood + sCharge) + tax) / 100;
                double total = costdrinks + costfood + sCharge + itax;

                txtcostofdrink.Text = "N" + string.Format("{0:0,00}", costdrinks);
                txtcostoffood.Text = "N" + string.Format("{0:0,00}", costfood);
                txtsubtotal.Text = "N" + string.Format("{0:0,00}", subtotal);
                txttotal.Text = "N" + string.Format("{0:0,00}", total);
                txtvat.Text = "N" + string.Format("{0:0,00}", itax);

            }
        }

        private void btnreciept_Click(object sender, EventArgs e)
        {
            if (txtfried.Text == "0" &&
                txtjollof.Text == "0" &&
                txtpounded.Text == "0" &&
                txtamala.Text == "0" &&
                txtsemovita.Text == "0" &&
                txtwhite.Text == "0" &&
                txtmango.Text == "0" &&
                txtkunu.Text == "0" &&
                txtfanta.Text == "0" &&
                txtcola.Text == "0" &&
                txtmiranda.Text == "0" &&
                txtsprite.Text == "0")
            {
                MessageBox.Show("Make a purchase first");
            }
            else
            {
                rtbreciept.Clear();
                rtbreciept.AppendText(Environment.NewLine);
                rtbreciept.AppendText("\t   Lincoln Restaurant" + Environment.NewLine);
                rtbreciept.AppendText("=====================" + Environment.NewLine);
                rtbreciept.AppendText("mango juice\t\t\t\t" + txtmango.Text + Environment.NewLine);
                rtbreciept.AppendText("kunu \t\t\t" + txtkunu.Text + Environment.NewLine);
                rtbreciept.AppendText("cola juice\t" + txtcola.Text + Environment.NewLine);
                rtbreciept.AppendText("fanta juice\t" + txtfanta.Text + Environment.NewLine);
                rtbreciept.AppendText("sprite juice\t" + txtsprite.Text + Environment.NewLine);
                rtbreciept.AppendText("miranda juice\t" + txtmiranda.Text + Environment.NewLine);

                rtbreciept.AppendText("white rice\t\t\t" + txtwhite.Text + Environment.NewLine);
                rtbreciept.AppendText("jollof rice\t\t\t" + txtjollof.Text + Environment.NewLine);
                rtbreciept.AppendText("fried rice\t\t\t\t" + txtfried.Text + Environment.NewLine);
                rtbreciept.AppendText("amala \t\t\t\t\t\t" + txtamala.Text + Environment.NewLine);
                rtbreciept.AppendText("pounded yam\t\t\t" + txtpounded.Text + Environment.NewLine);
                rtbreciept.AppendText("semovita\t\t\t\t" + txtsemovita.Text + Environment.NewLine);

                rtbreciept.AppendText("=====================" + Environment.NewLine);
                rtbreciept.AppendText("Service Charge \t\t\t" + txtscharge.Text + Environment.NewLine);
                rtbreciept.AppendText("===========================" + Environment.NewLine);
                rtbreciept.AppendText("Tax \t\t\t\t" + txtvat.Text + Environment.NewLine);
                rtbreciept.AppendText("sub total \t\t\t\t" + txtsubtotal.Text + Environment.NewLine);
                rtbreciept.AppendText("total \t\t\t\t" + txttotal.Text + Environment.NewLine);
                rtbreciept.AppendText("================================" + Environment.NewLine);
                rtbreciept.AppendText(lbtime.Text + "\t\t\t" + lbdate.Text);


            }
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtfried.Text = "0";
            txtjollof.Text = "0";
            txtpounded.Text = "0";
            txtamala.Text = "0";
            txtsemovita.Text = "0";
            txtwhite.Text = "0";
            txtmango.Text = "0";
            txtkunu.Text = "0";
            txtfanta.Text = "0";
            txtcola.Text = "0";
            txtmiranda.Text = "0";
            txtsprite.Text = "0";
            txtvat.Text = "0";
            txtsubtotal.Text = "0";
            txttotal.Text = "0";
            txtsubtotal.Text = "0";
            txttotal.Text = "0";
            txtcostofdrink.Text = "0";
            txtcostoffood.Text = "0";
            rtbreciept.Text = "0";
                
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Show();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(rtbreciept.Text, new Font("Arial", 14, FontStyle.Bold), Brushes.Black, 120, 120);
        }
    }
}