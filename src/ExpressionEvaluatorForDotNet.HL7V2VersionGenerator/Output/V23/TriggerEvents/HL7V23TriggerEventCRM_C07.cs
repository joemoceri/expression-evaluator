using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23TriggerEventCRM_C07
    {
        private readonly HL7V2Message message;
        private readonly HL7V23SegmentMSH msh;


        public string Id { get { return @"CRM_C07"; } }
        public string MessageStructureId { get { return @"CRM_C07"; } }
        public string EventDescription { get { return @"Correct/update phase information"; } }

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

        public HL7V23TriggerEventCRM_C07(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V23SegmentMSH(this.message);

        }
    }
}
