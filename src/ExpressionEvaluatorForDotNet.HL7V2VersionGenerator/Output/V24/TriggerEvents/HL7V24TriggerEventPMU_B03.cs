using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24TriggerEventPMU_B03
    {
        private readonly HL7V2Message message;
        private readonly HL7V24SegmentMSH msh;
private readonly HL7V24SegmentEVN evn;
private readonly HL7V24SegmentSTF stf;


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

        public HL7V24TriggerEventPMU_B03(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V24SegmentMSH(this.message);
this.evn = new HL7V24SegmentEVN(this.message);
this.stf = new HL7V24SegmentSTF(this.message);

        }
    }
}