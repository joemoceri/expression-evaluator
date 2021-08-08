using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27TriggerEventESU_U01
    {
        private readonly HL7V2Message message;
        private readonly HL7V27SegmentMSH msh;
private readonly HL7V27SegmentSFT sft;
private readonly HL7V27SegmentUAC uac;
private readonly HL7V27SegmentEQU equ;
private readonly HL7V27SegmentISD isd;
private readonly HL7V27SegmentROL rol;


        public string Id { get { return @"ESU_U01"; } }
        public string MessageStructureId { get { return @"ESU_U01"; } }
        public string EventDescription { get { return @"Automated equipment status update"; } }

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

        public HL7V27TriggerEventESU_U01(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V27SegmentMSH(this.message);
this.sft = new HL7V27SegmentSFT(this.message);
this.uac = new HL7V27SegmentUAC(this.message);
this.equ = new HL7V27SegmentEQU(this.message);
this.isd = new HL7V27SegmentISD(this.message);
this.rol = new HL7V27SegmentROL(this.message);

        }
    }
}
