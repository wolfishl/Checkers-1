﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CheckersProject; 

namespace CheckersProject
{
    class Game
    {
        private Player startingPlayer;
        private Player currentPlayer;
        private String computerColor;
        private String humanColor;
        private Button originButton;
        private Button destinationButton; 
        private bool originClicked;
        private bool destinationClicked; 
        private int computerScore; 
        private int humanScore; 

        public Game ()
        {
            this.computerScore = 0;
            this.humanScore = 0; 
        }
        public void SetStartingPlayer(Player player)
        {
            startingPlayer = player;
            currentPlayer = startingPlayer;
        }
        public Player GetStartingPlayer()
        {
            return startingPlayer;
        }
        public void NextPlayersTurn()
        {
            currentPlayer = currentPlayer == Player.MAX ? Player.MIN : Player.MAX;
        }
        public Player GetCurrentPlayer()
        {
            return currentPlayer;
        }
        public string GetHumanColor()
        {
            return this.humanColor;
        }
        public void SetHumanColor(string tag)
        {
            this.humanColor = tag;
        }
        public string GetComputerColor()
        {
            return this.computerColor;
        }
        public void SetComputerColor(string tag)
        {
            this.computerColor = tag;
        }
        public Button GetOriginButton()
        {
            return this.originButton; 
        }        
        public bool IsOriginClicked ()
        {
            return this.originClicked; 
        }
        public void SetOriginClicked(Button btn, bool clicked)
        {
            this.originButton = btn; 
            this.originClicked = clicked; 
        }
        public Button GetDestinationButton()
        {
            return this.destinationButton;
        }
        public bool IsDestinationClicked()
        {
            return this.destinationClicked;
        }
        public void SetDestinationClicked(Button btn, bool clicked)
        {
            this.destinationButton = btn;
            this.destinationClicked = clicked;
        }
        public void IncreaseComputerScore (int points)
        {
            this.computerScore += points;
        }        
        public void IncreaseHumanScore (int points)
        {
            this.humanScore += points;
        }
        public string GetComputerScore()
        {
            return this.computerScore.ToString(); 
        }
        public string GetHumanScore()
        {
            return this.humanScore.ToString(); 
        }

    }
}
