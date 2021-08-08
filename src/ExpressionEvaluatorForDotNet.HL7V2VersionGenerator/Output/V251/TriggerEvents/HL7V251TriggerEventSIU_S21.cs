using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251TriggerEventSIU_S21
    {
        private readonly HL7V2Message message;
        private readonly HL7V251SegmentMSH msh;
private readonly HL7V251SegmentSCH sch;
private readonly HL7V251SegmentTQ1 tq1;
private readonly HL7V251SegmentNTE nte;


        public string Id { get { return @"SIU_S21"; } }
        public string MessageStructureId { get { return @"SIU_S21"; } }
        public string EventDescription { get { return @"Notification of Discontinuation of Service/Resource on Appointment"; } }

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

        public HL7V251TriggerEventSIU_S21(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V251SegmentMSH(this.message);
this.sch = new HL7V251SegmentSCH(this.message);
this.tq1 = new HL7V251SegmentTQ1(this.message);
this.nte = new HL7V251SegmentNTE(this.message);

        }
    }
}