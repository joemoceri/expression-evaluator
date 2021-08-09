using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251TriggerEventMFK_M01
    {
        private readonly HL7V2Message message;
        public HL7V251SegmentMSH msh{get; init;}
public HL7V251SegmentSFT sft{get; init;}
public HL7V251SegmentMSA msa{get; init;}
public HL7V251SegmentERR err{get; init;}
public HL7V251SegmentMFI mfi{get; init;}
public HL7V251SegmentMFA mfa{get; init;}


        public string Id { get { return @"MFK_M01"; } }
        public string MessageStructureId { get { return @"MFK_M01"; } }
        public string EventDescription { get { return @"Master file application acknowledgment"; } }

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

        public HL7V251TriggerEventMFK_M01(HL7V2Message message)
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
