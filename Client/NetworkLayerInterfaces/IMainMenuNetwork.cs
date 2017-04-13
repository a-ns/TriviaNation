using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkLayerInterfaces
{
    public interface IMainMenuNetwork
    {
        void MainMenuSetupSocket(Action<String, String> MainMenuMessageBoxCallback);

        bool MainMenuSetEndPointLocation(String location);

        void MainMenuSignUp(String username, String password);

        bool MainMenuSignIn(String username, String password);

        void setNetwork(INetwork network);


    }
}
