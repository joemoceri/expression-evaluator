using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V271TriggerEventSLR_S29
    {
        private readonly HL7V2Message message;
        private readonly HL7V271SegmentMSH msh;
private readonly HL7V271SegmentSFT sft;
private readonly HL7V271SegmentUAC uac;
private readonly HL7V271SegmentSLT slt;


        public string Id { get { return @"SLR_S29"; } }
        public string MessageStructureId { get { return @"SLR_S29"; } }
        public string EventDescription { get { return @"Request Sterilization lot deletion"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_17",

                    };
            }
        }

        public HL7V271TriggerEventSLR_S29(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V271SegmentMSH(this.message);
this.sft = new HL7V271SegmentSFT(this.message);
this.uac = new HL7V271SegmentUAC(this.message);
this.slt = new HL7V271SegmentSLT(this.message);

        }
    }
}
