using System;
using System.Management.Automation;

namespace Exp2B
{
    [Cmdlet(VerbsCommon.Get, "RandomName")]
    public class CmdletOne : Cmdlet
    {
        protected override void ProcessRecord()
        {
            Console.WriteLine("Test");
            base.ProcessRecord();
        }
    }
}
