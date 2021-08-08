using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22TriggerEventDSR_Q03
    {
        private readonly HL7V2Message message;
        private readonly HL7V22SegmentMSH msh;
private readonly HL7V22SegmentMSA msa;
private readonly HL7V22SegmentQRD qrd;
private readonly HL7V22SegmentQRF qrf;
private readonly HL7V22SegmentDSP dsp;
private readonly HL7V22SegmentDSC dsc;


        public string Id { get { return @"DSR_Q03"; } }
        public string MessageStructureId { get { return @"DSR_Q03"; } }
        public string EventDescription { get { return @"Deferred Response to A Query"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_02",

                    };
            }
        }

        public HL7V22TriggerEventDSR_Q03(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V22SegmentMSH(this.message);
this.msa = new HL7V22SegmentMSA(this.message);
this.qrd = new HL7V22SegmentQRD(this.message);
this.qrf = new HL7V22SegmentQRF(this.message);
this.dsp = new HL7V22SegmentDSP(this.message);
this.dsc = new HL7V22SegmentDSC(this.message);

        }
    }
}
