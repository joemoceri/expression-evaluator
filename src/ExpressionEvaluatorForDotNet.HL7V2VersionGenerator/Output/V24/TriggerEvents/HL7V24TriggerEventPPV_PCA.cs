using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24TriggerEventPPV_PCA
    {
        private readonly HL7V2Message message;
        public HL7V24SegmentMSH msh{get; init;}
public HL7V24SegmentMSA msa{get; init;}
public HL7V24SegmentERR err{get; init;}
public HL7V24SegmentQAK qak{get; init;}
public HL7V24SegmentQRD qrd{get; init;}


        public string Id { get { return @"PPV_PCA"; } }
        public string MessageStructureId { get { return @"PPV_PCA"; } }
        public string EventDescription { get { return @"Patient goal response"; } }

        public string Sample { get { return null; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_12",

                    };
            }
        }

        public HL7V24TriggerEventPPV_PCA(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V24SegmentMSH(this.message);
this.msa = new HL7V24SegmentMSA(this.message);
this.err = new HL7V24SegmentERR(this.message);
this.qak = new HL7V24SegmentQAK(this.message);
this.qrd = new HL7V24SegmentQRD(this.message);

        }
    }
}
