using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251TriggerEventADT_A01
    {
        private readonly HL7V2Message message;
        private readonly HL7V251SegmentMSH msh;
private readonly HL7V251SegmentSFT sft;
private readonly HL7V251SegmentEVN evn;
private readonly HL7V251SegmentPID pid;
private readonly HL7V251SegmentPD1 pd1;
private readonly HL7V251SegmentROL rol;
private readonly HL7V251SegmentNK1 nk1;
private readonly HL7V251SegmentPV1 pv1;
private readonly HL7V251SegmentPV2 pv2;
private readonly HL7V251SegmentROL rol;
private readonly HL7V251SegmentDB1 db1;
private readonly HL7V251SegmentOBX obx;
private readonly HL7V251SegmentAL1 al1;
private readonly HL7V251SegmentDG1 dg1;
private readonly HL7V251SegmentDRG drg;
private readonly HL7V251SegmentGT1 gt1;
private readonly HL7V251SegmentACC acc;
private readonly HL7V251SegmentUB1 ub1;
private readonly HL7V251SegmentUB2 ub2;
private readonly HL7V251SegmentPDA pda;


        public string Id { get { return @"ADT_A01"; } }
        public string MessageStructureId { get { return @"ADT_A01"; } }
        public string EventDescription { get { return @"Admit/Visit Notification"; } }

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

        public HL7V251TriggerEventADT_A01(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V251SegmentMSH(this.message);
this.sft = new HL7V251SegmentSFT(this.message);
this.evn = new HL7V251SegmentEVN(this.message);
this.pid = new HL7V251SegmentPID(this.message);
this.pd1 = new HL7V251SegmentPD1(this.message);
this.rol = new HL7V251SegmentROL(this.message);
this.nk1 = new HL7V251SegmentNK1(this.message);
this.pv1 = new HL7V251SegmentPV1(this.message);
this.pv2 = new HL7V251SegmentPV2(this.message);
this.rol = new HL7V251SegmentROL(this.message);
this.db1 = new HL7V251SegmentDB1(this.message);
this.obx = new HL7V251SegmentOBX(this.message);
this.al1 = new HL7V251SegmentAL1(this.message);
this.dg1 = new HL7V251SegmentDG1(this.message);
this.drg = new HL7V251SegmentDRG(this.message);
this.gt1 = new HL7V251SegmentGT1(this.message);
this.acc = new HL7V251SegmentACC(this.message);
this.ub1 = new HL7V251SegmentUB1(this.message);
this.ub2 = new HL7V251SegmentUB2(this.message);
this.pda = new HL7V251SegmentPDA(this.message);

        }
    }
}
