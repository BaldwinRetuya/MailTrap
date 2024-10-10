using PhonesModel;
using PhonesDL;
using System.Reflection.Metadata;
using System.Numerics;

namespace PhonesBL
{
    public class phonesGetServices
    {
        public List<Phones> GetAllPhones()
        {
            phonesData phoneData = new phonesData();

            return phoneData.GetPhones();
        }

        public List<Phones> GetBrand(string Brand)
        {
            List<Phones> phoneBrand = new List<Phones>();

            foreach (var phone in GetAllPhones())
            {
                if (phone.Brand == Brand)
                {
                    phoneBrand.Add(phone);
                }
            }

            return phoneBrand;
        }

        public Phones GetPhones(string Brand, string Model, string Price)
        {
            Phones foundPhone = new Phones();

            foreach (var phone in GetAllPhones())
            {
                if (phone.Brand == Brand && phone.Model == Model && phone.Price == Price)
                {
                    foundPhone = phone;
                }
            }

            return foundPhone;
        }

    }
}