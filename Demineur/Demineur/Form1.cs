using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demineur
{
    public partial class Form1 : Form
    {
        //variable
        Boolean has_lost;
        Boolean IsRectange;
        ListBox bt_bomb = new ListBox();
        ListBox Bt_list = new ListBox();
        int Nbr_bomb, Found_bomb,Real_bomb_found;

        //programme
        public Form1()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label3.Text = Convert.ToString(trackBar1.Value);
        }

        private void Nud_X_ValueChanged(object sender, EventArgs e)
        {
            if (IsRectange == false)
            {
                Nud_Y.Value = Nud_X.Value;
            }
        }

        //zoom
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < Area.Controls.Count; i++)
            {
                Button bt;
                bt = (Button)(Area.Controls[i]);
                bt.Height = Convert.ToInt16(Nud_Size.Value);
                bt.Width = bt.Height;

                string[] Names;
                Names = bt.Name.Split('+');

                bt.Location = new Point(Convert.ToInt16(Names[0]) * bt.Height, Convert.ToInt16(Names[1]) * bt.Height);

            }
        }

        //creer la partie
        private void button1_Click(object sender, EventArgs e)
        {
            Grid();
            hallah_wakbar();
            has_lost = false;
        }

        //definit type de grille
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)//active le mode rectangle
            {
                Nud_Y.Visible = true;
                IsRectange = true;
            }
            else
            {
                Nud_Y.Visible = false;//active le mode carrer
                IsRectange = false;
                Nud_Y.Value = Nud_X.Value;
            }
        }

        //creation de la grille
        private void Grid()
        {

            Area.Controls.Clear();
            Bt_list.Items.Clear();
            bt_bomb.Items.Clear();

            int A = 0;
            int B = 1;

            int i;
            for (i = 0; i < Nud_Y.Value; i++)
            {
                int k;
                for (k = 0; k < Nud_X.Value; k++)
                {
                    Button bt = new Button();
                    bt.Height = Convert.ToInt16(Nud_Size.Value);
                    bt.Width = bt.Height;
                    bt.FlatStyle = FlatStyle.Flat;

                    if (A < Nud_X.Value)
                    {
                        A += 1;
                    }
                    else
                    {
                        A = 1;
                        B += 1;
                    }

                    bt.Tag = bt.Tag + "false+O";
                    bt.MouseDown += (s, e) => { Bt_clik(bt, e); };
                    bt.Name = (Convert.ToString(A) + "+" + (Convert.ToString(B)));
                    bt.Text = "0";
                    bt.FlatAppearance.BorderColor = Color.Green;
                    bt.BackColor = Color.Black;
                    bt.ForeColor = bt.BackColor;
                    Bt_list.Items.Add(bt.Name);

                    bt.Location = new Point(bt.Width * k, bt.Width * i);
                    Area.Controls.Add(bt);

                }
            }
        }

        //place les bombes
        private void hallah_wakbar()
        {

            Nbr_bomb = ((Convert.ToInt16(Nud_X.Value) * Convert.ToInt16(Nud_Y.Value)) * Convert.ToInt16(trackBar1.Value)) / 100;
            Found_bomb = Nbr_bomb;
            Real_bomb_found = Nbr_bomb;

            if (Nbr_bomb <= 0)
            {
                Nbr_bomb = 1;
            }

            label7.Text = Convert.ToString(Nbr_bomb);

            int RanNbr;
            Random Ran = new Random();
            ListBox Tempo_bt = new ListBox();
            Boolean contante = false;

            //definit les bombes
            for (int i = 1; i <= Nbr_bomb; i++)
            {
                contante = false;
                do
                {
                    contante = false;
                    RanNbr = Ran.Next(0, Area.Controls.Count);
                    if (Tempo_bt.Items.Contains(RanNbr) == true)
                    {
                        contante = true;
                    }

                }
                while (contante == true);

                Tempo_bt.Items.Add(RanNbr);

                Button bt = (Button)Area.Controls[RanNbr];
                //bt.BackColor = Color.Green;
                String Tagstr = Convert.ToString(bt.Tag);
                Tagstr = Tagstr.Replace("O", "B");
                bt.Tag = Tagstr;

            }

        }

        //click sur une case
        private void Bt_clik(object sender, MouseEventArgs e)
        {
            Button bt = (Button)sender;
            String Tagstr = Convert.ToString(bt.Tag);
            String[] Tags = Tagstr.Split('+');

            if (e.Button == MouseButtons.Left & has_lost == false )
            {
                if (Tags[1] == "B")
                {
                    Boom();
                    has_lost = true;
                }
                else if (Tags[0] == "false")
                {
                    Bt_check(bt, e);
                    bt.BackColor = Color.FromArgb(255, 10, 10, 10);
                    //bt.FlatAppearance.BorderColor = Color.Blue;
                }
            }
            else if (e.Button == MouseButtons.Right & has_lost == false)
            {
                flag(bt, e);
            }

            if (Real_bomb_found == 0&Found_bomb == 0 ) 
            {
                MessageBox.Show("Won!!!");
            }

        }

        //check les allentours
        private void Bt_check(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            String Tagstr = Convert.ToString(bt.Tag);
            String[] Tags = Tagstr.Split('+');

            if (Tags[0] == "false")
            {
                String[] Names = bt.Name.Split('+');
                Button[] BtArray = new Button[8];
                int[] BtArrayStr = new int[8];

                int A, B;

                A = Convert.ToInt16(Names[0]);
                B = Convert.ToInt16(Names[1]);
                Tagstr = Tagstr.Replace("false", "true");
                bt.Tag = Tagstr;
                //bt.Enabled = false;

                //identification des indices des button
                BtArrayStr[0] = Bt_list.Items.IndexOf(Convert.ToString(A - 1) + "+" + Convert.ToString(B - 1));
                BtArrayStr[1] = Bt_list.Items.IndexOf(Convert.ToString(A) + "+" + Convert.ToString(B - 1));
                BtArrayStr[2] = Bt_list.Items.IndexOf(Convert.ToString(A + 1) + "+" + Convert.ToString(B - 1));
                BtArrayStr[3] = Bt_list.Items.IndexOf(Convert.ToString(A - 1) + "+" + Convert.ToString(B));
                BtArrayStr[4] = Bt_list.Items.IndexOf(Convert.ToString(A + 1) + "+" + Convert.ToString(B));
                BtArrayStr[5] = Bt_list.Items.IndexOf(Convert.ToString(A - 1) + "+" + Convert.ToString(B + 1));
                BtArrayStr[6] = Bt_list.Items.IndexOf(Convert.ToString(A) + "+" + Convert.ToString(B + 1));
                BtArrayStr[7] = Bt_list.Items.IndexOf(Convert.ToString(A + 1) + "+" + Convert.ToString(B + 1));

                //assignation des button
                for (int i = 0; i < 8; i++)
                {

                    if (BtArrayStr[i] != -1)
                    {
                        BtArray[i] = (Button)Area.Controls[BtArrayStr[i]];
                    }

                }

                for (int i = 0; i < 8; i++)
                {
                    try
                    {
                        String Tagstr2 = Convert.ToString(BtArray[i].Tag);
                        String[] Tags2 = Tagstr2.Split('+');
                        if (Tags2[1] == "B")
                        {
                            int txt;
                            txt = Convert.ToInt16(bt.Text);
                            bt.Text = Convert.ToString(txt += 1);
                            bt.ForeColor = Color.Blue;
                            bt.FlatAppearance.BorderColor = Color.Blue;
                            bt.BackColor = Color.FromArgb(255, 10, 10, 10);
                        }
                    }
                    catch { }
                }
                for (int i = 0; i < 8; i++)
                {
                    try
                    {
                        String Tagstr2 = Convert.ToString(BtArray[i].Tag);
                        String[] Tags2 = Tagstr2.Split('+');
                        if (Tags2[0] == "false"&Tags2[1]!="B"&bt.Text=="0")
                        {
                            BtArray[i].BackColor = Color.FromArgb(255, 10, 10, 10);
                            // bt.ForeColor = Color.Blue;
                            BtArray[i].FlatAppearance.BorderColor = Color.Black;
                            bt.FlatAppearance.BorderColor = Color.Black;
                            Bt_check(BtArray[i], e);
                        }
                    }
                    catch
                    {
                        // MessageBox.Show("h");
                    }

                }
               

            }
        }

        //explose
        private void Boom()
        {
            for (int i = 0; i < Area.Controls.Count; i++)
            {
                Button bt = (Button)Area.Controls[i];
                String Tagstr = Convert.ToString(bt.Tag);
                String[] Tags = Tagstr.Split('+');

                if (Tags[1] == "B")
                {
                    bt.BackgroundImage = Minesweeper.Properties.Resources.round_bomb_outline_318_35017;
                    bt.BackgroundImageLayout = ImageLayout.Stretch;
                }
               // bt.Enabled = false;

            }
        }

        //place le drapeau
        private void flag(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            String Tagstr = Convert.ToString(bt.Tag);
            String[] Tags = Tagstr.Split('+');
            if (Tags[0] == "false")
            {
                if (bt.FlatAppearance.BorderColor != Color.Red)
                {
                    if (Tags[1] == "B")
                    {
                        Real_bomb_found -= 1;
                        Found_bomb -= 1;
                        bt.FlatAppearance.BorderColor = Color.Red;
                    }
                    else if (Tags[1] != "B")
                    {
                        Found_bomb -= 1;
                        bt.FlatAppearance.BorderColor = Color.Red;
                    }

                }
                else if (bt.FlatAppearance.BorderColor == Color.Red)
                {
                    if (Tags[1] == "B")
                    {
                        Real_bomb_found += 1;
                        Found_bomb += 1;
                        bt.FlatAppearance.BorderColor = Color.Green;

                    }
                    else if (Tags[1] != "B")
                    {
                        Found_bomb += 1;
                        bt.FlatAppearance.BorderColor = Color.Green ;
                    }

                }
                label7.Text = Convert.ToString(Found_bomb);
            }
        }
        
    }
}

