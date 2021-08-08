using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26TriggerEventSRM_S06
    {
        private readonly HL7V2Message message;
        private readonly HL7V26SegmentMSH msh;
private readonly HL7V26SegmentARQ arq;
private readonly HL7V26SegmentAPR apr;
private readonly HL7V26SegmentNTE nte;


        public string Id { get { return @"SRM_S06"; } }
        public string MessageStructureId { get { return @"SRM_S06"; } }
        public string EventDescription { get { return @"Request Appointment Deletion"; } }

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

        public HL7V26TriggerEventSRM_S06(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V26SegmentMSH(this.message);
this.arq = new HL7V26SegmentARQ(this.message);
this.apr = new HL7V26SegmentAPR(this.message);
this.nte = new HL7V26SegmentNTE(this.message);

        }
    }
}