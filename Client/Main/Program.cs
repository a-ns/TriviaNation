﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using NetworkLayerInterfaces;
using NetworkLayer;
using GUILayer;

namespace Main
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            INetwork network = Network.Instance;
            network.SetEndPointLocation("http://trivianation.herokuapp.com");
            IMainMenuNetwork mainMenuNetwork = MainMenuNetwork.Instance;
            mainMenuNetwork.setNetwork(network);
            IGameBoardNetwork gameNetwork = GameBoardNetwork.Instance;
            gameNetwork.setGameBoardNetwork(network);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GUILayer.MainMenu(network, mainMenuNetwork, gameNetwork));
        }
    }
}
