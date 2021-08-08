using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24TriggerEventOSR_Q06
    {
        private readonly HL7V2Message message;
        private readonly HL7V24SegmentMSH msh;
private readonly HL7V24SegmentMSA msa;
private readonly HL7V24SegmentERR err;
private readonly HL7V24SegmentNTE nte;
private readonly HL7V24SegmentQRD qrd;
private readonly HL7V24SegmentQRF qrf;
private readonly HL7V24SegmentDSC dsc;


        public string Id { get { return @"OSR_Q06"; } }
        public string MessageStructureId { get { return @"OSR_Q06"; } }
        public string EventDescription { get { return @"Query response for order status"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_04",

                    };
            }
        }

        public HL7V24TriggerEventOSR_Q06(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V24SegmentMSH(this.message);
this.msa = new HL7V24SegmentMSA(this.message);
this.err = new HL7V24SegmentERR(this.message);
this.nte = new HL7V24SegmentNTE(this.message);
this.qrd = new HL7V24SegmentQRD(this.message);
this.qrf = new HL7V24SegmentQRF(this.message);
this.dsc = new HL7V24SegmentDSC(this.message);

        }
    }
}