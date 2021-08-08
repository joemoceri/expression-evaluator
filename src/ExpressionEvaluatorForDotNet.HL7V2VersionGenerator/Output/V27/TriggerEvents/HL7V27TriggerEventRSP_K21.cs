using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27TriggerEventRSP_K21
    {
        private readonly HL7V2Message message;
        private readonly HL7V27SegmentMSH msh;
private readonly HL7V27SegmentSFT sft;
private readonly HL7V27SegmentUAC uac;
private readonly HL7V27SegmentMSA msa;
private readonly HL7V27SegmentERR err;
private readonly HL7V27SegmentQAK qak;
private readonly HL7V27SegmentQPD qpd;
private readonly HL7V27SegmentDSC dsc;


        public string Id { get { return @"RSP_K21"; } }
        public string MessageStructureId { get { return @"RSP_K21"; } }
        public string EventDescription { get { return @"Get person demographics response"; } }

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

        public HL7V27TriggerEventRSP_K21(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V27SegmentMSH(this.message);
this.sft = new HL7V27SegmentSFT(this.message);
this.uac = new HL7V27SegmentUAC(this.message);
this.msa = new HL7V27SegmentMSA(this.message);
this.err = new HL7V27SegmentERR(this.message);
this.qak = new HL7V27SegmentQAK(this.message);
this.qpd = new HL7V27SegmentQPD(this.message);
this.dsc = new HL7V27SegmentDSC(this.message);

        }
    }
}