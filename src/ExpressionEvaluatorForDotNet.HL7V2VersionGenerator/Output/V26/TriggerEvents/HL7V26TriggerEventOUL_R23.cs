using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26TriggerEventOUL_R23
    {
        private readonly HL7V2Message message;
        private readonly HL7V26SegmentMSH msh;
private readonly HL7V26SegmentSFT sft;
private readonly HL7V26SegmentUAC uac;
private readonly HL7V26SegmentNTE nte;
private readonly HL7V26SegmentNK1 nk1;
private readonly HL7V26SegmentDSC dsc;


        public string Id { get { return @"OUL_R23"; } }
        public string MessageStructureId { get { return @"OUL_R23"; } }
        public string EventDescription { get { return @"Unsolicited Specimen Container Oriented Observation"; } }

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

        public HL7V26TriggerEventOUL_R23(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V26SegmentMSH(this.message);
this.sft = new HL7V26SegmentSFT(this.message);
this.uac = new HL7V26SegmentUAC(this.message);
this.nte = new HL7V26SegmentNTE(this.message);
this.nk1 = new HL7V26SegmentNK1(this.message);
this.dsc = new HL7V26SegmentDSC(this.message);

        }
    }
}
