using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25TriggerEventADT_A02
    {
        private readonly HL7V2Message message;
        private readonly HL7V25SegmentMSH msh;
private readonly HL7V25SegmentSFT sft;
private readonly HL7V25SegmentEVN evn;
private readonly HL7V25SegmentPID pid;
private readonly HL7V25SegmentPD1 pd1;
private readonly HL7V25SegmentROL rol;
private readonly HL7V25SegmentPV1 pv1;
private readonly HL7V25SegmentPV2 pv2;
private readonly HL7V25SegmentROL rol;
private readonly HL7V25SegmentDB1 db1;
private readonly HL7V25SegmentOBX obx;
private readonly HL7V25SegmentPDA pda;


        public string Id { get { return @"ADT_A02"; } }
        public string MessageStructureId { get { return @"ADT_A02"; } }
        public string EventDescription { get { return @"Transfer a Patient"; } }

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

        public HL7V25TriggerEventADT_A02(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V25SegmentMSH(this.message);
this.sft = new HL7V25SegmentSFT(this.message);
this.evn = new HL7V25SegmentEVN(this.message);
this.pid = new HL7V25SegmentPID(this.message);
this.pd1 = new HL7V25SegmentPD1(this.message);
this.rol = new HL7V25SegmentROL(this.message);
this.pv1 = new HL7V25SegmentPV1(this.message);
this.pv2 = new HL7V25SegmentPV2(this.message);
this.rol = new HL7V25SegmentROL(this.message);
this.db1 = new HL7V25SegmentDB1(this.message);
this.obx = new HL7V25SegmentOBX(this.message);
this.pda = new HL7V25SegmentPDA(this.message);

        }
    }
}
