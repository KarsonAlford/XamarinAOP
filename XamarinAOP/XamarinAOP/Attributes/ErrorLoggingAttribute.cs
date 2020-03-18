using System.Diagnostics;
using MethodBoundaryAspect.Fody.Attributes;

namespace XamerinAOP.Attributes
{
    public sealed class ErrorLoggingAttribute : OnMethodBoundaryAspect
    {
        public override void OnEntry(MethodExecutionArgs args)
        {
            Debug.WriteLine("AOP OnEntry");
        }

        public override void OnExit(MethodExecutionArgs args)
        {
            Debug.WriteLine("AOP OnExit");
        }

        public override void OnException(MethodExecutionArgs args)
        {
            args.FlowBehavior = FlowBehavior.Continue;
            Debug.WriteLine("AOP " + args.Exception.Message);
        }
    }
}