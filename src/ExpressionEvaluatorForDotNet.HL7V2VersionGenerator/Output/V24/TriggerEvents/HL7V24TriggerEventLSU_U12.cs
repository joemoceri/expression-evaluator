using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24TriggerEventLSU_U12
    {
        private readonly HL7V2Message message;
        private readonly HL7V24SegmentMSH msh;
private readonly HL7V24SegmentEQU equ;
private readonly HL7V24SegmentEQP eqp;
private readonly HL7V24SegmentROL rol;


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

        public HL7V24TriggerEventLSU_U12(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V24SegmentMSH(this.message);
this.equ = new HL7V24SegmentEQU(this.message);
this.eqp = new HL7V24SegmentEQP(this.message);
this.rol = new HL7V24SegmentROL(this.message);

        }
    }
}