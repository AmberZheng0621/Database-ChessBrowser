using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ChessTools
{
    
    class PGNReader
    {
       public static void main(String[] args)
        {
            ReadPGN("kb1.pgn");
        }
        public static List<ChessGame> ReadPGN(String path)
        {
            List<ChessGame> games= new List<ChessGame>();
           if(!File.Exists(path))
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
                                game.SetDate(each.Substring(12, each.IndexOf("]") - 2));
                            i++;
                            each = readText[i];
                                continue;
                            }

                            if (each.StartsWith("[Event"))
                            {
                                game.SetEventName(each.Substring(8, each.IndexOf("]") - 2));
                            i++;
                            each = readText[i];
                            continue;
                            }
                            if (each.StartsWith("[Site"))
                            {
                                game.SetSite(each.Substring(7, each.IndexOf("]") - 2));
                            i++;
                            each = readText[i];
                            continue;
                            }

                            if (each.StartsWith("[WhiteElo"))
                            {
                                game.SetWhiteElo(each.Substring(11, each.IndexOf("]") - 2));
                            i++;
                            each = readText[i];
                            continue;
                            }
                            if (each.StartsWith("[BlackElo"))
                            {
                                game.SetBlackElo(each.Substring(11, each.IndexOf("]") - 2));
                            i++;
                            each = readText[i];
                            continue;
                            }
                            if (each.StartsWith("[White"))
                            {
                                game.SetWhiteName(each.Substring(8, each.IndexOf("]") - 2));
                            i++;
                            each = readText[i];
                            continue;
                            }
                            if (each.StartsWith("[Black"))
                            {
                                game.SetBlackName(each.Substring(8, each.IndexOf("]") - 2));
                            i++;
                            each = readText[i];
                            continue;
                            }
                            if (each.StartsWith("[Result"))
                            {
                                game.SetResult(each.Substring(9, each.IndexOf("]") - 2));
                            i++;
                            each = readText[i];
                            continue;
                            }
                            else
                        {
                            i++;
                        }
                    }
                    String move = "";
                    i++;
                    while (String.IsNullOrEmpty(each))
                    {
                        move = move + each;
                        i++;
                    }
                    game.Setmoves(move);
                    games.Add(game);
                }
                

                }

            

            return null;
        }
        
    }
}
