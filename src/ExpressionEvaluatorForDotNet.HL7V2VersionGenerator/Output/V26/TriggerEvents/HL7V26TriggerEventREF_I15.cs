using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26TriggerEventREF_I15
    {
        private readonly HL7V2Message message;
        public HL7V26SegmentMSH msh{get; init;}
public HL7V26SegmentSFT sft{get; init;}
public HL7V26SegmentUAC uac{get; init;}
public HL7V26SegmentRF1 rf1{get; init;}
public HL7V26SegmentPID pid{get; init;}
public HL7V26SegmentNK1 nk1{get; init;}
public HL7V26SegmentGT1 gt1{get; init;}
public HL7V26SegmentACC acc{get; init;}
public HL7V26SegmentDG1 dg1{get; init;}
public HL7V26SegmentDRG drg{get; init;}
public HL7V26SegmentAL1 al1{get; init;}
public HL7V26SegmentNTE nte{get; init;}


        public string Id { get { return @"REF_I15"; } }
        public string MessageStructureId { get { return @"REF_I15"; } }
        public string EventDescription { get { return @"Request Patient Referral Status"; } }

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

        public HL7V26TriggerEventREF_I15(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V26SegmentMSH(this.message);
this.sft = new HL7V26SegmentSFT(this.message);
this.uac = new HL7V26SegmentUAC(this.message);
this.rf1 = new HL7V26SegmentRF1(this.message);
this.pid = new HL7V26SegmentPID(this.message);
this.nk1 = new HL7V26SegmentNK1(this.message);
this.gt1 = new HL7V26SegmentGT1(this.message);
this.acc = new HL7V26SegmentACC(this.message);
this.dg1 = new HL7V26SegmentDG1(this.message);
this.drg = new HL7V26SegmentDRG(this.message);
this.al1 = new HL7V26SegmentAL1(this.message);
this.nte = new HL7V26SegmentNTE(this.message);

        }
    }
}
