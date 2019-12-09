using System;
using System.Management.Automation;

namespace CmdLetDotNet
{
    [Cmdlet(VerbsCommon.Get, "RandomName")]
    public class MainCommand : Cmdlet
    {
        [Parameter(Position = 1)]
        public string Name { get; set; }



        protected override void ProcessRecord()
        {
            var result = $"The name you passed was {Name ?? "empty"}";
            //Console.WriteLine("TEST");
            WriteObject(result);
            base.ProcessRecord();
        }
    }
}
