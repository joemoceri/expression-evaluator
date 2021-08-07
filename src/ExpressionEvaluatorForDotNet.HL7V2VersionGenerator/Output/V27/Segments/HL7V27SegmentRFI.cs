using System.Linq;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27SegmentRFI
    {
        public readonly HL7V2Message message;

        public string Id { get { return @"RFI"; } }

        public string SegmentId { get { return @"RFI"; } }
        
        public string LongName { get { return @"Request For Information"; } }
        
        public string Description { get { return @""; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_16",
                    };
            }
        }

        public IList<HL7V2FieldData> Fields 
        { 
            get 
            {
                return new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"RFI.1",
                            Type = @"Field",
                            Position = @"RFI.1",
                            Name = @"Request Date",
                            Length = 0,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"DTM",
                            DataTypeName = @"Date/time",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RFI.2",
                            Type = @"Field",
                            Position = @"RFI.2",
                            Name = @"Response Due Date",
                            Length = 0,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"DTM",
                            DataTypeName = @"Date/time",
                            TableId = null,
                            TableName = null,
                            Description = @"The latest date by which the additional information is to be returned to requestor.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RFI.3",
                            Type = @"Field",
                            Position = @"RFI.3",
                            Name = @"Patient Consent",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value For Hl7 Defined Tables",
                            TableId = @"0136",
                            TableName = @"Yes/no Indicator",
                            Description = @"Code indicating if the Payer has obtained patient consent for release of information (1) – Optional.  Refer to HL7 Table 0136 – Yes/No Indicator for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RFI.4",
                            Type = @"Field",
                            Position = @"RFI.4",
                            Name = @"Date Additional Information Was Submitted",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DTM",
                            DataTypeName = @"Date/time",
                            TableId = null,
                            TableName = null,
                            Description = @"The date on which the information was assembled for transmission to the Payer.  Not necessarily the same as the message date.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        };
            }
        }

        public HL7V27SegmentRFI(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V27Field requestDate;

public HL7V27Field RequestDate
{
    get
    {
        if (requestDate != null)
        {
            return requestDate;
        }

        requestDate = new HL7V27Field
        {
            field = message[@"RFI"][1],
            Id = @"RFI.1",
            Type = @"Field",
            Position = @"RFI.1",
            Name = @"Request Date",
            Length = 0,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"DTM",
            DataTypeName = @"Date/time",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return requestDate;
    } 
}
internal HL7V27Field responseDueDate;

public HL7V27Field ResponseDueDate
{
    get
    {
        if (responseDueDate != null)
        {
            return responseDueDate;
        }

        responseDueDate = new HL7V27Field
        {
            field = message[@"RFI"][2],
            Id = @"RFI.2",
            Type = @"Field",
            Position = @"RFI.2",
            Name = @"Response Due Date",
            Length = 0,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"DTM",
            DataTypeName = @"Date/time",
            TableId = null,
            TableName = null,
            Description = @"The latest date by which the additional information is to be returned to requestor.",
            Sample = @"",
        };

        

        

        

        return responseDueDate;
    } 
}
internal HL7V27Field patientConsent;

public HL7V27Field PatientConsent
{
    get
    {
        if (patientConsent != null)
        {
            return patientConsent;
        }

        patientConsent = new HL7V27Field
        {
            field = message[@"RFI"][3],
            Id = @"RFI.3",
            Type = @"Field",
            Position = @"RFI.3",
            Name = @"Patient Consent",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value For Hl7 Defined Tables",
            TableId = @"0136",
            TableName = @"Yes/no Indicator",
            Description = @"Code indicating if the Payer has obtained patient consent for release of information (1) – Optional.  Refer to HL7 Table 0136 – Yes/No Indicator for suggested values.",
            Sample = @"",
        };

        

        

        

        return patientConsent;
    } 
}
internal HL7V27Field dateAdditionalInformationWasSubmitted;

public HL7V27Field DateAdditionalInformationWasSubmitted
{
    get
    {
        if (dateAdditionalInformationWasSubmitted != null)
        {
            return dateAdditionalInformationWasSubmitted;
        }

        dateAdditionalInformationWasSubmitted = new HL7V27Field
        {
            field = message[@"RFI"][4],
            Id = @"RFI.4",
            Type = @"Field",
            Position = @"RFI.4",
            Name = @"Date Additional Information Was Submitted",
            Length = 0,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DTM",
            DataTypeName = @"Date/time",
            TableId = null,
            TableName = null,
            Description = @"The date on which the information was assembled for transmission to the Payer.  Not necessarily the same as the message date.",
            Sample = @"",
        };

        

        

        

        return dateAdditionalInformationWasSubmitted;
    } 
}

    }
}
