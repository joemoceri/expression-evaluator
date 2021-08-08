using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V28TriggerEventORD_O04
    {
        private readonly HL7V2Message message;
        private readonly HL7V28SegmentMSH msh;
private readonly HL7V28SegmentMSA msa;
private readonly HL7V28SegmentERR err;
private readonly HL7V28SegmentSFT sft;
private readonly HL7V28SegmentUAC uac;
private readonly HL7V28SegmentNTE nte;


        public string Id { get { return @"ORD_O04"; } }
        public string MessageStructureId { get { return @"ORD_O04"; } }
        public string EventDescription { get { return @"Diet order acknowledgment"; } }

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

        public HL7V28TriggerEventORD_O04(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V28SegmentMSH(this.message);
this.msa = new HL7V28SegmentMSA(this.message);
this.err = new HL7V28SegmentERR(this.message);
this.sft = new HL7V28SegmentSFT(this.message);
this.uac = new HL7V28SegmentUAC(this.message);
this.nte = new HL7V28SegmentNTE(this.message);

        }
    }
}
