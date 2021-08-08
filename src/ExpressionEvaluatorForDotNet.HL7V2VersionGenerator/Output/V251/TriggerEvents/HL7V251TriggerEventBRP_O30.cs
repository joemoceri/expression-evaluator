using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251TriggerEventBRP_O30
    {
        private readonly HL7V2Message message;
        private readonly HL7V251SegmentMSH msh;
private readonly HL7V251SegmentMSA msa;
private readonly HL7V251SegmentERR err;
private readonly HL7V251SegmentSFT sft;
private readonly HL7V251SegmentNTE nte;


        public string Id { get { return @"BRP_O30"; } }
        public string MessageStructureId { get { return @"BRP_O30"; } }
        public string EventDescription { get { return @"Blood Product Dispense Status Acknowledgment"; } }

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

        public HL7V251TriggerEventBRP_O30(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V251SegmentMSH(this.message);
this.msa = new HL7V251SegmentMSA(this.message);
this.err = new HL7V251SegmentERR(this.message);
this.sft = new HL7V251SegmentSFT(this.message);
this.nte = new HL7V251SegmentNTE(this.message);

        }
    }
}