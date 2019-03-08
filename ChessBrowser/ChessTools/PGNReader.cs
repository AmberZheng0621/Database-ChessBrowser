using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ChessTools
{
    
    public  class PGNReader
    {
       
        public  List<ChessGame> ReadPGN(String path)
        {
            List<ChessGame> games= new List<ChessGame>();
           if(File.Exists(path))
            {
                String[] readText = File.ReadAllLines(path);
                int i = 0;
                while(i<readText.Length)
                {
                    String each = readText[i];
                    ChessGame game = new ChessGame();
                    while (each.StartsWith("["))
                        {
                           
                            if (each.StartsWith("[EventDate"))
                            {
                              each= each.Substring(12, each.Length - 14);
                          
                                game.SetDate(each.Replace(".", "-"));
                            i++;
                            each = readText[i];
                                continue;
                            }

                            if (each.StartsWith("[Event"))
                            {
                                game.SetEventName(each.Substring(8, each.Length - 10));
                            i++;
                            each = readText[i];
                            continue;
                            }
                            if (each.StartsWith("[Site"))
                            {
                                game.SetSite(each.Substring(7, each.Length - 9));
                            i++;
                            each = readText[i];
                            continue;
                            }

                            if (each.StartsWith("[WhiteElo"))
                            {
                                game.SetWhiteElo(Convert.ToUInt32(each.Substring(11, each.Length - 13)));
                            i++;
                            each = readText[i];
                            continue;
                            }
                            if (each.StartsWith("[BlackElo"))
                            {
                                game.SetBlackElo(Convert.ToUInt32(each.Substring(11, each.Length - 13)));
                            i++;
                            each = readText[i];
                            continue;
                            }
                            if (each.StartsWith("[White"))
                            {
                                game.SetWhiteName(each.Substring(8, each.Length - 10));
                            i++;
                            each = readText[i];
                            continue;
                            }
                            if (each.StartsWith("[Black"))
                            {
                                game.SetBlackName(each.Substring(8, each.Length - 10));
                            i++;
                            each = readText[i];
                            continue;
                            }
                            if (each.StartsWith("[Result"))
                            {
                            String res = each.Substring(9, each.Length - 11);
                            if (res.Equals("1-0"))
                            {
                                game.SetResult("W");
                            }
                            else if (res.Equals("0-1"))
                            {
                                game.SetResult("B");
                            }
                            else
                            {
                                    game.SetResult("D");   
                            }
                            i++;
                            each = readText[i];
                            continue;
                            }
                            else
                        {
                            i++;
                            each = readText[i];
                            continue;
                        }
                    }
                    String move = "";
                   
                    i++;
                    while (!String.IsNullOrEmpty(readText[i])&& i<readText.Length)
                    {
                        move=move+readText[i];
                       
                        i++;
                        
                    }
                    
                    game.Setmoves(move);
                    games.Add(game);
                    i++;
                }
                

                }

            

            return games;
        }
        
    }
}
