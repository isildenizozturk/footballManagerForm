using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace footballManagerForm.Sınıflar
{
    internal class Player : IDisposable
    {
        private string name;

        public string NAME
        {
            get { return name; }
            set { name = value; }
        }

        private int kitnumber;

        public  int KitNumber
        {
            get { return kitnumber; }
            set { kitnumber = value; }
        }
        private string pic;

        public string Pic
        {
            get { return pic; }
            set { pic = value; }
        }

        protected int overall;
        public int Overall
        {
            get { return overall; }
            set { overall = value; }
        }

        public virtual string randomName(int random, string players)
        {  
            return NAME;
        }
        public virtual int kitNumber(int random, string players)
        {
            return KitNumber;
        }
        public virtual string photo(int random, string players)
        {
            return Pic;
        }
        public virtual int rating(int random, string players)
        {
            return Overall;
        }
        public int overallInfo()
        {
            return Overall;
        }

        public void Dispose()
        {
            //throw new NotImplementedException();
        }
    }

    class GoalKeeper : Player
    {
        public string[,] goalkeepers = new string[5, 4] 
        {
            {"Muslera","1",@"..\\..\\Resources\\muslera.png","79" },
            {"Courtois","1",@"..\\..\\Resources\\Courtois.png","90" },
            {"De Gea","1",@"..\\..\\Resources\\DeGea.png","87" },
            {"Handanović","1",@"..\\..\\Resources\\Handanović.png","84" },
            {"Donnarumma","99",@"..\\..\\Resources\\Donnarumma.png","88" }
        };
        public override string randomName(int random, string mevki)
        {
            return NAME = goalkeepers[random, 0];
        }

        public override int kitNumber(int random, string mevki)
        {
            return KitNumber = int.Parse(goalkeepers[random, 1]);
        }
        public override string photo(int random, string mevki)
        {
            return Pic = goalkeepers[random, 2];
        }
        public override int rating(int random, string mevki)
        {
            return Overall = int.Parse(goalkeepers[random, 3]);
        }
    }

    class Defender : Player
    {
        public string[,] centerbacks1 = new string[10, 4]
        {
            {"Nelsson","25",@"..\\..\\Resources\\nelsson.png","75" },
            {"Ramos","4",@"..\\..\\Resources\\ramos.png","84" },
            {"Bonucci","19",@"..\\..\\Resources\\Bonucci.png","84" },
            {"Rüdiger","22",@"..\\..\\Resources\\Rüdiger.png","87" },
            {"Varane","19",@"..\\..\\Resources\\varane.png","84" },
            {"Alaba","4",@"..\\..\\Resources\\alaba.png","86" },
            {"Vandijk","4",@"..\\..\\Resources\\Vandijk.png","90" },
            {"Skriniar","37",@"..\\..\\Resources\\Skriniar.png","86" },
            {"Dias","3",@"..\\..\\Resources\\dias.png","88" },
            {"Mings","5",@"..\\..\\Resources\\Mings.png","78" }
        };
        public string[,] leftbacks = new string[5, 4]
        {
            {"Robertson","26",@"..\\..\\Resources\\robertson.png","87" },
            {"Davies","19",@"..\\..\\Resources\\Davies.png","84" },
            {"Cancelo","7",@"..\\..\\Resources\\Cancelo.png","88" },
            {"Hernández","19",@"..\\..\\Resources\\Hernandez.png","85" },
            {"Cucurella","32",@"..\\..\\Resources\\Cucurella.png","81" }
        };
        public string[,] rightbacks = new string[5, 4]
        {
            {"Rosier","2",@"..\\..\\Resources\\Rosier.png","77" },
            {"Hakimi","2",@"..\\..\\Resources\\hakimi.png","84" },
            {"Sacha Boey","93",@"..\\..\\Resources\\Boey.png","71" },
            {"Mbabu","27",@"..\\..\\Resources\\Mbabu.png","77" },
            {"Carvajal","2",@"..\\..\\Resources\\Carvajal.png","84" }
        };
        #region Centerbacks random player

        public override string randomName(int random, string mevki)
        {
            if (mevki == "centerback")
                return NAME = centerbacks1[random, 0];
            else if (mevki == "leftback")
                return NAME = leftbacks[random, 0];
            else if (mevki == "rightback")
                return NAME = rightbacks[random, 0];
            else
                return NAME = "---";
        }

        public override int kitNumber(int random, string mevki)
        {
            if (mevki == "centerback")
                return KitNumber = int.Parse(centerbacks1[random, 1]);
            else if (mevki == "leftback")
                return KitNumber = int.Parse(leftbacks[random, 1]);
            else if (mevki == "rightback")
                return KitNumber = int.Parse(rightbacks[random, 1]);
            else
                return KitNumber = 0;
        }
        public override string photo(int random, string mevki)
        {
            if (mevki == "centerback")
                return Pic = centerbacks1[random, 2];
            else if (mevki == "leftback")
                return Pic = leftbacks[random, 2];
            else if (mevki == "rightback")
                return Pic = rightbacks[random, 2];
            else
                return Pic = "";
        }
        public override int rating(int random, string mevki)
        {
            if (mevki == "centerback")
                return Overall = int.Parse(centerbacks1[random, 3]);
            else if (mevki == "leftback")
                return Overall = int.Parse(leftbacks[random, 3]);
            else if (mevki == "rightback")
                return Overall = int.Parse(rightbacks[random, 3]);
            else
                return KitNumber = 0;
        }

        #endregion


    }

    class Midfielder : Player
    {
        public string[,] midfielders = new string[18, 4]
        {
            {"DeBruyne","17",@"..\\..\\Resources\\DeBruyne.png","91" },
            {"Goretzka","8",@"..\\..\\Resources\\Goretzka.png","84" },
            {"Modric","10",@"..\\..\\Resources\\modric.png","89" },
            {"Verratti","6",@"..\\..\\Resources\\verratti.png","87" },
            {"Oliveria","27",@"..\\..\\Resources\\oliviera.png","79" },
            {"Çalhanoğlu","20",@"..\\..\\Resources\\hakan.png","80" },
            {"Crespo","27",@"..\\..\\Resources\\crespo.png","74" },
            {"Bellingham","22",@"..\\..\\Resources\\bellingham.png","84" },
            {"Pogba","10",@"..\\..\\Resources\\pogba.png","85" },
            {"Fernandes","8",@"..\\..\\Resources\\fernandes.png","86" },
            {"Pedri","8",@"..\\..\\Resources\\pedri.png","85" },
            {"Rakitic","10",@"..\\..\\Resources\\rakitic.png","82" },
            {"Dele Alli","20",@"..\\..\\Resources\\Delle.png","77" },
            {"Dorukhan","8",@"..\\..\\Resources\\dorukhan.png","75" },
            {"Chamberlain","15",@"..\\..\\Resources\\chamberlain.png","77" },
            {"Tolisso","88",@"..\\..\\Resources\\tolisso.png","81" },
            {"Pjanić","16",@"..\\..\\Resources\\pjanic.png","81" },
            {"Gedson","83",@"..\\..\\Resources\\gedson.png","77" }
        };
        public override string randomName(int random, string mevki)
        {
            return NAME = midfielders[random, 0];
        }

        public override int kitNumber(int random, string mevki)
        {
            return KitNumber = int.Parse(midfielders[random, 1]);
        }
        public override string photo(int random, string mevki)
        {
            return Pic = midfielders[random, 2];
        }
        public override int rating(int random, string mevki)
        {
            return Overall = int.Parse(midfielders[random, 3]);
        }
    }

    class Forward : Player
    {
        public string[,] forwards = new string[10, 4]
        {
            {"Dybala","21",@"..\\..\\Resources\\Dybala.png","86" },
            {"Ronaldo","7",@"..\\..\\Resources\\ronaldo.png","90" },
            {"Salah","11",@"..\\..\\Resources\\salah.png","90" },
            {"Lewandowski","9",@"..\\..\\Resources\\lewandowski.png","91" },
            {"Neymar","10",@"..\\..\\Resources\\neymar.png","89" },
            {"Vlahovic","9",@"..\\..\\Resources\\Vlahovic.png","84" },
            {"Icardi","99",@"..\\..\\Resources\\icardi.png","77" },
            {"Haaland","9",@"..\\..\\Resources\\haaland.png","88" },
            {"Mbappe","7",@"..\\..\\Resources\\mbappe.png","91" },
            {"Giroud","9",@"..\\..\\Resources\\Giroud.png","82" }
        };
        public override string randomName(int random, string mevki)
        {
            return NAME = forwards[random, 0];
        }

        public override int kitNumber(int random, string mevki)
        {
            return KitNumber = int.Parse(forwards[random, 1]);
        }
        public override string photo(int random, string mevki)
        {
            return Pic = forwards[random, 2];
        }
        public override int rating(int random, string mevki)
        {
            return Overall = int.Parse(forwards[random, 3]);
        }
    }
}

