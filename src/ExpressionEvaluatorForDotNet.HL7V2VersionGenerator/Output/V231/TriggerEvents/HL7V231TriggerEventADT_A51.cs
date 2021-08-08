using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231TriggerEventADT_A51
    {
        private readonly HL7V2Message message;
        private readonly HL7V231SegmentMSH msh;
private readonly HL7V231SegmentEVN evn;
private readonly HL7V231SegmentPID pid;
private readonly HL7V231SegmentPD1 pd1;
private readonly HL7V231SegmentMRG mrg;
private readonly HL7V231SegmentPV1 pv1;


        public string Id { get { return @"ADT_A51"; } }
        public string MessageStructureId { get { return @"ADT_A51"; } }
        public string EventDescription { get { return @"Change alternate visit id"; } }

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

        public HL7V231TriggerEventADT_A51(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V231SegmentMSH(this.message);
this.evn = new HL7V231SegmentEVN(this.message);
this.pid = new HL7V231SegmentPID(this.message);
this.pd1 = new HL7V231SegmentPD1(this.message);
this.mrg = new HL7V231SegmentMRG(this.message);
this.pv1 = new HL7V231SegmentPV1(this.message);

        }
    }
}