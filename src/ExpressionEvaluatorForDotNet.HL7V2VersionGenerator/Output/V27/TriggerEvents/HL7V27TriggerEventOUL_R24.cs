using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27TriggerEventOUL_R24
    {
        private readonly HL7V2Message message;
        private readonly HL7V27SegmentMSH msh;
private readonly HL7V27SegmentSFT sft;
private readonly HL7V27SegmentUAC uac;
private readonly HL7V27SegmentNTE nte;
private readonly HL7V27SegmentNK1 nk1;


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

        public HL7V27TriggerEventOUL_R24(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V27SegmentMSH(this.message);
this.sft = new HL7V27SegmentSFT(this.message);
this.uac = new HL7V27SegmentUAC(this.message);
this.nte = new HL7V27SegmentNTE(this.message);
this.nk1 = new HL7V27SegmentNK1(this.message);

        }
    }
}