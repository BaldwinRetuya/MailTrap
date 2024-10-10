using PhonesModel;
using PhonesDL;

namespace PhonesDL
{
    public class phonesData
    {
        List<Phones> phones;
        sqlDBData sqlData;

        public phonesData()
        {
            phones = new List<Phones>();
            sqlData = new sqlDBData();
        }

        public List<Phones> GetPhones()
        {
            phones = sqlData.GetPhones();
            return phones;
        }
        public int AddPhones(Phones phone)
        {
            return sqlData.AddPhones(phone.Brand, phone.Model, phone.Price);
        }
        public int UpdatePhones(Phones phone)
        {
            return sqlData.UpdatePhones(phone.Brand, phone.Model, phone.Price);
        }
        public int DeletePhones(Phones phone)
        {
            return sqlData.DeletePhones(phone.Brand);
        }


    }
}