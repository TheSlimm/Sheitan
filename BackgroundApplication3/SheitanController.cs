using Restup.Webserver.Attributes;
using Restup.Webserver.Models.Contracts;
using Restup.Webserver.Models.Schemas;

namespace BackgroundApplication3
{
    [RestController(InstanceCreationType.PerCall)]
    public sealed class SheitanController
    {
        [UriFormat("/")]
        public IGetResponse Test()
        {
            return new GetResponse(GetResponse.ResponseStatus.OK, "wazaaaaaa");
        }
    }
}
