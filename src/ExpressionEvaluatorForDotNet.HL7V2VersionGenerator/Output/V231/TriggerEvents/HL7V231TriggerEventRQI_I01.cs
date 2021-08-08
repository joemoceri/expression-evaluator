using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231TriggerEventRQI_I01
    {
        private readonly HL7V2Message message;
        private readonly HL7V231SegmentMSH msh;
private readonly HL7V231SegmentPID pid;
private readonly HL7V231SegmentNK1 nk1;
private readonly HL7V231SegmentNTE nte;


        public string Id { get { return @"RQI_I01"; } }
        public string MessageStructureId { get { return @"RQI_I01"; } }
        public string EventDescription { get { return @"Request for insurance information"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_11",

                    };
            }
        }

        public HL7V231TriggerEventRQI_I01(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V231SegmentMSH(this.message);
this.pid = new HL7V231SegmentPID(this.message);
this.nk1 = new HL7V231SegmentNK1(this.message);
this.nte = new HL7V231SegmentNTE(this.message);

        }
    }
}
