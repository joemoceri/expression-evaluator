using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231TriggerEventSIU_S18
    {
        private readonly HL7V2Message message;
        private readonly HL7V231SegmentMSH msh;
private readonly HL7V231SegmentSCH sch;
private readonly HL7V231SegmentNTE nte;


        public string Id { get { return @"SIU_S18"; } }
        public string MessageStructureId { get { return @"SIU_S18"; } }
        public string EventDescription { get { return @"Notification of addition of service/resource on appointment"; } }

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

        public HL7V231TriggerEventSIU_S18(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V231SegmentMSH(this.message);
this.sch = new HL7V231SegmentSCH(this.message);
this.nte = new HL7V231SegmentNTE(this.message);

        }
    }
}
