using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231TriggerEventSRR_S01
    {
        private readonly HL7V2Message message;
        private readonly HL7V231SegmentMSH msh;
private readonly HL7V231SegmentMSA msa;
private readonly HL7V231SegmentERR err;


        public string Id { get { return @"SRR_S01"; } }
        public string MessageStructureId { get { return @"SRR_S01"; } }
        public string EventDescription { get { return @"Result new appointment booking"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_10",

                    };
            }
        }

        public HL7V231TriggerEventSRR_S01(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V231SegmentMSH(this.message);
this.msa = new HL7V231SegmentMSA(this.message);
this.err = new HL7V231SegmentERR(this.message);

        }
    }
}