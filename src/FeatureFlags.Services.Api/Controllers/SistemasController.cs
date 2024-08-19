using Microsoft.AspNetCore.Mvc;
using System.Net;
using FeatureFlags.Application.AppServices.Interface;
using FeatureFlags.Application.ViewModel;

namespace UnimedFESP.FeatureFlags.Services.Api.Controllers
{
    [Route("api/[controller]")]
    public class SistemasController : ApiController
    {
        protected readonly ISistemaAppService _sistemasAppService;

        public SistemasController(ISistemaAppService sistemasAppService)
        {
            _sistemasAppService = sistemasAppService;
        }

        [HttpGet()]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType(typeof(ActionResult), (int)HttpStatusCode.OK)]
        public async Task<IEnumerable<SistemaViewModel>> Get()
        {
            return await _sistemasAppService.GetAllSistema();
        }

        [HttpPost()]
        public async Task<IActionResult> Post([FromBody] SistemaViewModel model)
        {
            return !ModelState.IsValid ? CustomResponse(ModelState) : CustomResponse(_sistemasAppService.IncluirSistema(model));
        }
    }
}
