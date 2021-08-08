using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24TriggerEventSIU_S23
    {
        private readonly HL7V2Message message;
        private readonly HL7V24SegmentMSH msh;
private readonly HL7V24SegmentSCH sch;
private readonly HL7V24SegmentNTE nte;


        public string Id { get { return @"SIU_S23"; } }
        public string MessageStructureId { get { return @"SIU_S23"; } }
        public string EventDescription { get { return @"Notification of Blocked Schedule Time Slot(S)"; } }

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

        public HL7V24TriggerEventSIU_S23(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V24SegmentMSH(this.message);
this.sch = new HL7V24SegmentSCH(this.message);
this.nte = new HL7V24SegmentNTE(this.message);

        }
    }
}
