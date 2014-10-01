using System.Text.RegularExpressions;
using Nancy;

namespace NancySelfHostedWithSignalR.Modules
{
    public class IndexModule : NancyModule
    {
        public IndexModule()
        {

            Get[@"/{uri*}"] = parameters =>
            {
                var regex = new Regex(@"\.(png|gif|jpg|jpeg)$");
                if (regex.IsMatch(parameters.uri))
                {
                    return View["index"];
                }
                else
                {
                    return null;
                }
            };
            Get["/"] = parameters =>
            {
                return View["index"];
            };
        }
    }
}