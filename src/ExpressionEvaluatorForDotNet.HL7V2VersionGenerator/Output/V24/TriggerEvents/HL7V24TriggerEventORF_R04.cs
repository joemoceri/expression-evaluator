using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24TriggerEventORF_R04
    {
        private readonly HL7V2Message message;
        private readonly HL7V24SegmentMSH msh;
private readonly HL7V24SegmentMSA msa;
private readonly HL7V24SegmentQRD qrd;
private readonly HL7V24SegmentQRF qrf;
private readonly HL7V24SegmentERR err;
private readonly HL7V24SegmentQAK qak;
private readonly HL7V24SegmentDSC dsc;


        public string Id { get { return @"ORF_R04"; } }
        public string MessageStructureId { get { return @"ORF_R04"; } }
        public string EventDescription { get { return @"Response to query; transmission of requested observation"; } }

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

        public HL7V24TriggerEventORF_R04(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V24SegmentMSH(this.message);
this.msa = new HL7V24SegmentMSA(this.message);
this.qrd = new HL7V24SegmentQRD(this.message);
this.qrf = new HL7V24SegmentQRF(this.message);
this.err = new HL7V24SegmentERR(this.message);
this.qak = new HL7V24SegmentQAK(this.message);
this.dsc = new HL7V24SegmentDSC(this.message);

        }
    }
}