using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardGame;

namespace Pinochle
{
    public class PinochleGame
    {
        public List<Player> Team1 { get; set; }
        public List<Player> Team2 { get; set; }
        public Player PlayerOne { get; set; }
        public Player PlayerTwo { get; set; }
        public Player PlayerThree { get; set; }
        public Player PlayerFour { get; set; }
        public int OpeningBid { get; set; }
        public Suit.SuitType Trump { get; set; }
        public int Team1Score { get; set; }
        public int Team2Score { get; set; }
        public bool End { get; set; }
        private int _currentDealer = 0;

        public PinochleGame(Player playerOne, Player playerTwo, Player playerThree, Player playerFour)
        {
            PlayerOne = playerOne;
            PlayerTwo = playerTwo;
            PlayerOne = playerOne;
            PlayerOne = playerOne;

            Team1Score = 0;
            Team2Score = 0;
            OpeningBid = 25;
            End = false;
        }

        public Player GetNextDealer()
        {
            Player CurrentDealer = new Player("Unknown");
            if (_currentDealer == 0)
            {
                Random rnd = new Random();
                int _currentDealer = rnd.Next(1, 4);
            }
            switch (_currentDealer)
            {
                case 1:
                    CurrentDealer = PlayerOne;
                    break;
                case 2:
                    CurrentDealer = PlayerTwo;
                    break;
                case 3:
                    CurrentDealer = PlayerThree;
                    break;
                case 4:
                    CurrentDealer = PlayerFour;
                    break;
            }
            return CurrentDealer;
        }
    }
}
