using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using NetworkLayerInterfaces;
using NetworkLayer;

namespace MainMenu
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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainMenu(network, mainMenuNetwork));
        }
    }
}
