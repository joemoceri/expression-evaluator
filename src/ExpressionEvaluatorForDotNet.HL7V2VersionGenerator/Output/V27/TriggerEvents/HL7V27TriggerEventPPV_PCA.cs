using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27TriggerEventPPV_PCA
    {
        private readonly HL7V2Message message;
        public HL7V27SegmentMSH msh{get; init;}
public HL7V27SegmentSFT sft{get; init;}
public HL7V27SegmentUAC uac{get; init;}
public HL7V27SegmentMSA msa{get; init;}
public HL7V27SegmentERR err{get; init;}
public HL7V27SegmentQAK qak{get; init;}
public HL7V27SegmentQRD qrd{get; init;}


        public string Id { get { return @"PPV_PCA"; } }
        public string MessageStructureId { get { return @"PPV_PCA"; } }
        public string EventDescription { get { return @"PC/ goal response"; } }

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

        public HL7V27TriggerEventPPV_PCA(HL7V2Message message)
        {
            this.message = message;
            this.msh = new HL7V27SegmentMSH(this.message);
this.sft = new HL7V27SegmentSFT(this.message);
this.uac = new HL7V27SegmentUAC(this.message);
this.msa = new HL7V27SegmentMSA(this.message);
this.err = new HL7V27SegmentERR(this.message);
this.qak = new HL7V27SegmentQAK(this.message);
this.qrd = new HL7V27SegmentQRD(this.message);

        }
    }
}
