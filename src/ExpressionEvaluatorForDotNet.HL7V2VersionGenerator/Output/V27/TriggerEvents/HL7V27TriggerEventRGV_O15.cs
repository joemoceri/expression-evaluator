using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27TriggerEventRGV_O15
    {
        private readonly HL7V2Message message;
        private readonly HL7V27SegmentMSH msh;
private readonly HL7V27SegmentSFT sft;
private readonly HL7V27SegmentUAC uac;
private readonly HL7V27SegmentNTE nte;


        public string Id { get { return @"RGV_O15"; } }
        public string MessageStructureId { get { return @"RGV_O15"; } }
        public string EventDescription { get { return @"Pharmacy/treatment give"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_04",

                    };
            }
        }

        public HL7V27TriggerEventRGV_O15(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V27SegmentMSH(this.message);
this.sft = new HL7V27SegmentSFT(this.message);
this.uac = new HL7V27SegmentUAC(this.message);
this.nte = new HL7V27SegmentNTE(this.message);

        }
    }
}
