using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        FileStream einlesen,delete, adden, suchenreader;
        string zeile,editz;
        int i,suchen;
        const string buchstaben = "abcdefghijklmnopqrstuvwxyz";
        int index = -1;
        int count;
        public virtual int SelectedIndex { get; set; }

        public Form1()
        {
            InitializeComponent();
        }
        //################################################
        private void Form1_Load(object sender, EventArgs e)
        {
            //--------------------Tooltips-----------------
            
            cbosortieren.Items.Add("Name");
            cbosortieren.Items.Add("Vorname");
            cbosortieren.Items.Add("Geburtstag");
            cbosortieren.Items.Add("Adresse");

            ToolTip del = new ToolTip();
            del.ShowAlways = true;
            del.SetToolTip(btnlöschen, "Datensatz löschen");

            ToolTip add = new ToolTip();
            add.ShowAlways = true;
            add.SetToolTip(btnadd, "Datensatz hinzufügen");

            ToolTip recycle = new ToolTip();
            recycle.ShowAlways = true;
            recycle.SetToolTip(btnerneuern, "Datensatz aktualisieren");

            ToolTip beenden = new ToolTip();
            beenden.ShowAlways = true;
            beenden.SetToolTip(btnclose, "Programm beenden");



           //--------------------GeburtstagsFarbe-----------------
            string komma = ",";
            char[] koma = komma.ToCharArray();
            einlesen = new FileStream("adressen.txt", FileMode.Open, FileAccess.Read);
            StreamReader lesen = new StreamReader(einlesen, System.Text.Encoding.UTF7);
            while (lesen.Peek() != -1)
            {
                zeile = lesen.ReadLine();
                editz = zeile;
                
                int editzl = editz.Length;
                int position1 = editz.IndexOfAny(koma);
                int position2 = editz.IndexOfAny(koma, position1 + 1);
                int position3 = editz.IndexOfAny(koma, position2 + 1);
                string geburtstag = editz.Substring(position3 + 2, editzl - (position3 + 2));
 
                TimeSpan differenz;
                DateTime geb;
                geb = Convert.ToDateTime(geburtstag);
                DateTime heute = DateTime.Today;
                differenz = geb - heute;                                             
                int tag = differenz.Days;
                      
                if ( tag >= 0 && tag < 2)
                {
                    listView1.Items.Add(zeile).ForeColor = Color.Red;
                }
                else if (tag >= 2 && tag < 7)
                {
                    listView1.Items.Add(zeile).ForeColor = Color.Yellow;
                }
                else if (tag >= 7 && tag < 14)
                {
                    listView1.Items.Add(zeile).ForeColor = Color.Green;
                }
                else
                {
                    listView1.Items.Add(zeile);
                }               
            }
            lesen.Close();
        }
        //################################################
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listBox1.SelectedIndex == -1)
            {
            }
            else
            {
                editz = listBox1.SelectedItem.ToString();
                string komma = ",";
                char[] koma = komma.ToCharArray();              
                int editzl = editz.Length;
                int position1 = editz.IndexOfAny(koma);
                int position2 = editz.IndexOfAny(koma, position1 + 1);
                int position3 = editz.IndexOfAny(koma, position2 + 1);

                if (position1 == -1 || position2 == -1 || position3 == -1)
                {
                }
                else
                {
                    string name = editz.Substring(0, position1);
                    string vorname = editz.Substring(position1 + 2, position2 - (position1 + 2));
                    string adresse = editz.Substring(position2 + 2, position3 - (position2 + 2));
                    string geburtstag = editz.Substring(position3 + 2, editzl - (position3 + 2));

                    txtadresse.Text = adresse;
                    txtgeburtstag.Text = geburtstag;
                    txtname.Text = name;
                    txtvorname.Text = vorname;
                }
            }
            
        }
        //################################################
        private void btnlöschen_Click(object sender, EventArgs e)
        {

            int select = listBox1.SelectedIndex;
            string[] array = new string[listBox1.Items.Count];

            delete = new FileStream("adressen.txt", FileMode.Create, FileAccess.Write);
            StreamWriter löschen = new StreamWriter(delete, System.Text.Encoding.UTF7);         
            for (i = 0; i < listBox1.Items.Count; i++)
            {
                if (i == select)
                {                
                }
                else
                {
                    object s = listBox1.Items[i];
                    array[i] = s.ToString();
                    löschen.WriteLine(array[i]);
                }
            }
            löschen.Close();
            listBox1.Items.Clear();

            einlesen = new FileStream("adressen.txt", FileMode.Open, FileAccess.Read);
            StreamReader lesen = new StreamReader(einlesen, System.Text.Encoding.UTF7);
            while (lesen.Peek() != -1)
            {
                zeile = lesen.ReadLine();
                listBox1.Items.Add(zeile);
            }
            lesen.Close();        

            txtadresse.Text= "";
            txtname.Text = "";
            txtvorname.Text = "";
            txtgeburtstag.Text = "";   
           
        }
        //################################################
        private void btnadd_Click(object sender, EventArgs e)
        {

            listBox1.Items.Clear();

            string name = txtname.Text;
            string vorname = txtvorname.Text;
            string adresse = txtadresse.Text;
            string geburtstag = txtgeburtstag.Text;
            string zeile = name + ", " + vorname + ", " + adresse + ", " + geburtstag;

            adden = new FileStream("adressen.txt", FileMode.Append, FileAccess.Write);
            StreamWriter adden1 = new StreamWriter(adden, System.Text.Encoding.UTF7);
            {
                adden1.WriteLine(zeile);              
            }
            adden1.Close();

            einlesen = new FileStream("adressen.txt", FileMode.Open, FileAccess.Read);
            StreamReader lesen = new StreamReader(einlesen, System.Text.Encoding.UTF7);
            while (lesen.Peek() != -1)
            {
                zeile = lesen.ReadLine();
                listBox1.Items.Add(zeile);
            }
            lesen.Close(); 

            txtadresse.Text= "";
            txtname.Text = "";
            txtvorname.Text = "";
            txtgeburtstag.Text = "";
        }
        //################################################
        private void btnerneuern_Click(object sender, EventArgs e)
        {

            int select = listBox1.SelectedIndex;
            string[] array = new string[listBox1.Items.Count];

            delete = new FileStream("adressen.txt", FileMode.Create, FileAccess.Write);
            StreamWriter löschen = new StreamWriter(delete, System.Text.Encoding.UTF7);
            for (i = 0; i < listBox1.Items.Count; i++)
            {
                if (i == select)
                {
                    string name = txtname.Text;
                    string vorname = txtvorname.Text;
                    string adresse = txtadresse.Text;
                    string geburtstag = txtgeburtstag.Text;
                    string zeile = name + ", " + vorname + ", " + adresse + ", " + geburtstag;

                    löschen.WriteLine(zeile);

                }
                else
                {
                    object s = listBox1.Items[i];
                    array[i] = s.ToString();
                    löschen.WriteLine(array[i]);
                }
            }
            löschen.Close();
            listBox1.Items.Clear();

            einlesen = new FileStream("adressen.txt", FileMode.Open, FileAccess.Read);
            StreamReader lesen = new StreamReader(einlesen, System.Text.Encoding.UTF7);
            while (lesen.Peek() != -1)
            {
                zeile = lesen.ReadLine();
                listBox1.Items.Add(zeile);
            }
            lesen.Close();

            txtadresse.Text = "";
            txtname.Text = "";
            txtvorname.Text = "";
            txtgeburtstag.Text = "";    
        }
        //################################################
        private void cbosortieren_SelectedIndexChanged(object sender, EventArgs e)
        {

            string komma = ",";
            char[] koma = komma.ToCharArray();
            string item = cbosortieren.SelectedItem.ToString();

            //------------------Name------------------------------

            if (item == "Name")
            {
                listBox1.Sorted = true;
            }


            //-------------------Vorname-----------------------------

            if (item == "Vorname")
            {
                                                                       
                    listBox1.Items.Clear();
                    einlesen = new FileStream("adressen.txt", FileMode.Open, FileAccess.Read);
                    StreamReader lesen = new StreamReader(einlesen, System.Text.Encoding.UTF7);
                    while (lesen.Peek() != -1)
                    {
                        zeile = lesen.ReadLine();
                        listBox1.Items.Add(zeile);
                    }
                    lesen.Close();
                               
            }
        }              
        //################################################
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            string[] zeile = new string[count];
            suchenreader = new FileStream("adressen.txt", FileMode.Open, FileAccess.Read);
            StreamReader suchenread = new StreamReader(suchenreader, System.Text.Encoding.UTF7);          
            while (suchenread.Peek() != -1)
            {
                string wort = textBox1.Text;
                string zeilener = suchenread.ReadLine();
                count = count + 1;              
                suchen = zeilener.IndexOf(wort);

                if( suchen == -1)
                {
                }
                else
                {
                    listBox1.Items.Add(zeilener);
                }                
            }
            suchenread.Close();
        }
        //################################################
        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            

            
            

           index = listView1.SelectedIndices[0];

           if (index < 0)
           {
           }
           else
           {
               {
                   object s = listView1.SelectedItems[0].Text;
                   string editz = s.ToString();

                   
                   string komma = ",";
                   char[] koma = komma.ToCharArray();
                   int editzl = editz.Length;
                   int position1 = editz.IndexOfAny(koma);
                   int position2 = editz.IndexOfAny(koma, position1 + 1);
                   int position3 = editz.IndexOfAny(koma, position2 + 1);

                   if (position1 == -1 || position2 == -1 || position3 == -1)
                   {
                   }
                   else
                   {
                       string name = editz.Substring(0, position1);
                       string vorname = editz.Substring(position1 + 2, position2 - (position1 + 2));
                       string adresse = editz.Substring(position2 + 2, position3 - (position2 + 2));
                       string geburtstag = editz.Substring(position3 + 2, editzl - (position3 + 2));

                       txtadresse.Text = adresse;
                       txtgeburtstag.Text = geburtstag;
                       txtname.Text = name;
                       txtvorname.Text = vorname;
                       
                       
                   }


               }
           }

          
           






        }
        //################################################




        }
    }

