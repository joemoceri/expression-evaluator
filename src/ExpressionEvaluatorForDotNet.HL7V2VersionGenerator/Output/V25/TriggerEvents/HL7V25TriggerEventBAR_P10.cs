using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25TriggerEventBAR_P10
    {
        private readonly HL7V2Message message;
        private readonly HL7V25SegmentMSH msh;
private readonly HL7V25SegmentSFT sft;
private readonly HL7V25SegmentEVN evn;
private readonly HL7V25SegmentPID pid;
private readonly HL7V25SegmentPV1 pv1;
private readonly HL7V25SegmentDG1 dg1;
private readonly HL7V25SegmentGP1 gp1;


        public string Id { get { return @"BAR_P10"; } }
        public string MessageStructureId { get { return @"BAR_P10"; } }
        public string EventDescription { get { return @"Transmit Ambulatory Payment Classification (APC) Groups"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_06",

                    };
            }
        }

        public HL7V25TriggerEventBAR_P10(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V25SegmentMSH(this.message);
this.sft = new HL7V25SegmentSFT(this.message);
this.evn = new HL7V25SegmentEVN(this.message);
this.pid = new HL7V25SegmentPID(this.message);
this.pv1 = new HL7V25SegmentPV1(this.message);
this.dg1 = new HL7V25SegmentDG1(this.message);
this.gp1 = new HL7V25SegmentGP1(this.message);

        }
    }
}
