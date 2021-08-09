using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25TriggerEventMFN_M13
    {
        private readonly HL7V2Message message;
        public HL7V25SegmentMSH msh{get; init;}
public HL7V25SegmentSFT sft{get; init;}
public HL7V25SegmentMFI mfi{get; init;}
public HL7V25SegmentMFE mfe{get; init;}


        public string Id { get { return @"MFN_M13"; } }
        public string MessageStructureId { get { return @"MFN_M13"; } }
        public string EventDescription { get { return @"Master File Notification - General"; } }

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

        public HL7V25TriggerEventMFN_M13(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V25SegmentMSH(this.message);
this.sft = new HL7V25SegmentSFT(this.message);
this.mfi = new HL7V25SegmentMFI(this.message);
this.mfe = new HL7V25SegmentMFE(this.message);

        }
    }
}
