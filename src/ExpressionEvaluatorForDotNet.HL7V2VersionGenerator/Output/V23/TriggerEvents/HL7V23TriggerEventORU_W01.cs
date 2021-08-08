using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23TriggerEventORU_W01
    {
        private readonly HL7V2Message message;
        private readonly HL7V23SegmentMSH msh;
private readonly HL7V23SegmentDSC dsc;


        public string Id { get { return @"ORU_W01"; } }
        public string MessageStructureId { get { return @"ORU_W01"; } }
        public string EventDescription { get { return @"Waveform result, unsolicited transmission of requested information"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_07",

                    };
            }
        }

        public HL7V23TriggerEventORU_W01(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V23SegmentMSH(this.message);
this.dsc = new HL7V23SegmentDSC(this.message);

        }
    }
}