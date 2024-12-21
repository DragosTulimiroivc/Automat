/*
 
 UPUTSTVO ZA KORISCENJE AUTOMATA
 
 
 
 Ukoliko pokrecete ovaj program to znaci da ste vlasnik.
 Kao vlasnik automata morate ga prvo napuniti.
 Sifra za vlasnika je #31#.
 Unosite artikal tako sto PRVO izaberete datum kad mu istice rok trajanja, a zatim unesete sifru artkla koji hocete da ubacite.
 Kada ubacite prvi artikal u nizu birate koliko ce on da kosta.
 Svi artikli u tom nizu koji su uneti posle njega ce imati istu cenu (Ako su uneti u isto vreme znaci da kostaju isto).
 Na prvu policu unosite cipseve.
 Na drugu gisine.
 Na trecu cokoladice.
 Na cetvrtu vode.
 I na petu sokove.
 Kao vlasnik takodje mozete uneti novcanice u kasu automata ili ih uzeti iz nje (posto je poenta automata da imate neke pare koje mozete uzeti iz njega).
 Kada zavrsite sa vlasnickim duznostima ukucajte ponovo sifru i ostavite ukljucen program kako bi mogli kupci da koriste vas automat pa se vratite za par dana da vidite profit.
 
 Hvala na koriscenju ovog programa :)
 
 
 */


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automat
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MoneyIn.Text = "0";
            CenaCips.Text = "0";
            CenaPardon.Text = "0";
            CenaCoko.Text = "0";
            CenaVoda.Text = "0";
            CenaIvi.Text = "0";
            kecSlika.Text = Convert.ToString(kasa.kec);
            petSlika.Text = Convert.ToString(kasa.pet);
            desetSlika.Text = Convert.ToString(kasa.deset);
            dvadesetSlika.Text = Convert.ToString(kasa.dvadeset);
            pedesetSlika.Text = Convert.ToString(kasa.pedeset);
            stoSlika.Text = Convert.ToString(kasa.sto);
            Console.WriteLine("UPUTSTVO ZA KORISCENJE AUTOMATA");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Ukoliko pokrecete ovaj program to znaci da ste vlasnik.");
            Console.WriteLine("Kao vlasnik automata morate ga prvo napuniti.");
            Console.WriteLine("Sifra za vlasnika je #31#.");
            Console.WriteLine("Unosite artikal tako sto PRVO izaberete datum kad mu istice rok trajanja, a zatim unesete sifru artkla koji hocete da ubacite.");
            Console.WriteLine("Kada ubacite prvi artikal u nizu birate koliko ce on da kosta.");
            Console.WriteLine("Svi artikli u tom nizu koji su uneti posle njega ce imati istu cenu (Ako su uneti u isto vreme znaci da kostaju isto).");
            Console.WriteLine("Na prvu policu unosite cipseve.");
            Console.WriteLine("Na drugu gisine.");
            Console.WriteLine("Na trecu cokoladice.");
            Console.WriteLine("Na cetvrtu vode.");
            Console.WriteLine("I na petu sokove.");
            Console.WriteLine("Kao vlasnik takodje mozete uneti novcanice u kasu automata ili ih uzeti iz nje (posto je poenta automata da imate neke pare koje mozete uzeti iz njega).");
            Console.WriteLine("Kada zavrsite sa vlasnickim duznostima ukucajte ponovo sifru i ostavite ukljucen program kako bi mogli kupci da koriste vas automat pa se vratite za par dana da vidite profit.");
            Console.WriteLine("");
            Console.WriteLine("Hvala na koriscenju ovog programa :)");
            p = 0;
        }
        private void pictureBox18_Click(object sender, EventArgs e)
        {

        }

        private void cips1_Click(object sender, EventArgs e)
        {

        }

        private void jedan_Click(object sender, EventArgs e)
        {
            if (Unos.Text == "Cena11?")
            {
                if (CenaCips.Text == "0")
                {
                    CenaCips.Text = "1";
                    c = 0;
                }
                else
                {
                    CenaCips.Text += "1";
                    c = 0;
                }
            }
            else if (Unos.Text == "Cena21?")
            {
                if (CenaPardon.Text == "0")
                {
                    CenaPardon.Text = "1";
                    p = 0;
                }
                else
                {
                    CenaPardon.Text += "1";
                    p = 0;
                }
            }
            else if (Unos.Text == "Cena31?")
            {
                if (CenaCoko.Text == "0")
                {
                    CenaCoko.Text = "1";
                    n = 0;
                }
                else
                {
                    CenaCoko.Text += "1";
                    n = 0;
                }
            }
            else if (Unos.Text == "Cena41?")
            {
                if (CenaVoda.Text == "0")
                {
                    CenaVoda.Text = "1";
                    v = 0;
                }
                else
                {
                    CenaVoda.Text += "1";
                    v = 0;
                }
            }
            else if (Unos.Text == "Cena51?")
            {
                if (CenaIvi.Text == "0")
                {
                    CenaIvi.Text = "1";
                    i = 0;
                }
                else
                {
                    CenaIvi.Text += "1";
                    i = 0;
                }
            }
            else
            {
                Unos.Text += "1";
            }
            if (Unos.Text == "11")
            {
                if (gazda % 2 == 0)
                {
                    if ((Convert.ToInt32(CenaCips.Text) <= Convert.ToInt32(MoneyIn.Text)) && (MoneyIn.Text != "0"))
                    {
                        cipsi1.stanja[0]--;
                        if (cipsi1.stanja[0] == 0)
                        {
                            cips1.Visible = false;
                            MoneyIn.Text = Convert.ToString(Convert.ToInt32(MoneyIn.Text) - Convert.ToInt32(CenaCips.Text));
                        }
                        if (cipsi1.stanja[0] == 1)
                        {
                            cips2.Visible = false;
                            MoneyIn.Text = Convert.ToString(Convert.ToInt32(MoneyIn.Text) - Convert.ToInt32(CenaCips.Text));
                        }
                        if (cipsi1.stanja[0] == 2)
                        {
                            cips3.Visible = false;
                            MoneyIn.Text = Convert.ToString(Convert.ToInt32(MoneyIn.Text) - Convert.ToInt32(CenaCips.Text));
                        }
                        if (cipsi1.stanja[0] == 3)
                        {
                            cips4.Visible = false;
                            MoneyIn.Text = Convert.ToString(Convert.ToInt32(MoneyIn.Text) - Convert.ToInt32(CenaCips.Text));
                        }
                        if (cipsi1.stanja[0] == 4)
                        {
                            cips5.Visible = false;
                            MoneyIn.Text = Convert.ToString(Convert.ToInt32(MoneyIn.Text) - Convert.ToInt32(CenaCips.Text));
                        }
                    }
                    Unos.Text = "";
                }
                else
                {
                    cipsi1.stanja[0]++;
                    if (cipsi1.stanja[0] == 1)
                    {
                        cips1.Visible = true;
                        cipsi1.rok = dateTimePicker1.Value;
                        CenaCips.Text = "0";
                        Unos.Text = "Cena11?";
                        c = 0;
                    }
                    if (cipsi1.stanja[0] == 2)
                    {
                        cips2.Visible = true;
                        cipsi2.rok = dateTimePicker1.Value;
                        Unos.Text = "";

                    }
                    if (cipsi1.stanja[0] == 3)
                    {
                        cips3.Visible = true;
                        cipsi3.rok = dateTimePicker1.Value;
                        Unos.Text = "";
                    }
                    if (cipsi1.stanja[0] == 4)
                    {
                        cips4.Visible = true;
                        cipsi4.rok = dateTimePicker1.Value;
                        Unos.Text = "";
                    }
                    if (cipsi1.stanja[0] == 5)
                    {
                        cips5.Visible = true;
                        cipsi5.rok = dateTimePicker1.Value;
                        Unos.Text = "";
                    }
                }
            }
            if (Unos.Text == "21")
            {
                if (gazda % 2 == 0)
                {
                    if ((Convert.ToInt32(CenaPardon.Text) <= Convert.ToInt32(MoneyIn.Text)) && (MoneyIn.Text != "0"))
                    {
                        cipsi1.stanja[1]--;
                        if (cipsi1.stanja[1] == 0)
                        {
                            pardon1.Visible = false;
                            MoneyIn.Text = Convert.ToString(Convert.ToInt32(MoneyIn.Text) - Convert.ToInt32(CenaPardon.Text));
                        }
                        if (cipsi1.stanja[1] == 1)
                        {
                            pardon2.Visible = false;
                            MoneyIn.Text = Convert.ToString(Convert.ToInt32(MoneyIn.Text) - Convert.ToInt32(CenaPardon.Text));
                        }
                        if (cipsi1.stanja[1] == 2)
                        {
                            pardon3.Visible = false;
                            MoneyIn.Text = Convert.ToString(Convert.ToInt32(MoneyIn.Text) - Convert.ToInt32(CenaPardon.Text));
                        }
                        if (cipsi1.stanja[1] == 3)
                        {
                            pardon4.Visible = false;
                            MoneyIn.Text = Convert.ToString(Convert.ToInt32(MoneyIn.Text) - Convert.ToInt32(CenaPardon.Text));
                        }
                        if (cipsi1.stanja[1] == 4)
                        {
                            pardon5.Visible = false;
                            MoneyIn.Text = Convert.ToString(Convert.ToInt32(MoneyIn.Text) - Convert.ToInt32(CenaPardon.Text));
                        }
                    }
                    Unos.Text = "";
                }
                else
                {
                    cipsi1.stanja[1]++;
                    if (cipsi1.stanja[1] == 1)
                    {
                        pardon1.Visible = true;
                        girsine1.rok = dateTimePicker1.Value;
                        CenaPardon.Text = "0";
                        Unos.Text = "Cena21?";
                        p = 0;
                    }
                    if (cipsi1.stanja[1] == 2)
                    {
                        pardon2.Visible = true;
                        girsine2.rok = dateTimePicker1.Value;
                        Unos.Text = "";

                    }
                    if (cipsi1.stanja[1] == 3)
                    {
                        pardon3.Visible = true;
                        girsine3.rok = dateTimePicker1.Value;
                        Unos.Text = "";
                    }
                    if (cipsi1.stanja[1] == 4)
                    {
                        pardon4.Visible = true;
                        girsine4.rok = dateTimePicker1.Value;
                        Unos.Text = "";
                    }
                    if (cipsi1.stanja[1] == 5)
                    {
                        pardon5.Visible = true;
                        girsine5.rok = dateTimePicker1.Value;
                        Unos.Text = "";
                    }
                }
            }
            if (Unos.Text == "31")
            {
                if (gazda % 2 == 0)
                {
                    if ((Convert.ToInt32(CenaCoko.Text) <= Convert.ToInt32(MoneyIn.Text)) && (MoneyIn.Text != "0"))
                    {
                        cipsi1.stanja[2]--;
                        if (cipsi1.stanja[2] == 0)
                        {
                            coko1.Visible = false;
                            MoneyIn.Text = Convert.ToString(Convert.ToInt32(MoneyIn.Text) - Convert.ToInt32(CenaCoko.Text));
                        }
                        if (cipsi1.stanja[2] == 1)
                        {
                            coko2.Visible = false;
                            MoneyIn.Text = Convert.ToString(Convert.ToInt32(MoneyIn.Text) - Convert.ToInt32(CenaCoko.Text));
                        }
                        if (cipsi1.stanja[2] == 2)
                        {
                            coko3.Visible = false;
                            MoneyIn.Text = Convert.ToString(Convert.ToInt32(MoneyIn.Text) - Convert.ToInt32(CenaCoko.Text));
                        }
                        if (cipsi1.stanja[2] == 3)
                        {
                            coko4.Visible = false;
                            MoneyIn.Text = Convert.ToString(Convert.ToInt32(MoneyIn.Text) - Convert.ToInt32(CenaCoko.Text));
                        }
                        if (cipsi1.stanja[2] == 4)
                        {
                            coko5.Visible = false;
                            MoneyIn.Text = Convert.ToString(Convert.ToInt32(MoneyIn.Text) - Convert.ToInt32(CenaCoko.Text));
                        }
                    }
                    Unos.Text = "";
                }
                else
                {
                    cipsi1.stanja[2]++;
                    if (cipsi1.stanja[2] == 1)
                    {
                        coko1.Visible = true;
                        najZelje1.rok = dateTimePicker1.Value;
                        CenaCoko.Text = "0";
                        Unos.Text = "Cena31?";
                        n = 0;
                    }
                    if (cipsi1.stanja[2] == 2)
                    {
                        coko2.Visible = true;
                        najZelje2.rok = dateTimePicker1.Value;
                        Unos.Text = "";

                    }
                    if (cipsi1.stanja[2] == 3)
                    {
                        coko3.Visible = true;
                        najZelje3.rok = dateTimePicker1.Value;
                        Unos.Text = "";
                    }
                    if (cipsi1.stanja[2] == 4)
                    {
                        coko4.Visible = true;
                        najZelje4.rok = dateTimePicker1.Value;
                        Unos.Text = "";
                    }
                    if (cipsi1.stanja[2] == 5)
                    {
                        coko5.Visible = true;
                        najZelje5.rok = dateTimePicker1.Value;
                        Unos.Text = "";
                    }
                }
            }
            if (Unos.Text == "41")
            {
                if (gazda % 2 == 0)
                {
                    if ((Convert.ToInt32(CenaVoda.Text) <= Convert.ToInt32(MoneyIn.Text)) && (MoneyIn.Text != "0"))
                    {
                        cipsi1.stanja[3]--;
                        if (cipsi1.stanja[3] == 0)
                        {
                            voda1.Visible = false;
                            MoneyIn.Text = Convert.ToString(Convert.ToInt32(MoneyIn.Text) - Convert.ToInt32(CenaVoda.Text));
                        }
                        if (cipsi1.stanja[3] == 1)
                        {
                            voda2.Visible = false;
                            MoneyIn.Text = Convert.ToString(Convert.ToInt32(MoneyIn.Text) - Convert.ToInt32(CenaVoda.Text));
                        }
                        if (cipsi1.stanja[3] == 2)
                        {
                            voda3.Visible = false;
                            MoneyIn.Text = Convert.ToString(Convert.ToInt32(MoneyIn.Text) - Convert.ToInt32(CenaVoda.Text));
                        }
                        if (cipsi1.stanja[3] == 3)
                        {
                            voda4.Visible = false;
                            MoneyIn.Text = Convert.ToString(Convert.ToInt32(MoneyIn.Text) - Convert.ToInt32(CenaVoda.Text));
                        }
                        if (cipsi1.stanja[3] == 4)
                        {
                            voda5.Visible = false;
                            MoneyIn.Text = Convert.ToString(Convert.ToInt32(MoneyIn.Text) - Convert.ToInt32(CenaVoda.Text));
                        }
                    }
                    Unos.Text = "";
                }
                else
                {
                    cipsi1.stanja[3]++;
                    if (cipsi1.stanja[3] == 1)
                    {
                        voda1.Visible = true;
                        aqua1.rok = dateTimePicker1.Value;
                        CenaVoda.Text = "0";
                        Unos.Text = "Cena41?";
                        v = 0;
                    }
                    if (cipsi1.stanja[3] == 2)
                    {
                        voda2.Visible = true;
                        aqua2.rok = dateTimePicker1.Value;
                        Unos.Text = "";

                    }
                    if (cipsi1.stanja[3] == 3)
                    {
                        voda3.Visible = true;
                        aqua3.rok = dateTimePicker1.Value;
                        Unos.Text = "";
                    }
                    if (cipsi1.stanja[3] == 4)
                    {
                        voda4.Visible = true;
                        aqua4.rok = dateTimePicker1.Value;
                        Unos.Text = "";
                    }
                    if (cipsi1.stanja[3] == 5)
                    {
                        voda5.Visible = true;
                        aqua5.rok = dateTimePicker1.Value;
                        Unos.Text = "";
                    }
                }
            }
            if (Unos.Text == "51")
            {
                if (gazda % 2 == 0)
                {
                    if ((Convert.ToInt32(CenaIvi.Text) <= Convert.ToInt32(MoneyIn.Text)) && (MoneyIn.Text != "0"))
                    {
                        cipsi1.stanja[4]--;
                        if (cipsi1.stanja[4] == 0)
                        {
                            ivi1.Visible = false;
                            MoneyIn.Text = Convert.ToString(Convert.ToInt32(MoneyIn.Text) - Convert.ToInt32(CenaIvi.Text));
                        }
                        if (cipsi1.stanja[4] == 1)
                        {
                            ivi2.Visible = false;
                            MoneyIn.Text = Convert.ToString(Convert.ToInt32(MoneyIn.Text) - Convert.ToInt32(CenaIvi.Text));
                        }
                        if (cipsi1.stanja[4] == 2)
                        {
                            ivi3.Visible = false;
                            MoneyIn.Text = Convert.ToString(Convert.ToInt32(MoneyIn.Text) - Convert.ToInt32(CenaIvi.Text));
                        }
                        if (cipsi1.stanja[4] == 3)
                        {
                            ivi4.Visible = false;
                            MoneyIn.Text = Convert.ToString(Convert.ToInt32(MoneyIn.Text) - Convert.ToInt32(CenaIvi.Text));
                        }
                        if (cipsi1.stanja[4] == 4)
                        {
                            ivi5.Visible = false;
                            MoneyIn.Text = Convert.ToString(Convert.ToInt32(MoneyIn.Text) - Convert.ToInt32(CenaIvi.Text));
                        }
                    }
                    Unos.Text = "";
                }
                else
                {
                    cipsi1.stanja[4]++;
                    if (cipsi1.stanja[4] == 1)
                    {
                        ivi1.Visible = true;
                        sok1.rok = dateTimePicker1.Value;
                        CenaIvi.Text = "0";
                        Unos.Text = "Cena51?";
                        i = 0;
                    }
                    if (cipsi1.stanja[4] == 2)
                    {
                        ivi2.Visible = true;
                        sok2.rok = dateTimePicker1.Value;
                        Unos.Text = "";

                    }
                    if (cipsi1.stanja[4] == 3)
                    {
                        ivi3.Visible = true;
                        sok3.rok = dateTimePicker1.Value;
                        Unos.Text = "";
                    }
                    if (cipsi1.stanja[4] == 4)
                    {
                        ivi4.Visible = true;
                        sok4.rok = dateTimePicker1.Value;
                        Unos.Text = "";
                    }
                    if (cipsi1.stanja[4] == 5)
                    {
                        ivi5.Visible = true;
                        sok5.rok = dateTimePicker1.Value;
                        Unos.Text = "";
                    }
                }
            }
        }

        private void dva_Click(object sender, EventArgs e)
        {
            if (Unos.Text == "Cena11?")
            {
                if (CenaCips.Text == "0")
                {
                    CenaCips.Text = "2";
                    c = 0;
                }
                else
                {
                    CenaCips.Text += "2";
                    c = 0;
                }
            }
            else if (Unos.Text == "Cena21?")
            {
                if (CenaPardon.Text == "0")
                {
                    CenaPardon.Text = "2";
                    p = 0;
                }
                else
                {
                    CenaPardon.Text += "2";
                    p = 0;
                }
            }
            else if (Unos.Text == "Cena31?")
            {
                if (CenaCoko.Text == "0")
                {
                    CenaCoko.Text = "2";
                    n = 0;
                }
                else
                {
                    CenaCoko.Text += "2";
                    n = 0;
                }
            }
            else if (Unos.Text == "Cena41?")
            {
                if (CenaVoda.Text == "0")
                {
                    CenaVoda.Text = "2";
                    v = 0;
                }
                else
                {
                    CenaVoda.Text += "2";
                    v = 0;
                }
            }
            else if (Unos.Text == "Cena51?")
            {
                if (CenaIvi.Text == "0")
                {
                    CenaIvi.Text = "2";
                    i = 0;
                }
                else
                {
                    CenaIvi.Text += "2";
                    v = 0;
                }
            }
            else
            {
                Unos.Text += "2";
            }
        }

        private void tri_Click(object sender, EventArgs e)
        {
            if (Unos.Text == "Cena11?")
            {
                if (CenaCips.Text == "0")
                {
                    CenaCips.Text = "3";
                    c = 0;
                }
                else
                {
                    CenaCips.Text += "3";
                    c = 0;
                }
            }
            else if (Unos.Text == "Cena21?")
            {
                if (CenaPardon.Text == "0")
                {
                    CenaPardon.Text = "3";
                    p = 0;
                }
                else
                {
                    CenaPardon.Text += "3";
                    p = 0;
                }
            }
            else if (Unos.Text == "Cena31?")
            {
                if (CenaCoko.Text == "0")
                {
                    CenaCoko.Text = "3";
                    n = 0;
                }
                else
                {
                    CenaCoko.Text += "3";
                    n = 0;
                }
            }
            else if (Unos.Text == "Cena41?")
            {
                if (CenaVoda.Text == "0")
                {
                    CenaVoda.Text = "3";
                }
                else
                {
                    CenaVoda.Text += "3";
                }
                v = 0;
            }
            else if (Unos.Text == "Cena51?")
            {
                if (CenaIvi.Text == "0")
                {
                    CenaIvi.Text = "3";
                }
                else
                {
                    CenaIvi.Text += "3";
                }
                i = 0;
            }
            else
            {
                Unos.Text += "3";
            }
        }

        private void cetiri_Click(object sender, EventArgs e)
        {
            if (Unos.Text == "Cena11?")
            {
                if (CenaCips.Text == "0")
                {
                    CenaCips.Text = "4";
                }
                else
                {
                    CenaCips.Text += "4";
                }
                c = 0;
            }
            else if (Unos.Text == "Cena21?")
            {
                if (CenaPardon.Text == "0")
                {
                    CenaPardon.Text = "4";
                }
                else
                {
                    CenaPardon.Text += "4";
                }
                c = 0;
            }
            else if (Unos.Text == "Cena31?")
            {
                if (CenaCoko.Text == "0")
                {
                    CenaCoko.Text = "4";
                }
                else
                {
                    CenaCoko.Text += "4";
                }
                p = 0;
            }
            else if (Unos.Text == "Cena41?")
            {
                if (CenaVoda.Text == "0")
                {
                    CenaVoda.Text = "4";
                }
                else
                {
                    CenaVoda.Text += "4";
                }
            }
            else if (Unos.Text == "Cena51?")
            {
                if (CenaIvi.Text == "0")
                {
                    CenaIvi.Text = "4";
                }
                else
                {
                    CenaIvi.Text += "4";
                }
            }
            else
            {
                Unos.Text += "4";
            }
        }

        private void pet_Click(object sender, EventArgs e)
        {
            if (Unos.Text == "Cena11?")
            {
                if (CenaCips.Text == "0")
                {
                    CenaCips.Text = "5";
                }
                else
                {
                    CenaCips.Text += "5";
                }
            }
            else if (Unos.Text == "Cena21?")
            {
                if (CenaPardon.Text == "0")
                {
                    CenaPardon.Text = "5";
                }
                else
                {
                    CenaPardon.Text += "5";
                }
                p = 0;
            }
            else if (Unos.Text == "Cena31?")
            {
                if (CenaCoko.Text == "0")
                {
                    CenaCoko.Text = "5";
                }
                else
                {
                    CenaCoko.Text += "5";
                }
            }
            else if (Unos.Text == "Cena41?")
            {
                if (CenaVoda.Text == "0")
                {
                    CenaVoda.Text = "5";
                }
                else
                {
                    CenaVoda.Text += "5";
                }
            }
            else if (Unos.Text == "Cena51?")
            {
                if (CenaIvi.Text == "0")
                {
                    CenaIvi.Text = "5";
                }
                else
                {
                    CenaIvi.Text += "5";
                }
            }
            else
            {
                Unos.Text += "5";
            }
        }

        private void sest_Click(object sender, EventArgs e)
        {
            if (Unos.Text == "Cena11?")
            {
                if (CenaCips.Text == "0")
                {
                    CenaCips.Text = "6";
                }
                else
                {
                    CenaCips.Text += "6";
                }
            }
            else if (Unos.Text == "Cena21?")
            {
                if (CenaPardon.Text == "0")
                {
                    CenaPardon.Text = "6";
                }
                else
                {
                    CenaPardon.Text += "6";
                }
                p = 0;
            }
            else if (Unos.Text == "Cena31?")
            {
                if (CenaCoko.Text == "0")
                {
                    CenaCoko.Text = "6";
                }
                else
                {
                    CenaCoko.Text += "6";
                }
            }
            else if (Unos.Text == "Cena41?")
            {
                if (CenaVoda.Text == "0")
                {
                    CenaVoda.Text = "6";
                }
                else
                {
                    CenaVoda.Text += "6";
                }
            }
            else if (Unos.Text == "Cena51?")
            {
                if (CenaIvi.Text == "0")
                {
                    CenaIvi.Text = "6";
                }
                else
                {
                    CenaIvi.Text += "6";
                }
            }
            else
            {
                Unos.Text += "6";
            }
        }

        private void sedam_Click(object sender, EventArgs e)
        {
            if (Unos.Text == "Cena11?")
            {
                if (CenaCips.Text == "0")
                {
                    CenaCips.Text = "7";
                }
                else
                {
                    CenaCips.Text += "7";
                }
            }
            else if (Unos.Text == "Cena21?")
            {
                if (CenaPardon.Text == "0")
                {
                    CenaPardon.Text = "7";
                }
                else
                {
                    CenaPardon.Text += "7";
                }
                p = 0;
            }
            else if (Unos.Text == "Cena31?")
            {
                if (CenaCoko.Text == "0")
                {
                    CenaCoko.Text = "7";
                }
                else
                {
                    CenaCoko.Text += "7";
                }
            }
            else if (Unos.Text == "Cena41?")
            {
                if (CenaVoda.Text == "0")
                {
                    CenaVoda.Text = "7";
                }
                else
                {
                    CenaVoda.Text += "7";
                }
            }
            else if (Unos.Text == "Cena51?")
            {
                if (CenaIvi.Text == "0")
                {
                    CenaIvi.Text = "7";
                }
                else
                {
                    CenaIvi.Text += "7";
                }
            }
            else
            {
                Unos.Text += "7";
            }
        }

        private void osam_Click(object sender, EventArgs e)
        {
            if (Unos.Text == "Cena11?")
            {
                if (CenaCips.Text == "0")
                {
                    CenaCips.Text = "8";
                }
                else
                {
                    CenaCips.Text += "8";
                }
            }
            else if (Unos.Text == "Cena21?")
            {
                if (CenaPardon.Text == "0")
                {
                    CenaPardon.Text = "8";
                }
                else
                {
                    CenaPardon.Text += "8";
                }
            }
            else if (Unos.Text == "Cena31?")
            {
                if (CenaCoko.Text == "0")
                {
                    CenaCoko.Text = "8";
                }
                else
                {
                    CenaCoko.Text += "8";
                }
            }
            else if (Unos.Text == "Cena41?")
            {
                if (CenaVoda.Text == "0")
                {
                    CenaVoda.Text = "8";
                }
                else
                {
                    CenaVoda.Text += "8";
                }
            }
            else if (Unos.Text == "Cena51?")
            {
                if (CenaIvi.Text == "0")
                {
                    CenaIvi.Text = "8";
                }
                else
                {
                    CenaIvi.Text += "8";
                }
            }
            else
            {
                Unos.Text += "8";
            }
        }

        private void devet_Click(object sender, EventArgs e)
        {
            if (Unos.Text == "Cena11?")
            {
                if (CenaCips.Text == "0")
                {
                    CenaCips.Text = "9";
                }
                else
                {
                    CenaCips.Text += "9";
                }
            }
            else if (Unos.Text == "Cena21?")
            {
                if (CenaPardon.Text == "0")
                {
                    CenaPardon.Text = "9";
                }
                else
                {
                    CenaPardon.Text += "9";
                }
                p = 0;
            }
            else if (Unos.Text == "Cena31?")
            {
                if (CenaCoko.Text == "0")
                {
                    CenaCoko.Text = "9";
                }
                else
                {
                    CenaCoko.Text += "9";
                }
            }
            else if (Unos.Text == "Cena41?")
            {
                if (CenaVoda.Text == "0")
                {
                    CenaVoda.Text = "9";
                }
                else
                {
                    CenaVoda.Text += "9";
                }
            }
            else if (Unos.Text == "Cena51?")
            {
                if (CenaIvi.Text == "0")
                {
                    CenaIvi.Text = "9";
                }
                else
                {
                    CenaIvi.Text += "9";
                }
            }
            else
            {
                Unos.Text += "9";
            }
        }

        private void nula_Click(object sender, EventArgs e)
        {
            if (Unos.Text == "Cena11?")
            {
                if (CenaCips.Text == "0")
                {
                    CenaCips.Text = "0";
                }
                else
                {
                    CenaCips.Text += "0";
                }
            }
            else if (Unos.Text == "Cena21?")
            {
                if (CenaPardon.Text == "0")
                {
                    CenaPardon.Text = "0";
                }
                else
                {
                    CenaPardon.Text += "0";
                }
            }
            else if (Unos.Text == "Cena31?")
            {
                if (CenaCoko.Text == "0")
                {
                    CenaCoko.Text = "0";
                }
                else
                {
                    CenaCoko.Text += "0";
                }
            }
            else if (Unos.Text == "Cena41?")
            {
                if (CenaVoda.Text == "0")
                {
                    CenaVoda.Text = "0";
                }
                else
                {
                    CenaVoda.Text += "0";
                }
            }
            else if (Unos.Text == "Cena51?")
            {
                if (CenaIvi.Text == "0")
                {
                    CenaIvi.Text = "0";
                }
                else
                {
                    CenaIvi.Text += "0";
                }
            }
            else
            {
                Unos.Text += "0";
            }
        }

        private void taraba_Click(object sender, EventArgs e)
        {
            Unos.Text += "#";
            if (Unos.Text == "#31#")
            {
                gazda += 1;
                if (gazda % 2 == 0)
                {
                    kasica.Visible = false;
                }
                else
                {
                    kasica.Visible = true;
                }
                Unos.Text = "";
            }
            if ((Unos.Text == "Cena11?#") || (Unos.Text == "Cena21?#") || (Unos.Text == "Cena31?#") || (Unos.Text == "Cena41?#") || (Unos.Text == "Cena51?#")) 
            {
                Unos.Text = "";
                if (Unos.Text == "Cena11?#") { c = 0;
                    if (DateTime.Now.DayOfWeek == DayOfWeek.Monday)
                    {
                        if (c == 0)
                        {
                            CenaCips.Text = Convert.ToString(Math.Round(Convert.ToDouble(CenaCips.Text) - 0.1 * Convert.ToDouble(CenaCips.Text)));
                            c++;
                        }
                    }
                    if (DateTime.Now.DayOfWeek == DayOfWeek.Tuesday)
                    {
                        if (p == 0)
                        {
                            CenaPardon.Text = Convert.ToString(Math.Round(Convert.ToDouble(CenaPardon.Text) - 0.1 * Convert.ToDouble(CenaPardon.Text)));
                            p++;
                        }
                    }
                    if (DateTime.Now.DayOfWeek == DayOfWeek.Wednesday)
                    {
                        if (n == 0)
                        {
                            CenaCoko.Text = Convert.ToString(Math.Round(Convert.ToDouble(CenaCoko.Text) - 0.1 * Convert.ToDouble(CenaCoko.Text)));
                            n++;
                        }
                    }
                    if (DateTime.Now.DayOfWeek == DayOfWeek.Thursday)
                    {
                        if (v == 0)
                        {
                            CenaVoda.Text = Convert.ToString(Math.Round(Convert.ToDouble(CenaVoda.Text) - 0.1 * Convert.ToDouble(CenaVoda.Text)));
                            v++;
                        }
                    }
                    if (DateTime.Now.DayOfWeek == DayOfWeek.Thursday)
                    {
                        if (i == 0)
                        {
                            CenaIvi.Text = Convert.ToString(Math.Round(Convert.ToDouble(CenaIvi.Text) - 0.1 * Convert.ToDouble(CenaIvi.Text)));
                            i++;
                        }
                    }
                    if ((cipsi1.rok == DateTime.Now.AddDays(-1)) || (cipsi1.rok == DateTime.Now) || (cipsi1.rok == DateTime.Now.AddDays(-2)))
                    {
                        if (c == 0)
                        {

                            CenaCips.Text = Convert.ToString(Math.Round(Convert.ToDouble(CenaCips.Text) - 0.2 * Convert.ToDouble(CenaCips.Text)));
                            c++;
                        }
                    }
                    if ((girsine1.rok == DateTime.Now.AddDays(-1)) || (girsine1.rok == DateTime.Now) || (girsine1.rok == DateTime.Now.AddDays(-2)))
                    {
                        if (p == 0)
                        {
                            CenaPardon.Text = Convert.ToString(Math.Round(Convert.ToDouble(CenaPardon.Text) - 0.2 * Convert.ToDouble(CenaPardon.Text)));
                            p++;
                        }
                    }
                    if ((najZelje1.rok == DateTime.Now.AddDays(-1)) || (najZelje1.rok == DateTime.Now) || (najZelje1.rok == DateTime.Now.AddDays(-2)))
                    {
                        if (n == 0)
                        {
                            CenaCoko.Text = Convert.ToString(Math.Round(Convert.ToDouble(CenaCoko.Text) - 0.2 * Convert.ToDouble(CenaCoko.Text)));
                            n++;
                        }
                    }
                    if ((aqua1.rok == DateTime.Now.AddDays(-1)) || (aqua1.rok == DateTime.Now) || (aqua1.rok == DateTime.Now.AddDays(-2)))
                    {
                        if (v == 0)
                        {
                            CenaVoda.Text = Convert.ToString(Math.Round(Convert.ToDouble(CenaVoda.Text) - 0.2 * Convert.ToDouble(CenaVoda.Text)));
                            v++;
                        }
                    }
                    if ((sok1.rok == DateTime.Now.AddDays(-1)) || (sok1.rok == DateTime.Now) || (sok1.rok == DateTime.Now.AddDays(-2)))
                    {
                        if (i == 0)
                        {
                            CenaIvi.Text = Convert.ToString(Math.Round(Convert.ToDouble(CenaIvi.Text) - 0.2 * Convert.ToDouble(CenaIvi.Text)));
                            i++;
                        }
                    }
                }
                if (Unos.Text == "Cena21?#") { p = 0;
                    if (DateTime.Now.DayOfWeek == DayOfWeek.Monday)
                    {
                        if (c == 0)
                        {
                            CenaCips.Text = Convert.ToString(Math.Round(Convert.ToDouble(CenaCips.Text) - 0.1 * Convert.ToDouble(CenaCips.Text)));
                            c++;
                        }
                    }
                    if (DateTime.Now.DayOfWeek == DayOfWeek.Tuesday)
                    {
                        if (p == 0)
                        {
                            CenaPardon.Text = Convert.ToString(Math.Round(Convert.ToDouble(CenaPardon.Text) - 0.1 * Convert.ToDouble(CenaPardon.Text)));
                            p++;
                        }
                    }
                    if (DateTime.Now.DayOfWeek == DayOfWeek.Wednesday)
                    {
                        if (n == 0)
                        {
                            CenaCoko.Text = Convert.ToString(Math.Round(Convert.ToDouble(CenaCoko.Text) - 0.1 * Convert.ToDouble(CenaCoko.Text)));
                            n++;
                        }
                    }
                    if (DateTime.Now.DayOfWeek == DayOfWeek.Thursday)
                    {
                        if (v == 0)
                        {
                            CenaVoda.Text = Convert.ToString(Math.Round(Convert.ToDouble(CenaVoda.Text) - 0.1 * Convert.ToDouble(CenaVoda.Text)));
                            v++;
                        }
                    }
                    if (DateTime.Now.DayOfWeek == DayOfWeek.Thursday)
                    {
                        if (i == 0)
                        {
                            CenaIvi.Text = Convert.ToString(Math.Round(Convert.ToDouble(CenaIvi.Text) - 0.1 * Convert.ToDouble(CenaIvi.Text)));
                            i++;
                        }
                    }
                    if ((cipsi1.rok == DateTime.Now.AddDays(-1)) || (cipsi1.rok == DateTime.Now) || (cipsi1.rok == DateTime.Now.AddDays(-2)))
                    {
                        if (c == 0)
                        {

                            CenaCips.Text = Convert.ToString(Math.Round(Convert.ToDouble(CenaCips.Text) - 0.2 * Convert.ToDouble(CenaCips.Text)));
                            c++;
                        }
                    }
                    if ((girsine1.rok == DateTime.Now.AddDays(-1)) || (girsine1.rok == DateTime.Now) || (girsine1.rok == DateTime.Now.AddDays(-2)))
                    {
                        if (p == 0)
                        {
                            CenaPardon.Text = Convert.ToString(Math.Round(Convert.ToDouble(CenaPardon.Text) - 0.2 * Convert.ToDouble(CenaPardon.Text)));
                            p++;
                        }
                    }
                    if ((najZelje1.rok == DateTime.Now.AddDays(-1)) || (najZelje1.rok == DateTime.Now) || (najZelje1.rok == DateTime.Now.AddDays(-2)))
                    {
                        if (n == 0)
                        {
                            CenaCoko.Text = Convert.ToString(Math.Round(Convert.ToDouble(CenaCoko.Text) - 0.2 * Convert.ToDouble(CenaCoko.Text)));
                            n++;
                        }
                    }
                    if ((aqua1.rok == DateTime.Now.AddDays(-1)) || (aqua1.rok == DateTime.Now) || (aqua1.rok == DateTime.Now.AddDays(-2)))
                    {
                        if (v == 0)
                        {
                            CenaVoda.Text = Convert.ToString(Math.Round(Convert.ToDouble(CenaVoda.Text) - 0.2 * Convert.ToDouble(CenaVoda.Text)));
                            v++;
                        }
                    }
                    if ((sok1.rok == DateTime.Now.AddDays(-1)) || (sok1.rok == DateTime.Now) || (sok1.rok == DateTime.Now.AddDays(-2)))
                    {
                        if (i == 0)
                        {
                            CenaIvi.Text = Convert.ToString(Math.Round(Convert.ToDouble(CenaIvi.Text) - 0.2 * Convert.ToDouble(CenaIvi.Text)));
                            i++;
                        }
                    }
                }
                if (Unos.Text == "Cena31?#") { n = 0; if (DateTime.Now.DayOfWeek == DayOfWeek.Monday)
                    {
                        if (c == 0)
                        {
                            CenaCips.Text = Convert.ToString(Math.Round(Convert.ToDouble(CenaCips.Text) - 0.1 * Convert.ToDouble(CenaCips.Text)));
                            c++;
                        }
                    }
                    if (DateTime.Now.DayOfWeek == DayOfWeek.Tuesday)
                    {
                        if (p == 0)
                        {
                            CenaPardon.Text = Convert.ToString(Math.Round(Convert.ToDouble(CenaPardon.Text) - 0.1 * Convert.ToDouble(CenaPardon.Text)));
                            p++;
                        }
                    }
                    if (DateTime.Now.DayOfWeek == DayOfWeek.Wednesday)
                    {
                        if (n == 0)
                        {
                            CenaCoko.Text = Convert.ToString(Math.Round(Convert.ToDouble(CenaCoko.Text) - 0.1 * Convert.ToDouble(CenaCoko.Text)));
                            n++;
                        }
                    }
                    if (DateTime.Now.DayOfWeek == DayOfWeek.Thursday)
                    {
                        if (v == 0)
                        {
                            CenaVoda.Text = Convert.ToString(Math.Round(Convert.ToDouble(CenaVoda.Text) - 0.1 * Convert.ToDouble(CenaVoda.Text)));
                            v++;
                        }
                    }
                    if (DateTime.Now.DayOfWeek == DayOfWeek.Thursday)
                    {
                        if (i == 0)
                        {
                            CenaIvi.Text = Convert.ToString(Math.Round(Convert.ToDouble(CenaIvi.Text) - 0.1 * Convert.ToDouble(CenaIvi.Text)));
                            i++;
                        }
                    }
                    if ((cipsi1.rok == DateTime.Now.AddDays(-1)) || (cipsi1.rok == DateTime.Now) || (cipsi1.rok == DateTime.Now.AddDays(-2)))
                    {
                        if (c == 0)
                        {

                            CenaCips.Text = Convert.ToString(Math.Round(Convert.ToDouble(CenaCips.Text) - 0.2 * Convert.ToDouble(CenaCips.Text)));
                            c++;
                        }
                    }
                    if ((girsine1.rok == DateTime.Now.AddDays(-1)) || (girsine1.rok == DateTime.Now) || (girsine1.rok == DateTime.Now.AddDays(-2)))
                    {
                        if (p == 0)
                        {
                            CenaPardon.Text = Convert.ToString(Math.Round(Convert.ToDouble(CenaPardon.Text) - 0.2 * Convert.ToDouble(CenaPardon.Text)));
                            p++;
                        }
                    }
                    if ((najZelje1.rok == DateTime.Now.AddDays(-1)) || (najZelje1.rok == DateTime.Now) || (najZelje1.rok == DateTime.Now.AddDays(-2)))
                    {
                        if (n == 0)
                        {
                            CenaCoko.Text = Convert.ToString(Math.Round(Convert.ToDouble(CenaCoko.Text) - 0.2 * Convert.ToDouble(CenaCoko.Text)));
                            n++;
                        }
                    }
                    if ((aqua1.rok == DateTime.Now.AddDays(-1)) || (aqua1.rok == DateTime.Now) || (aqua1.rok == DateTime.Now.AddDays(-2)))
                    {
                        if (v == 0)
                        {
                            CenaVoda.Text = Convert.ToString(Math.Round(Convert.ToDouble(CenaVoda.Text) - 0.2 * Convert.ToDouble(CenaVoda.Text)));
                            v++;
                        }
                    }
                    if ((sok1.rok == DateTime.Now.AddDays(-1)) || (sok1.rok == DateTime.Now) || (sok1.rok == DateTime.Now.AddDays(-2)))
                    {
                        if (i == 0)
                        {
                            CenaIvi.Text = Convert.ToString(Math.Round(Convert.ToDouble(CenaIvi.Text) - 0.2 * Convert.ToDouble(CenaIvi.Text)));
                            i++;
                        }
                    }
                }
                if (Unos.Text == "Cena41?#") { v = 0; if (DateTime.Now.DayOfWeek == DayOfWeek.Monday)
                    {
                        if (c == 0)
                        {
                            CenaCips.Text = Convert.ToString(Math.Round(Convert.ToDouble(CenaCips.Text) - 0.1 * Convert.ToDouble(CenaCips.Text)));
                            c++;
                        }
                    }
                    if (DateTime.Now.DayOfWeek == DayOfWeek.Tuesday)
                    {
                        if (p == 0)
                        {
                            CenaPardon.Text = Convert.ToString(Math.Round(Convert.ToDouble(CenaPardon.Text) - 0.1 * Convert.ToDouble(CenaPardon.Text)));
                            p++;
                        }
                    }
                    if (DateTime.Now.DayOfWeek == DayOfWeek.Wednesday)
                    {
                        if (n == 0)
                        {
                            CenaCoko.Text = Convert.ToString(Math.Round(Convert.ToDouble(CenaCoko.Text) - 0.1 * Convert.ToDouble(CenaCoko.Text)));
                            n++;
                        }
                    }
                    if (DateTime.Now.DayOfWeek == DayOfWeek.Thursday)
                    {
                        if (v == 0)
                        {
                            CenaVoda.Text = Convert.ToString(Math.Round(Convert.ToDouble(CenaVoda.Text) - 0.1 * Convert.ToDouble(CenaVoda.Text)));
                            v++;
                        }
                    }
                    if (DateTime.Now.DayOfWeek == DayOfWeek.Thursday)
                    {
                        if (i == 0)
                        {
                            CenaIvi.Text = Convert.ToString(Math.Round(Convert.ToDouble(CenaIvi.Text) - 0.1 * Convert.ToDouble(CenaIvi.Text)));
                            i++;
                        }
                    }
                    if ((cipsi1.rok == DateTime.Now.AddDays(-1)) || (cipsi1.rok == DateTime.Now) || (cipsi1.rok == DateTime.Now.AddDays(-2)))
                    {
                        if (c == 0)
                        {

                            CenaCips.Text = Convert.ToString(Math.Round(Convert.ToDouble(CenaCips.Text) - 0.2 * Convert.ToDouble(CenaCips.Text)));
                            c++;
                        }
                    }
                    if ((girsine1.rok == DateTime.Now.AddDays(-1)) || (girsine1.rok == DateTime.Now) || (girsine1.rok == DateTime.Now.AddDays(-2)))
                    {
                        if (p == 0)
                        {
                            CenaPardon.Text = Convert.ToString(Math.Round(Convert.ToDouble(CenaPardon.Text) - 0.2 * Convert.ToDouble(CenaPardon.Text)));
                            p++;
                        }
                    }
                    if ((najZelje1.rok == DateTime.Now.AddDays(-1)) || (najZelje1.rok == DateTime.Now) || (najZelje1.rok == DateTime.Now.AddDays(-2)))
                    {
                        if (n == 0)
                        {
                            CenaCoko.Text = Convert.ToString(Math.Round(Convert.ToDouble(CenaCoko.Text) - 0.2 * Convert.ToDouble(CenaCoko.Text)));
                            n++;
                        }
                    }
                    if ((aqua1.rok == DateTime.Now.AddDays(-1)) || (aqua1.rok == DateTime.Now) || (aqua1.rok == DateTime.Now.AddDays(-2)))
                    {
                        if (v == 0)
                        {
                            CenaVoda.Text = Convert.ToString(Math.Round(Convert.ToDouble(CenaVoda.Text) - 0.2 * Convert.ToDouble(CenaVoda.Text)));
                            v++;
                        }
                    }
                    if ((sok1.rok == DateTime.Now.AddDays(-1)) || (sok1.rok == DateTime.Now) || (sok1.rok == DateTime.Now.AddDays(-2)))
                    {
                        if (i == 0)
                        {
                            CenaIvi.Text = Convert.ToString(Math.Round(Convert.ToDouble(CenaIvi.Text) - 0.2 * Convert.ToDouble(CenaIvi.Text)));
                            i++;
                        }
                    }
                }
                if (Unos.Text == "Cena51?#") { i = 0; if (DateTime.Now.DayOfWeek == DayOfWeek.Monday)
                    {
                        if (c == 0)
                        {
                            CenaCips.Text = Convert.ToString(Math.Round(Convert.ToDouble(CenaCips.Text) - 0.1 * Convert.ToDouble(CenaCips.Text)));
                            c++;
                        }
                    }
                    if (DateTime.Now.DayOfWeek == DayOfWeek.Tuesday)
                    {
                        if (p == 0)
                        {
                            CenaPardon.Text = Convert.ToString(Math.Round(Convert.ToDouble(CenaPardon.Text) - 0.1 * Convert.ToDouble(CenaPardon.Text)));
                            p++;
                        }
                    }
                    if (DateTime.Now.DayOfWeek == DayOfWeek.Wednesday)
                    {
                        if (n == 0)
                        {
                            CenaCoko.Text = Convert.ToString(Math.Round(Convert.ToDouble(CenaCoko.Text) - 0.1 * Convert.ToDouble(CenaCoko.Text)));
                            n++;
                        }
                    }
                    if (DateTime.Now.DayOfWeek == DayOfWeek.Thursday)
                    {
                        if (v == 0)
                        {
                            CenaVoda.Text = Convert.ToString(Math.Round(Convert.ToDouble(CenaVoda.Text) - 0.1 * Convert.ToDouble(CenaVoda.Text)));
                            v++;
                        }
                    }
                    if (DateTime.Now.DayOfWeek == DayOfWeek.Thursday)
                    {
                        if (i == 0)
                        {
                            CenaIvi.Text = Convert.ToString(Math.Round(Convert.ToDouble(CenaIvi.Text) - 0.1 * Convert.ToDouble(CenaIvi.Text)));
                            i++;
                        }
                    }
                    if ((cipsi1.rok == DateTime.Now.AddDays(-1)) || (cipsi1.rok == DateTime.Now) || (cipsi1.rok == DateTime.Now.AddDays(-2)))
                    {
                        if (c == 0)
                        {

                            CenaCips.Text = Convert.ToString(Math.Round(Convert.ToDouble(CenaCips.Text) - 0.2 * Convert.ToDouble(CenaCips.Text)));
                            c++;
                        }
                    }
                    if ((girsine1.rok == DateTime.Now.AddDays(-1)) || (girsine1.rok == DateTime.Now) || (girsine1.rok == DateTime.Now.AddDays(-2)))
                    {
                        if (p == 0)
                        {
                            CenaPardon.Text = Convert.ToString(Math.Round(Convert.ToDouble(CenaPardon.Text) - 0.2 * Convert.ToDouble(CenaPardon.Text)));
                            p++;
                        }
                    }
                    if ((najZelje1.rok == DateTime.Now.AddDays(-1)) || (najZelje1.rok == DateTime.Now) || (najZelje1.rok == DateTime.Now.AddDays(-2)))
                    {
                        if (n == 0)
                        {
                            CenaCoko.Text = Convert.ToString(Math.Round(Convert.ToDouble(CenaCoko.Text) - 0.2 * Convert.ToDouble(CenaCoko.Text)));
                            n++;
                        }
                    }
                    if ((aqua1.rok == DateTime.Now.AddDays(-1)) || (aqua1.rok == DateTime.Now) || (aqua1.rok == DateTime.Now.AddDays(-2)))
                    {
                        if (v == 0)
                        {
                            CenaVoda.Text = Convert.ToString(Math.Round(Convert.ToDouble(CenaVoda.Text) - 0.2 * Convert.ToDouble(CenaVoda.Text)));
                            v++;
                        }
                    }
                    if ((sok1.rok == DateTime.Now.AddDays(-1)) || (sok1.rok == DateTime.Now) || (sok1.rok == DateTime.Now.AddDays(-2)))
                    {
                        if (i == 0)
                        {
                            CenaIvi.Text = Convert.ToString(Math.Round(Convert.ToDouble(CenaIvi.Text) - 0.2 * Convert.ToDouble(CenaIvi.Text)));
                            i++;
                        }
                    }
                }
                
            }

        }

        private void clear_Click(object sender, EventArgs e)
        {
            Unos.Text = "";
        }
        Artikal cipsi1 = new Artikal();
        Artikal cipsi2 = new Artikal();
        Artikal cipsi3 = new Artikal();
        Artikal cipsi4 = new Artikal();
        Artikal cipsi5 = new Artikal();
        Artikal girsine1 = new Artikal();
        Artikal girsine2 = new Artikal();
        Artikal girsine3 = new Artikal();
        Artikal girsine4 = new Artikal();
        Artikal girsine5 = new Artikal();
        Artikal najZelje1 = new Artikal();
        Artikal najZelje2 = new Artikal();
        Artikal najZelje3 = new Artikal();
        Artikal najZelje4 = new Artikal();
        Artikal najZelje5 = new Artikal();
        Artikal aqua1 = new Artikal();
        Artikal aqua2 = new Artikal();
        Artikal aqua3 = new Artikal();
        Artikal aqua4 = new Artikal();
        Artikal aqua5 = new Artikal();
        Artikal sok1 = new Artikal();
        Artikal sok2 = new Artikal();
        Artikal sok3 = new Artikal();
        Artikal sok4 = new Artikal();
        Artikal sok5 = new Artikal();
        int gazda = 0;
        public int c = 0;
        public int p = 0;
        public int n = 0;
        public int v = 0;
        public int i = 0;
        Kasa kasa = new Kasa();

        private void cips5_Click(object sender, EventArgs e)
        {

        }

        private void kecPlus_Click(object sender, EventArgs e)
        {
            kasa.kec++;
            kecSlika.Text = Convert.ToString(kasa.kec);
        }

        private void petPlus_Click(object sender, EventArgs e)
        {
            kasa.pet++;
            petSlika.Text = Convert.ToString(kasa.pet);
        }

        private void desetPlus_Click(object sender, EventArgs e)
        {
            kasa.deset++;
            desetSlika.Text = Convert.ToString(kasa.deset);
        }

        private void dvadesetPlus_Click(object sender, EventArgs e)
        {
            kasa.dvadeset++;
            dvadesetSlika.Text = Convert.ToString(kasa.dvadeset);
        }

        private void pedesetPlus_Click(object sender, EventArgs e)
        {
            kasa.pedeset++;
            pedesetSlika.Text = Convert.ToString(kasa.pedeset);
        }

        private void stoPlus_Click(object sender, EventArgs e)
        {
            kasa.sto++;
            stoSlika.Text = Convert.ToString(kasa.sto);
        }

        private void kecMinus_Click(object sender, EventArgs e)
        {
            kasa.kec--;
            kecSlika.Text = Convert.ToString(kasa.kec);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            kasa.pet--;
            petSlika.Text = Convert.ToString(kasa.pet);
        }//petMinus

        private void desetMinus_Click(object sender, EventArgs e)
        {
            kasa.deset--;
            desetSlika.Text = Convert.ToString(kasa.deset);
        }

        private void dvadesetMinus_Click(object sender, EventArgs e)
        {
            kasa.dvadeset--;
            dvadesetSlika.Text = Convert.ToString(kasa.dvadeset);
        }

        private void pedesetMinus_Click(object sender, EventArgs e)
        {
            kasa.pedeset--;
            pedesetSlika.Text = Convert.ToString(kasa.pedeset);
        }

        private void stoMinus_Click(object sender, EventArgs e)
        {
            kasa.sto--;
            stoSlika.Text = Convert.ToString(kasa.sto);
        }

        private void novcic_Click(object sender, EventArgs e)
        {
            MoneyIn.Text = Convert.ToString(Convert.ToInt32(MoneyIn.Text) + 1);
            kasa.kec++;
            kecSlika.Text = Convert.ToString(kasa.kec);
        }

        private void kovanica_Click(object sender, EventArgs e)
        {
            MoneyIn.Text = Convert.ToString(Convert.ToInt32(MoneyIn.Text) + 5);
            kasa.pet++;
            petSlika.Text = Convert.ToString(kasa.pet);
        }

        private void Karadzic_Click(object sender, EventArgs e)
        {
            MoneyIn.Text = Convert.ToString(Convert.ToInt32(MoneyIn.Text) + 10);
            kasa.deset++;
            desetSlika.Text = Convert.ToString(kasa.deset);
        }

        private void Nadezda_Click(object sender, EventArgs e)
        {
            MoneyIn.Text = Convert.ToString(Convert.ToInt32(MoneyIn.Text) + 20);
            kasa.dvadeset++;
            dvadesetSlika.Text = Convert.ToString(kasa.dvadeset);
        }

        private void Mokranjac_Click(object sender, EventArgs e)
        {
            MoneyIn.Text = Convert.ToString(Convert.ToInt32(MoneyIn.Text) + 50);
            kasa.pedeset++;
            pedesetSlika.Text = Convert.ToString(kasa.pedeset);
        }

        private void Tesla_Click(object sender, EventArgs e)
        {
            MoneyIn.Text = Convert.ToString(Convert.ToInt32(MoneyIn.Text) + 100);
            kasa.sto++;
            stoSlika.Text = Convert.ToString(kasa.sto);
        }

        private void kusur_Click(object sender, EventArgs e)
        {
            while (Convert.ToInt32(MoneyIn.Text) != 0)
            {
                if ((Convert.ToInt32(MoneyIn.Text) >= 100) && (kasa.sto > 0))
                {
                    kasa.sto--;
                    stoSlika.Text = Convert.ToString(kasa.sto);
                    MoneyIn.Text = Convert.ToString(Convert.ToInt32(MoneyIn.Text) - 100);
                }
                else if ((Convert.ToInt32(MoneyIn.Text) >= 50) && (kasa.pedeset > 0))
                {
                    kasa.pedeset--;
                    pedesetSlika.Text = Convert.ToString(kasa.pedeset);
                    MoneyIn.Text = Convert.ToString(Convert.ToInt32(MoneyIn.Text) - 50);
                }
                else if ((Convert.ToInt32(MoneyIn.Text) >= 20) && (kasa.dvadeset > 0))
                {
                    kasa.dvadeset--;
                    dvadesetSlika.Text = Convert.ToString(kasa.dvadeset);
                    MoneyIn.Text = Convert.ToString(Convert.ToInt32(MoneyIn.Text) - 20);
                }
                else if ((Convert.ToInt32(MoneyIn.Text) >= 10) && (kasa.deset > 0))
                {
                    kasa.deset--;
                    desetSlika.Text = Convert.ToString(kasa.deset);
                    MoneyIn.Text = Convert.ToString(Convert.ToInt32(MoneyIn.Text) - 10);
                }
                else if ((Convert.ToInt32(MoneyIn.Text) >= 5) && (kasa.sto > 0))
                {
                    kasa.pet--;
                    petSlika.Text = Convert.ToString(kasa.pet);
                    MoneyIn.Text = Convert.ToString(Convert.ToInt32(MoneyIn.Text) - 5);
                }
                else if ((Convert.ToInt32(MoneyIn.Text) >= 1) && (kasa.sto > 0))
                {
                    kasa.kec--;
                    kecSlika.Text = Convert.ToString(kasa.kec);
                    MoneyIn.Text = Convert.ToString(Convert.ToInt32(MoneyIn.Text) - 1);
                }
                else break;
            }
        }

        private void Uputstvo_Enter(object sender, EventArgs e)
        {
            Uputstvo.Visible = false;
        }
        private void Uputstvo_Click(object sender, EventArgs e)
        {
            Uputstvo.Visible = false;
        }

        private void label20_Click(object sender, EventArgs e)
        {
            Uputstvo.Visible = false;
        }
    }
    class Artikal
    {
        public bool ima = false;
        public int[] stanja = { 0, 0, 0, 0, 0 }
        ;
        public DateTime rok;
        public Artikal() { }
    }
    class Kasa
    {
        public int kec = 1000;
        public int pet = 1000;
        public int deset = 500;
        public int dvadeset = 500;
        public int pedeset = 500;
        public int sto = 500;
    }   
}