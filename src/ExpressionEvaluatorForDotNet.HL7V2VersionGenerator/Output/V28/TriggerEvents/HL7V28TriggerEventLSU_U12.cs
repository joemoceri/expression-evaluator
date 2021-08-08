using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V28TriggerEventLSU_U12
    {
        private readonly HL7V2Message message;
        private readonly HL7V28SegmentMSH msh;
private readonly HL7V28SegmentSFT sft;
private readonly HL7V28SegmentUAC uac;
private readonly HL7V28SegmentEQU equ;
private readonly HL7V28SegmentEQP eqp;


        public string Id { get { return @"LSU_U12"; } }
        public string MessageStructureId { get { return @"LSU_U12"; } }
        public string EventDescription { get { return @"Automated equipment log/service update"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_13",

                    };
            }
        }

        public HL7V28TriggerEventLSU_U12(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V28SegmentMSH(this.message);
this.sft = new HL7V28SegmentSFT(this.message);
this.uac = new HL7V28SegmentUAC(this.message);
this.equ = new HL7V28SegmentEQU(this.message);
this.eqp = new HL7V28SegmentEQP(this.message);

        }
    }
}
