using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V28TriggerEventPMU_B05
    {
        private readonly HL7V2Message message;
        private readonly HL7V28SegmentMSH msh;
private readonly HL7V28SegmentSFT sft;
private readonly HL7V28SegmentUAC uac;
private readonly HL7V28SegmentEVN evn;
private readonly HL7V28SegmentSTF stf;
private readonly HL7V28SegmentPRA pra;
private readonly HL7V28SegmentORG org;


        public string Id { get { return @"PMU_B05"; } }
        public string MessageStructureId { get { return @"PMU_B05"; } }
        public string EventDescription { get { return @"Deactivate practicing person"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_15",

                    };
            }
        }

        public HL7V28TriggerEventPMU_B05(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V28SegmentMSH(this.message);
this.sft = new HL7V28SegmentSFT(this.message);
this.uac = new HL7V28SegmentUAC(this.message);
this.evn = new HL7V28SegmentEVN(this.message);
this.stf = new HL7V28SegmentSTF(this.message);
this.pra = new HL7V28SegmentPRA(this.message);
this.org = new HL7V28SegmentORG(this.message);

        }
    }
}
