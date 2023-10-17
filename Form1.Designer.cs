namespace Lincoln_Restaurant_Management
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            lbdate = new Label();
            label1 = new Label();
            lbtime = new Label();
            panel2 = new Panel();
            txtcola = new TextBox();
            chcola = new CheckBox();
            txtsprite = new TextBox();
            chsprite = new CheckBox();
            txtfanta = new TextBox();
            chfanta = new CheckBox();
            txtmiranda = new TextBox();
            chmiranda = new CheckBox();
            txtkunu = new TextBox();
            chkunu = new CheckBox();
            label2 = new Label();
            txtmango = new TextBox();
            chmango = new CheckBox();
            panel3 = new Panel();
            txtamala = new TextBox();
            chamala = new CheckBox();
            txtfried = new TextBox();
            chfried = new CheckBox();
            txtjollof = new TextBox();
            chjollof = new CheckBox();
            txtsemovita = new TextBox();
            chsemovita = new CheckBox();
            txtpounded = new TextBox();
            chpounded = new CheckBox();
            txtwhite = new TextBox();
            chwhite = new CheckBox();
            label3 = new Label();
            panel4 = new Panel();
            txtscharge = new TextBox();
            label6 = new Label();
            txtcostoffood = new TextBox();
            label5 = new Label();
            txtcostofdrink = new TextBox();
            label4 = new Label();
            panel5 = new Panel();
            txttotal = new TextBox();
            label9 = new Label();
            txtvat = new TextBox();
            label8 = new Label();
            txtsubtotal = new TextBox();
            label7 = new Label();
            panel6 = new Panel();
            btnexit = new Button();
            btnreset = new Button();
            btnreciept = new Button();
            btntotal = new Button();
            panel7 = new Panel();
            toolStrip1 = new ToolStrip();
            newToolStripButton = new ToolStripButton();
            openToolStripButton = new ToolStripButton();
            saveToolStripButton = new ToolStripButton();
            printToolStripButton = new ToolStripButton();
            toolStripSeparator = new ToolStripSeparator();
            copyToolStripButton = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            rtbreciept = new RichTextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Info;
            panel1.Controls.Add(lbdate);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(6, 16);
            panel1.Name = "panel1";
            panel1.Size = new Size(959, 52);
            panel1.TabIndex = 0;
            // 
            // lbdate
            // 
            lbdate.AutoSize = true;
            lbdate.Location = new Point(897, 37);
            lbdate.Name = "lbdate";
            lbdate.Size = new Size(59, 15);
            lbdate.TabIndex = 2;
            lbdate.Text = "13/9/2023";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(285, 9);
            label1.Name = "label1";
            label1.Size = new Size(352, 25);
            label1.TabIndex = 0;
            label1.Text = "Lincoln Restaurant Management";
            // 
            // lbtime
            // 
            lbtime.AutoSize = true;
            lbtime.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbtime.Location = new Point(6, 45);
            lbtime.Name = "lbtime";
            lbtime.Size = new Size(70, 20);
            lbtime.TabIndex = 1;
            lbtime.Text = "10:00 PM";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Info;
            panel2.Controls.Add(txtcola);
            panel2.Controls.Add(chcola);
            panel2.Controls.Add(txtsprite);
            panel2.Controls.Add(chsprite);
            panel2.Controls.Add(txtfanta);
            panel2.Controls.Add(chfanta);
            panel2.Controls.Add(txtmiranda);
            panel2.Controls.Add(chmiranda);
            panel2.Controls.Add(txtkunu);
            panel2.Controls.Add(chkunu);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtmango);
            panel2.Controls.Add(chmango);
            panel2.Location = new Point(6, 74);
            panel2.Name = "panel2";
            panel2.Size = new Size(319, 340);
            panel2.TabIndex = 1;
            // 
            // txtcola
            // 
            txtcola.BorderStyle = BorderStyle.FixedSingle;
            txtcola.Location = new Point(198, 249);
            txtcola.Name = "txtcola";
            txtcola.Size = new Size(106, 23);
            txtcola.TabIndex = 12;
            // 
            // chcola
            // 
            chcola.AutoSize = true;
            chcola.Font = new Font("Dubai Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            chcola.Location = new Point(15, 244);
            chcola.Name = "chcola";
            chcola.Size = new Size(102, 31);
            chcola.TabIndex = 11;
            chcola.Text = "Cola Cola";
            chcola.UseVisualStyleBackColor = true;
            chcola.CheckedChanged += chcola_CheckedChanged;
            // 
            // txtsprite
            // 
            txtsprite.BorderStyle = BorderStyle.FixedSingle;
            txtsprite.Location = new Point(198, 155);
            txtsprite.Name = "txtsprite";
            txtsprite.Size = new Size(106, 23);
            txtsprite.TabIndex = 10;
            // 
            // chsprite
            // 
            chsprite.AutoSize = true;
            chsprite.Font = new Font("Dubai Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            chsprite.Location = new Point(15, 150);
            chsprite.Name = "chsprite";
            chsprite.Size = new Size(78, 31);
            chsprite.TabIndex = 9;
            chsprite.Text = "Sprite";
            chsprite.UseVisualStyleBackColor = true;
            chsprite.CheckedChanged += chsprite_CheckedChanged;
            // 
            // txtfanta
            // 
            txtfanta.BorderStyle = BorderStyle.FixedSingle;
            txtfanta.Location = new Point(198, 104);
            txtfanta.Name = "txtfanta";
            txtfanta.Size = new Size(106, 23);
            txtfanta.TabIndex = 8;
            // 
            // chfanta
            // 
            chfanta.AutoSize = true;
            chfanta.Font = new Font("Dubai Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            chfanta.Location = new Point(15, 99);
            chfanta.Name = "chfanta";
            chfanta.Size = new Size(74, 31);
            chfanta.TabIndex = 7;
            chfanta.Text = "Fanta";
            chfanta.UseVisualStyleBackColor = true;
            chfanta.CheckedChanged += chfanta_CheckedChanged;
            // 
            // txtmiranda
            // 
            txtmiranda.BorderStyle = BorderStyle.FixedSingle;
            txtmiranda.Location = new Point(199, 290);
            txtmiranda.Name = "txtmiranda";
            txtmiranda.Size = new Size(106, 23);
            txtmiranda.TabIndex = 6;
            // 
            // chmiranda
            // 
            chmiranda.AutoSize = true;
            chmiranda.Font = new Font("Dubai Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            chmiranda.Location = new Point(15, 285);
            chmiranda.Name = "chmiranda";
            chmiranda.Size = new Size(89, 31);
            chmiranda.TabIndex = 5;
            chmiranda.Text = "Mirinda";
            chmiranda.UseVisualStyleBackColor = true;
            chmiranda.CheckedChanged += chmiranda_CheckedChanged;
            // 
            // txtkunu
            // 
            txtkunu.BorderStyle = BorderStyle.FixedSingle;
            txtkunu.Location = new Point(198, 203);
            txtkunu.Name = "txtkunu";
            txtkunu.Size = new Size(106, 23);
            txtkunu.TabIndex = 4;
            // 
            // chkunu
            // 
            chkunu.AutoSize = true;
            chkunu.Font = new Font("Dubai Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            chkunu.Location = new Point(15, 195);
            chkunu.Name = "chkunu";
            chkunu.Size = new Size(69, 31);
            chkunu.TabIndex = 3;
            chkunu.Text = "Kunu";
            chkunu.UseVisualStyleBackColor = true;
            chkunu.CheckedChanged += chkunu_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(94, 10);
            label2.Name = "label2";
            label2.Size = new Size(87, 23);
            label2.TabIndex = 2;
            label2.Text = "DRINKS";
            // 
            // txtmango
            // 
            txtmango.BorderStyle = BorderStyle.FixedSingle;
            txtmango.Location = new Point(198, 58);
            txtmango.Name = "txtmango";
            txtmango.Size = new Size(106, 23);
            txtmango.TabIndex = 1;
            // 
            // chmango
            // 
            chmango.AutoSize = true;
            chmango.Font = new Font("Dubai Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            chmango.Location = new Point(15, 53);
            chmango.Name = "chmango";
            chmango.Size = new Size(125, 31);
            chmango.TabIndex = 0;
            chmango.Text = "Mango Juice";
            chmango.UseVisualStyleBackColor = true;
            chmango.CheckedChanged += chmango_CheckedChanged;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Info;
            panel3.Controls.Add(txtamala);
            panel3.Controls.Add(chamala);
            panel3.Controls.Add(txtfried);
            panel3.Controls.Add(chfried);
            panel3.Controls.Add(txtjollof);
            panel3.Controls.Add(chjollof);
            panel3.Controls.Add(txtsemovita);
            panel3.Controls.Add(chsemovita);
            panel3.Controls.Add(txtpounded);
            panel3.Controls.Add(chpounded);
            panel3.Controls.Add(txtwhite);
            panel3.Controls.Add(chwhite);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(331, 74);
            panel3.Name = "panel3";
            panel3.Size = new Size(303, 340);
            panel3.TabIndex = 2;
            // 
            // txtamala
            // 
            txtamala.BorderStyle = BorderStyle.FixedSingle;
            txtamala.Location = new Point(189, 235);
            txtamala.Name = "txtamala";
            txtamala.Size = new Size(106, 23);
            txtamala.TabIndex = 24;
            // 
            // chamala
            // 
            chamala.AutoSize = true;
            chamala.Font = new Font("Dubai Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            chamala.Location = new Point(6, 230);
            chamala.Name = "chamala";
            chamala.Size = new Size(79, 31);
            chamala.TabIndex = 23;
            chamala.Text = "Amala";
            chamala.UseVisualStyleBackColor = true;
            chamala.CheckedChanged += chamala_CheckedChanged;
            // 
            // txtfried
            // 
            txtfried.BorderStyle = BorderStyle.FixedSingle;
            txtfried.Location = new Point(189, 141);
            txtfried.Name = "txtfried";
            txtfried.Size = new Size(106, 23);
            txtfried.TabIndex = 22;
            // 
            // chfried
            // 
            chfried.AutoSize = true;
            chfried.Font = new Font("Dubai Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            chfried.Location = new Point(6, 136);
            chfried.Name = "chfried";
            chfried.Size = new Size(107, 31);
            chfried.TabIndex = 21;
            chfried.Text = "Fried Rice";
            chfried.UseVisualStyleBackColor = true;
            chfried.CheckedChanged += chfried_CheckedChanged;
            // 
            // txtjollof
            // 
            txtjollof.BorderStyle = BorderStyle.FixedSingle;
            txtjollof.Location = new Point(189, 90);
            txtjollof.Name = "txtjollof";
            txtjollof.Size = new Size(106, 23);
            txtjollof.TabIndex = 20;
            // 
            // chjollof
            // 
            chjollof.AutoSize = true;
            chjollof.Font = new Font("Dubai Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            chjollof.Location = new Point(6, 85);
            chjollof.Name = "chjollof";
            chjollof.Size = new Size(110, 31);
            chjollof.TabIndex = 19;
            chjollof.Text = "Jollof Rice";
            chjollof.UseVisualStyleBackColor = true;
            chjollof.CheckedChanged += chjollof_CheckedChanged;
            // 
            // txtsemovita
            // 
            txtsemovita.BorderStyle = BorderStyle.FixedSingle;
            txtsemovita.Location = new Point(190, 276);
            txtsemovita.Name = "txtsemovita";
            txtsemovita.Size = new Size(106, 23);
            txtsemovita.TabIndex = 18;
            // 
            // chsemovita
            // 
            chsemovita.AutoSize = true;
            chsemovita.Font = new Font("Dubai Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            chsemovita.Location = new Point(6, 271);
            chsemovita.Name = "chsemovita";
            chsemovita.Size = new Size(102, 31);
            chsemovita.TabIndex = 17;
            chsemovita.Text = "Semovita";
            chsemovita.UseVisualStyleBackColor = true;
            chsemovita.CheckedChanged += chsemovita_CheckedChanged;
            // 
            // txtpounded
            // 
            txtpounded.BorderStyle = BorderStyle.FixedSingle;
            txtpounded.Location = new Point(189, 189);
            txtpounded.Name = "txtpounded";
            txtpounded.Size = new Size(106, 23);
            txtpounded.TabIndex = 16;
            // 
            // chpounded
            // 
            chpounded.AutoSize = true;
            chpounded.Font = new Font("Dubai Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            chpounded.Location = new Point(6, 181);
            chpounded.Name = "chpounded";
            chpounded.Size = new Size(134, 31);
            chpounded.TabIndex = 15;
            chpounded.Text = "Pounded Yam";
            chpounded.UseVisualStyleBackColor = true;
            chpounded.CheckedChanged += chpounded_CheckedChanged;
            // 
            // txtwhite
            // 
            txtwhite.BorderStyle = BorderStyle.FixedSingle;
            txtwhite.Location = new Point(189, 44);
            txtwhite.Name = "txtwhite";
            txtwhite.Size = new Size(106, 23);
            txtwhite.TabIndex = 14;
            // 
            // chwhite
            // 
            chwhite.AutoSize = true;
            chwhite.Font = new Font("Dubai Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            chwhite.Location = new Point(6, 39);
            chwhite.Name = "chwhite";
            chwhite.Size = new Size(114, 31);
            chwhite.TabIndex = 13;
            chwhite.Text = "White Rice";
            chwhite.UseVisualStyleBackColor = true;
            chwhite.CheckedChanged += chwhite_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(112, 10);
            label3.Name = "label3";
            label3.Size = new Size(65, 23);
            label3.TabIndex = 3;
            label3.Text = "FOOD";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.Info;
            panel4.Controls.Add(txtscharge);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(txtcostoffood);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(txtcostofdrink);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(6, 420);
            panel4.Name = "panel4";
            panel4.Size = new Size(319, 150);
            panel4.TabIndex = 3;
            // 
            // txtscharge
            // 
            txtscharge.BorderStyle = BorderStyle.FixedSingle;
            txtscharge.Location = new Point(186, 112);
            txtscharge.Name = "txtscharge";
            txtscharge.Size = new Size(106, 23);
            txtscharge.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Dubai Medium", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(24, 109);
            label6.Name = "label6";
            label6.Size = new Size(119, 25);
            label6.TabIndex = 10;
            label6.Text = "Service Charge";
            // 
            // txtcostoffood
            // 
            txtcostoffood.BorderStyle = BorderStyle.FixedSingle;
            txtcostoffood.Location = new Point(187, 65);
            txtcostoffood.Name = "txtcostoffood";
            txtcostoffood.Size = new Size(106, 23);
            txtcostoffood.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Dubai Medium", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(25, 62);
            label5.Name = "label5";
            label5.Size = new Size(103, 25);
            label5.TabIndex = 8;
            label5.Text = "Cost of Food";
            // 
            // txtcostofdrink
            // 
            txtcostofdrink.BorderStyle = BorderStyle.FixedSingle;
            txtcostofdrink.Location = new Point(186, 21);
            txtcostofdrink.Name = "txtcostofdrink";
            txtcostofdrink.Size = new Size(106, 23);
            txtcostofdrink.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Dubai Medium", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(24, 18);
            label4.Name = "label4";
            label4.Size = new Size(107, 25);
            label4.TabIndex = 0;
            label4.Text = "Cost of Drink";
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.Info;
            panel5.Controls.Add(txttotal);
            panel5.Controls.Add(label9);
            panel5.Controls.Add(txtvat);
            panel5.Controls.Add(label8);
            panel5.Controls.Add(txtsubtotal);
            panel5.Controls.Add(label7);
            panel5.Location = new Point(331, 420);
            panel5.Name = "panel5";
            panel5.Size = new Size(303, 150);
            panel5.TabIndex = 4;
            // 
            // txttotal
            // 
            txttotal.BorderStyle = BorderStyle.FixedSingle;
            txttotal.Location = new Point(169, 112);
            txttotal.Name = "txttotal";
            txttotal.Size = new Size(106, 23);
            txttotal.TabIndex = 13;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Dubai Medium", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(24, 109);
            label9.Name = "label9";
            label9.Size = new Size(50, 25);
            label9.TabIndex = 12;
            label9.Text = "Total";
            // 
            // txtvat
            // 
            txtvat.BorderStyle = BorderStyle.FixedSingle;
            txtvat.Location = new Point(169, 24);
            txtvat.Name = "txtvat";
            txtvat.Size = new Size(106, 23);
            txtvat.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Dubai Medium", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(24, 21);
            label8.Name = "label8";
            label8.Size = new Size(44, 25);
            label8.TabIndex = 10;
            label8.Text = "VAT";
            // 
            // txtsubtotal
            // 
            txtsubtotal.BorderStyle = BorderStyle.FixedSingle;
            txtsubtotal.Location = new Point(169, 66);
            txtsubtotal.Name = "txtsubtotal";
            txtsubtotal.Size = new Size(106, 23);
            txtsubtotal.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Dubai Medium", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(24, 63);
            label7.Name = "label7";
            label7.Size = new Size(77, 25);
            label7.TabIndex = 8;
            label7.Text = "Sub total";
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.Info;
            panel6.Controls.Add(btnexit);
            panel6.Controls.Add(btnreset);
            panel6.Controls.Add(btnreciept);
            panel6.Controls.Add(btntotal);
            panel6.ForeColor = SystemColors.ControlLightLight;
            panel6.Location = new Point(640, 470);
            panel6.Name = "panel6";
            panel6.Size = new Size(325, 100);
            panel6.TabIndex = 5;
            // 
            // btnexit
            // 
            btnexit.BackColor = Color.Red;
            btnexit.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnexit.Location = new Point(120, 62);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(86, 35);
            btnexit.TabIndex = 3;
            btnexit.Text = "EXIT";
            btnexit.UseVisualStyleBackColor = false;
            btnexit.Click += btnexit_Click;
            // 
            // btnreset
            // 
            btnreset.BackColor = Color.Goldenrod;
            btnreset.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnreset.Location = new Point(225, 12);
            btnreset.Name = "btnreset";
            btnreset.Size = new Size(86, 35);
            btnreset.TabIndex = 2;
            btnreset.Text = "RESET";
            btnreset.UseVisualStyleBackColor = false;
            btnreset.Click += btnreset_Click;
            // 
            // btnreciept
            // 
            btnreciept.BackColor = Color.Goldenrod;
            btnreciept.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnreciept.Location = new Point(120, 12);
            btnreciept.Name = "btnreciept";
            btnreciept.Size = new Size(86, 35);
            btnreciept.TabIndex = 1;
            btnreciept.Text = "RECIEPT";
            btnreciept.UseVisualStyleBackColor = false;
            btnreciept.Click += btnreciept_Click;
            // 
            // btntotal
            // 
            btntotal.BackColor = Color.Goldenrod;
            btntotal.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btntotal.Location = new Point(12, 12);
            btntotal.Name = "btntotal";
            btntotal.Size = new Size(86, 35);
            btntotal.TabIndex = 0;
            btntotal.Text = "TOTAL";
            btntotal.UseVisualStyleBackColor = false;
            btntotal.Click += btntotal_Click;
            // 
            // panel7
            // 
            panel7.Controls.Add(toolStrip1);
            panel7.Controls.Add(rtbreciept);
            panel7.Location = new Point(640, 74);
            panel7.Name = "panel7";
            panel7.Size = new Size(325, 389);
            panel7.TabIndex = 6;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { newToolStripButton, openToolStripButton, saveToolStripButton, printToolStripButton, toolStripSeparator, copyToolStripButton, toolStripSeparator1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(325, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // newToolStripButton
            // 
            newToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            newToolStripButton.Image = (Image)resources.GetObject("newToolStripButton.Image");
            newToolStripButton.ImageTransparentColor = Color.Magenta;
            newToolStripButton.Name = "newToolStripButton";
            newToolStripButton.Size = new Size(23, 22);
            newToolStripButton.Text = "&New";
            // 
            // openToolStripButton
            // 
            openToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            openToolStripButton.Image = (Image)resources.GetObject("openToolStripButton.Image");
            openToolStripButton.ImageTransparentColor = Color.Magenta;
            openToolStripButton.Name = "openToolStripButton";
            openToolStripButton.Size = new Size(23, 22);
            openToolStripButton.Text = "&Open";
            // 
            // saveToolStripButton
            // 
            saveToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            saveToolStripButton.Image = (Image)resources.GetObject("saveToolStripButton.Image");
            saveToolStripButton.ImageTransparentColor = Color.Magenta;
            saveToolStripButton.Name = "saveToolStripButton";
            saveToolStripButton.Size = new Size(23, 22);
            saveToolStripButton.Text = "&Save";
            // 
            // printToolStripButton
            // 
            printToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            printToolStripButton.Image = (Image)resources.GetObject("printToolStripButton.Image");
            printToolStripButton.ImageTransparentColor = Color.Magenta;
            printToolStripButton.Name = "printToolStripButton";
            printToolStripButton.Size = new Size(23, 22);
            printToolStripButton.Text = "&Print";
            printToolStripButton.Click += printToolStripButton_Click;
            // 
            // toolStripSeparator
            // 
            toolStripSeparator.Name = "toolStripSeparator";
            toolStripSeparator.Size = new Size(6, 25);
            // 
            // copyToolStripButton
            // 
            copyToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            copyToolStripButton.Image = (Image)resources.GetObject("copyToolStripButton.Image");
            copyToolStripButton.ImageTransparentColor = Color.Magenta;
            copyToolStripButton.Name = "copyToolStripButton";
            copyToolStripButton.Size = new Size(23, 22);
            copyToolStripButton.Text = "&Copy";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // rtbreciept
            // 
            rtbreciept.Location = new Point(0, 28);
            rtbreciept.Name = "rtbreciept";
            rtbreciept.Size = new Size(319, 358);
            rtbreciept.TabIndex = 0;
            rtbreciept.Text = "";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(977, 582);
            Controls.Add(panel7);
            Controls.Add(lbtime);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Label label1;
        private CheckBox chmango;
        private TextBox txtmango;
        private Label label2;
        private Label label3;
        private TextBox txtcola;
        private CheckBox chcola;
        private TextBox txtsprite;
        private CheckBox chsprite;
        private TextBox txtfanta;
        private CheckBox chfanta;
        private TextBox txtmiranda;
        private CheckBox chmiranda;
        private TextBox txtkunu;
        private CheckBox chkunu;
        private Button btntotal;
        private Button btnexit;
        private Button btnreset;
        private Button btnreciept;
        private TextBox txtscharge;
        private Label label6;
        private TextBox txtcostoffood;
        private Label label5;
        private TextBox txtcostofdrink;
        private Label label4;
        private TextBox txttotal;
        private Label label9;
        private TextBox txtvat;
        private Label label8;
        private TextBox txtsubtotal;
        private Label label7;
        private Panel panel7;
        private ToolStrip toolStrip1;
        private RichTextBox rtbreciept;
        private ToolStripButton newToolStripButton;
        private ToolStripButton openToolStripButton;
        private ToolStripButton saveToolStripButton;
        private ToolStripButton printToolStripButton;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripButton copyToolStripButton;
        private ToolStripSeparator toolStripSeparator1;
        private TextBox txtamala;
        private CheckBox chamala;
        private TextBox txtfried;
        private CheckBox chfried;
        private TextBox txtjollof;
        private CheckBox chjollof;
        private TextBox txtsemovita;
        private CheckBox chsemovita;
        private TextBox txtpounded;
        private CheckBox chpounded;
        private TextBox txtwhite;
        private CheckBox chwhite;
        private Label lbtime;
        private System.Windows.Forms.Timer timer1;
        private Label lbdate;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
    }
}