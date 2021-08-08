using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23TriggerEventRRI_I14
    {
        private readonly HL7V2Message message;
        private readonly HL7V23SegmentMSH msh;
private readonly HL7V23SegmentMSA msa;
private readonly HL7V23SegmentRF1 rf1;
private readonly HL7V23SegmentPID pid;
private readonly HL7V23SegmentACC acc;
private readonly HL7V23SegmentDG1 dg1;
private readonly HL7V23SegmentDRG drg;
private readonly HL7V23SegmentAL1 al1;
private readonly HL7V23SegmentNTE nte;


        public string Id { get { return @"RRI_I14"; } }
        public string MessageStructureId { get { return @"RRI_I14"; } }
        public string EventDescription { get { return @"Response cancel patient referral "; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_11",

                    };
            }
        }

        public HL7V23TriggerEventRRI_I14(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V23SegmentMSH(this.message);
this.msa = new HL7V23SegmentMSA(this.message);
this.rf1 = new HL7V23SegmentRF1(this.message);
this.pid = new HL7V23SegmentPID(this.message);
this.acc = new HL7V23SegmentACC(this.message);
this.dg1 = new HL7V23SegmentDG1(this.message);
this.drg = new HL7V23SegmentDRG(this.message);
this.al1 = new HL7V23SegmentAL1(this.message);
this.nte = new HL7V23SegmentNTE(this.message);

        }
    }
}