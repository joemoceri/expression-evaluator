using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231TriggerEventRAR_RAR
    {
        private readonly HL7V2Message message;
        private readonly HL7V231SegmentMSH msh;
private readonly HL7V231SegmentMSA msa;
private readonly HL7V231SegmentERR err;
private readonly HL7V231SegmentDSC dsc;


        public string Id { get { return @"RAR_RAR"; } }
        public string MessageStructureId { get { return @"RAR_RAR"; } }
        public string EventDescription { get { return @"Pharmacy/treatment administration information response"; } }

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

        public HL7V231TriggerEventRAR_RAR(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V231SegmentMSH(this.message);
this.msa = new HL7V231SegmentMSA(this.message);
this.err = new HL7V231SegmentERR(this.message);
this.dsc = new HL7V231SegmentDSC(this.message);

        }
    }
}
