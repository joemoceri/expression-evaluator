using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V271TriggerEventEAC_U07
    {
        private readonly HL7V2Message message;
        public HL7V271SegmentMSH msh{get; init;}
public HL7V271SegmentSFT sft{get; init;}
public HL7V271SegmentUAC uac{get; init;}
public HL7V271SegmentEQU equ{get; init;}
public HL7V271SegmentROL rol{get; init;}


        public string Id { get { return @"EAC_U07"; } }
        public string MessageStructureId { get { return @"EAC_U07"; } }
        public string EventDescription { get { return @"Automated equipment command"; } }

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

        public HL7V271TriggerEventEAC_U07(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V271SegmentMSH(this.message);
this.sft = new HL7V271SegmentSFT(this.message);
this.uac = new HL7V271SegmentUAC(this.message);
this.equ = new HL7V271SegmentEQU(this.message);
this.rol = new HL7V271SegmentROL(this.message);

        }
    }
}
