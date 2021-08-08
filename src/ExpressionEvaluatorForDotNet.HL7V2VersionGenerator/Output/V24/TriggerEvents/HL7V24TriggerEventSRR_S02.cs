using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24TriggerEventSRR_S02
    {
        private readonly HL7V2Message message;
        private readonly HL7V24SegmentMSH msh;
private readonly HL7V24SegmentMSA msa;
private readonly HL7V24SegmentERR err;


        public string Id { get { return @"SRR_S02"; } }
        public string MessageStructureId { get { return @"SRR_S02"; } }
        public string EventDescription { get { return @"Scheduled request response - Appointment rescheduling"; } }

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

        public HL7V24TriggerEventSRR_S02(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V24SegmentMSH(this.message);
this.msa = new HL7V24SegmentMSA(this.message);
this.err = new HL7V24SegmentERR(this.message);

        }
    }
}