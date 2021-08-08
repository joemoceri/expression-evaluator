using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27TriggerEventCCM_I21
    {
        private readonly HL7V2Message message;
        private readonly HL7V27SegmentMSH msh;
private readonly HL7V27SegmentSFT sft;
private readonly HL7V27SegmentUAC uac;
private readonly HL7V27SegmentPID pid;
private readonly HL7V27SegmentPD1 pd1;
private readonly HL7V27SegmentNK1 nk1;
private readonly HL7V27SegmentREL rel;


        public string Id { get { return @"CCM_I21"; } }
        public string MessageStructureId { get { return @"CCM_I21"; } }
        public string EventDescription { get { return @"Collaborative Care Message"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_11",

                    };
            }
        }

        public HL7V27TriggerEventCCM_I21(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V27SegmentMSH(this.message);
this.sft = new HL7V27SegmentSFT(this.message);
this.uac = new HL7V27SegmentUAC(this.message);
this.pid = new HL7V27SegmentPID(this.message);
this.pd1 = new HL7V27SegmentPD1(this.message);
this.nk1 = new HL7V27SegmentNK1(this.message);
this.rel = new HL7V27SegmentREL(this.message);

        }
    }
}