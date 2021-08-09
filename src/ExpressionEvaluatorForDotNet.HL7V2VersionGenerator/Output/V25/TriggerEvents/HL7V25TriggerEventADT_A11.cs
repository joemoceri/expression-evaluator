using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25TriggerEventADT_A11
    {
        private readonly HL7V2Message message;
        public HL7V25SegmentMSH msh{get; init;}
public HL7V25SegmentSFT sft{get; init;}
public HL7V25SegmentEVN evn{get; init;}
public HL7V25SegmentPID pid{get; init;}
public HL7V25SegmentPD1 pd1{get; init;}
public HL7V25SegmentPV1 pv1{get; init;}
public HL7V25SegmentPV2 pv2{get; init;}
public HL7V25SegmentDB1 db1{get; init;}
public HL7V25SegmentOBX obx{get; init;}
public HL7V25SegmentDG1 dg1{get; init;}


        public string Id { get { return @"ADT_A11"; } }
        public string MessageStructureId { get { return @"ADT_A11"; } }
        public string EventDescription { get { return @"Cancel Admit/Visit Notification"; } }

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

        public HL7V25TriggerEventADT_A11(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V25SegmentMSH(this.message);
this.sft = new HL7V25SegmentSFT(this.message);
this.evn = new HL7V25SegmentEVN(this.message);
this.pid = new HL7V25SegmentPID(this.message);
this.pd1 = new HL7V25SegmentPD1(this.message);
this.pv1 = new HL7V25SegmentPV1(this.message);
this.pv2 = new HL7V25SegmentPV2(this.message);
this.db1 = new HL7V25SegmentDB1(this.message);
this.obx = new HL7V25SegmentOBX(this.message);
this.dg1 = new HL7V25SegmentDG1(this.message);

        }
    }
}
