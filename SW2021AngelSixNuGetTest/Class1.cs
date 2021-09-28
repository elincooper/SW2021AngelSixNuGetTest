using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AngelSix.SolidDna;
using Dna;
using static AngelSix.SolidDna.SolidWorksEnvironment;

namespace SW2021AngelSixNuGetTest
{
    public class SolidDnaAddinIntegration : AddInIntegration
    {
        public override void ApplicationStartup()
        {
            
        }

        public override void PreConnectToSolidWorks()
        {
            
        }

        public override void PreLoadPlugIns()
        {
            
        }
    }

    public class NuGetTestPlugIn : SolidPlugIn
    {
        public override string AddInTitle => "NuGetTestPlugIn";

        public override string AddInDescription => "Test the NuGet package";

        public override void ConnectedToSolidWorks()
        {
            Application.ShowMessageBox("test", SolidWorksMessageBoxIcon.Information);
        }

        public override void DisconnectedFromSolidWorks()
        {

        }
    }
}
