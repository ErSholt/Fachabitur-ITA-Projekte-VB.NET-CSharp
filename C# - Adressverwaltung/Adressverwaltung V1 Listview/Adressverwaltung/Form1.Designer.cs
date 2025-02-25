namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblname = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.lblvorname = new System.Windows.Forms.Label();
            this.txtvorname = new System.Windows.Forms.TextBox();
            this.lbladresse = new System.Windows.Forms.Label();
            this.txtadresse = new System.Windows.Forms.TextBox();
            this.lblgeburtstag = new System.Windows.Forms.Label();
            this.txtgeburtstag = new System.Windows.Forms.TextBox();
            this.btnerneuern = new System.Windows.Forms.Button();
            this.btnlöschen = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.cbosortieren = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnclose = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.Location = new System.Drawing.Point(3, 351);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(305, 17);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(333, 82);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(35, 13);
            this.lblname.TabIndex = 1;
            this.lblname.Text = "Name";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(336, 99);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(82, 20);
            this.txtname.TabIndex = 2;
            // 
            // lblvorname
            // 
            this.lblvorname.AutoSize = true;
            this.lblvorname.Location = new System.Drawing.Point(479, 82);
            this.lblvorname.Name = "lblvorname";
            this.lblvorname.Size = new System.Drawing.Size(49, 13);
            this.lblvorname.TabIndex = 3;
            this.lblvorname.Text = "Vorname";
            // 
            // txtvorname
            // 
            this.txtvorname.Location = new System.Drawing.Point(482, 99);
            this.txtvorname.Name = "txtvorname";
            this.txtvorname.Size = new System.Drawing.Size(82, 20);
            this.txtvorname.TabIndex = 4;
            // 
            // lbladresse
            // 
            this.lbladresse.AutoSize = true;
            this.lbladresse.Location = new System.Drawing.Point(333, 140);
            this.lbladresse.Name = "lbladresse";
            this.lbladresse.Size = new System.Drawing.Size(45, 13);
            this.lbladresse.TabIndex = 5;
            this.lbladresse.Text = "Adresse";
            // 
            // txtadresse
            // 
            this.txtadresse.Location = new System.Drawing.Point(336, 156);
            this.txtadresse.Name = "txtadresse";
            this.txtadresse.Size = new System.Drawing.Size(228, 20);
            this.txtadresse.TabIndex = 6;
            // 
            // lblgeburtstag
            // 
            this.lblgeburtstag.AutoSize = true;
            this.lblgeburtstag.Location = new System.Drawing.Point(333, 196);
            this.lblgeburtstag.Name = "lblgeburtstag";
            this.lblgeburtstag.Size = new System.Drawing.Size(59, 13);
            this.lblgeburtstag.TabIndex = 7;
            this.lblgeburtstag.Text = "Geburtstag\r\n";
            // 
            // txtgeburtstag
            // 
            this.txtgeburtstag.Location = new System.Drawing.Point(336, 212);
            this.txtgeburtstag.Name = "txtgeburtstag";
            this.txtgeburtstag.Size = new System.Drawing.Size(228, 20);
            this.txtgeburtstag.TabIndex = 8;
            // 
            // btnerneuern
            // 
            this.btnerneuern.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnerneuern.BackgroundImage")));
            this.btnerneuern.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnerneuern.Location = new System.Drawing.Point(336, 251);
            this.btnerneuern.Name = "btnerneuern";
            this.btnerneuern.Size = new System.Drawing.Size(72, 62);
            this.btnerneuern.TabIndex = 9;
            this.btnerneuern.UseVisualStyleBackColor = true;
            this.btnerneuern.Click += new System.EventHandler(this.btnerneuern_Click);
            // 
            // btnlöschen
            // 
            this.btnlöschen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnlöschen.BackgroundImage")));
            this.btnlöschen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnlöschen.Location = new System.Drawing.Point(414, 251);
            this.btnlöschen.Name = "btnlöschen";
            this.btnlöschen.Size = new System.Drawing.Size(72, 62);
            this.btnlöschen.TabIndex = 10;
            this.btnlöschen.UseVisualStyleBackColor = true;
            this.btnlöschen.Click += new System.EventHandler(this.btnlöschen_Click);
            // 
            // btnadd
            // 
            this.btnadd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnadd.BackgroundImage")));
            this.btnadd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnadd.Location = new System.Drawing.Point(492, 251);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(72, 62);
            this.btnadd.TabIndex = 11;
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // cbosortieren
            // 
            this.cbosortieren.FormattingEnabled = true;
            this.cbosortieren.Location = new System.Drawing.Point(3, 30);
            this.cbosortieren.Name = "cbosortieren";
            this.cbosortieren.Size = new System.Drawing.Size(305, 21);
            this.cbosortieren.TabIndex = 12;
            this.cbosortieren.SelectedIndexChanged += new System.EventHandler(this.cbosortieren_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Adressen sortieren nach:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(333, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Suche nach Inhalten in Datensätzen:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(336, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(228, 20);
            this.textBox1.TabIndex = 15;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(327, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 2);
            this.label3.TabIndex = 16;
            // 
            // btnclose
            // 
            this.btnclose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnclose.BackgroundImage")));
            this.btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnclose.Location = new System.Drawing.Point(336, 319);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(228, 46);
            this.btnclose.TabIndex = 17;
            this.btnclose.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(3, 58);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(305, 278);
            this.listView1.TabIndex = 18;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 384);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbosortieren);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btnlöschen);
            this.Controls.Add(this.btnerneuern);
            this.Controls.Add(this.txtgeburtstag);
            this.Controls.Add(this.lblgeburtstag);
            this.Controls.Add(this.txtadresse);
            this.Controls.Add(this.lbladresse);
            this.Controls.Add(this.txtvorname);
            this.Controls.Add(this.lblvorname);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.listBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Adressenverwaltung";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label lblvorname;
        private System.Windows.Forms.TextBox txtvorname;
        private System.Windows.Forms.Label lbladresse;
        private System.Windows.Forms.TextBox txtadresse;
        private System.Windows.Forms.Label lblgeburtstag;
        private System.Windows.Forms.TextBox txtgeburtstag;
        private System.Windows.Forms.Button btnerneuern;
        private System.Windows.Forms.Button btnlöschen;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.ComboBox cbosortieren;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.ListView listView1;
    }
}

