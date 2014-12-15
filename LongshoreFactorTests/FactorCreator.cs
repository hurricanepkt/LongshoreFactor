using LongshoreFactor;

namespace LongshoreFactorTests
{
    public class FactorCreator
    {
        public static Factors Create(Employer employer = Employer.Other, 
            bool crew = false, 
            bool vesselsInNavigation = false, 
            bool seaTrials = false,
            bool commercialVessels = false,
            bool over65Ft = false,
            bool construction = false,
            bool trueMarina = false,
            bool nonprofit = false,
            bool docksideEmp = false,
            bool controlledEnviroment = false,
            bool loading = false,
            bool seawalls = false,
            bool barge = false,
            bool sec9023A = false,
            bool vendor  = false,
            bool vendorRepair = false,
            bool vendorPermanent = false,
            bool vendorSimilar = false
            )
        {
            return new Factors
            {
                Employer = employer,
                Crew = crew,
                VesselsInNavigation = vesselsInNavigation,
                SeaTrials = seaTrials,
                CommercialVessels = commercialVessels,
                Over65ft = over65Ft,
                Construction = construction,
                TrueMarina = trueMarina,
                Nonprofit = nonprofit,
                DocksideEmp = docksideEmp,
                ControlledEnviroment = controlledEnviroment,
                Loading = loading,
                Seawalls = seawalls,
                Barge = barge,
                Sec9023a = sec9023A,
                Vendor = vendor,
                VendorRepair = vendorRepair,
                VendorPermanent = vendorPermanent,
                VendorSimilar = vendorSimilar
            };
        }
    }
}