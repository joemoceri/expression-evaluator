using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V271TriggerEventPMU_B03
    {
        private readonly HL7V2Message message;
        public HL7V271SegmentMSH msh{get; init;}
public HL7V271SegmentSFT sft{get; init;}
public HL7V271SegmentUAC uac{get; init;}
public HL7V271SegmentEVN evn{get; init;}
public HL7V271SegmentSTF stf{get; init;}


        public string Id { get { return @"PMU_B03"; } }
        public string MessageStructureId { get { return @"PMU_B03"; } }
        public string EventDescription { get { return @"Delete personnel record"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_15",

                    };
            }
        }

        public HL7V271TriggerEventPMU_B03(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V271SegmentMSH(this.message);
this.sft = new HL7V271SegmentSFT(this.message);
this.uac = new HL7V271SegmentUAC(this.message);
this.evn = new HL7V271SegmentEVN(this.message);
this.stf = new HL7V271SegmentSTF(this.message);

        }
    }
}
