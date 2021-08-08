using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251TriggerEventQBP_Q11
    {
        private readonly HL7V2Message message;
        private readonly HL7V251SegmentMSH msh;
private readonly HL7V251SegmentSFT sft;
private readonly HL7V251SegmentQPD qpd;
private readonly HL7V251SegmentRCP rcp;
private readonly HL7V251SegmentDSC dsc;


        public string Id { get { return @"QBP_Q11"; } }
        public string MessageStructureId { get { return @"QBP_Q11"; } }
        public string EventDescription { get { return @"Query by Parameter Requesting an RSP Segment Pattern Response"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_05",

                    };
            }
        }

        public HL7V251TriggerEventQBP_Q11(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V251SegmentMSH(this.message);
this.sft = new HL7V251SegmentSFT(this.message);
this.qpd = new HL7V251SegmentQPD(this.message);
this.rcp = new HL7V251SegmentRCP(this.message);
this.dsc = new HL7V251SegmentDSC(this.message);

        }
    }
}
