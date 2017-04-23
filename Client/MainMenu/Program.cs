using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using NetworkLayerInterfaces;
using NetworkLayer;

namespace GUILayer
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
            network.SetEndPointLocation("http://localhost:3000");
            IMainMenuNetwork mainMenuNetwork = MainMenuNetwork.Instance;
            mainMenuNetwork.setNetwork(network);
            IGameBoardNetwork gameNetwork = GameBoardNetwork.Instance;
            gameNetwork.setGameBoardNetwork(network);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainMenu(network, mainMenuNetwork, gameNetwork));
            
            //Application.Run(new EditGameBoard(gameNetwork));     // FOR TESTING GAME BOARD
        }
    }
}
