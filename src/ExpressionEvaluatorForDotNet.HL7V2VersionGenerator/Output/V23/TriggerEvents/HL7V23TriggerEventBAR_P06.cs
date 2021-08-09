using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23TriggerEventBAR_P06
    {
        private readonly HL7V2Message message;
        public HL7V23SegmentMSH msh{get; init;}
public HL7V23SegmentEVN evn{get; init;}


        public string Id { get { return @"BAR_P06"; } }
        public string MessageStructureId { get { return @"BAR_P06"; } }
        public string EventDescription { get { return @"End account"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_06",

                    };
            }
        }

        public HL7V23TriggerEventBAR_P06(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V23SegmentMSH(this.message);
this.evn = new HL7V23SegmentEVN(this.message);

        }
    }
}
