using System;


namespace PhonesBL
{
    public class phonesVS
    {
        phonesGetServices getServices = new phonesGetServices();

        public bool CheckIfBrandExist(string Brand)
        {
            bool result = getServices.GetBrand(Brand) != null;
            return result;

        }

        public bool CheckIfPhoneExist(string Brand, string Model, string Price)
        {
            bool result = getServices.GetPhones(Brand, Model, Price) != null;
            return result;
        }

    }
}