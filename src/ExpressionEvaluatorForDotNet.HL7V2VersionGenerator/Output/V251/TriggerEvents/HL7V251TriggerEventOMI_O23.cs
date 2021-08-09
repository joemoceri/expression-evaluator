using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251TriggerEventOMI_O23
    {
        private readonly HL7V2Message message;
        public HL7V251SegmentMSH msh{get; init;}
public HL7V251SegmentSFT sft{get; init;}
public HL7V251SegmentNTE nte{get; init;}


        public string Id { get { return @"OMI_O23"; } }
        public string MessageStructureId { get { return @"OMI_O23"; } }
        public string EventDescription { get { return @"Imaging Order"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_04",

                    };
            }
        }

        public HL7V251TriggerEventOMI_O23(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V251SegmentMSH(this.message);
this.sft = new HL7V251SegmentSFT(this.message);
this.nte = new HL7V251SegmentNTE(this.message);

        }
    }
}
