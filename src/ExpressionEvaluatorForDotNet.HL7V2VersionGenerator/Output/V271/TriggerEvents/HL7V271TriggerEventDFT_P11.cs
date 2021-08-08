using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V271TriggerEventDFT_P11
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
private readonly HL7V271SegmentPV2 pv2;
private readonly HL7V271SegmentROL rol;
private readonly HL7V271SegmentDB1 db1;
private readonly HL7V271SegmentDG1 dg1;
private readonly HL7V271SegmentDRG drg;
private readonly HL7V271SegmentGT1 gt1;
private readonly HL7V271SegmentACC acc;


        public string Id { get { return @"DFT_P11"; } }
        public string MessageStructureId { get { return @"DFT_P11"; } }
        public string EventDescription { get { return @"Post Detail Financial Transactions - New"; } }

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

        public HL7V271TriggerEventDFT_P11(HL7V2Message message)
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
this.pv2 = new HL7V271SegmentPV2(this.message);
this.rol = new HL7V271SegmentROL(this.message);
this.db1 = new HL7V271SegmentDB1(this.message);
this.dg1 = new HL7V271SegmentDG1(this.message);
this.drg = new HL7V271SegmentDRG(this.message);
this.gt1 = new HL7V271SegmentGT1(this.message);
this.acc = new HL7V271SegmentACC(this.message);

        }
    }
}
