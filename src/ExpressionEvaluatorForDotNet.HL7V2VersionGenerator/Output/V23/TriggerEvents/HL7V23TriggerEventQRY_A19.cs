using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23TriggerEventQRY_A19
    {
        private readonly HL7V2Message message;
        private readonly HL7V23SegmentMSH msh;
private readonly HL7V23SegmentQRD qrd;
private readonly HL7V23SegmentQRF qrf;


        public string Id { get { return @"QRY_A19"; } }
        public string MessageStructureId { get { return @"QRY_A19"; } }
        public string EventDescription { get { return @"Patient query"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_02",
"CH_03",

                    };
            }
        }

        public HL7V23TriggerEventQRY_A19(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V23SegmentMSH(this.message);
this.qrd = new HL7V23SegmentQRD(this.message);
this.qrf = new HL7V23SegmentQRF(this.message);

        }
    }
}
