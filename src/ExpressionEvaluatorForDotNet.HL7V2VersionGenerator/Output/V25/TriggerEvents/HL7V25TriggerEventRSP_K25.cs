using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25TriggerEventRSP_K25
    {
        private readonly HL7V2Message message;
        private readonly HL7V25SegmentMSH msh;
private readonly HL7V25SegmentSFT sft;
private readonly HL7V25SegmentMSA msa;
private readonly HL7V25SegmentERR err;
private readonly HL7V25SegmentQAK qak;
private readonly HL7V25SegmentQPD qpd;
private readonly HL7V25SegmentRCP rcp;
private readonly HL7V25SegmentDSC dsc;


        public string Id { get { return @"RSP_K25"; } }
        public string MessageStructureId { get { return @"RSP_K25"; } }
        public string EventDescription { get { return @"Response - Personnel information"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_15",

                    };
            }
        }

        public HL7V25TriggerEventRSP_K25(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V25SegmentMSH(this.message);
this.sft = new HL7V25SegmentSFT(this.message);
this.msa = new HL7V25SegmentMSA(this.message);
this.err = new HL7V25SegmentERR(this.message);
this.qak = new HL7V25SegmentQAK(this.message);
this.qpd = new HL7V25SegmentQPD(this.message);
this.rcp = new HL7V25SegmentRCP(this.message);
this.dsc = new HL7V25SegmentDSC(this.message);

        }
    }
}
