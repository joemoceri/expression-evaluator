using System.Linq;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25SegmentMFA
    {
        public readonly HL7V2Message message;

        public string Id { get { return @"MFA"; } }

        public string SegmentId { get { return @"MFA"; } }
        
        public string LongName { get { return @"Master File Acknowledgment"; } }
        
        public string Description { get { return @"The Technical Steward for the MFA segment is CQ."; } }
        
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
                            Id = @"MFA.1",
                            Type = @"Field",
                            Position = @"MFA.1",
                            Name = @"Record-Level Event Code",
                            Length = 3,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0180",
                            TableName = @"Record-level event code",
                            Description = @"This field defines record-level event for the master file record identified by the MFI segment and the primary key in this segment. Refer to HL7 table 0180 - Record level event code for valid values.

Note:  If the MFI-3 - File-level event code is ""REP"" (replace file), then each MFA segment must have an MFA-1 - Record-level event code of ""MAD"" (add record to master file). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MFA.2",
                            Type = @"Field",
                            Position = @"MFA.2",
                            Name = @"MFN Control ID",
                            Length = 20,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains a number or other identifier that uniquely identifies this change to this record from the point of view of the originating system. This field uniquely identifies the particular record (identified by the MFE segment) being acknowledged by this MFA segment. When returned to the originating system via the MFA segment, this field allows the target system to precisely identify which change to this record is being acknowledged. It is only required if MFI-6 - Response Level Code requires responses at the record level (any value other than NE).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MFA.3",
                            Type = @"Field",
                            Position = @"MFA.3",
                            Name = @"Event Completion Date/Time",
                            Length = 26,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"This field may be required or optional depending on the site specifications for the given master file, master file event, and receiving facility.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"MFA.3.1",
                            Type = @"Component",
                            Position = @"MFA.3.1",
                            Name = @"Time",
                            Length = 24,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"DTM",
                            DataTypeName = @"Date/Time",
                            TableId = null,
                            TableName = null,
                            Description = @"The point in time.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MFA.3.2",
                            Type = @"Component",
                            Position = @"MFA.3.2",
                            Name = @"Degree Of Precision",
                            Length = 1,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0529",
                            TableName = @"Precision",
                            Description = @"Retained only for purposes of backward compatibility as of v 2.3. Refer to component 1 for current method of designating degree of precision.

Indicates the degree of precision of the time stamp (Y = year, L = month, D = day, H = hour, M = minute, S = second). Refer to HL7 Table 0529 - Precision for valid value.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MFA.4",
                            Type = @"Field",
                            Position = @"MFA.4",
                            Name = @"MFN Record Level Error Return",
                            Length = 250,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0181",
                            TableName = @"MFN record-level error return",
                            Description = @"This field contains the status of the requested update. Site-defined table, specific to each master file being updated via this transaction.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"MFA.4.1",
                            Type = @"Component",
                            Position = @"MFA.4.1",
                            Name = @"Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MFA.4.2",
                            Type = @"Component",
                            Position = @"MFA.4.2",
                            Name = @"Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MFA.4.3",
                            Type = @"Component",
                            Position = @"MFA.4.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MFA.4.4",
                            Type = @"Component",
                            Position = @"MFA.4.4",
                            Name = @"Alternate Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"An alternate sequence of characters (the code) that uniquely identifies the item being referenced. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MFA.4.5",
                            Type = @"Component",
                            Position = @"MFA.4.5",
                            Name = @"Alternate Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MFA.4.6",
                            Type = @"Component",
                            Position = @"MFA.4.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MFA.5",
                            Type = @"Field",
                            Position = @"MFA.5",
                            Name = @"Primary Key Value - MFA",
                            Length = 250,
                            Usage = @"R",
                            Rpt = @"*",
                            DataType = @"VARIES",
                            DataTypeName = @"Variable Datatype",
                            TableId = null,
                            TableName = null,
                            Description = @"This field uniquely identifies the record of the master file (identified in the MFI segment) for which the update status is being acknowledged (as defined by the field MFN-4 - Record Level Error Return ). The data type of this field is defined by the value of MFA-6 - Value Type - MFA, and may take on the format of any of the HL7 data types defined in HL7 table 0355 - Primary Key Value Type. The PL data type is used only on location master transactions.

The following exception to the use of the CE data type is deprecated in V2.3.1, and left in for backward compatibility.  When the CE data type is used, the first component of this CE data field carries an optional subcomponent, the application ID, that uniquely defines the application responsible for creating the primary key value.  The application ID subcomponents can be used to guarantee uniqueness of the primary key across multiple applications.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MFA.6",
                            Type = @"Field",
                            Position = @"MFA.6",
                            Name = @"Primary Key Value Type - MFA",
                            Length = 3,
                            Usage = @"R",
                            Rpt = @"*",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0355",
                            TableName = @"Primary key value type",
                            Description = @"This field contains the HL7 data type of MFA-5 - Primary Key Value - MFA. The valid HL7 data types are listed in HL7 table 0355 - Primary key value type .",
                            Sample = @"",
                            FieldDatas = null
                        },
                        };
            }
        }

        public HL7V25SegmentMFA(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V25Field recordLevelEventCode;

public HL7V25Field RecordLevelEventCode
{
    get
    {
        if (recordLevelEventCode != null)
        {
            return recordLevelEventCode;
        }

        recordLevelEventCode = new HL7V25Field
        {
            field = message[@"MFA"][1],
            Id = @"MFA.1",
            Type = @"Field",
            Position = @"MFA.1",
            Name = @"Record-Level Event Code",
            Length = 3,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0180",
            TableName = @"Record-level event code",
            Description = @"This field defines record-level event for the master file record identified by the MFI segment and the primary key in this segment. Refer to HL7 table 0180 - Record level event code for valid values.

Note:  If the MFI-3 - File-level event code is ""REP"" (replace file), then each MFA segment must have an MFA-1 - Record-level event code of ""MAD"" (add record to master file). ",
            Sample = @"",
        };

        

        

        

        return recordLevelEventCode;
    } 
}
internal HL7V25Field mFNControlID;

public HL7V25Field MFNControlID
{
    get
    {
        if (mFNControlID != null)
        {
            return mFNControlID;
        }

        mFNControlID = new HL7V25Field
        {
            field = message[@"MFA"][2],
            Id = @"MFA.2",
            Type = @"Field",
            Position = @"MFA.2",
            Name = @"MFN Control ID",
            Length = 20,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains a number or other identifier that uniquely identifies this change to this record from the point of view of the originating system. This field uniquely identifies the particular record (identified by the MFE segment) being acknowledged by this MFA segment. When returned to the originating system via the MFA segment, this field allows the target system to precisely identify which change to this record is being acknowledged. It is only required if MFI-6 - Response Level Code requires responses at the record level (any value other than NE).",
            Sample = @"",
        };

        

        

        

        return mFNControlID;
    } 
}
internal HL7V25Field eventCompletionDateTime;

public HL7V25Field EventCompletionDateTime
{
    get
    {
        if (eventCompletionDateTime != null)
        {
            return eventCompletionDateTime;
        }

        eventCompletionDateTime = new HL7V25Field
        {
            field = message[@"MFA"][3],
            Id = @"MFA.3",
            Type = @"Field",
            Position = @"MFA.3",
            Name = @"Event Completion Date/Time",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field may be required or optional depending on the site specifications for the given master file, master file event, and receiving facility.",
            Sample = @"",
        };

        

        

        

        return eventCompletionDateTime;
    } 
}
internal HL7V25Field mFNRecordLevelErrorReturn;

public HL7V25Field MFNRecordLevelErrorReturn
{
    get
    {
        if (mFNRecordLevelErrorReturn != null)
        {
            return mFNRecordLevelErrorReturn;
        }

        mFNRecordLevelErrorReturn = new HL7V25Field
        {
            field = message[@"MFA"][4],
            Id = @"MFA.4",
            Type = @"Field",
            Position = @"MFA.4",
            Name = @"MFN Record Level Error Return",
            Length = 250,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0181",
            TableName = @"MFN record-level error return",
            Description = @"This field contains the status of the requested update. Site-defined table, specific to each master file being updated via this transaction.",
            Sample = @"",
        };

        

        

        

        return mFNRecordLevelErrorReturn;
    } 
}
internal HL7V25Field primaryKeyValueMFA;

public HL7V25Field PrimaryKeyValueMFA
{
    get
    {
        if (primaryKeyValueMFA != null)
        {
            return primaryKeyValueMFA;
        }

        primaryKeyValueMFA = new HL7V25Field
        {
            field = message[@"MFA"][5],
            Id = @"MFA.5",
            Type = @"Field",
            Position = @"MFA.5",
            Name = @"Primary Key Value - MFA",
            Length = 250,
            Usage = @"R",
            Rpt = @"*",
            DataType = @"VARIES",
            DataTypeName = @"Variable Datatype",
            TableId = null,
            TableName = null,
            Description = @"This field uniquely identifies the record of the master file (identified in the MFI segment) for which the update status is being acknowledged (as defined by the field MFN-4 - Record Level Error Return ). The data type of this field is defined by the value of MFA-6 - Value Type - MFA, and may take on the format of any of the HL7 data types defined in HL7 table 0355 - Primary Key Value Type. The PL data type is used only on location master transactions.

The following exception to the use of the CE data type is deprecated in V2.3.1, and left in for backward compatibility.  When the CE data type is used, the first component of this CE data field carries an optional subcomponent, the application ID, that uniquely defines the application responsible for creating the primary key value.  The application ID subcomponents can be used to guarantee uniqueness of the primary key across multiple applications.",
            Sample = @"",
        };

        

        

        

        return primaryKeyValueMFA;
    } 
}
internal HL7V25Field primaryKeyValueTypeMFA;

public HL7V25Field PrimaryKeyValueTypeMFA
{
    get
    {
        if (primaryKeyValueTypeMFA != null)
        {
            return primaryKeyValueTypeMFA;
        }

        primaryKeyValueTypeMFA = new HL7V25Field
        {
            field = message[@"MFA"][6],
            Id = @"MFA.6",
            Type = @"Field",
            Position = @"MFA.6",
            Name = @"Primary Key Value Type - MFA",
            Length = 3,
            Usage = @"R",
            Rpt = @"*",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0355",
            TableName = @"Primary key value type",
            Description = @"This field contains the HL7 data type of MFA-5 - Primary Key Value - MFA. The valid HL7 data types are listed in HL7 table 0355 - Primary key value type .",
            Sample = @"",
        };

        

        

        

        return primaryKeyValueTypeMFA;
    } 
}

    }
}
