using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V271TriggerEventPMU_B06
    {
        private readonly HL7V2Message message;
        private readonly HL7V271SegmentMSH msh;
private readonly HL7V271SegmentSFT sft;
private readonly HL7V271SegmentUAC uac;
private readonly HL7V271SegmentEVN evn;
private readonly HL7V271SegmentSTF stf;
private readonly HL7V271SegmentPRA pra;
private readonly HL7V271SegmentORG org;


        public string Id { get { return @"PMU_B06"; } }
        public string MessageStructureId { get { return @"PMU_B06"; } }
        public string EventDescription { get { return @"Terminate practicing person"; } }

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

        public HL7V271TriggerEventPMU_B06(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V271SegmentMSH(this.message);
this.sft = new HL7V271SegmentSFT(this.message);
this.uac = new HL7V271SegmentUAC(this.message);
this.evn = new HL7V271SegmentEVN(this.message);
this.stf = new HL7V271SegmentSTF(this.message);
this.pra = new HL7V271SegmentPRA(this.message);
this.org = new HL7V271SegmentORG(this.message);

        }
    }
}
