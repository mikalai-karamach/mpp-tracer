using mpp_tracer.Classes.Model;
using Newtonsoft.Json;
using Util.Interfaces;

namespace Util.Implementations
{
    public class JsonTraceResultFormatter : ITraceResultFormatter
    {
        public string FormatTraceResult(TraceResult traceResult)
        {
            return JsonConvert.SerializeObject(traceResult, Formatting.Indented);
        }
    }
}