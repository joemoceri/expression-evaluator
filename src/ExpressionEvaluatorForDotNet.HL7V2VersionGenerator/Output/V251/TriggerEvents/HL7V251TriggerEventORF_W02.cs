using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251TriggerEventORF_W02
    {
        private readonly HL7V2Message message;
        private readonly HL7V251SegmentMSH msh;
private readonly HL7V251SegmentSFT sft;
private readonly HL7V251SegmentMSA msa;
private readonly HL7V251SegmentQRD qrd;
private readonly HL7V251SegmentQRF qrf;
private readonly HL7V251SegmentERR err;
private readonly HL7V251SegmentQAK qak;
private readonly HL7V251SegmentDSC dsc;


        public string Id { get { return @"ORF_W02"; } }
        public string MessageStructureId { get { return @"ORF_W02"; } }
        public string EventDescription { get { return @"Waveform result, response to query"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_07",

                    };
            }
        }

        public HL7V251TriggerEventORF_W02(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V251SegmentMSH(this.message);
this.sft = new HL7V251SegmentSFT(this.message);
this.msa = new HL7V251SegmentMSA(this.message);
this.qrd = new HL7V251SegmentQRD(this.message);
this.qrf = new HL7V251SegmentQRF(this.message);
this.err = new HL7V251SegmentERR(this.message);
this.qak = new HL7V251SegmentQAK(this.message);
this.dsc = new HL7V251SegmentDSC(this.message);

        }
    }
}