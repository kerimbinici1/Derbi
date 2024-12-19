using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp8
{
    public partial class Form2 : Form

    {
        public Form2()
        {
            InitializeComponent();

        }
        Random rastgele = new Random();
        int gspuan = 0;
        int tspuan = 0;
        int fbpuan = 0;
        int bjkpuan = 0;
        int gg = 0;
        int fg = 0;
        int tg = 0;
        int bg = 0;
        int t, y, u = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            int a = rastgele.Next(0, 5);
            int b = rastgele.Next(0, 5);
            int c = rastgele.Next(0, 5);
            int t = rastgele.Next(0, 5);
            label4.Text = a.ToString();
            label5.Text = b.ToString();
            label8.Text = c.ToString();
            label9.Text = t.ToString();
            label8.Text = t.ToString();



            if (Convert.ToInt32(label4.Text) > (Convert.ToInt32(label5.Text)))
            {
                gspuan = gspuan + 3;
                labelgspuan.Text = gspuan.ToString();


            }
            if (Convert.ToInt32(label5.Text) > (Convert.ToInt32(label4.Text)))
            {
                fbpuan = fbpuan + 3;
                labelfbpuan.Text = fbpuan.ToString();
            }
            if (Convert.ToInt32(label4.Text) == (Convert.ToInt32(label5.Text)))
            {
                fbpuan = fbpuan + 1;
                gspuan = gspuan + 1;
                labelfbpuan.Text = fbpuan.ToString();
                labelgspuan.Text = gspuan.ToString();
            }
            if (Convert.ToUInt32(label8.Text) > (Convert.ToInt32(label9.Text)))
            {
                bjkpuan = bjkpuan + 3;
                labelbjkpuan.Text = bjkpuan.ToString();
            }
            if (Convert.ToUInt32(label9.Text) > (Convert.ToInt32(label8.Text)))
            {
                tspuan = tspuan + 3;
                labeltspuan.Text = tspuan.ToString();
            }
            if (Convert.ToUInt32(label9.Text) == (Convert.ToInt32(label8.Text)))
            {
                tspuan = tspuan + 1;
                bjkpuan = bjkpuan + 1;
                labeltspuan.Text = tspuan.ToString();
                labelbjkpuan.Text = bjkpuan.ToString();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            int a = rastgele.Next(0, 5);
            int b = rastgele.Next(0, 5);
            int c = rastgele.Next(0, 5);
            int t = rastgele.Next(0, 5);
            label18.Text = a.ToString();
            label11.Text = b.ToString();
            label19.Text = c.ToString();
            label12.Text = t.ToString();




            if (Convert.ToInt32(label18.Text) > (Convert.ToInt32(label19.Text)))
            {
                gspuan = gspuan + 3;
                labelgspuan.Text = gspuan.ToString();
            }
            if (Convert.ToInt32(label11.Text) > (Convert.ToInt32(label12.Text)))
            {
                fbpuan = fbpuan + 3;
                labelfbpuan.Text = fbpuan.ToString();
            }
            if (Convert.ToInt32(label11.Text) == (Convert.ToInt32(label12.Text)))
            {
                fbpuan = fbpuan + 1;
                tspuan = tspuan + 1;
                labelfbpuan.Text = fbpuan.ToString();
                labeltspuan.Text = tspuan.ToString();
            }
            if (Convert.ToUInt32(label19.Text) > (Convert.ToUInt32(label18.Text)))
            {
                bjkpuan = bjkpuan + 3;
                labelbjkpuan.Text = bjkpuan.ToString();
            }
            if (Convert.ToUInt32(label12.Text) > (Convert.ToInt32(label11.Text)))
            {
                tspuan = tspuan + 3;
                labeltspuan.Text = tspuan.ToString();
            }
            if (Convert.ToUInt32(label18.Text) == (Convert.ToInt32(label19.Text)))
            {
                bjkpuan = bjkpuan + 1;
                gspuan = gspuan + 1;
                labelbjkpuan.Text = bjkpuan.ToString();
                labelgspuan.Text = gspuan.ToString();
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
            int a = rastgele.Next(0, 5);
            int b = rastgele.Next(0, 5);
            int c = rastgele.Next(0, 5);
            int t = rastgele.Next(0, 5);
            label222.Text = a.ToString();
            label30.Text = b.ToString();
            label29.Text = c.ToString();
            label25.Text = t.ToString();


            if (Convert.ToInt32(label222.Text) > (Convert.ToInt32(label25.Text)))
            {
                gspuan = gspuan + 3;
                labelgspuan.Text = gspuan.ToString();
            }
            if (Convert.ToInt32(label30.Text) > (Convert.ToInt32(label29.Text)))
            {
                fbpuan = fbpuan + 3;
                labelfbpuan.Text = fbpuan.ToString();
            }
            if (Convert.ToInt32(label30.Text) == (Convert.ToInt32(label29.Text)))
            {
                fbpuan = fbpuan + 1;
                bjkpuan = bjkpuan + 1;
                labelfbpuan.Text = fbpuan.ToString();
                labelbjkpuan.Text = bjkpuan.ToString();
            }
            if (Convert.ToUInt32(label29.Text) > (Convert.ToInt32(label30.Text)))
            {
                bjkpuan = bjkpuan + 3;
                labelbjkpuan.Text = bjkpuan.ToString();
            }
            if (Convert.ToUInt32(label25.Text) > (Convert.ToInt32(label222.Text)))
            {
                tspuan = tspuan + 3;
                labeltspuan.Text = tspuan.ToString();
            }
            if (Convert.ToUInt32(label222.Text) == (Convert.ToInt32(label25.Text)))
            {
                tspuan = tspuan + 1;
                gspuan = gspuan + 1;
                labeltspuan.Text = tspuan.ToString();
                labelgspuan.Text = gspuan.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        { 
            if(Convert.ToInt32(labelbjkpuan.Text)>Convert.ToInt32(labelgspuan.Text) && Convert.ToInt32(labelbjkpuan.Text)>Convert.ToInt32(labelfbpuan.Text) && Convert.ToInt32(labelbjkpuan.Text) > Convert.ToInt32(labeltspuan.Text))
                {
                    axWindowsMediaPlayer1.URL = "C:\\Users\\kerim\\Desktop\\bjkmarş.mp3";
                    label37.Text = "Şampiyon Beşiktaşşşş!!!!";
                    pictureBox1.ImageLocation = "C:\\Users\\kerim\\Desktop\\bjk.png";
                }
        
            if (Convert.ToUInt32(labelgspuan.Text) > Convert.ToInt32(labelfbpuan.Text) && Convert.ToInt32(labelgspuan.Text) > Convert.ToInt32(labeltspuan.Text) && Convert.ToInt32(labelgspuan.Text) > Convert.ToInt32(labelbjkpuan.Text))
            {
                axWindowsMediaPlayer1.URL = "C:\\Users\\kerim\\Desktop\\marşgs.mp3";
                label37.Text = "Şampiyon Galatasaray!!!!!!";
                pictureBox1.ImageLocation = "C:\\Users\\kerim\\Desktop\\gs.png";
            }
            if (Convert.ToInt32(labelfbpuan.Text) > Convert.ToInt32(labelbjkpuan.Text) && Convert.ToInt32(labelfbpuan.Text) > Convert.ToInt32(labelgspuan.Text) && Convert.ToInt32(labelfbpuan.Text) > Convert.ToUInt32(labeltspuan.Text))
            {
                axWindowsMediaPlayer1.URL = "C:\\Users\\kerim\\Desktop\\fenermaş.mp3";
                label37.Text = "Şampiyon fenerbahçe!!!!!!";
                pictureBox1.ImageLocation = "C:\\Users\\kerim\\Desktop\\fb.jpg";
            }

            if (Convert.ToInt32(labeltspuan.Text) > Convert.ToInt32(labelgspuan.Text) && Convert.ToInt32(labeltspuan.Text) > Convert.ToInt32(labelfbpuan.Text) && Convert.ToInt32(labeltspuan.Text) > Convert.ToInt32(labelbjkpuan.Text))
            {

                {
                    axWindowsMediaPlayer1.URL = "C:\\Users\\kerim\\Desktop\\tsmarş.mp3";
                    label37.Text = "Şampiyon TrabzonSpor!!!!!!";
                    pictureBox1.ImageLocation = "C:\\Users\\kerim\\Desktop\\ts.jpg";
                }

               



            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label36.Visible = false;
            label45.Visible = false;
            label46.Visible = false;
            label47.Visible = false;
            groupBox6.Visible = false;
            g.Visible = false;
            f.Visible = false;
            lt.Visible = false;
            b.Visible = false;
            ga.Visible = false;
            fe.Visible = false;
            be.Visible = false;
            tr.Visible = false;
        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(labelgspuan.Text) == Convert.ToInt32(labelfbpuan.Text))
            {
                groupBox6.Visible = true;
                label46.Visible = true;
                label45.Visible = true;
                int a = rastgele.Next(0, 5);
                int b = rastgele.Next(0, 5);
                label48.Text = a.ToString();
                label49.Text = b.ToString();
                if (Convert.ToInt32(label48.Text) > Convert.ToInt32(label49.Text))
                {
                    gspuan = gspuan + 1;
                    labelgspuan.Text = gspuan.ToString();
                }
                if (Convert.ToInt32(label49.Text) > Convert.ToInt32(label48.Text))
                {
                    fbpuan = fbpuan + 1;
                    labelfbpuan.Text = fbpuan.ToString();
                }
            }
            if (Convert.ToInt32(labelgspuan.Text) == Convert.ToInt32(labelbjkpuan.Text))
            {
                groupBox6.Visible = true;
                label46.Visible = true;
                label36.Visible = true;
                if (Convert.ToInt32(label48.Text) > Convert.ToInt32(label49.Text))
                {
                    gspuan = gspuan + 1;
                    labelgspuan.Text = gspuan.ToString();
                }
                if (Convert.ToInt32(label49.Text) > Convert.ToInt32(label48.Text))
                {
                    bjkpuan = bjkpuan + 1;
                    labelbjkpuan.Text = bjkpuan.ToString();
                }

            }
            if (Convert.ToInt32(labelgspuan.Text) == Convert.ToInt32(labeltspuan.Text))
            {
                groupBox6.Visible = true;
                label46.Visible = true;
                label47.Visible = true;
                if (Convert.ToInt32(label48.Text) > Convert.ToInt32(label49.Text))
                {
                    gspuan = gspuan + 1;
                    labelgspuan.Text = gspuan.ToString();
                }
                if (Convert.ToInt32(label49.Text) > Convert.ToInt32(label48.Text))
                {
                    tspuan = tspuan + 1;
                    labeltspuan.Text = tspuan.ToString();
                }

               
                if (Convert.ToInt32(labelfbpuan.Text) == Convert.ToInt32(labelbjkpuan.Text))
                {
                    groupBox6.Visible = true;
                    b.Visible = true;
                    f.Visible = true;
                    if (Convert.ToInt32(label48.Text) > Convert.ToInt32(label49.Text))
                    {
                        fbpuan = fbpuan + 1;
                        labelfbpuan.Text = fbpuan.ToString();
                    }
                    if (Convert.ToInt32(label49.Text) > Convert.ToInt32(label48.Text))
                    {
                        bjkpuan = bjkpuan + 1;
                        labelbjkpuan.Text = bjkpuan.ToString();
                    }

                }
                if (Convert.ToInt32(labelfbpuan.Text) == Convert.ToInt32(labeltspuan.Text))
                {
                    groupBox6.Visible = true;
                    f.Visible = true;
                    lt.Visible = true;
                    if (Convert.ToInt32(label48.Text) > Convert.ToInt32(label49.Text))
                    {
                        fbpuan = fbpuan + 1;
                        labelfbpuan.Text = fbpuan.ToString();
                    }
                    if (Convert.ToInt32(label49.Text) > Convert.ToInt32(label48.Text))
                    {
                        tspuan = tspuan + 1;
                        labeltspuan.Text = tspuan.ToString();
                    }                  

                    }
                if (Convert.ToInt32(labelbjkpuan.Text) == Convert.ToInt32(labeltspuan.Text))
                {
                    groupBox6.Visible = true;
                    be.Visible = true;
                    tr.Visible = true;
                    { 
                        if (Convert.ToInt32(label48.Text) > Convert.ToInt32(label49.Text))
                        {
                            bjkpuan = bjkpuan + 1;
                            labelbjkpuan.Text = bjkpuan.ToString();

                        }
                        if (Convert.ToUInt32(label49.Text) > Convert.ToUInt32(label48.Text))
                        {
                            tspuan = tspuan + 1;
                            labeltspuan.Text = tspuan.ToString();
                            
                        }
                    }
                }
                    }
            }
        }

    }


    

