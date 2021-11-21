using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.ThePaintist
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Piece> pieces = new List<Piece>();

            for (int i = 0; i < n; i++)
            {
                List<string> initialPiece = Console.ReadLine().Split("|").ToList();
                Piece newPiece = new Piece(initialPiece[0],initialPiece[1],initialPiece[2]);
                
                pieces.Add(newPiece);
            }

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Stop")
            {
                List<string> commandInfo = input.Split("|").ToList();
                string firstCommand = commandInfo[0];
                string currPieceName = commandInfo[1];
                string currComposer = string.Empty;
                string currKey = string.Empty;

                if (firstCommand == "Add")
                {
                    currComposer = commandInfo[2];
                    currKey = commandInfo[3];

                    if (CheckIfPieceExist(pieces , currPieceName))
                    {
                        Console.WriteLine($"{currPieceName} is already in the collection!");
                    }
                    else
                    {
                        Piece newPiece = new Piece(currPieceName , currComposer , currKey);
                        Console.WriteLine($"{currPieceName} by {currComposer} in {currKey} added to the collection!");
                        pieces.Add(newPiece);
                    }
                }
                else if (firstCommand == "Remove")
                {
                    if (CheckIfPieceExist(pieces , currPieceName))
                    {
                        for (int i = 0; i < pieces.Count; i++)
                        {
                            if (pieces[i].Name == currPieceName)
                            {
                                pieces.RemoveAt(i);
                                Console.WriteLine($"Successfully removed {currPieceName}!");
                                break;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {currPieceName} does not exist in the collection.");
                    }
                }
                else if (firstCommand == "ChangeKey")
                {
                    currKey = commandInfo[2];

                    if (CheckIfPieceExist(pieces , currPieceName))
                    {
                        for (int i = 0; i < pieces.Count; i++)
                        {
                            if (pieces[i].Name == currPieceName)
                            {
                                pieces[i].Key = currKey;
                                Console.WriteLine($"Changed the key of {currPieceName} to {currKey}!");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {currPieceName} does not exist in the collection.");
                    }
                }
            }

            pieces = pieces.OrderBy(x => x.Name).ThenBy(x => x.Composer).ToList();

            for (int j = 0; j < pieces.Count; j++)
            {
                Console.WriteLine($"{pieces[j].Name} -> Composer: {pieces[j].Composer}, Key: {pieces[j].Key}");
            }
        }

        static public bool CheckIfPieceExist (List<Piece> pieces , string pieceName)
        {
            bool pieceExist = false;

            for (int i = 0; i < pieces.Count; i++)
            {
                if (pieces[i].Name == pieceName)
                {
                    pieceExist = true;
                    break;
                }
            }
            return pieceExist;
        }
    }
}
