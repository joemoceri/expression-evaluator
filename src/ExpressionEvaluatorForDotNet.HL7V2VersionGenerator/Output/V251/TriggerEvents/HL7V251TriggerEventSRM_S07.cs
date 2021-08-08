using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251TriggerEventSRM_S07
    {
        private readonly HL7V2Message message;
        private readonly HL7V251SegmentMSH msh;
private readonly HL7V251SegmentARQ arq;
private readonly HL7V251SegmentAPR apr;
private readonly HL7V251SegmentNTE nte;


        public string Id { get { return @"SRM_S07"; } }
        public string MessageStructureId { get { return @"SRM_S07"; } }
        public string EventDescription { get { return @"Schedule request - Addition of service/resource on appointment"; } }

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

        public HL7V251TriggerEventSRM_S07(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V251SegmentMSH(this.message);
this.arq = new HL7V251SegmentARQ(this.message);
this.apr = new HL7V251SegmentAPR(this.message);
this.nte = new HL7V251SegmentNTE(this.message);

        }
    }
}
