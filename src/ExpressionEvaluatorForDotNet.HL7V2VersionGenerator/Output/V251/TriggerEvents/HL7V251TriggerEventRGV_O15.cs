using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251TriggerEventRGV_O15
    {
        private readonly HL7V2Message message;
        private readonly HL7V251SegmentMSH msh;
private readonly HL7V251SegmentSFT sft;
private readonly HL7V251SegmentNTE nte;


        public string Id { get { return @"RGV_O15"; } }
        public string MessageStructureId { get { return @"RGV_O15"; } }
        public string EventDescription { get { return @"Pharmacy/Treatment Give"; } }

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

        public HL7V251TriggerEventRGV_O15(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V251SegmentMSH(this.message);
this.sft = new HL7V251SegmentSFT(this.message);
this.nte = new HL7V251SegmentNTE(this.message);

        }
    }
}