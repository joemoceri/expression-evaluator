using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25TriggerEventADT_A36
    {
        private readonly HL7V2Message message;
        public HL7V25SegmentMSH msh{get; init;}
public HL7V25SegmentSFT sft{get; init;}
public HL7V25SegmentEVN evn{get; init;}
public HL7V25SegmentPID pid{get; init;}
public HL7V25SegmentPD1 pd1{get; init;}
public HL7V25SegmentMRG mrg{get; init;}


        public string Id { get { return @"ADT_A36"; } }
        public string MessageStructureId { get { return @"ADT_A36"; } }
        public string EventDescription { get { return @"Merge Patient Information - Patient ID & Account Number "; } }

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

        public HL7V25TriggerEventADT_A36(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V25SegmentMSH(this.message);
this.sft = new HL7V25SegmentSFT(this.message);
this.evn = new HL7V25SegmentEVN(this.message);
this.pid = new HL7V25SegmentPID(this.message);
this.pd1 = new HL7V25SegmentPD1(this.message);
this.mrg = new HL7V25SegmentMRG(this.message);

        }
    }
}
