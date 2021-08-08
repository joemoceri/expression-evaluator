using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24TriggerEventMFN_M04
    {
        private readonly HL7V2Message message;
        private readonly HL7V24SegmentMSH msh;
private readonly HL7V24SegmentMFI mfi;


        public string Id { get { return @"MFN_M04"; } }
        public string MessageStructureId { get { return @"MFN_M04"; } }
        public string EventDescription { get { return @"Master files notification - Charge description master file"; } }

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

        public HL7V24TriggerEventMFN_M04(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V24SegmentMSH(this.message);
this.mfi = new HL7V24SegmentMFI(this.message);

        }
    }
}