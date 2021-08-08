using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V271TriggerEventADT_A61
    {
        private readonly HL7V2Message message;
        private readonly HL7V271SegmentMSH msh;
private readonly HL7V271SegmentSFT sft;
private readonly HL7V271SegmentUAC uac;
private readonly HL7V271SegmentEVN evn;
private readonly HL7V271SegmentPID pid;
private readonly HL7V271SegmentPD1 pd1;
private readonly HL7V271SegmentROL rol;
private readonly HL7V271SegmentPV1 pv1;
private readonly HL7V271SegmentROL rol;
private readonly HL7V271SegmentPV2 pv2;


        public string Id { get { return @"ADT_A61"; } }
        public string MessageStructureId { get { return @"ADT_A61"; } }
        public string EventDescription { get { return @"Change consulting doctor"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_03",

                    };
            }
        }

        public HL7V271TriggerEventADT_A61(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V271SegmentMSH(this.message);
this.sft = new HL7V271SegmentSFT(this.message);
this.uac = new HL7V271SegmentUAC(this.message);
this.evn = new HL7V271SegmentEVN(this.message);
this.pid = new HL7V271SegmentPID(this.message);
this.pd1 = new HL7V271SegmentPD1(this.message);
this.rol = new HL7V271SegmentROL(this.message);
this.pv1 = new HL7V271SegmentPV1(this.message);
this.rol = new HL7V271SegmentROL(this.message);
this.pv2 = new HL7V271SegmentPV2(this.message);

        }
    }
}
