using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251TriggerEventRSP_K25
    {
        private readonly HL7V2Message message;
        private readonly HL7V251SegmentMSH msh;
private readonly HL7V251SegmentSFT sft;
private readonly HL7V251SegmentMSA msa;
private readonly HL7V251SegmentERR err;
private readonly HL7V251SegmentQAK qak;
private readonly HL7V251SegmentQPD qpd;
private readonly HL7V251SegmentRCP rcp;
private readonly HL7V251SegmentDSC dsc;


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

        public HL7V251TriggerEventRSP_K25(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V251SegmentMSH(this.message);
this.sft = new HL7V251SegmentSFT(this.message);
this.msa = new HL7V251SegmentMSA(this.message);
this.err = new HL7V251SegmentERR(this.message);
this.qak = new HL7V251SegmentQAK(this.message);
this.qpd = new HL7V251SegmentQPD(this.message);
this.rcp = new HL7V251SegmentRCP(this.message);
this.dsc = new HL7V251SegmentDSC(this.message);

        }
    }
}