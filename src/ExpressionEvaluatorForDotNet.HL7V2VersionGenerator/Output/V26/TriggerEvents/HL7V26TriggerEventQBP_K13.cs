using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26TriggerEventQBP_K13
    {
        private readonly HL7V2Message message;
        private readonly HL7V26SegmentMSH msh;
private readonly HL7V26SegmentMSA msa;
private readonly HL7V26SegmentERR err;
private readonly HL7V26SegmentQAK qak;
private readonly HL7V26SegmentQPD qpd;
private readonly HL7V26SegmentDSC dsc;


        public string Id { get { return @"QBP_K13"; } }
        public string MessageStructureId { get { return @"QBP_K13"; } }
        public string EventDescription { get { return @"Query by parameter"; } }

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

        public HL7V26TriggerEventQBP_K13(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V26SegmentMSH(this.message);
this.msa = new HL7V26SegmentMSA(this.message);
this.err = new HL7V26SegmentERR(this.message);
this.qak = new HL7V26SegmentQAK(this.message);
this.qpd = new HL7V26SegmentQPD(this.message);
this.dsc = new HL7V26SegmentDSC(this.message);

        }
    }
}