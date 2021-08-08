using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22TriggerEventADT_A37
    {
        private readonly HL7V2Message message;
        private readonly HL7V22SegmentMSH msh;
private readonly HL7V22SegmentEVN evn;
private readonly HL7V22SegmentPID pid;
private readonly HL7V22SegmentPV1 pv1;
private readonly HL7V22SegmentPID pid;
private readonly HL7V22SegmentPV1 pv1;


        public string Id { get { return @"ADT_A37"; } }
        public string MessageStructureId { get { return @"ADT_A37"; } }
        public string EventDescription { get { return @"unlink patient information"; } }

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

        public HL7V22TriggerEventADT_A37(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V22SegmentMSH(this.message);
this.evn = new HL7V22SegmentEVN(this.message);
this.pid = new HL7V22SegmentPID(this.message);
this.pv1 = new HL7V22SegmentPV1(this.message);
this.pid = new HL7V22SegmentPID(this.message);
this.pv1 = new HL7V22SegmentPV1(this.message);

        }
    }
}