using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23TriggerEventMFN_M06
    {
        private readonly HL7V2Message message;
        private readonly HL7V23SegmentMSH msh;
private readonly HL7V23SegmentMFI mfi;


        public string Id { get { return @"MFN_M06"; } }
        public string MessageStructureId { get { return @"MFN_M06"; } }
        public string EventDescription { get { return @"Clinical study with phases and schedules master file"; } }

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

        public HL7V23TriggerEventMFN_M06(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V23SegmentMSH(this.message);
this.mfi = new HL7V23SegmentMFI(this.message);

        }
    }
}