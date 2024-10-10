using Microsoft.AspNetCore.Mvc;
using PhonesBL;

namespace PhonesAPI.Controllers
{
    [ApiController]
    [Route("api/phones")]
    public class PhonesControllers : ControllerBase
    {
        phonesGetServices getServices;
        phoneUD transactionService;

        public PhonesControllers()
        {
            getServices = new phonesGetServices();
            transactionService = new phoneUD();
        }

        [HttpGet]
        public IEnumerable<PhonesAPI.phones> Getphone()
        {
            var phone = getServices.GetAllPhones();

            List<PhonesAPI.phones> cont = new List<PhonesAPI.phones>();

            foreach (var phones in phone)
            {
                cont.Add(new PhonesAPI.phones { Brand = phones.Brand, Model = phones.Model, Price = phones.Price });
            }
            return cont;
        }
        [HttpPost]
        public JsonResult Addphones(phones request)
        {
            var result = transactionService.CreatePhone(request.Brand, request.Model, request.Price);

            return new JsonResult(result);

        }

        [HttpPatch]
        public JsonResult Updatephones(phones request)
        {
            var result = transactionService.UpdatePhone(request.Brand, request.Model, request.Price);

            return new JsonResult(result);
        }

        [HttpDelete]
        public JsonResult DeleteP(PhonesAPI.phones request)
        {

            var phoneToDelete = new PhonesModel.Phones
            {
                Brand = request.Brand

            };

            var result = transactionService.DeletePhone(phoneToDelete);

            return new JsonResult(result);
        }
    }
}


