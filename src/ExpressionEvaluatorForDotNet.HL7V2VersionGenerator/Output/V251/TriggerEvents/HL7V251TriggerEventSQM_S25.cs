using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251TriggerEventSQM_S25
    {
        private readonly HL7V2Message message;
        public HL7V251SegmentMSH msh{get; init;}
public HL7V251SegmentQRD qrd{get; init;}
public HL7V251SegmentQRF qrf{get; init;}
public HL7V251SegmentDSC dsc{get; init;}


        public string Id { get { return @"SQM_S25"; } }
        public string MessageStructureId { get { return @"SQM_S25"; } }
        public string EventDescription { get { return @"Schedule query message and response"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_10",

                    };
            }
        }

        public HL7V251TriggerEventSQM_S25(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V251SegmentMSH(this.message);
this.qrd = new HL7V251SegmentQRD(this.message);
this.qrf = new HL7V251SegmentQRF(this.message);
this.dsc = new HL7V251SegmentDSC(this.message);

        }
    }
}
