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
        FileStream einlesen, delete, adden, suchenreader, einlesen2, einlesen3,erneuern;
        string zeile,editz;
        int i,suchen,a;
        const string buchstaben = "abcdefghijklmnopqrstuvwxyz";
        int zählen;
        int count;
        string gebneu;
        Boolean warner = true;
        const string komma = ",";
        


        public Form1()
        {
            InitializeComponent();
        }
        //################################################
        private void Form1_Load(object sender, EventArgs e)
        {
                    
            this.MaximumSize = new System.Drawing.Size(593, 411);
            this.MinimumSize  = new System.Drawing.Size(593, 411);

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

            einlesen = new FileStream("adressen.txt", FileMode.Open, FileAccess.Read);
            StreamReader lesen = new StreamReader(einlesen, System.Text.Encoding.UTF7);
            while (lesen.Peek() != -1)
            {
                zeile = lesen.ReadLine();
                editz = zeile;
                listBox1.Items.Add(zeile);
                
            }
            lesen.Close();
           

        }
        //################################################
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            char[] koma = komma.ToCharArray();




            if (listBox1.SelectedIndex == -1)
            {
            }
            else
            {
                editz = listBox1.SelectedItem.ToString();                             
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
            //--------speichert daten--------------------------------------------------
            string altsuche = textBox1.Text;
            Boolean gleich = false;
            int zählen2 = 0;
            int select = listBox1.SelectedIndex;
            string zdel = listBox1.SelectedItem.ToString();
           
            //--------------zählt einträge in txtdatei---------------------------------
            einlesen  = new FileStream("adressen.txt", FileMode.Open, FileAccess.Read);
            StreamReader lesen = new StreamReader(einlesen, System.Text.Encoding.UTF7);
            while (lesen.Peek() != -1)
            {
                zeile = lesen.ReadLine();
                zählen = zählen + 1;

            }
            lesen.Close();                            
            string[] zahl = new string[zählen];

           //--------------füllt array mit den erwünschten datensätzen----------------
            einlesen2 = new FileStream("adressen.txt", FileMode.Open, FileAccess.Read);
            StreamReader lesen2 = new StreamReader(einlesen2, System.Text.Encoding.UTF7);
            while (lesen2.Peek() != -1)
            {
                if (gleich == false)
                {
                    zeile = lesen2.ReadLine();
                    if (zeile == zdel)
                    {
                        gleich = true;
                    }
                    else
                    {
                        zahl[zählen2] = zeile;
                        zählen2 = zählen2 + 1;
                        
                    }
                }
                else
                {
                    zeile = lesen2.ReadLine();
                    zahl[zählen2] = zeile;
                    zählen2 = zählen2 + 1;
                }              
            }
            lesen2.Close();

            //-------------schreibt gewünschte daten sätze in die txt-----------------
            delete = new FileStream("adressen.txt", FileMode.Create , FileAccess.Write);
            StreamWriter löschen= new StreamWriter(delete, System.Text.Encoding.UTF7);
            {
                for(i = 0; i < zählen2; i++)
                {
               löschen.WriteLine(zahl[i]);
                }
            }
            löschen.Close();
            listBox1.Items.Clear();

            //-------------zeigt gewünschte daten sätze an -----------------------------
            einlesen3 = new FileStream("adressen.txt", FileMode.Open, FileAccess.Read);
            StreamReader lesen3 = new StreamReader(einlesen3, System.Text.Encoding.UTF7);
            while (lesen3.Peek() != -1)
            {
                zeile = lesen3.ReadLine();               
                listBox1.Items.Add(zeile);

            }
            lesen3.Close();

            //--------Zeigt alte such option an--------------------------------------------------
            textBox1.Text = "";
            textBox1.Text = altsuche;

            //--------warner wird aktualisiert--------------------------------------------------
            if (warner == false)
            {
                warner = true;
                btnwarner.PerformClick();
            }
        }
        //################################################
        private void btnadd_Click(object sender, EventArgs e)
        {
            char[] koma = komma.ToCharArray();
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

            if (warner == false)
            {
                warner = true;
                btnwarner.PerformClick();
            }

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

            if (warner == false)
            {
                warner = true;
                btnwarner.PerformClick();
            }
        }
        //################################################
        private void cbosortieren_SelectedIndexChanged(object sender, EventArgs e)
        {
            char[] koma = komma.ToCharArray();
            //------------------itemszählen und deklaration reset------------------------------
            string altsuche = textBox1.Text;            
            string item = cbosortieren.SelectedItem.ToString();

            listBox1.Sorted = false;
            count = 0;
            zählen = 0;

            einlesen = new FileStream("adressen.txt", FileMode.Open, FileAccess.Read);
            StreamReader lesen = new StreamReader(einlesen, System.Text.Encoding.UTF7);
            while (lesen.Peek() != -1)
            {
                zeile = lesen.ReadLine();
                zählen = zählen + 1;

            }
            lesen.Close();

            string[] vnarray = new string[zählen];
            string[] zeilearray = new string[zählen];
            string[] vtonarray = new string[zählen];


            //------------------Name------------------------------

            if (item == "Name")
            {
                listBox1.Sorted = true;
            }

            //-------------------Vorname-----------------------------

            if (item == "Vorname")              
            {
                               
                einlesen = new FileStream("adressen.txt", FileMode.Open, FileAccess.Read);
                StreamReader arraylesen = new StreamReader(einlesen, System.Text.Encoding.UTF7);
                while (arraylesen.Peek() != -1)
                {
                    zeile = arraylesen.ReadLine();
                    zeilearray[count] = zeile;
                    editz = zeile;

                    int editzl = editz.Length;
                    int position1 = editz.IndexOfAny(koma);
                    int position2 = editz.IndexOfAny(koma, position1 + 1);
                    int position3 = editz.IndexOfAny(koma, position2 + 1);
                  
                    string name = editz.Substring(0, position1);
                    string vorname = editz.Substring(position1 + 2, position2 - (position1 + 2));
                    string adresse = editz.Substring(position2 + 2, position3 - (position2 + 2));
                    string geburtstag = editz.Substring(position3 + 2, editzl - (position3 + 2));

                    vnarray[count] = vorname + ", " + name + ", " + adresse + ", " + geburtstag; 

                    count = count + 1;
                }
                arraylesen.Close();
                Array.Sort(vnarray);

                for (i = 0; i < count; i++)
                {
                    string vton = vnarray[i];
                    editz = vton;

                    int editzl = editz.Length;
                    int position1 = editz.IndexOfAny(koma);
                    int position2 = editz.IndexOfAny(koma, position1 + 1);
                    int position3 = editz.IndexOfAny(koma, position2 + 1);

                    string vorname = editz.Substring(0, position1);
                    string name = editz.Substring(position1 + 2, position2 - (position1 + 2));
                    string adresse = editz.Substring(position2 + 2, position3 - (position2 + 2));
                    string geburtstag = editz.Substring(position3 + 2, editzl - (position3 + 2));


                    vtonarray[i] = name + ", " + vorname + ", " + adresse + ", " + geburtstag;

                }


                erneuern = new FileStream("adressen.txt", FileMode.Create, FileAccess.Write);
                StreamWriter aktu1 = new StreamWriter(erneuern, System.Text.Encoding.UTF7);
                for (i = 0; i < count; i++)
                {
                    aktu1.WriteLine(vtonarray[i]);               

                }
                aktu1.Close();
               
                listBox1.Items.Clear();
                einlesen = new FileStream("adressen.txt", FileMode.Open, FileAccess.Read);
                StreamReader arraylesen2 = new StreamReader(einlesen, System.Text.Encoding.UTF7);
                while (arraylesen2.Peek() != -1)
                {
                    string huffle = arraylesen2.ReadLine();
                    listBox1.Items.Add(huffle);
                }
                arraylesen2.Close();

                textBox1.Text = "";
                textBox1.Text = altsuche;

            }
           
            //-------------------Adresse-----------------------------

            if (item == "Adresse")
            {
                
                einlesen = new FileStream("adressen.txt", FileMode.Open, FileAccess.Read);
                StreamReader arraylesen = new StreamReader(einlesen, System.Text.Encoding.UTF7);
                while (arraylesen.Peek() != -1)
                {
                    zeile = arraylesen.ReadLine();
                    zeilearray[count] = zeile;
                    editz = zeile;

                    int editzl = editz.Length;
                    int position1 = editz.IndexOfAny(koma);
                    int position2 = editz.IndexOfAny(koma, position1 + 1);
                    int position3 = editz.IndexOfAny(koma, position2 + 1);

                    string name = editz.Substring(0, position1);
                    string vorname = editz.Substring(position1 + 2, position2 - (position1 + 2));
                    string adresse = editz.Substring(position2 + 2, position3 - (position2 + 2));
                    string geburtstag = editz.Substring(position3 + 2, editzl - (position3 + 2));

                    vnarray[count] = adresse + ", " + vorname + ", " + name + ", " + geburtstag;

                    count = count + 1;
                }
                arraylesen.Close();
                Array.Sort(vnarray);

                for (i = 0; i < count; i++)
                {
                    string vton = vnarray[i];
                    editz = vton;

                    int editzl = editz.Length;
                    int position1 = editz.IndexOfAny(koma);
                    int position2 = editz.IndexOfAny(koma, position1 + 1);
                    int position3 = editz.IndexOfAny(koma, position2 + 1);

                    string adresse = editz.Substring(0, position1);
                    string vorname = editz.Substring(position1 + 2, position2 - (position1 + 2));
                    string name = editz.Substring(position2 + 2, position3 - (position2 + 2));
                    string geburtstag = editz.Substring(position3 + 2, editzl - (position3 + 2));


                    vtonarray[i] = name + ", " + vorname + ", " + adresse + ", " + geburtstag;

                }
                erneuern = new FileStream("adressen.txt", FileMode.Create, FileAccess.Write);
                StreamWriter aktu1 = new StreamWriter(erneuern, System.Text.Encoding.UTF7);
                for (i = 0; i < count; i++)
                {
                    aktu1.WriteLine(vtonarray[i]);

                }
                aktu1.Close();

                listBox1.Items.Clear();
                einlesen = new FileStream("adressen.txt", FileMode.Open, FileAccess.Read);
                StreamReader arraylesen2 = new StreamReader(einlesen, System.Text.Encoding.UTF7);
                while (arraylesen2.Peek() != -1)
                {
                    string huffle = arraylesen2.ReadLine();
                    listBox1.Items.Add(huffle);
                }
                arraylesen2.Close();

                textBox1.Text = "";
                textBox1.Text = altsuche;


            }



            //-------------------geburtsag-----------------------------
            if (item == "Geburtstag")
            {

                einlesen = new FileStream("adressen.txt", FileMode.Open, FileAccess.Read);
                StreamReader arraylesen = new StreamReader(einlesen, System.Text.Encoding.UTF7);
                while (arraylesen.Peek() != -1)
                {
                    gebneu = "";
                    zeile = arraylesen.ReadLine();
                    zeilearray[count] = zeile;
                    editz = zeile;

                    int editzl = editz.Length;
                    int position1 = editz.IndexOfAny(koma);
                    int position2 = editz.IndexOfAny(koma, position1 + 1);
                    int position3 = editz.IndexOfAny(koma, position2 + 1);

                    string name = editz.Substring(0, position1);
                    string vorname = editz.Substring(position1 + 2, position2 - (position1 + 2));
                    string adresse = editz.Substring(position2 + 2, position3 - (position2 + 2));
                    string geburtstag = editz.Substring(position3 + 2, editzl - (position3 + 2));

                    string[] gebarray = geburtstag.Split('.');
                    
                    for (i = 2; i > -1; i--)
                    {
                        gebneu = gebneu + "." + gebarray[i];

                    }

                    vnarray[count] = gebneu + ", " + vorname + ", " + adresse + ", " + name;
                    count = count + 1;
                }
                arraylesen.Close();
                Array.Sort(vnarray);

                for (i = 0; i < count; i++)
                {
                    gebneu = "";
                    string vton = vnarray[i];                    
                    editz = vton;

                    int editzl = editz.Length;
                    int position1 = editz.IndexOfAny(koma);
                    int position2 = editz.IndexOfAny(koma, position1 + 1);
                    int position3 = editz.IndexOfAny(koma, position2 + 1);

                    string geburtstag = editz.Substring(0, position1);
                    string vorname = editz.Substring(position1 + 2, position2 - (position1 + 2));
                    string adresse = editz.Substring(position2 + 2, position3 - (position2 + 2));
                    string name = editz.Substring(position3 + 2, editzl - (position3 + 2));
                   
                    int max = geburtstag.Length;
                    string geburtstag2 = geburtstag.Substring(1, max - 1);
                    string[] gebarray = geburtstag2.Split('.');

                    for (a = 2; a >-1; a--)
                    {
                        if (a >0)
                        {
                            gebneu = gebneu + gebarray[a] + ".";
                        }
                        else
                        {
                            gebneu = gebneu + gebarray[a];
                        }
                    }
                    vtonarray[i] = name + ", " + vorname + ", " + adresse + ", " + gebneu;
                }
            
                erneuern = new FileStream("adressen.txt", FileMode.Create, FileAccess.Write);
                StreamWriter aktu1 = new StreamWriter(erneuern, System.Text.Encoding.UTF7);
                for (i = 0; i < count; i++)
                {
                    aktu1.WriteLine(vtonarray[i]);

                }
                aktu1.Close();

                listBox1.Items.Clear();
                einlesen = new FileStream("adressen.txt", FileMode.Open, FileAccess.Read);
                StreamReader arraylesen2 = new StreamReader(einlesen, System.Text.Encoding.UTF7);
                while (arraylesen2.Peek() != -1)
                {
                    string huffle = arraylesen2.ReadLine();
                    listBox1.Items.Add(huffle);
                }
                arraylesen2.Close();

                textBox1.Text = "";
                textBox1.Text = altsuche;
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
        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
        //################################################
        private void button1_Click(object sender, EventArgs e)
        {
            char[] koma = komma.ToCharArray();
            string[] vnarray = new string[zählen];           
            string[] vtonarray = new string[zählen];

            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();

            if (warner == true)
            {

                this.MaximumSize = new System.Drawing.Size(901, 411);
                this.MinimumSize = new System.Drawing.Size(901, 411);
               
                listBox2.Enabled = true;
                listBox3.Enabled = true;
                listBox4.Enabled = true;


                einlesen = new FileStream("adressen.txt", FileMode.Open, FileAccess.Read);
                StreamReader arraylesen = new StreamReader(einlesen, System.Text.Encoding.UTF7);
                while (arraylesen.Peek() != -1)
                {
                    gebneu = "";
                    zeile = arraylesen.ReadLine();                   
                    editz = zeile;

                    int editzl = editz.Length;
                    int position1 = editz.IndexOfAny(koma);
                    int position2 = editz.IndexOfAny(koma, position1 + 1);
                    int position3 = editz.IndexOfAny(koma, position2 + 1);

                    string name = editz.Substring(0, position1);
                    string vorname = editz.Substring(position1 + 2, position2 - (position1 + 2));
                    string adresse = editz.Substring(position2 + 2, position3 - (position2 + 2));
                    string geburtstag = editz.Substring(position3 + 2, editzl - (position3 + 2));

                    string[] gebarray = geburtstag.Split('.');
                                   
                    for (i = 0; i <2; i++)
                    {
                        gebneu = gebneu + gebarray[i] + ".";

                    }
             
                    string thisyear = DateTime.Today.ToString("yyyy");
                    gebneu = gebneu + thisyear;
                    DateTime geburtstag2 = Convert.ToDateTime(gebneu);
                    TimeSpan differenz;

                    differenz = geburtstag2 - DateTime.Today;



                    if (differenz.Days < 0)
                    {
                        gebneu = "";
                        for (i = 0; i < 2; i++)
                        {
                            gebneu = gebneu + gebarray[i] + ".";

                        }
                      
                        int nextyear =  DateTime.Today.Year + 1;
                        string ny = Convert.ToString(nextyear);

                        gebneu = gebneu + ny;
                        geburtstag2 = Convert.ToDateTime(gebneu);

                        differenz = geburtstag2 - DateTime.Today;
                    }


                    if (differenz.Days >-1 && differenz.Days < 7)
                    {
                        listBox2.Items.Add(zeile);



                    }
                    else if (differenz.Days > 6 && differenz.Days < 11)
                    {
                        listBox3.Items.Add(zeile);



                    }
                    else if (differenz.Days > 10 && differenz.Days < 15)
                    {
                        listBox4.Items.Add(zeile);



                    }
                    
                }
                arraylesen.Close();
                warner = false;
          
            
            
            
            
            }
            else
            {
                this.MaximumSize = new System.Drawing.Size(593, 411);
                this.MinimumSize = new System.Drawing.Size(593, 411);
                listBox2.Enabled = false;
                listBox3.Enabled = false;
                listBox4.Enabled = false;
                warner = true;
            }














        }
        //################################################ 
       
        //################################################      
        }
    }

