using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace LongshoreFactor
{
    public class Factors
    {
        public Employer Employer { get; set; }
        public bool Crew { get; set; }
        public bool VesselsInNavigation { get; set; }
        public bool SeaTrials { get; set; }



        public bool CommercialVessels { get; set; }

        public bool Over65ft { get; set; }

        public bool Construction { get; set; }

        public bool TrueMarina { get; set; }

        public bool Nonprofit { get; set; }

        public bool DocksideEmp { get; set; }

        public bool ControlledEnviroment { get; set; }

        public bool Loading { get; set; }

        public bool Seawalls { get; set; }

        public bool Barge { get; set; }

        public bool Sec9023a { get; set; }

        public bool Vendor { get; set; }

        public bool VendorRepair { get; set; }

        public bool VendorPermanent { get; set; }

        public bool VendorSimilar { get; set; }
    }

    public enum Employer
    {
        Other,
        Shipyard,
        BoatBuilder,
        BoatRepair,
        Marina,
        Restaurant,
        Catering,
        YachtClub,
        Vessel,
        FishFarm,
        MarineContractor
    }

    public class CalculatorResult
    {
        public bool StateActWorkersComp { get; set; }
        public bool Longshore { get; set; }
        public bool Admiralty { get; set; }
    }
}
