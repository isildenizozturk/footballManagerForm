using footballManagerForm.Sınıflar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace footballManagerForm
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        int overallA, overallB;
        private void takimAolusturbtn_Click(object sender, EventArgs e)
        {                    
            try
            {                
                if (countrycmbx.SelectedIndex != -1 && teamAcmbx.SelectedIndex != -1)
                {

                    #region Random objects

                    Random keeper = new Random();
                    int kp1, kp2;

                    Random center1 = new Random();
                    Random center2 = new Random();
                    Random left = new Random();
                    Random right = new Random();
                    int Astp, Astp2, Bstp, Bstp2;
                    int Alb, Arb, Blb, Brb;                  

                    Random midfielder1 = new Random();
                    Random midfielder2 = new Random();
                    Random midfielder3 = new Random();
                    Random midfielder4 = new Random();
                    int ao1, ao2, ao3, ao4, bo1, bo2, bo3, bo4;

                    Random forward1 = new Random();
                    Random forward2 = new Random();
                    int Af1, Af2, Bf1, Bf2;
                    
                    #endregion

                    #region Team A

                    using (Team teamA = new Team())
                    {
                        #region Team A - Goalkeeper
                        using (GoalKeeper gk = new GoalKeeper())
                        {                           
                            kp1 = keeper.Next(0, 5);
                            team1Gklbl.Text = gk.randomName(kp1, "goalkeeper");
                            team1GkNumberllbl.Text = gk.kitNumber(kp1, "goalkeeper").ToString();
                            teamAKeeperpbx.Image = Image.FromFile(gk.photo(kp1, "goalkeeper"));
                            team1GkOvrllbl.Text = gk.rating(kp1, "goalkeeper").ToString();
                            overallA += gk.overallInfo();
                        }

                        #endregion

                        #region Team A - Defenders

                        using (Defender df = new Defender())
                        {
                            Astp = center1.Next(0, 10);
                            Astp2 = center2.Next(0, 10);
                            while (Astp == Astp2)
                            {
                                Astp2 = center2.Next(0, 10);
                            }

                            #region Centerback1

                            team1cb1lbl.Text = df.randomName(Astp, "centerback");
                            team1cb1numberlbl.Text = df.kitNumber(Astp, "centerback").ToString();
                            teamAdefender2pbx.Image = Image.FromFile(df.photo(Astp, "centerback"));
                            team1cb1Ovrlbl.Text = df.rating(Astp, "centerback").ToString();
                            overallA += df.overallInfo();

                            #endregion

                            #region Centerback2

                            team1cb2lbl.Text = df.randomName(Astp2, "centerback");
                            team1cb2numberlbl.Text = df.kitNumber(Astp2, "centerback").ToString();
                            teamAdefender3pbx.Image = Image.FromFile(df.photo(Astp2, "centerback"));
                            team1cb2Ovrlbl.Text = df.rating(Astp2, "centerback").ToString();
                            overallA += df.overallInfo();

                            #endregion

                            #region Left Back

                            Alb = left.Next(0, 5);
                            team1lblbl.Text = df.randomName(Alb, "leftback");
                            team1lbnumberlbl.Text = df.kitNumber(Alb, "leftback").ToString();
                            teamAdefender4pbx.Image = Image.FromFile(df.photo(Alb, "leftback"));
                            team1lbOvrlbl.Text = df.rating(Alb, "leftback").ToString();
                            overallA += df.overallInfo();

                            #endregion

                            #region Right Back

                            Arb = right.Next(0, 5);
                            team1rblbl.Text = df.randomName(Arb, "rightback");
                            team1rbnumberlbl.Text = df.kitNumber(Arb, "rightback").ToString();
                            teamAdefender1pbx.Image = Image.FromFile(df.photo(Arb, "rightback"));
                            team1rbOvrlbl.Text = df.rating(Arb, "rightback").ToString();
                            overallA += df.overallInfo();


                            #endregion
                        }
                        #endregion

                        #region Team A - Midfielders

                        using (Midfielder mf = new Midfielder())
                        {
                            ao1 = midfielder1.Next(0, 12);
                            ao2 = midfielder2.Next(0, 12);
                            ao3 = midfielder3.Next(0, 12);
                            ao4 = midfielder4.Next(0, 12);
                            while (ao1 == ao2 || ao1 == ao3 || ao1 == ao4)
                            {
                                ao1 = midfielder1.Next(0, 12);
                            }
                            while (ao2 == ao1 || ao2 == ao3 || ao2 == ao4)
                            {
                                ao2 = midfielder2.Next(0, 12);
                            }
                            while (ao3 == ao1 || ao3 == ao2 || ao3 == ao4)
                            {
                                ao3 = midfielder3.Next(0, 12);
                            }
                            while (ao4 == ao1 || ao4 == ao2 || ao4 == ao3)
                            {
                                ao4 = midfielder4.Next(0, 12);
                            }

                            #region Midfielder 1

                            team1mid1lbl.Text = mf.randomName(ao1, "midfielder");
                            team1mid1numberlbl.Text = mf.kitNumber(ao1, "midfielder").ToString();
                            teamAmid1pbx.Image = Image.FromFile(mf.photo(ao1, "midfielder"));
                            team1mid1Ovrlbl.Text = mf.rating(ao1, "midfielder").ToString();
                            overallA += mf.overallInfo();

                            #endregion

                            #region Midfielder 2

                            team1mid2lbl.Text = mf.randomName(ao2, "midfielder");
                            team1mid2numberlbl.Text = mf.kitNumber(ao2, "midfielder").ToString();
                            teamAmid2pbx.Image = Image.FromFile(mf.photo(ao2, "midfielder"));
                            team1mid2Ovrlbl.Text = mf.rating(ao2, "midfielder").ToString();
                            overallA += mf.overallInfo();

                            #endregion

                            #region Midfielder 3

                            team1mid3lbl.Text = mf.randomName(ao3, "midfielder");
                            team1mid3numberlbl.Text = mf.kitNumber(ao3, "midfielder").ToString();
                            teamAmid3pbx.Image = Image.FromFile(mf.photo(ao3, "midfielder"));
                            team1mid3Ovrlbl.Text = mf.rating(ao3, "midfielder").ToString();
                            overallA += mf.overallInfo();

                            #endregion

                            #region Midfielder 4

                            team1mid4lbl.Text = mf.randomName(ao4, "midfielder");
                            team1mid4numberlbl.Text = mf.kitNumber(ao4, "midfielder").ToString();
                            teamAmid4pbx.Image = Image.FromFile(mf.photo(ao4, "midfielder"));
                            team1mid4Ovrlbl.Text = mf.rating(ao4, "midfielder").ToString();
                            overallA += mf.overallInfo();

                            #endregion
                        }

                        #endregion

                        #region Team A - Forwards

                        using (Forward fw = new Forward())
                        {
                            Af1 = forward1.Next(0, 10);
                            Af2 = forward2.Next(0, 10);
                            while (Af1 == Af2)
                            {
                                Af2 = forward2.Next(0, 10);
                            }

                            #region Centerback1

                            team1frw1lbl.Text = fw.randomName(Af1, "forward");
                            team1frw1numberlbl.Text = fw.kitNumber(Af1, "forward").ToString();
                            teamAforward1pbx.Image = Image.FromFile(fw.photo(Af1, "forward"));
                            team1frw1Ovrlbl.Text = fw.rating(Af1, "forward").ToString();
                            overallA += fw.overallInfo();

                            #endregion

                            #region Centerback2

                            team1frw2lbl.Text = fw.randomName(Af2, "forward");
                            team1frw2numberlbl.Text = fw.kitNumber(Af2, "forward").ToString();
                            teamAforward2pbx.Image = Image.FromFile(fw.photo(Af2, "forward"));
                            team1frw2Ovrlbl.Text = fw.rating(Af2, "forward").ToString();
                            overallA += fw.overallInfo();

                            #endregion
                        }
                        #endregion
                    }

                    #endregion

                    #region Team B 

                    using (Team teamB = new Team() )
                    {

                        #region Team B - Goalkeeper

                        using (GoalKeeper gk = new GoalKeeper())
                        {
                            #region farklı takım aynı oyuncu kontrolü

                            kp2 = keeper.Next(0, 5);
                            while (kp1 == kp2)
                            {
                                kp2 = keeper.Next(0, 5);
                            }

                            #endregion

                            team2Gklbl.Text = gk.randomName(kp2, "goalkeeper");
                            team2GkNumberllbl.Text = gk.kitNumber(kp2, "goalkeeper").ToString();
                            teamBKeeperpbx.Image = Image.FromFile(gk.photo(kp2, "goalkeeper"));
                            team2GkOvrllbl.Text = gk.rating(kp2, "goalkeeper").ToString();
                            overallB += gk.overallInfo();
                        }

                        #endregion

                        #region Team B - Defenders


                        using (Defender df = new Defender())
                        {
                            Bstp = center1.Next(0, 10);
                            Bstp2 = center2.Next(0, 10);

                            #region ensuring that both of the team dont have the same players

                            while (Astp == Bstp || Bstp == Astp2)
                            {
                                Bstp = center2.Next(0, 10);
                            }
                            while (Astp == Bstp2 || Bstp2 == Astp2)
                            {
                                Bstp2 = center2.Next(0, 10);
                            }

                            #endregion

                            #region ensuring that there is not more than one of the same player

                            while (Bstp == Bstp2)
                            {
                                Bstp2 = center2.Next(0, 10);
                            }

                            #endregion

                            #region Centerback1

                            team2cb1lbl.Text = df.randomName(Bstp, "centerback");
                            team2cb1numberlbl.Text = df.kitNumber(Bstp, "centerback").ToString();
                            teamBdefender2pbx.Image = Image.FromFile(df.photo(Bstp, "centerback"));
                            team2cb1Ovrlbl.Text = df.rating(Bstp, "centerback").ToString();
                            overallB += df.overallInfo();

                            #endregion

                            #region Centerback2

                            team2cb2lbl.Text = df.randomName(Bstp2, "centerback");
                            team2cb2numberlbl.Text = df.kitNumber(Bstp2, "centerback").ToString();
                            teamBdefender3pbx.Image = Image.FromFile(df.photo(Bstp2, "centerback"));
                            team2cb2Ovrlbl.Text = df.rating(Bstp2, "centerback").ToString();
                            overallB += df.overallInfo();

                            #endregion

                            #region Left Back

                            Blb = left.Next(0, 5);
                            while (Alb == Blb)
                            {
                                Blb = left.Next(0, 5);
                            }

                            team2lblbl.Text = df.randomName(Blb, "leftback");
                            team2lbnumberlbl.Text = df.kitNumber(Blb, "leftback").ToString();
                            teamBdefender1pbx.Image = Image.FromFile(df.photo(Blb, "leftback"));
                            team2lbOvrlbl.Text = df.rating(Blb, "leftback").ToString();
                            overallB += df.overallInfo();

                            #endregion

                            #region Right Back

                            Brb = right.Next(0, 5);
 
                            while (Arb == Brb)
                            {
                                Brb = right.Next(0, 5);
                            }

                            team2rblbl.Text = df.randomName(Brb, "rightback");
                            team2rbnumberlbl.Text = df.kitNumber(Brb, "rightback").ToString();
                            teamBdefender4pbx.Image = Image.FromFile(df.photo(Brb, "rightback"));
                            team2rbOvrlbl.Text = df.rating(Brb, "rightback").ToString();
                            overallB += df.overallInfo();

                            #endregion
                        }
                        #endregion

                        #region Team B - Midfielders

                        using (Midfielder mf = new Midfielder())
                        {
                            bo1 = midfielder1.Next(0, 18);
                            bo2 = midfielder2.Next(0, 18);
                            bo3 = midfielder3.Next(0, 18);
                            bo4 = midfielder4.Next(0, 18);

                            #region ensuring that there is not more than one of the same player

                            while (bo1 == ao1 || bo1 == ao2 || bo1 == ao3 || bo1 == ao4)
                            {
                                bo1 = midfielder1.Next(0, 18);
                            }
                            while (bo2 == ao1 || bo2 == ao2 || bo2 == ao3 || bo2 == ao4)
                            {
                                bo2 = midfielder2.Next(0, 18);
                            }
                            while (bo3 == ao1 || bo3 == ao2 || bo3 == ao3 || bo3 == ao4)
                            {
                                bo3 = midfielder3.Next(0, 18);
                            }
                            while (bo4 == ao1 || bo4 == ao2 || bo4 == ao3 || bo4 == ao4)
                            {
                                bo4 = midfielder4.Next(0, 18);
                            }

                            #endregion


                            #region ensuring that there is not more than one of the same player

                            while (bo1 == bo2 || bo1 == bo3 || bo1 == bo4)
                            {
                                bo1 = midfielder1.Next(0, 18);
                            }
                            while (bo2 == bo1 || bo2 == bo3 || bo2 == bo4)
                            {
                                bo2 = midfielder2.Next(0, 18);
                            }
                            while (bo3 == bo1 || bo3 == bo2 || bo3 == bo4)
                            {
                                bo3 = midfielder3.Next(0, 18);
                            }
                            while (bo4 == bo1 || bo4 == bo2 || bo4 == bo3)
                            {
                                bo4 = midfielder4.Next(0, 18);
                            }

                            #endregion


                            #region Midfielder 1

                            team2mid1lbl.Text = mf.randomName(bo1, "midfielder");
                            team2mid1numberlbl.Text = mf.kitNumber(bo1, "midfielder").ToString();
                            teamBmid1pbx.Image = Image.FromFile(mf.photo(bo1, "midfielder"));
                            team2mid1Ovrlbl.Text = mf.rating(bo1, "midfielder").ToString();
                            overallB += mf.overallInfo();

                            #endregion

                            #region Midfielder 2

                            team2mid2lbl.Text = mf.randomName(bo2, "midfielder");
                            team2mid2numberlbl.Text = mf.kitNumber(bo2, "midfielder").ToString();
                            teamBmid2pbx.Image = Image.FromFile(mf.photo(bo2, "midfielder"));
                            team2mid2Ovrlbl.Text = mf.rating(bo2, "midfielder").ToString();
                            overallB += mf.overallInfo();

                            #endregion

                            #region Midfielder 3

                            team2mid3lbl.Text = mf.randomName(bo3, "midfielder");
                            team2mid3numberlbl.Text = mf.kitNumber(bo3, "midfielder").ToString();
                            teamBmid3pbx.Image = Image.FromFile(mf.photo(bo3, "midfielder"));
                            team2mid3Ovrlbl.Text = mf.rating(bo3, "midfielder").ToString();
                            overallB += mf.overallInfo();

                            #endregion

                            #region Midfielder 4

                            team2mid4lbl.Text = mf.randomName(bo4, "midfielder");
                            team2mid4numberlbl.Text = mf.kitNumber(bo4, "midfielder").ToString();
                            teamBmid4pbx.Image = Image.FromFile(mf.photo(bo4, "midfielder"));
                            team2mid4Ovrlbl.Text = mf.rating(bo4, "midfielder").ToString();
                            overallB += mf.overallInfo();

                            #endregion
                        }

                        #endregion

                        #region Team B - Forwards

                        using (Forward fw = new Forward())
                        {
                            Bf1 = forward1.Next(0, 10);
                            Bf2 = forward2.Next(0, 10);

                            #region ensuring that both of the team dont have the same players

                            while (Af1 == Bf1 || Bf1 == Af2)
                            {
                                Bf1 = center2.Next(0, 10);
                            }
                            while (Af1 == Bf2 || Bf2 == Af2)
                            {
                                Bf2 = center2.Next(0, 10);
                            }

                            #endregion

                            #region ensuring that there is not more than one of the same player

                            while (Bf1 == Bf2)
                            {
                                Bf2 = forward2.Next(0, 10);
                            }

                            #endregion

                            #region Forward 1

                            team2frw1lbl.Text = fw.randomName(Bf1, "forward");
                            team2frw1numberlbl.Text = fw.kitNumber(Bf1, "forward").ToString();
                            teamBforward1pbx.Image = Image.FromFile(fw.photo(Bf1, "forward"));
                            team2frw1Ovrlbl.Text = fw.rating(Bf1, "forward").ToString();
                            overallB += fw.overallInfo();

                            #endregion

                            #region Forward 2

                            team2frw2lbl.Text = fw.randomName(Bf2, "forward");
                            team2frw2numberlbl.Text = fw.kitNumber(Bf2, "forward").ToString();
                            teamBforward2pbx.Image = Image.FromFile(fw.photo(Bf2, "forward"));
                            team2frw2Ovrlbl.Text = fw.rating(Bf2, "forward").ToString();
                            overallB += fw.overallInfo();

                            #endregion
                        }
                        #endregion
                    }


                    #endregion

                }
                else
                    MessageBox.Show("You must make a choice");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        
        }
        private void maciOynabtn_Click(object sender, EventArgs e)
        {
            team1Overall.Text = (overallA / 11).ToString();
            team2Overall.Text = (overallB / 11).ToString();
            team1Overall.Visible = true;
            team2Overall.Visible = true;

            Random score = new Random();
            int scoreA = score.Next(0, 5);
            int scoreB = score.Next(0, 5);

            if (overallA > overallB)
            {
                while(scoreA < scoreB)
                {
                    scoreA = score.Next(0, 5);
                    scoreB = score.Next(0, 5);
                }
            }

            else if (overallB > overallA)
            {
                while (scoreB < scoreA)
                {
                    scoreA = score.Next(0, 5);
                    scoreB = score.Next(0, 5);
                }
            }

            else 
            {
                while (scoreB < scoreA)
                {
                    scoreA = score.Next(0, 5);
                    
                }
                while (scoreA < scoreB)
                {
                    scoreB = score.Next(0, 5);
                }

            }
            skor1lbl.Text = scoreA.ToString(); 
            skor2lbl.Text = scoreB.ToString();  
            skor1lbl.Visible = true;
            skor2lbl.Visible = true;


        }

        private void ulkecmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            overallA = 0;
            overallB = 0;
            switch (countrycmbx.Text)
            {
                case "Türkiye":
                    teamAcmbx.Items.Clear();
                    teamBcmbx.Items.Clear();
                    string[] turkiye = { "Galatasaray", "Fenerbahçe", "Beşiktaş", "Trabzonspor", "Başakşehir" };
                    teamAcmbx.Items.AddRange(turkiye);
                    teamBcmbx.Items.AddRange(turkiye);
                    break;
                case "İngiltere":
                    teamAcmbx.Items.Clear();
                    teamBcmbx.Items.Clear();
                    string[] ingiltere = { "Liverpool", "Manchester City", "Manchester United", "Arsenal", "Chealsea" };
                    teamAcmbx.Items.AddRange(ingiltere);
                    teamBcmbx.Items.AddRange(ingiltere);
                    break;
                case "İspanya":
                    teamAcmbx.Items.Clear();
                    teamBcmbx.Items.Clear();
                    string[] ispanya = { "Barcelona", "Real Madrid", "Atletico Madrid", "Villarreal", "Real Sociedad" };
                    teamAcmbx.Items.AddRange(ispanya);
                    teamBcmbx.Items.AddRange(ispanya);
                    break;
                case "İtalya":
                    teamAcmbx.Items.Clear();
                    teamBcmbx.Items.Clear();
                    string[] italya = { "Juventus", "Inter", "Milan", "Napoli", "Lazio" };
                    teamAcmbx.Items.AddRange(italya);
                    teamBcmbx.Items.AddRange(italya);
                    break;
                case "Fransa":
                    teamAcmbx.Items.Clear();
                    teamBcmbx.Items.Clear();
                    string[] fransa = { "PSG", "Lyon", "Monaco", "Lille", "Marseille" };
                    teamAcmbx.Items.AddRange(fransa);
                    teamBcmbx.Items.AddRange(fransa);
                    break;
                case "Almanya":
                    teamAcmbx.Items.Clear();
                    teamBcmbx.Items.Clear();
                    string[] almanya = { "Borussia Dortmund", "Bayern Munich", "Freiburg", "Wolfsburg", "Bayer Leverkusen" };
                    teamAcmbx.Items.AddRange(almanya);
                    teamBcmbx.Items.AddRange(almanya);
                    break;
                default:
                    teamAcmbx.Items.Clear();
                    teamBcmbx.Items.Clear();
                    break;
            }

        }

        private void takimAcmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            overallA = 0;
            overallB = 0;
            teamAlogo.Visible = true;
            if (teamAcmbx.SelectedIndex == teamBcmbx.SelectedIndex)
            {
                MessageBox.Show("Aynı takımı seçemezsiniz");
            }
            else
            {
                if (teamAcmbx.SelectedIndex != -1)
                {
                    switch (teamAcmbx.Text)
                    {
                        case "Galatasaray":
                            teamAlogo.Image = Image.FromFile(@"..\\..\\logo\\gs.png");
                            break;
                        case "Fenerbahçe":
                            teamAlogo.Image = Image.FromFile(@"..\\..\\logo\\fb.png");
                            break;
                        case "Beşiktaş":
                            teamAlogo.Image = Image.FromFile(@"..\\..\\logo\\bjk.png");
                            break;
                        case "Trabzonspor":
                            teamAlogo.Image = Image.FromFile(@"..\\..\\logo\\ts.png");
                            break;
                        case "Başakşehir":
                            teamAlogo.Image = Image.FromFile(@"..\\..\\logo\\başakşehir.png");
                            break;
                        case "Liverpool":
                            teamAlogo.Image = Image.FromFile(@"..\\..\\logo\\liverpool.png");
                            break;
                        case "Manchester City":
                            teamAlogo.Image = Image.FromFile(@"..\\..\\logo\\city.png");
                            break;
                        case "Manchester United":
                            teamAlogo.Image = Image.FromFile(@"..\\..\\logo\\united.png");
                            break;
                        case "Arsenal":
                            teamAlogo.Image = Image.FromFile(@"..\\..\\logo\\arsenal.png");
                            break;
                        case "Chealsea":
                            teamAlogo.Image = Image.FromFile(@"..\\..\\logo\\chealsea.png");
                            break;
                        case "Barcelona":
                            teamAlogo.Image = Image.FromFile(@"..\\..\\logo\\barcelona.png");
                            break;
                        case "Real Madrid":
                            teamAlogo.Image = Image.FromFile(@"..\\..\\logo\\realmadrid.png");
                            break;
                        case "Atletico Madrid":
                            teamAlogo.Image = Image.FromFile(@"..\\..\\logo\\atletico.png");
                            break;
                        case "Villarreal":
                            teamAlogo.Image = Image.FromFile(@"..\\..\\logo\\villareal.png");
                            break;
                        case "Real Sociedad":
                            teamAlogo.Image = Image.FromFile(@"..\\..\\logo\\sociedad.png");
                            break;
                        case "Juventus":
                            teamAlogo.Image = Image.FromFile(@"..\\..\\logo\\juventus.png");
                            break;
                        case "Inter":
                            teamAlogo.Image = Image.FromFile(@"..\\..\\logo\\inter.png");
                            break;
                        case "Milan":
                            teamAlogo.Image = Image.FromFile(@"..\\..\\logo\\milan.png");
                            break;
                        case "Napoli":
                            teamAlogo.Image = Image.FromFile(@"..\\..\\logo\\napoli.png");
                            break;
                        case "Lazio":
                            teamAlogo.Image = Image.FromFile(@"..\\..\\logo\\lazio.png");
                            break;
                        case "PSG":
                            teamAlogo.Image = Image.FromFile(@"..\\..\\logo\\psg.png");
                            break;
                        case "Lyon":
                            teamAlogo.Image = Image.FromFile(@"..\\..\\logo\\lyon.png");
                            break;
                        case "Monaco":
                            teamAlogo.Image = Image.FromFile(@"..\\..\\logo\\milan.png");
                            break;
                        case "Lille":
                            teamAlogo.Image = Image.FromFile(@"..\\..\\logo\\lille.png");
                            break;
                        case "Marseille":
                            teamAlogo.Image = Image.FromFile(@"..\\..\\logo\\marseille.png");
                            break;
                        case "Borussia Dortmund":
                            teamAlogo.Image = Image.FromFile(@"..\\..\\logo\\dortmund.png");
                            break;
                        case "Bayern Munich":
                            teamAlogo.Image = Image.FromFile(@"..\\..\\logo\\munich.png");
                            break;
                        case "Freiburg":
                            teamAlogo.Image = Image.FromFile(@"..\\..\\logo\\freiburg.png");
                            break;
                        case "Wolfsburg":
                            teamAlogo.Image = Image.FromFile(@"..\\..\\logo\\wolfsburg.png");
                            break;
                        case "Bayer Leverkusen":
                            teamAlogo.Image = Image.FromFile(@"..\\..\\logo\\leverkusen.png");
                            break;
                    }
                }
                else
                {
                    teamAlogo.Visible = false;
                }
            }


        }

        private void takimBcmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            overallA = 0;
            overallB = 0;
            if (teamAcmbx.SelectedIndex == teamBcmbx.SelectedIndex)
            {
                MessageBox.Show("Aynı takımı seçemezsiniz");
            }
            else
            {
                if (teamBcmbx.SelectedIndex != -1)
                {
                    teamBlogo.Visible = true;
                    switch (teamBcmbx.Text)
                    {
                        case "Galatasaray":
                            teamBlogo.Image = Image.FromFile(@"..\\..\\logo\\gs.png");
                            break;
                        case "Fenerbahçe":
                            teamBlogo.Image = Image.FromFile(@"..\\..\\logo\\fb.png");
                            break;
                        case "Beşiktaş":
                            teamBlogo.Image = Image.FromFile(@"..\\..\\logo\\bjk.png");
                            break;
                        case "Trabzonspor":
                            teamBlogo.Image = Image.FromFile(@"..\\..\\logo\\ts.png");
                            break;
                        case "Başakşehir":
                            teamBlogo.Image = Image.FromFile(@"..\\..\\logo\\başakşehir.png");
                            break;
                        case "Liverpool":
                            teamBlogo.Image = Image.FromFile(@"..\\..\\logo\\liverpool.png");
                            break;
                        case "Manchester City":
                            teamBlogo.Image = Image.FromFile(@"..\\..\\logo\\city.png");
                            break;
                        case "Manchester United":
                            teamBlogo.Image = Image.FromFile(@"..\\..\\logo\\united.png");
                            break;
                        case "Arsenal":
                            teamBlogo.Image = Image.FromFile(@"..\\..\\logo\\arsenal.png");
                            break;
                        case "Chealsea":
                            teamBlogo.Image = Image.FromFile(@"..\\..\\logo\\chealsea.png");
                            break;
                        case "Barcelona":
                            teamBlogo.Image = Image.FromFile(@"..\\..\\logo\\barcelona.png");
                            break;
                        case "Real Madrid":
                            teamBlogo.Image = Image.FromFile(@"..\\..\\logo\\realmadrid.png");
                            break;
                        case "Atletico Madrid":
                            teamBlogo.Image = Image.FromFile(@"..\\..\\logo\\atletico.png");
                            break;
                        case "Villarreal":
                            teamBlogo.Image = Image.FromFile(@"..\\..\\logo\\villareal.png");
                            break;
                        case "Real Sociedad":
                            teamBlogo.Image = Image.FromFile(@"..\\..\\logo\\sociedad.png");
                            break;
                        case "Juventus":
                            teamBlogo.Image = Image.FromFile(@"..\\..\\logo\\juventus.png");
                            break;
                        case "Inter":
                            teamBlogo.Image = Image.FromFile(@"..\\..\\logo\\inter.png");
                            break;
                        case "Milan":
                            teamBlogo.Image = Image.FromFile(@"..\\..\\logo\\milan.png");
                            break;
                        case "Napoli":
                            teamBlogo.Image = Image.FromFile(@"..\\..\\logo\\napoli.png");
                            break;
                        case "Lazio":
                            teamBlogo.Image = Image.FromFile(@"..\\..\\logo\\lazio.png");
                            break;
                        case "PSG":
                            teamBlogo.Image = Image.FromFile(@"..\\..\\logo\\psg.png");
                            break;
                        case "Lyon":
                            teamBlogo.Image = Image.FromFile(@"..\\..\\logo\\lyon.png");
                            break;
                        case "Monaco":
                            teamBlogo.Image = Image.FromFile(@"..\\..\\logo\\milan.png");
                            break;
                        case "Lille":
                            teamBlogo.Image = Image.FromFile(@"..\\..\\logo\\lille.png");
                            break;
                        case "Marseille":
                            teamBlogo.Image = Image.FromFile(@"..\\..\\logo\\marseille.png");
                            break;
                        case "Borussia Dortmund":
                            teamBlogo.Image = Image.FromFile(@"..\\..\\logo\\dortmund.png");
                            break;
                        case "Bayern Munich":
                            teamBlogo.Image = Image.FromFile(@"..\\..\\logo\\munich.png");
                            break;
                        case "Freiburg":
                            teamBlogo.Image = Image.FromFile(@"..\\..\\logo\\freiburg.png");
                            break;
                        case "Wolfsburg":
                            teamBlogo.Image = Image.FromFile(@"..\\..\\logo\\wolfsburg.png");
                            break;
                        case "Bayer Leverkusen":
                            teamBlogo.Image = Image.FromFile(@"..\\..\\logo\\leverkusen.png");
                            break;
                    }
                }
                else
                {
                    teamBlogo.Visible = false;
                }
            }
        }



        #region Gereksiz
        private void team1mid2numberlbl_Click(object sender, EventArgs e)
        {

        }

        private void team1mid1numberlbl_Click(object sender, EventArgs e)
        {

        }
        private void takimBolusturbtn_Click(object sender, EventArgs e)
        {

        }


        private void label15_Click(object sender, EventArgs e)
        {

        }
        #endregion

    }
}
