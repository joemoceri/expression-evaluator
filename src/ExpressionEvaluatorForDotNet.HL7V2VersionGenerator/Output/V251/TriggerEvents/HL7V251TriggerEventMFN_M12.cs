using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251TriggerEventMFN_M12
    {
        private readonly HL7V2Message message;
        private readonly HL7V251SegmentMSH msh;
private readonly HL7V251SegmentSFT sft;
private readonly HL7V251SegmentMFI mfi;


        public string Id { get { return @"MFN_M12"; } }
        public string MessageStructureId { get { return @"MFN_M12"; } }
        public string EventDescription { get { return @"Master File Notification - Additional Basic Observation/Service Attributes"; } }

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

        public HL7V251TriggerEventMFN_M12(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V251SegmentMSH(this.message);
this.sft = new HL7V251SegmentSFT(this.message);
this.mfi = new HL7V251SegmentMFI(this.message);

        }
    }
}