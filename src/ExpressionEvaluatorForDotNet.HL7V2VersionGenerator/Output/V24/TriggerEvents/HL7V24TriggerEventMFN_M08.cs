using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24TriggerEventMFN_M08
    {
        private readonly HL7V2Message message;
        private readonly HL7V24SegmentMSH msh;
private readonly HL7V24SegmentMFI mfi;


        public string Id { get { return @"MFN_M08"; } }
        public string MessageStructureId { get { return @"MFN_M08"; } }
        public string EventDescription { get { return @"Master files notification - Test/observation (numeric) master file"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_08",

                    };
            }
        }

        public HL7V24TriggerEventMFN_M08(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V24SegmentMSH(this.message);
this.mfi = new HL7V24SegmentMFI(this.message);

        }
    }
}