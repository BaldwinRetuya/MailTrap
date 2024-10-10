using PhonesDL;
using PhonesModel;
using PhonesBL;

namespace Client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            phonesGetServices services = new phonesGetServices();

            var phones = services.GetAllPhones();

            foreach (var item in phones)
            {
                Console.WriteLine(item.Brand);
                Console.WriteLine(item.Model);
                Console.WriteLine(item.Price);

            }
        }
    }
}