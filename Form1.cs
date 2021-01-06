using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4x4_iks_oks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = igrac+"";
            tabla[0, 0] = igrac;
            button1.Enabled = false;
            racunarIgra();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Text = igrac + "";
            tabla[0, 1] = igrac;
            button2.Enabled = false;
            racunarIgra();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Text = igrac + "";
            tabla[0, 2] = igrac;
            button3.Enabled = false;
            racunarIgra();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Text = igrac + "";
            tabla[0, 3] = igrac;
            button4.Enabled = false;
            racunarIgra();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Text = igrac + "";
            tabla[1, 0] = igrac;
            button5.Enabled = false;
            racunarIgra();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Text = igrac + "";
            tabla[1, 1] = igrac;
            button6.Enabled = false;
            racunarIgra();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Text = igrac + "";
            tabla[1, 2] = igrac;
            button7.Enabled = false;
            racunarIgra();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Text = igrac + "";
            tabla[1, 3] = igrac;
            button8.Enabled = false;
            racunarIgra();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Text = igrac + "";
            tabla[2, 0] = igrac;
            button9.Enabled = false;
            racunarIgra();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button10.Text = igrac + "";
            tabla[2, 1] = igrac;
            button10.Enabled = false;
            racunarIgra();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            button11.Text = igrac + "";
            tabla[2, 2] = igrac;
            button11.Enabled = false;
            racunarIgra();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button12.Text = igrac + "";
            tabla[2, 3] = igrac;
            button12.Enabled = false;
            racunarIgra();
        }
      
        private void button13_Click(object sender, EventArgs e)
        {
            button13.Text = igrac + "";
            tabla[3, 0] = igrac;
            button13.Enabled = false;
            racunarIgra();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            button14.Text = igrac + "";
            tabla[3, 1] = igrac;
            button14.Enabled = false;
            racunarIgra();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            button15.Text = igrac + "";
            tabla[3, 2] = igrac;
            button15.Enabled = false;
            racunarIgra();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            button16.Text = igrac + "";
            tabla[3, 3] = igrac;
            button16.Enabled = false;
            racunarIgra();
        }

        //Odigrani potezi

        char igrac = 'x',racunar='o';
        char[,] tabla = new char[4, 4];
        List<Button> polja;
        int[] ciljniPotezi;

        private void Form1_Load(object sender, EventArgs e)
        {
            polja = new List<Button>();
            polja.Add(button1);
            polja.Add(button2);
            polja.Add(button3);
            polja.Add(button4);
            polja.Add(button5);
            polja.Add(button6);
            polja.Add(button7);
            polja.Add(button8);
            polja.Add(button9);
            polja.Add(button10);
            polja.Add(button11);
            polja.Add(button12);
            polja.Add(button13);
            polja.Add(button14);
            polja.Add(button15);
            polja.Add(button16);
            for (int i = 0; i < 16; i++)
                polja[i].Enabled = false;

            ciljniPotezi = new int[]{5, 6, 9, 0, 10, 12, 15 ,3, 1, 2, 4, 7, 8, 11, 13, 14};//Indeks poteza sa najvecim uticajem po redu
            Random r = new Random();
            int granica = r.Next(0, 3);
            if(granica%2==0)
            {
                ciljniPotezi[0] = 6;
                ciljniPotezi[1] = 5;

                ciljniPotezi[3] = 12;
                ciljniPotezi[5] = 0;

                ciljniPotezi[6] = 3;
                ciljniPotezi[7] = 15;

            }
            else
            {
                ciljniPotezi[2] = 6;
                ciljniPotezi[1] = 9;

                ciljniPotezi[3] = 15;
                ciljniPotezi[6] = 0;

                ciljniPotezi[5] = 3;
                ciljniPotezi[7] = 12;
            }
            int pomocna = 0;
            for (int i = 0; i < granica; i++)            
                for (int j = i; j >= 0; j--)
                {
                    pomocna = ciljniPotezi[i];
                    ciljniPotezi[i]=ciljniPotezi[j];
                    ciljniPotezi[j] = pomocna;
                }
            
            //Randomizacija ciljnih poteza
        }//Stavljanje polja u listu i kreiranje ciljnih poteza

        private void novaIgra_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            if (r.Next(1,100)%2 == 0)
            {
                igrac = 'x';
                racunar = 'o';
                label1.Text = "Vi ste X";
            }
            else 
            {
                igrac = 'o';
                racunar = 'x';
                label1.Text = "Vi ste O";
            }
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                    tabla[i, j] = ' ';
            for (int i = 0; i < 16; i++)
            {
                polja[i].Enabled = true;
                polja[i].Text = "";
                polja[i].BackColor = Color.White;
            }
            if (racunar == 'x')
                racunarIgra();
        }//Pokretanje nove igre

        bool mogucPotez() 
        {
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                    if(tabla[i,j]==' ')
                        return true;
            return false;
        }//Proverava da li je moguce napraviti potez

        void odigrajPotez(int x,int y)
        {
            if (igrac=='x')
            {
                tabla[x, y] = 'o';
                polja[x * 4 + y].Text = "o";
            }
            else
            {
                tabla[x, y] = 'x';
                polja[x * 4 + y].Text = "x";
            }
            if (!mogucPotez())
            {
                krajPartije(true);
                return;
            }//Partija je neresena, nema vise mogucih poteza
            for (int i = 0; i < 16; i++)
                if (polja[i].Text == "")
                    polja[i].Enabled = true;//Kraj poteza racunara, dopustanje korisniku da napravi svoj potez
        }

        bool pobeda(char proveraIgrac)
        {
            bool da;
            for (int i = 0; i < 4; i++)
            {
                da = true;
                for (int j = 0; j < 4; j++)
                {
                    if(tabla[i,j]!=proveraIgrac)
                    {
                        da = false;
                        break;
                    }
                }
                if (da)
                    return true;
            }//Horizontalna pobeda

            for (int i = 0; i < 4; i++)
            {
                da = true;
                for (int j = 0; j < 4; j++)
                {
                    if (tabla[j,i] != proveraIgrac)
                    {
                        da = false;
                        break;
                    }
                }
                if (da)
                    return true;
            }//Vertikalna pobeda

            if (tabla[0, 0] == proveraIgrac && tabla[1, 1] == proveraIgrac && tabla[2, 2] == proveraIgrac && tabla[3, 3] == proveraIgrac)
                return true;
            if (tabla[0, 3] == proveraIgrac && tabla[1, 2] == proveraIgrac && tabla[2, 1] == proveraIgrac && tabla[3, 0] == proveraIgrac)
                return true;
            //Dijagonalne pobede

            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    if (tabla[i, j] == proveraIgrac && tabla[i + 1, j] == proveraIgrac && tabla[i, j + 1] == proveraIgrac && tabla[i + 1, j + 1] == proveraIgrac)
                        return true;//Kockasta pobeda
            return false;
        }//Proverava da li je dati igrac pobedio

        int pretiPobedu(char proveraIgrac)
        {
            bool preti = false;
            for (int i = 0; i < 4; i++)                
                for (int j = 0; j < 4; j++)
                {
                    if(tabla[i,j]==' ')
                    {
                        tabla[i, j] = proveraIgrac;
                        preti = pobeda(proveraIgrac);
                        tabla[i, j] = ' ';
                        if (preti)
                            return i*4+j;
                    }
                }

            return -1;
        }//Ako igrac ne preti pobedu u jednom potezu vraca -1, ako preti vraca indeks tog polja 

        bool neminovnaPobeda(char proveraIgrac) 
        {
            int pretecaPolja = 0;//broj polja na kojima igrac preti pobedu u jednom potezu
            if (pretiPobedu(proveraIgrac == igrac ? racunar : igrac) != -1)
                return false;
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                {
                    if (tabla[i, j] == ' ')
                    {
                        tabla[i, j] = proveraIgrac;
                        if (pobeda(proveraIgrac))
                            pretecaPolja++;
                        tabla[i, j] = ' ';                      
                    }
                    if (pretecaPolja > 1)
                        return true;//Ako igrac preti pobedu na vise mesta ne mozemo ga zaustaviti
                }
            return false;
        }//Proverava da li igrac pobedjuje sigurno u sledecem potezu

        int dvopoteznaPobeda(char provIgrac)
        {
            if (pretiPobedu(provIgrac == igrac ? racunar : igrac) != -1)
                return -1;
            bool pomocna = false;
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                {
                    if (tabla[i, j] == ' ')
                    {
                        tabla[i, j] = provIgrac;
                        pomocna = neminovnaPobeda(provIgrac);
                        tabla[i, j] = ' ';
                        if (pomocna)
                            return i*4+j;
                    }
                }
            return -1;
        }//Sluzi da proveri da li iz date pozicije moze doci do dvopotezne pobede i daje indeks poteza ako moze

        int tropoteznaPobeda(char provIgrac) 
        {
            //Treba uraditi da proveri da li postoji forsirana pobeda u tri poteza i obratiti paznju da ne ostanes izlozen
            //Nekoj neminovnoj pobedi protivnika ili pretecoj pobedi treba i to proveriti usput
            bool jeste=true;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    jeste = true;
                    if (tabla[i, j] == ' ')
                    {

                        tabla[i, j] = provIgrac;

                        for (int k = 0; k < 4; k++)
                        {
                            for (int l = 0; l < 4; l++)
                            {
                                
                                if (tabla[k, l] == ' ')
                                {
                                    tabla[k, l] = provIgrac == igrac ? racunar : igrac;
                                    jeste = jeste && dvopoteznaPobeda(provIgrac) != -1;
                                    tabla[k, l] = ' ';
                                }
                            }
                        }

                        tabla[i, j] = ' ';
                        if (jeste)
                            return i * 4 + j;//Ako postoji potez takav da koji god potez da odigra protivnik moze biti ostvarena 
                                             //dvopotezna pobeda nakon toga igra se taj potez
                    }
                }
            }


            return -1;
        }//Proverava da li dati igrac moze doci do tropotezne pobede iz date pozicije

        void obojPobednika(char pobednik)
        {
            Color bojaPobednika = pobednik == racunar ? Color.Red : Color.LightGreen;
            bool da;
            for (int i = 0; i < 4; i++)
            {
                da = true;
                for (int j = 0; j < 4; j++)
                {
                    if (tabla[i, j] != pobednik)
                    {
                        da = false;
                        break;
                    }
                }
                if (da)
                    for (int j = 0; j < 4; j++)
                        polja[i * 4 + j].BackColor = bojaPobednika;              
            }//Horizontalna pobeda

            for (int i = 0; i < 4; i++)
            {
                da = true;
                for (int j = 0; j < 4; j++)
                {
                    if (tabla[j, i] != pobednik)
                    {
                        da = false;
                        break;
                    }
                }
                if (da)
                    for (int j = 0; j < 4; j++)
                        polja[j * 4 + i].BackColor = bojaPobednika;
            }//Vertikalna pobeda

            if (tabla[0, 0] == pobednik && tabla[1, 1] == pobednik && tabla[2, 2] == pobednik && tabla[3, 3] == pobednik)          
                for (int i = 0; i < 4; i++)
                    for (int j = 0; j < 4; j++)
                        if (i == j)
                            polja[i * 4 + j].BackColor = bojaPobednika;            
            if (tabla[0, 3] == pobednik && tabla[1, 2] == pobednik && tabla[2, 1] == pobednik && tabla[3, 0] == pobednik)
                for (int i = 0; i < 4; i++)
                    for (int j = 0; j < 4; j++)
                        if (i + j == 3)
                            polja[i * 4 + j].BackColor = bojaPobednika;
            //Dijagonalne pobede

            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    if (tabla[i, j] == pobednik && tabla[i + 1, j] == pobednik && tabla[i, j + 1] == pobednik && tabla[i + 1, j + 1] == pobednik)
                    {
                        polja[i * 4 + j].BackColor = bojaPobednika;
                        polja[i * 4+4 + j].BackColor = bojaPobednika;
                        polja[i * 4 + j+1].BackColor = bojaPobednika;
                        polja[i * 4 + j+5].BackColor = bojaPobednika;
                    }
                    //Kockasta pobeda
        }//Oboji pobednicku kombinaciju odgovarajucom bojom

        void krajPartije(bool nereseno) 
        {
            if (nereseno)
                label1.Text += " i partija je neresena.";
            else
            {
                if (pobeda(racunar))
                {
                    obojPobednika(racunar);
                    label1.Text += " i izgubili ste.";
                }
                else 
                {
                    obojPobednika(igrac);
                    label1.Text += " i pobedili ste.";
                }
            }
        }//Govori rezultat pratije i ako je odlucujuc poziva obojPobednika

        int izaberiPotez()
        {

            int pomocna;
            pomocna = dvopoteznaPobeda(racunar);
            if (pomocna!=-1)            
                return pomocna;//Ako postoji potez kojim se dolazi do pobede u sledecem potezu taj ce biti odigran 
            
            pomocna = tropoteznaPobeda(racunar);           
            if (pomocna != -1)
            {
            tabla[pomocna / 4, pomocna % 4] = racunar;
            if (dvopoteznaPobeda(igrac)==-1)
                    return pomocna;//Ako postoji tropotezna pobeda a protivnik ne preti dvopoteznu onda je to optimalno
                 tabla[pomocna / 4, pomocna % 4] = ' ';
            }

            pomocna = dvopoteznaPobeda(igrac);
            if (pomocna != -1)
                for (int i = 0; i < 16; i++)
                {
                    if (tabla[ciljniPotezi[i] / 4, ciljniPotezi[i] % 4] == ' ')
                    {
                        tabla[ciljniPotezi[i] / 4, ciljniPotezi[i] % 4] = racunar;
                        if (dvopoteznaPobeda(igrac) == -1)
                            return ciljniPotezi[i];//Ako postoji potez koji sprecava poraz u dva poteza odigrati taj potez
                        tabla[ciljniPotezi[i] / 4, ciljniPotezi[i] % 4] = ' ';
                    }
                    if (i == 15)
                        return pomocna;//Ako svakako sledi poraz u dva poteza spreciti bar jedan, da moze da se nastavi partija ako
                }                      //protivnik pogresi

            //Ako ni racunar ni igrac nemaju nekih pretnji trenutnih odigrati potez takav da ne omogucava pobedu protivniku a otvara
            //poziciju sto vise
            bool[] maska = new bool[16];
            for (int i = 0; i < 16; i++)
            {
                int x = ciljniPotezi[i] / 4, y = ciljniPotezi[i] % 4;
                if (tabla[x, y] != ' ')
                    continue;
                tabla[x, y] = racunar;
                maska[i] = (tropoteznaPobeda(igrac) == -1);//Ako potez omogucava protivniku tropoteznu pobedu bice preskocen, odnosno ako               
                tabla[x, y] = ' ';                         // ne omogucava bice razmotren za dvopoteznu pobedu
            }

            for (int i = 0; i < 16; i++)
            {
                int x=ciljniPotezi[i]/4, y=ciljniPotezi[i] % 4;
                if (tabla[x, y] != ' ')
                    continue;
                tabla[x, y] = racunar;
                if(maska[i])
                    if (dvopoteznaPobeda(igrac) == -1)
                         return ciljniPotezi[i];
                tabla[x, y] = ' ';
            }//Ako postoji potez koji sprecava i poraz u tri poteza i u dva taj ce biti odigran

            for (int i = 0; i < 16; i++)
            {
                int x = ciljniPotezi[i] / 4, y = ciljniPotezi[i] % 4;
                if (tabla[x, y] != ' ')
                    continue;
                tabla[x, y] = racunar;
                if (dvopoteznaPobeda(igrac) == -1)
                    return ciljniPotezi[i];
                tabla[x, y] = ' ';
            }//Ako postoji potez koji sprecava bar pobedu u dva poteza bice odigran


            //Ako svaki potez vodi do poraza odigrati onaj koji sprecava bar jednu
            return dvopoteznaPobeda(igrac);
        }//Trazi optimalan potez
        void racunarIgra() 
        {
            for (int i = 0; i < 16; i++)
                polja[i].Enabled = false;//Pocinje potez racunara, onemogucava se igracu da napravi potez pre nego sto racunar zavrsi
            if (pobeda(igrac)) 
            {
                krajPartije(false);
                return;
            }//Ako je igrac pobedio partija se zavrsava

            if(!mogucPotez())
            {
                krajPartije(true);
                return;
            }//Partija je neresena, nema vise mogucih poteza

            int pomocna = pretiPobedu(racunar);
            if (pomocna !=-1)
            {
                odigrajPotez(pomocna / 4, pomocna % 4);
                krajPartije(false);
                return;
            }//Ako moze da pobedi odmah odigra taj potez i partija je gotova

            pomocna = pretiPobedu(igrac);

            if (pomocna != -1)
            {
                odigrajPotez(pomocna / 4, pomocna % 4);                              
                return;
            }//Ako igrac preti pobedu to odmah mora biti spreceno ako ne mozemo da pobedimo trenutno

            //Ako nema trenutnih pretnji trazi se optimalan potez

            pomocna = izaberiPotez();
            odigrajPotez(pomocna / 4, pomocna % 4);
        }//Potez racunara
    }
}
