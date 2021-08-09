using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251TriggerEventADT_A38
    {
        private readonly HL7V2Message message;
        public HL7V251SegmentMSH msh{get; init;}
public HL7V251SegmentSFT sft{get; init;}
public HL7V251SegmentEVN evn{get; init;}
public HL7V251SegmentPID pid{get; init;}
public HL7V251SegmentPD1 pd1{get; init;}
public HL7V251SegmentPV1 pv1{get; init;}
public HL7V251SegmentPV2 pv2{get; init;}
public HL7V251SegmentDB1 db1{get; init;}
public HL7V251SegmentOBX obx{get; init;}
public HL7V251SegmentDG1 dg1{get; init;}
public HL7V251SegmentDRG drg{get; init;}


        public string Id { get { return @"ADT_A38"; } }
        public string MessageStructureId { get { return @"ADT_A38"; } }
        public string EventDescription { get { return @"Cancel Pre-Admit"; } }

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

        public HL7V251TriggerEventADT_A38(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V251SegmentMSH(this.message);
this.sft = new HL7V251SegmentSFT(this.message);
this.evn = new HL7V251SegmentEVN(this.message);
this.pid = new HL7V251SegmentPID(this.message);
this.pd1 = new HL7V251SegmentPD1(this.message);
this.pv1 = new HL7V251SegmentPV1(this.message);
this.pv2 = new HL7V251SegmentPV2(this.message);
this.db1 = new HL7V251SegmentDB1(this.message);
this.obx = new HL7V251SegmentOBX(this.message);
this.dg1 = new HL7V251SegmentDG1(this.message);
this.drg = new HL7V251SegmentDRG(this.message);

        }
    }
}
