using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24TriggerEventMFK_M07
    {
        private readonly HL7V2Message message;
        public HL7V24SegmentMSH msh{get; init;}
public HL7V24SegmentMSA msa{get; init;}
public HL7V24SegmentMFI mfi{get; init;}
public HL7V24SegmentMFA mfa{get; init;}


        public string Id { get { return @"MFK_M07"; } }
        public string MessageStructureId { get { return @"MFK_M07"; } }
        public string EventDescription { get { return @"Master file acknowledgment - Clinical study without phases but with schedules master file"; } }

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

        public HL7V24TriggerEventMFK_M07(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V24SegmentMSH(this.message);
this.msa = new HL7V24SegmentMSA(this.message);
this.mfi = new HL7V24SegmentMFI(this.message);
this.mfa = new HL7V24SegmentMFA(this.message);

        }
    }
}
