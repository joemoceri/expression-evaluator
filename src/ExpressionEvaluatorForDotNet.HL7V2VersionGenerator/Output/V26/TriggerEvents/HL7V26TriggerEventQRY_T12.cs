using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26TriggerEventQRY_T12
    {
        private readonly HL7V2Message message;
        private readonly HL7V26SegmentMSH msh;
private readonly HL7V26SegmentQRD qrd;
private readonly HL7V26SegmentQRF qrf;


        public string Id { get { return @"QRY_T12"; } }
        public string MessageStructureId { get { return @"QRY_T12"; } }
        public string EventDescription { get { return @"Document Query"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_09",

                    };
            }
        }

        public HL7V26TriggerEventQRY_T12(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V26SegmentMSH(this.message);
this.qrd = new HL7V26SegmentQRD(this.message);
this.qrf = new HL7V26SegmentQRF(this.message);

        }
    }
}