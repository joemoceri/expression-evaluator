using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26TriggerEventSDR_S31
    {
        private readonly HL7V2Message message;
        private readonly HL7V26SegmentMSH msh;
private readonly HL7V26SegmentSFT sft;
private readonly HL7V26SegmentUAC uac;


        public string Id { get { return @"SDR_S31"; } }
        public string MessageStructureId { get { return @"SDR_S31"; } }
        public string EventDescription { get { return @"Request Sterilization Anti-Microbial Device Data"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_17",

                    };
            }
        }

        public HL7V26TriggerEventSDR_S31(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V26SegmentMSH(this.message);
this.sft = new HL7V26SegmentSFT(this.message);
this.uac = new HL7V26SegmentUAC(this.message);

        }
    }
}