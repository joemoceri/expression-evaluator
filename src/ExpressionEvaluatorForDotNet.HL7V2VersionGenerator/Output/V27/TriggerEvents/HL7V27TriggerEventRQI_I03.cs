using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27TriggerEventRQI_I03
    {
        private readonly HL7V2Message message;
        public HL7V27SegmentMSH msh{get; init;}
public HL7V27SegmentSFT sft{get; init;}
public HL7V27SegmentUAC uac{get; init;}
public HL7V27SegmentPID pid{get; init;}
public HL7V27SegmentNK1 nk1{get; init;}
public HL7V27SegmentNTE nte{get; init;}


        public string Id { get { return @"RQI_I03"; } }
        public string MessageStructureId { get { return @"RQI_I03"; } }
        public string EventDescription { get { return @"Request/receipt of patient selection list"; } }

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

        public HL7V27TriggerEventRQI_I03(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V27SegmentMSH(this.message);
this.sft = new HL7V27SegmentSFT(this.message);
this.uac = new HL7V27SegmentUAC(this.message);
this.pid = new HL7V27SegmentPID(this.message);
this.nk1 = new HL7V27SegmentNK1(this.message);
this.nte = new HL7V27SegmentNTE(this.message);

        }
    }
}
