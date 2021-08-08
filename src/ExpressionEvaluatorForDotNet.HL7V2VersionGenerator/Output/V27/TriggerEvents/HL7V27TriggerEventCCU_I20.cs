using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27TriggerEventCCU_I20
    {
        private readonly HL7V2Message message;
        private readonly HL7V27SegmentMSH msh;
private readonly HL7V27SegmentSFT sft;
private readonly HL7V27SegmentUAC uac;
private readonly HL7V27SegmentRF1 rf1;
private readonly HL7V27SegmentNK1 nk1;
private readonly HL7V27SegmentREL rel;


        public string Id { get { return @"CCU_I20"; } }
        public string MessageStructureId { get { return @"CCU_I20"; } }
        public string EventDescription { get { return @"Asynchronous Collaborative Care Update"; } }

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

        public HL7V27TriggerEventCCU_I20(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V27SegmentMSH(this.message);
this.sft = new HL7V27SegmentSFT(this.message);
this.uac = new HL7V27SegmentUAC(this.message);
this.rf1 = new HL7V27SegmentRF1(this.message);
this.nk1 = new HL7V27SegmentNK1(this.message);
this.rel = new HL7V27SegmentREL(this.message);

        }
    }
}