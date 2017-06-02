using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pusk_atma
{
    public partial class Form1 : Form
    {
        List<komanda> komandalar;

        List<ListBox> torbalar = new List<ListBox>();
        List<ListBox> qruplar = new List<ListBox>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            komanda yenikomanda = null;

            komandalar = new List<komanda>();

            yenikomanda = new komanda("Milan", "Italiya");
            komandalar.Add(yenikomanda);
            yenikomanda = new komanda("Bayern Munich", "Almaniya");
            komandalar.Add(yenikomanda);
            yenikomanda = new komanda("Barselona", "Ispaniya");
            komandalar.Add(yenikomanda);
            yenikomanda = new komanda("Celsi", "Ingiltere");
            komandalar.Add(yenikomanda);
            yenikomanda = new komanda("Real Madrid", "Ispaniya");
            komandalar.Add(yenikomanda);
            yenikomanda = new komanda("Mancestr Yunayted", "Ingiltere");
            komandalar.Add(yenikomanda);
            yenikomanda = new komanda("Arsenal", "Ingiltere");
            komandalar.Add(yenikomanda);
            yenikomanda = new komanda("Porto", "Portuqaliya");
            komandalar.Add(yenikomanda);
            yenikomanda = new komanda("Benfika", "Portuqaliya");
            komandalar.Add(yenikomanda);
            yenikomanda = new komanda("Atletiko Madrid", "Ispaniya");
            komandalar.Add(yenikomanda);
            yenikomanda = new komanda("Salke 04", "Almaniya");
            komandalar.Add(yenikomanda);
            yenikomanda = new komanda("Saxtyor", "Ukrayna");
            komandalar.Add(yenikomanda);
            yenikomanda = new komanda("Marsel", "Fransa");
            komandalar.Add(yenikomanda);
            yenikomanda = new komanda("Liverpul", "Ingiltere");
            komandalar.Add(yenikomanda);
            yenikomanda = new komanda("PSJ", "Fransa");
            komandalar.Add(yenikomanda);
            yenikomanda = new komanda("Yuventus", "Italiya");
            komandalar.Add(yenikomanda);
            yenikomanda = new komanda("Zenit", "Rusiya");
            komandalar.Add(yenikomanda);
            yenikomanda = new komanda("Mancestr Siti", "Ingiltere");
            komandalar.Add(yenikomanda);
            yenikomanda = new komanda("Ajax", "Hollandiya");
            komandalar.Add(yenikomanda);
            yenikomanda = new komanda("Borussiya Dortmund", "Almaniya");
            komandalar.Add(yenikomanda);
            yenikomanda = new komanda("Olimpiakos", "Yunanistan");
            komandalar.Add(yenikomanda);
            yenikomanda = new komanda("Qalatasaray", "Turkiye");
            komandalar.Add(yenikomanda);
            yenikomanda = new komanda("Fenerbahce", "Turkiye");
            komandalar.Add(yenikomanda);
            yenikomanda = new komanda("Napoli", "Italiya");
            komandalar.Add(yenikomanda);
            yenikomanda = new komanda("Seltik", "Isvecre");
            komandalar.Add(yenikomanda);
            yenikomanda = new komanda("Qarabag", "Azerbaycan");
            komandalar.Add(yenikomanda);
            yenikomanda = new komanda("Neftci", "Azerbaycan");
            komandalar.Add(yenikomanda);
            yenikomanda = new komanda("Besiktas", "Turkiye");
            komandalar.Add(yenikomanda);
            yenikomanda = new komanda("Roma", "Italiya");
            komandalar.Add(yenikomanda);
            yenikomanda = new komanda("Inter", "Italiya");
            komandalar.Add(yenikomanda);
            yenikomanda = new komanda("Trabzonspor", "Turkiye");
            komandalar.Add(yenikomanda);
            yenikomanda = new komanda("Qebele", "Azerbaycan");
            komandalar.Add(yenikomanda);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
                btn.Enabled = false;
            Random rnd = new Random();
            List<int> secilenKomandalar = new List<int>();

            for (int i = 0; i < 4; i++)
            {
                secilenKomandalar.Clear();
                for (int j = 0; j < 8; j++)
                {
                    int secilenKomanda = rnd.Next(0, komandalar.Count / 4);
                    if (secilenKomandalar.Contains(secilenKomanda))
                    {
                        j--;
                    }
                    else
                    {
                        secilenKomandalar.Add(secilenKomanda);
                    }
                }
                bool eyniOlkedenKomandaVar = false;
                for (int k = 0; k < 8; k++)
                {
                  eyniOlkedenKomandaVar = eyniOlkedenKomandaVarmi(qruplar[k], torbalar[i].Items[secilenKomandalar[k]] as komanda);
                    if (eyniOlkedenKomandaVar)
                    {
                        break;
                    }
                }
                if (!eyniOlkedenKomandaVar)
                {
                    listBox1.Items.Add(torbalar[i].Items[secilenKomandalar[0]] as komanda);
                    listBox2.Items.Add(torbalar[i].Items[secilenKomandalar[1]] as komanda);
                    listBox3.Items.Add(torbalar[i].Items[secilenKomandalar[2]] as komanda);
                    listBox4.Items.Add(torbalar[i].Items[secilenKomandalar[3]] as komanda);
                    listBox5.Items.Add(torbalar[i].Items[secilenKomandalar[4]] as komanda);
                    listBox6.Items.Add(torbalar[i].Items[secilenKomandalar[5]] as komanda);
                    listBox7.Items.Add(torbalar[i].Items[secilenKomandalar[6]] as komanda);
                    listBox8.Items.Add(torbalar[i].Items[secilenKomandalar[7]] as komanda);
                }
                else
                {
                    i--;
                }

            }
        }
        private bool eyniOlkedenKomandaVarmi (ListBox qrup, komanda komanda)
        {
            bool durum = false;
            for (int i = 0; i < qrup.Items.Count; i++)
            {
                komanda qrupKomanda = qrup.Items[i] as komanda;
                if (qrupKomanda.TeamCountry == komanda.TeamCountry)
                {
                    durum = true;
                    break;
                }
            }
            return durum;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            var btn = sender as Button;
            btn.Enabled = false;
            ListTorba1.Items.Clear();
            ListTorba2.Items.Clear();
            ListTorba3.Items.Clear();
            ListTorba4.Items.Clear();
            torbalar.Clear();
            Random rnd = new Random();
            List<int> secilenKomandalar = new List<int>();
            for (int i = 0; i < komandalar.Count; i++)
            {
                int secilenKomanda = rnd.Next(0, komandalar.Count);
                if (secilenKomandalar.Contains(secilenKomanda))
                {
                    i--;
                }
                else
                {
                    secilenKomandalar.Add(secilenKomanda);
                }
            }
            for (int i = 0; i < secilenKomandalar.Count; i++)
            {
                if (i<8)
                {
                    ListTorba1.Items.Add(komandalar[secilenKomandalar[i]]);
                }
                else if (i<16)
                {
                    ListTorba2.Items.Add(komandalar[secilenKomandalar[i]]);
                }
                else if (i<24)
                {
                    ListTorba3.Items.Add(komandalar[secilenKomandalar[i]]);

                }
                else
                {
                    ListTorba4.Items.Add(komandalar[secilenKomandalar[i]]);

                }
            }
            torbalar.Add(ListTorba1);
            torbalar.Add(ListTorba2);
            torbalar.Add(ListTorba3);
            torbalar.Add(ListTorba4);

            qruplar.Add(listBox1);
            qruplar.Add(listBox2);
            qruplar.Add(listBox3);
            qruplar.Add(listBox4);
            qruplar.Add(listBox5);
            qruplar.Add(listBox6);
            qruplar.Add(listBox7);
            qruplar.Add(listBox8);
        }
    }
}
