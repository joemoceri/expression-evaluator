using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27TriggerEventADT_A24
    {
        private readonly HL7V2Message message;
        private readonly HL7V27SegmentMSH msh;
private readonly HL7V27SegmentSFT sft;
private readonly HL7V27SegmentUAC uac;
private readonly HL7V27SegmentEVN evn;
private readonly HL7V27SegmentPID pid;
private readonly HL7V27SegmentPD1 pd1;
private readonly HL7V27SegmentPV1 pv1;
private readonly HL7V27SegmentDB1 db1;
private readonly HL7V27SegmentPID pid;
private readonly HL7V27SegmentPD1 pd1;
private readonly HL7V27SegmentPV1 pv1;
private readonly HL7V27SegmentDB1 db1;


        public string Id { get { return @"ADT_A24"; } }
        public string MessageStructureId { get { return @"ADT_A24"; } }
        public string EventDescription { get { return @"Link patient information"; } }

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

        public HL7V27TriggerEventADT_A24(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V27SegmentMSH(this.message);
this.sft = new HL7V27SegmentSFT(this.message);
this.uac = new HL7V27SegmentUAC(this.message);
this.evn = new HL7V27SegmentEVN(this.message);
this.pid = new HL7V27SegmentPID(this.message);
this.pd1 = new HL7V27SegmentPD1(this.message);
this.pv1 = new HL7V27SegmentPV1(this.message);
this.db1 = new HL7V27SegmentDB1(this.message);
this.pid = new HL7V27SegmentPID(this.message);
this.pd1 = new HL7V27SegmentPD1(this.message);
this.pv1 = new HL7V27SegmentPV1(this.message);
this.db1 = new HL7V27SegmentDB1(this.message);

        }
    }
}