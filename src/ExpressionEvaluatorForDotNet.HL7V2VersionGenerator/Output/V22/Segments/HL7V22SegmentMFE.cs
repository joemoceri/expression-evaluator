using System.Linq;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22SegmentMFE
    {
        public readonly HL7V2Message message;

        public string Id { get { return @"MFE"; } }

        public string SegmentId { get { return @"MFE"; } }
        
        public string LongName { get { return @"Master File Entry"; } }
        
        public string Description { get { return @""; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_08",
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
                            Id = @"MFE.1",
                            Type = @"Field",
                            Position = @"MFE.1",
                            Name = @"Record-level Event Code",
                            Length = 3,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0180",
                            TableName = @"RECORD LEVEL EVENT CODE",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MFE.2",
                            Type = @"Field",
                            Position = @"MFE.2",
                            Name = @"Mfn Control Id",
                            Length = 20,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MFE.3",
                            Type = @"Field",
                            Position = @"MFE.3",
                            Name = @"Effective Date / Time",
                            Length = 26,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"MFE.3.1",
                            Type = @"Component",
                            Position = @"MFE.3.1",
                            Name = @"Time Of An Event",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MFE.3.2",
                            Type = @"Component",
                            Position = @"MFE.3.2",
                            Name = @"Degree Of Precision",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MFE.4",
                            Type = @"Field",
                            Position = @"MFE.4",
                            Name = @"Primary Key Value",
                            Length = 60,
                            Usage = @"R",
                            Rpt = @"*",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"MFE.4.1",
                            Type = @"Component",
                            Position = @"MFE.4.1",
                            Name = @"Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>.  Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MFE.4.2",
                            Type = @"Component",
                            Position = @"MFE.4.2",
                            Name = @"Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Name or description of the item in question.  E.g., myocardial infarction or x-ray impression.  Its data type is string (ST).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MFE.4.3",
                            Type = @"Component",
                            Position = @"MFE.4.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system will be assigned a unique identifier.  This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item.  For backward compatibility, if this component is absent, it will be taken to mean the CPT-4 with ASTM extensions, i.e., AS4.  Other coding systems that might appear here are ICD-9, ICD-10, SNOMED, etc.  Each system will be given a unique identifying string.  The current ASTM 1238-88  diagnostic/procedure/observation/drug ID/health outcomes coding systems are identified in the tables below.  Others may be added as needed.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MFE.4.4",
                            Type = @"Component",
                            Position = @"MFE.4.4",
                            Name = @"Alternate Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MFE.4.5",
                            Type = @"Component",
                            Position = @"MFE.4.5",
                            Name = @"Alternate Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MFE.4.6",
                            Type = @"Component",
                            Position = @"MFE.4.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        };
            }
        }

        public HL7V22SegmentMFE(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V22Field recordlevelEventCode;

public HL7V22Field RecordlevelEventCode
{
    get
    {
        if (recordlevelEventCode != null)
        {
            return recordlevelEventCode;
        }

        recordlevelEventCode = new HL7V22Field
        {
            field = message[@"MFE"][1],
            Id = @"MFE.1",
            Type = @"Field",
            Position = @"MFE.1",
            Name = @"Record-level Event Code",
            Length = 3,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0180",
            TableName = @"RECORD LEVEL EVENT CODE",
            Description = null,
            Sample = @"",
        };

        

        

        

        return recordlevelEventCode;
    } 
}
internal HL7V22Field mfnControlId;

public HL7V22Field MfnControlId
{
    get
    {
        if (mfnControlId != null)
        {
            return mfnControlId;
        }

        mfnControlId = new HL7V22Field
        {
            field = message[@"MFE"][2],
            Id = @"MFE.2",
            Type = @"Field",
            Position = @"MFE.2",
            Name = @"Mfn Control Id",
            Length = 20,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return mfnControlId;
    } 
}
internal HL7V22Field effectiveDateTime;

public HL7V22Field EffectiveDateTime
{
    get
    {
        if (effectiveDateTime != null)
        {
            return effectiveDateTime;
        }

        effectiveDateTime = new HL7V22Field
        {
            field = message[@"MFE"][3],
            Id = @"MFE.3",
            Type = @"Field",
            Position = @"MFE.3",
            Name = @"Effective Date / Time",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return effectiveDateTime;
    } 
}
internal HL7V22Field primaryKeyValue;

public HL7V22Field PrimaryKeyValue
{
    get
    {
        if (primaryKeyValue != null)
        {
            return primaryKeyValue;
        }

        primaryKeyValue = new HL7V22Field
        {
            field = message[@"MFE"][4],
            Id = @"MFE.4",
            Type = @"Field",
            Position = @"MFE.4",
            Name = @"Primary Key Value",
            Length = 60,
            Usage = @"R",
            Rpt = @"*",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return primaryKeyValue;
    } 
}

    }
}
