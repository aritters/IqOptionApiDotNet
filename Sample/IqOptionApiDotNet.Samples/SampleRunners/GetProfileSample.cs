using System.Threading.Tasks;
using Newtonsoft.Json;

namespace IqOptionApiDotNet.Samples.SampleRunners
{
    public class GetProfileSample : SampleRunner
    {


        public override async Task RunSample()
        {
            if (await IqClientApiDotNet.ConnectAsync())
            {
                var profile = await IqClientApiDotNet.GetProfileAsync();
                _logger.Information(JsonConvert.SerializeObject(profile));
            }
        }
    }
}