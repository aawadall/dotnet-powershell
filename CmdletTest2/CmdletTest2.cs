using System.Management.Automation;

namespace CmdletTest2
{
    [Cmdlet(VerbsCommon.Get,"RandomName")]
    public class CmdletTest2 : Cmdlet
    {
        [Parameter(Position =1, ValueFromPipeline =true)]
        public string Name { get; set; }

      

        protected override void ProcessRecord()
        {
            var result = $"The name you passed was {Name??"empty"}";
            //Console.WriteLine("TEST");
            WriteObject(result);
            base.ProcessRecord();
        }

       
    }
}
