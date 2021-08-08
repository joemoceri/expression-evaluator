using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V271TriggerEventUDM_Q05
    {
        private readonly HL7V2Message message;
        private readonly HL7V271SegmentMSH msh;
private readonly HL7V271SegmentSFT sft;
private readonly HL7V271SegmentUAC uac;
private readonly HL7V271SegmentURD urd;
private readonly HL7V271SegmentURS urs;
private readonly HL7V271SegmentDSP dsp;
private readonly HL7V271SegmentDSC dsc;


        public string Id { get { return @"UDM_Q05"; } }
        public string MessageStructureId { get { return @"UDM_Q05"; } }
        public string EventDescription { get { return @"Unsolicited display update message"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_05",

                    };
            }
        }

        public HL7V271TriggerEventUDM_Q05(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V271SegmentMSH(this.message);
this.sft = new HL7V271SegmentSFT(this.message);
this.uac = new HL7V271SegmentUAC(this.message);
this.urd = new HL7V271SegmentURD(this.message);
this.urs = new HL7V271SegmentURS(this.message);
this.dsp = new HL7V271SegmentDSP(this.message);
this.dsc = new HL7V271SegmentDSC(this.message);

        }
    }
}