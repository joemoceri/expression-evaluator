using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25TriggerEventQBP_Z81
    {
        private readonly HL7V2Message message;
        public HL7V25SegmentMSH msh{get; init;}
public HL7V25SegmentSFT sft{get; init;}
public HL7V25SegmentQPD qpd{get; init;}
public HL7V25SegmentRCP rcp{get; init;}
public HL7V25SegmentDSC dsc{get; init;}


        public string Id { get { return @"QBP_Z81"; } }
        public string MessageStructureId { get { return @"QBP_Z81"; } }
        public string EventDescription { get { return @"Dispense History Query"; } }

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

        public HL7V25TriggerEventQBP_Z81(HL7V2Message message)
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
