using Microsoft.AspNet.SignalR;
using Microsoft.Owin.Cors;
using Owin;

namespace NancySelfHostedWithSignalR
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.Map("/signalr", map =>
            {

                map.UseCors(CorsOptions.AllowAll);

                var hubConfiguration = new HubConfiguration {// You can enable JSONP by uncommenting line below.
                    // JSONP requests are insecure but some older browsers (and some
                    // versions of IE) require JSONP to work cross domain
                    // EnableJSONP = true
                };

                // Run the SignalR pipeline. We're not using MapSignalR
                // since this branch is already runs under the "/signalr"
                // path.
                map.RunSignalR(hubConfiguration);
            })
                .UseNancy();
        }
    }
}