using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V28TriggerEventSRM_S04
    {
        private readonly HL7V2Message message;
        private readonly HL7V28SegmentMSH msh;
private readonly HL7V28SegmentARQ arq;
private readonly HL7V28SegmentAPR apr;
private readonly HL7V28SegmentNTE nte;


        public string Id { get { return @"SRM_S04"; } }
        public string MessageStructureId { get { return @"SRM_S04"; } }
        public string EventDescription { get { return @"Request appointment cancellation"; } }

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

        public HL7V28TriggerEventSRM_S04(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V28SegmentMSH(this.message);
this.arq = new HL7V28SegmentARQ(this.message);
this.apr = new HL7V28SegmentAPR(this.message);
this.nte = new HL7V28SegmentNTE(this.message);

        }
    }
}
