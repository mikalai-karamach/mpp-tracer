using System.Reflection;

namespace mpp_tracer
{
    public class MethodMetadata
    {
        internal MethodMetadata(MethodBase methodBase)
        {
            Name = methodBase.Name;
            ClassName = methodBase.DeclaringType?.ToString();
            CountOfParameters = methodBase.GetParameters().Length;
        }

        public string Name { get; }
        public string ClassName { get; }
        public int CountOfParameters { get; }
    }
}