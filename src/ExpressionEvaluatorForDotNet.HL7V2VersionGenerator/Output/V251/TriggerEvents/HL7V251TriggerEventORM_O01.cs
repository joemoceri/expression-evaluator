using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251TriggerEventORM_O01
    {
        private readonly HL7V2Message message;
        private readonly HL7V251SegmentMSH msh;
private readonly HL7V251SegmentNTE nte;


        public string Id { get { return @"ORM_O01"; } }
        public string MessageStructureId { get { return @"ORM_O01"; } }
        public string EventDescription { get { return @"General Order"; } }

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

        public HL7V251TriggerEventORM_O01(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V251SegmentMSH(this.message);
this.nte = new HL7V251SegmentNTE(this.message);

        }
    }
}