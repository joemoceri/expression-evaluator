using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27TriggerEventPGL_PC8
    {
        private readonly HL7V2Message message;
        private readonly HL7V27SegmentMSH msh;
private readonly HL7V27SegmentSFT sft;
private readonly HL7V27SegmentUAC uac;
private readonly HL7V27SegmentPID pid;


        public string Id { get { return @"PGL_PC8"; } }
        public string MessageStructureId { get { return @"PGL_PC8"; } }
        public string EventDescription { get { return @"PC/ goal delete"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_12",

                    };
            }
        }

        public HL7V27TriggerEventPGL_PC8(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V27SegmentMSH(this.message);
this.sft = new HL7V27SegmentSFT(this.message);
this.uac = new HL7V27SegmentUAC(this.message);
this.pid = new HL7V27SegmentPID(this.message);

        }
    }
}