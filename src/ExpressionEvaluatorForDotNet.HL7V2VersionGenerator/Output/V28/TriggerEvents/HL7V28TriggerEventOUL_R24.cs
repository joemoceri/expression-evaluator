using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V28TriggerEventOUL_R24
    {
        private readonly HL7V2Message message;
        public HL7V28SegmentMSH msh{get; init;}
public HL7V28SegmentSFT sft{get; init;}
public HL7V28SegmentUAC uac{get; init;}
public HL7V28SegmentNTE nte{get; init;}
public HL7V28SegmentNK1 nk1{get; init;}


        public string Id { get { return @"OUL_R24"; } }
        public string MessageStructureId { get { return @"OUL_R24"; } }
        public string EventDescription { get { return @"Unsolicited Order Oriented Observation Message"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_07",

                    };
            }
        }

        public HL7V28TriggerEventOUL_R24(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V28SegmentMSH(this.message);
this.sft = new HL7V28SegmentSFT(this.message);
this.uac = new HL7V28SegmentUAC(this.message);
this.nte = new HL7V28SegmentNTE(this.message);
this.nk1 = new HL7V28SegmentNK1(this.message);

        }
    }
}
