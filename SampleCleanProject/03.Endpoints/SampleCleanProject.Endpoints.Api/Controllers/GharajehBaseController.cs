using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace SampleCleanProject.Endpoints.Api.Controllers
{
    [Route("[controller]/[action]"), ApiController]
    public class GharajehBaseController : ControllerBase
    {
        private ISender? _mediator;
        protected ISender Mediator => _mediator ??= HttpContext.RequestServices.GetRequiredService<ISender>();
    }
}
