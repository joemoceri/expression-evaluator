using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V28TriggerEventRQI_I03
    {
        private readonly HL7V2Message message;
        private readonly HL7V28SegmentMSH msh;
private readonly HL7V28SegmentSFT sft;
private readonly HL7V28SegmentUAC uac;
private readonly HL7V28SegmentPID pid;
private readonly HL7V28SegmentNK1 nk1;
private readonly HL7V28SegmentNTE nte;


        public string Id { get { return @"RQI_I03"; } }
        public string MessageStructureId { get { return @"RQI_I03"; } }
        public string EventDescription { get { return @"Request/receipt of patient selection list"; } }

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

        public HL7V28TriggerEventRQI_I03(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V28SegmentMSH(this.message);
this.sft = new HL7V28SegmentSFT(this.message);
this.uac = new HL7V28SegmentUAC(this.message);
this.pid = new HL7V28SegmentPID(this.message);
this.nk1 = new HL7V28SegmentNK1(this.message);
this.nte = new HL7V28SegmentNTE(this.message);

        }
    }
}
