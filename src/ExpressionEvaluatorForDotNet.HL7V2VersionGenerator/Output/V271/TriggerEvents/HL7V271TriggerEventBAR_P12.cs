using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V271TriggerEventBAR_P12
    {
        private readonly HL7V2Message message;
        private readonly HL7V271SegmentMSH msh;
private readonly HL7V271SegmentSFT sft;
private readonly HL7V271SegmentUAC uac;
private readonly HL7V271SegmentEVN evn;
private readonly HL7V271SegmentPID pid;
private readonly HL7V271SegmentPV1 pv1;
private readonly HL7V271SegmentDG1 dg1;
private readonly HL7V271SegmentDRG drg;
private readonly HL7V271SegmentOBX obx;


        public string Id { get { return @"BAR_P12"; } }
        public string MessageStructureId { get { return @"BAR_P12"; } }
        public string EventDescription { get { return @"Update Diagnosis/Procedure"; } }

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

        public HL7V271TriggerEventBAR_P12(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V271SegmentMSH(this.message);
this.sft = new HL7V271SegmentSFT(this.message);
this.uac = new HL7V271SegmentUAC(this.message);
this.evn = new HL7V271SegmentEVN(this.message);
this.pid = new HL7V271SegmentPID(this.message);
this.pv1 = new HL7V271SegmentPV1(this.message);
this.dg1 = new HL7V271SegmentDG1(this.message);
this.drg = new HL7V271SegmentDRG(this.message);
this.obx = new HL7V271SegmentOBX(this.message);

        }
    }
}