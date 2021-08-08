using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25TriggerEventQBP_Q23
    {
        private readonly HL7V2Message message;
        private readonly HL7V25SegmentMSH msh;
private readonly HL7V25SegmentSFT sft;
private readonly HL7V25SegmentQPD qpd;
private readonly HL7V25SegmentRCP rcp;
private readonly HL7V25SegmentDSC dsc;


        public string Id { get { return @"QBP_Q23"; } }
        public string MessageStructureId { get { return @"QBP_Q23"; } }
        public string EventDescription { get { return @"Get Corresponding Identifiers Query"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_03",

                    };
            }
        }

        public HL7V25TriggerEventQBP_Q23(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V25SegmentMSH(this.message);
this.sft = new HL7V25SegmentSFT(this.message);
this.qpd = new HL7V25SegmentQPD(this.message);
this.rcp = new HL7V25SegmentRCP(this.message);
this.dsc = new HL7V25SegmentDSC(this.message);

        }
    }
}
