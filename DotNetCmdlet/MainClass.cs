using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DotNetCmdlet
{
    [Cmdlet(VerbsCommon.Get,"Name")]
    public class MainClass : Cmdlet 
    {
        [Parameter(Position =1, Mandatory =true, ValueFromPipeline =true)]
        public string Name { get; set; }

        protected override void BeginProcessing()
        {
            Console.WriteLine("Starting");
            base.BeginProcessing();
        }
        protected override void ProcessRecord()
        {
            
            var result = new
            {
                
                Id = Guid.NewGuid(),
                Message = $"The name you passed was {Name ?? "empty"}",
                Timestamp = DateTime.Now.ToUniversalTime()
            }
            ;
            
            WriteObject(result);
            WriteDebug(result.Message);
            base.ProcessRecord();
            
            Thread.Sleep(1000);
        }

        protected override void EndProcessing()
        {
            Console.WriteLine("Thank yopu");
            base.EndProcessing();
        }

        protected override void StopProcessing()
        {
            Console.WriteLine("Processing stopped with no guarantee to complete request");
            base.StopProcessing();
        }
    }
}
