using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27TriggerEventPMU_B07
    {
        private readonly HL7V2Message message;
        private readonly HL7V27SegmentMSH msh;
private readonly HL7V27SegmentSFT sft;
private readonly HL7V27SegmentUAC uac;
private readonly HL7V27SegmentEVN evn;
private readonly HL7V27SegmentSTF stf;
private readonly HL7V27SegmentPRA pra;


        public string Id { get { return @"PMU_B07"; } }
        public string MessageStructureId { get { return @"PMU_B07"; } }
        public string EventDescription { get { return @"Grant Certificate/Permission"; } }

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

        public HL7V27TriggerEventPMU_B07(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V27SegmentMSH(this.message);
this.sft = new HL7V27SegmentSFT(this.message);
this.uac = new HL7V27SegmentUAC(this.message);
this.evn = new HL7V27SegmentEVN(this.message);
this.stf = new HL7V27SegmentSTF(this.message);
this.pra = new HL7V27SegmentPRA(this.message);

        }
    }
}