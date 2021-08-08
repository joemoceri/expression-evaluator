using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V271TriggerEventORN_O08
    {
        private readonly HL7V2Message message;
        private readonly HL7V271SegmentMSH msh;
private readonly HL7V271SegmentMSA msa;
private readonly HL7V271SegmentERR err;
private readonly HL7V271SegmentSFT sft;
private readonly HL7V271SegmentUAC uac;
private readonly HL7V271SegmentNTE nte;


        public string Id { get { return @"ORN_O08"; } }
        public string MessageStructureId { get { return @"ORN_O08"; } }
        public string EventDescription { get { return @"Non-stock requisition acknowledgment"; } }

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

        public HL7V271TriggerEventORN_O08(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V271SegmentMSH(this.message);
this.msa = new HL7V271SegmentMSA(this.message);
this.err = new HL7V271SegmentERR(this.message);
this.sft = new HL7V271SegmentSFT(this.message);
this.uac = new HL7V271SegmentUAC(this.message);
this.nte = new HL7V271SegmentNTE(this.message);

        }
    }
}
