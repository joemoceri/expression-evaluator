using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24TriggerEventMFK_M05
    {
        private readonly HL7V2Message message;
        private readonly HL7V24SegmentMSH msh;
private readonly HL7V24SegmentMSA msa;
private readonly HL7V24SegmentMFI mfi;
private readonly HL7V24SegmentMFA mfa;


        public string Id { get { return @"MFK_M05"; } }
        public string MessageStructureId { get { return @"MFK_M05"; } }
        public string EventDescription { get { return @"Master file acknowledgment - Patient location master file"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_08",

                    };
            }
        }

        public HL7V24TriggerEventMFK_M05(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V24SegmentMSH(this.message);
this.msa = new HL7V24SegmentMSA(this.message);
this.mfi = new HL7V24SegmentMFI(this.message);
this.mfa = new HL7V24SegmentMFA(this.message);

        }
    }
}
