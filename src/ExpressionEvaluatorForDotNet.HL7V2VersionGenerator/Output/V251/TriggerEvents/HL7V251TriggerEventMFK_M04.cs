using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251TriggerEventMFK_M04
    {
        private readonly HL7V2Message message;
        private readonly HL7V251SegmentMSH msh;
private readonly HL7V251SegmentSFT sft;
private readonly HL7V251SegmentMSA msa;
private readonly HL7V251SegmentERR err;
private readonly HL7V251SegmentMFI mfi;
private readonly HL7V251SegmentMFA mfa;


        public string Id { get { return @"MFK_M04"; } }
        public string MessageStructureId { get { return @"MFK_M04"; } }
        public string EventDescription { get { return @"Master file acknowledgment - Charge description master file"; } }

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

        public HL7V251TriggerEventMFK_M04(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V251SegmentMSH(this.message);
this.sft = new HL7V251SegmentSFT(this.message);
this.msa = new HL7V251SegmentMSA(this.message);
this.err = new HL7V251SegmentERR(this.message);
this.mfi = new HL7V251SegmentMFI(this.message);
this.mfa = new HL7V251SegmentMFA(this.message);

        }
    }
}
