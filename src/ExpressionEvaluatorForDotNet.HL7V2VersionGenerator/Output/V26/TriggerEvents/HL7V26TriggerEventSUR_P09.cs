using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26TriggerEventSUR_P09
    {
        private readonly HL7V2Message message;
        private readonly HL7V26SegmentMSH msh;


        public string Id { get { return @"SUR_P09"; } }
        public string MessageStructureId { get { return @"SUR_P09"; } }
        public string EventDescription { get { return @"Summary Product Experience Report"; } }

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

        public HL7V26TriggerEventSUR_P09(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V26SegmentMSH(this.message);

        }
    }
}
