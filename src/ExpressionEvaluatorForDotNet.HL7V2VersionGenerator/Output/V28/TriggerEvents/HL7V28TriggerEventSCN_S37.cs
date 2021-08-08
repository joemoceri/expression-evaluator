using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V28TriggerEventSCN_S37
    {
        private readonly HL7V2Message message;
        private readonly HL7V28SegmentMSH msh;
private readonly HL7V28SegmentSFT sft;
private readonly HL7V28SegmentUAC uac;


        public string Id { get { return @"SCN_S37"; } }
        public string MessageStructureId { get { return @"SCN_S37"; } }
        public string EventDescription { get { return @"Notification of anti-microbial device cycle data"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_17",

                    };
            }
        }

        public HL7V28TriggerEventSCN_S37(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V28SegmentMSH(this.message);
this.sft = new HL7V28SegmentSFT(this.message);
this.uac = new HL7V28SegmentUAC(this.message);

        }
    }
}