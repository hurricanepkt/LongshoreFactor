namespace LongshoreFactor
{
public class Calculator
{
    private static Factors _factors;
    public static CalculatorResult Calculate(Factors factors)
    {
        _factors = factors;
        return new CalculatorResult
        {
            StateActWorkersComp = true,
            Longshore = CalculateLongshore(),
            Admiralty = CalculateAdmiralty()
        };
    }

    private static bool CalculateLongshore()
    {
        if (_factors.Employer == Employer.Shipyard)
        {
            return true;
        }
        if (_factors.Employer == Employer.Catering)
        {
            return true;
        }
        if (_factors.Employer == Employer.Marina)
        {
            if (_factors.Construction)
            {
                return true;
            }
            return (_factors.CommercialVessels || _factors.Over65ft);
        }
        if (_factors.Employer == Employer.FishFarm)
        {
            return (!_factors.ControlledEnviroment) || _factors.Loading;
        }
        if (_factors.Employer == Employer.MarineContractor)
        {
            return (!_factors.Seawalls) || _factors.Barge;
        }
        if (_factors.Employer != Employer.Other)
        {
            return (_factors.CommercialVessels || _factors.Over65ft || _factors.DocksideEmp);
        }
              
        if (_factors.Sec9023a == false && _factors.Vendor == false)
        {
            return true;
        }
        if (_factors.Vendor)
        {
            return (_factors.VendorPermanent || _factors.VendorRepair
                    || _factors.VendorSimilar || _factors.Loading);
        }
        return (_factors.CommercialVessels || _factors.Over65ft || _factors.DocksideEmp);
    }

    private static bool CalculateAdmiralty()
    {
        return (_factors.Crew || _factors.VesselsInNavigation || _factors.SeaTrials);
    }
}
}