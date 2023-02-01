using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace footballManagerForm.Sınıflar
{
    internal class Team:IDisposable
    {
        private string teamName;
        public string TeamName
        {
            get { return teamName; }
            set { teamName = value; }
        }


        public void Dispose()
        {
            //throw new NotImplementedException();
        }
    }
}
