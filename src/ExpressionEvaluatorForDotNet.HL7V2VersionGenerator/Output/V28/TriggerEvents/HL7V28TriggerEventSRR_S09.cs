using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V28TriggerEventSRR_S09
    {
        private readonly HL7V2Message message;
        private readonly HL7V28SegmentMSH msh;
private readonly HL7V28SegmentMSA msa;
private readonly HL7V28SegmentERR err;


        public string Id { get { return @"SRR_S09"; } }
        public string MessageStructureId { get { return @"SRR_S09"; } }
        public string EventDescription { get { return @"Scheduled Request Response - Request Cancellation of Service/Resource on Appointment "; } }

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

        public HL7V28TriggerEventSRR_S09(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V28SegmentMSH(this.message);
this.msa = new HL7V28SegmentMSA(this.message);
this.err = new HL7V28SegmentERR(this.message);

        }
    }
}