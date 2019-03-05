using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessTools
{
    public class ChessGame
    {
        private String Event;
        public String GetEventName()
        {
            return this.Event;
        }
        public void SetEventName(String Eve)
        {
            this.Event = Eve;
        }
        private String Site;
        public String GetSite()
        {
            return this.Site;
        }
        public void SetSite(String site)
        {
            this.Site = site;
        }

        private String EventDate;
        public String GetDate()
        {
            return this.EventDate;
        }
        public void SetDate(String date)
        {
            this.EventDate = date;
        }
        private String Black;
        public String GetBlackName()
        {
            return this.Black;
        }
        public void SetBlackName(String black)
        {
            this.Black = black;
        }
        private String White;
        public String GetWhiteName()
        {
            return this.White;
        }
        public void SetWhiteName(String white)
        {
            this.White = white;
        }
        private String WhiteElo;
        public String GetWhiteElo()
        {
            return this.WhiteElo;
        }
        public void SetWhiteElo(String whiteelo)
        {
            this.WhiteElo = whiteelo;
        }
        private String BlackElo;
        public String GetBlackElo()
        {
            return this.BlackElo;
        }
        public void SetBlackElo(String blackelo)
        {
            this.BlackElo = blackelo;
        }
        private String Result;
        public String GetResult()
        {
            return this.Result;
        }
        public void SetResult(String result)
        {
            this.Result = result;
        }
        private String moves;
        public String Getmoves()
        {
            return this.moves;
        }
        public void Setmoves(String move)
        {
            this.moves = move;
        }


    }
}
