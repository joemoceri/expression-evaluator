using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26TriggerEventINU_U05
    {
        private readonly HL7V2Message message;
        private readonly HL7V26SegmentMSH msh;
private readonly HL7V26SegmentSFT sft;
private readonly HL7V26SegmentUAC uac;
private readonly HL7V26SegmentEQU equ;
private readonly HL7V26SegmentINV inv;
private readonly HL7V26SegmentROL rol;


        public string Id { get { return @"INU_U05"; } }
        public string MessageStructureId { get { return @"INU_U05"; } }
        public string EventDescription { get { return @"Automated Equipment Inventory Update"; } }

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

        public HL7V26TriggerEventINU_U05(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V26SegmentMSH(this.message);
this.sft = new HL7V26SegmentSFT(this.message);
this.uac = new HL7V26SegmentUAC(this.message);
this.equ = new HL7V26SegmentEQU(this.message);
this.inv = new HL7V26SegmentINV(this.message);
this.rol = new HL7V26SegmentROL(this.message);

        }
    }
}
