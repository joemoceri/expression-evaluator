using System.Linq;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26SegmentCON
    {
        public readonly HL7V2Message message;

        public string Id { get { return @"CON"; } }

        public string SegmentId { get { return @"CON"; } }
        
        public string LongName { get { return @"Consent Segment"; } }
        
        public string Description { get { return @"The consent segment provides details about a specific consent by a patient or staff member."; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_09",
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
                            Id = @"CON.1",
                            Type = @"Field",
                            Position = @"CON.1",
                            Name = @"Set ID - CON",
                            Length = 4,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"SI",
                            DataTypeName = @"Sequence ID",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the number that identifies this segment instance within the message. For the first occurrence of the segment, the sequence number shall be one; for the second occurrence, the sequence number shall be two; etc.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CON.2",
                            Type = @"Field",
                            Position = @"CON.2",
                            Name = @"Consent Type",
                            Length = 705,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded with Exceptions",
                            TableId = @"0496",
                            TableName = @"Consent Type",
                            Description = @"This field describes what the subject is consenting to, i.e., what type of service, surgical procedure, information access/release or other event. For values see User-Defined Table 0496 - Consent Type.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"CON.2.1",
                            Type = @"Component",
                            Position = @"CON.2.1",
                            Name = @"Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CON.2.2",
                            Type = @"Component",
                            Position = @"CON.2.2",
                            Name = @"Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component contains the descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CON.2.3",
                            Type = @"Component",
                            Position = @"CON.2.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CON.2.4",
                            Type = @"Component",
                            Position = @"CON.2.4",
                            Name = @"Alternate Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"An alternate sequence of characters (the code) that uniquely identifies the item being referenced. Analogous to ""Identifier"" in component 1. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CON.2.5",
                            Type = @"Component",
                            Position = @"CON.2.5",
                            Name = @"Alternate Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. Analogous to ""Text"" in component 2. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CON.2.6",
                            Type = @"Component",
                            Position = @"CON.2.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component. Analogous to Name of Coding System above. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CON.2.7",
                            Type = @"Component",
                            Position = @"CON.2.7",
                            Name = @"Coding System Version Id",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID. If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CON.2.8",
                            Type = @"Component",
                            Position = @"CON.2.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 4-6.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CON.2.9",
                            Type = @"Component",
                            Position = @"CON.2.9",
                            Name = @"Original Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The original text that was available to an automated process or a human before a specific code was assigned.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CON.3",
                            Type = @"Field",
                            Position = @"CON.3",
                            Name = @"Consent Form ID and Version",
                            Length = 40,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Identifies a specific version of a consent form used to record the consent. A given version of a consent form implies a particular set of wording that appears on the form.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CON.4",
                            Type = @"Field",
                            Position = @"CON.4",
                            Name = @"Consent Form Number",
                            Length = 427,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"EI",
                            DataTypeName = @"Entity Identifier",
                            TableId = null,
                            TableName = null,
                            Description = @"Uniquely identifies a specific recorded consent. This may be the number assigned to an electronic consent, or may be the number on a printed consent form.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"CON.4.1",
                            Type = @"Component",
                            Position = @"CON.4.1",
                            Name = @"Entity Identifier",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component, <entity identifier>, is usually defined to be unique within the series of identifiers created by the <assigning authority>, defined by a hierarchic designator, represented by components 2 through 4. See Section 2.A.33, ""HD - hierarchic designator"".",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CON.4.2",
                            Type = @"Component",
                            Position = @"CON.4.2",
                            Name = @"Namespace Id",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0363",
                            TableName = @"Assigning authority",
                            Description = @"The assigning authority is a unique identifier of the system (or organization or agency or department) that creates the data. Refer to User-defined Table 0363 - Assigning authority for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CON.4.3",
                            Type = @"Component",
                            Position = @"CON.4.3",
                            Name = @"Universal Id",
                            Length = 199,
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
                            Id = @"CON.4.4",
                            Type = @"Component",
                            Position = @"CON.4.4",
                            Name = @"Universal Id Type",
                            Length = 6,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CON.5",
                            Type = @"Field",
                            Position = @"CON.5",
                            Name = @"Consent Text",
                            Length = 65536,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"FT",
                            DataTypeName = @"Formatted Text Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Describes the specific procedures/information releases/events the subject is consenting to.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CON.6",
                            Type = @"Field",
                            Position = @"CON.6",
                            Name = @"Subject-specific Consent Text",
                            Length = 65536,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"FT",
                            DataTypeName = @"Formatted Text Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Describes any additions or variations to the standard procedures/information releases/events from a standard consent that are applicable to the subject whose consent is sought.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CON.7",
                            Type = @"Field",
                            Position = @"CON.7",
                            Name = @"Consent Background Information",
                            Length = 65535,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"FT",
                            DataTypeName = @"Formatted Text Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Describes any additional information relating to the procedure/information release/event that needs to be understood by the subject for informed consent. May include the reason for the service, the expected benefit, risks, etc.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CON.8",
                            Type = @"Field",
                            Position = @"CON.8",
                            Name = @"Subject-specific Consent Background Text",
                            Length = 65535,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"FT",
                            DataTypeName = @"Formatted Text Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Describes any additions or variations to the standard additional information that needs to be understood by the patient for informed consent. May include a description of benefits and risks that are specific to the subject from whom consent is sought. May also include an indication that there are no subject-specific risks/benefits.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CON.9",
                            Type = @"Field",
                            Position = @"CON.9",
                            Name = @"Consenter-imposed limitations",
                            Length = 65535,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"FT",
                            DataTypeName = @"Formatted Text Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Describes any restrictions or limitations placed on their consent by the subject.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CON.10",
                            Type = @"Field",
                            Position = @"CON.10",
                            Name = @"Consent Mode",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CNE",
                            DataTypeName = @"Coded with No Exceptions",
                            TableId = @"0497",
                            TableName = @"Consent Mode",
                            Description = @"The method in which a subject provides consent.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"CON.10.1",
                            Type = @"Component",
                            Position = @"CON.10.1",
                            Name = @"Identifier",
                            Length = 20,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CNE.2. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CON.10.2",
                            Type = @"Component",
                            Position = @"CON.10.2",
                            Name = @"Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component contains the descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression. This is the corresponding text assigned by the coding system to the identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CON.10.3",
                            Type = @"Component",
                            Position = @"CON.10.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"The third component contains the code for the name of the coding system from which the value in CNE.1 is obtained.Refer to HL7 Table 0396 - Coding System s in section 2.16.4, ""Coding System Table"" for valid values. Each coding system is assigned a unique identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CON.10.4",
                            Type = @"Component",
                            Position = @"CON.10.4",
                            Name = @"Alternate Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Analogous to “Identifier” in component 1.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CON.10.5",
                            Type = @"Component",
                            Position = @"CON.10.5",
                            Name = @"Alternate Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. Analogous to ""Text"" in component 2.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CON.10.6",
                            Type = @"Component",
                            Position = @"CON.10.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component. Analogous to Name of Coding System in component 3. Refer to HL7 Table 0396 - Coding Systems in section 2.16.4, ""Coding System Table"" for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CON.10.7",
                            Type = @"Component",
                            Position = @"CON.10.7",
                            Name = @"Coding System Version Id",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"the version ID for the coding system identified by component 3. It belongs conceptually to components 1-3 and appears here only for reasons of backward compatibility.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CON.10.8",
                            Type = @"Component",
                            Position = @"CON.10.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"the version ID for the coding system identified by component 6. It belongs conceptually to the group of Alternate components (see note 2.A.1) and appears here only for reasons of backward compatibility.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CON.10.9",
                            Type = @"Component",
                            Position = @"CON.10.9",
                            Name = @"Original Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The original text that was available to an automated process or a human before a specific code was assigned.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CON.11",
                            Type = @"Field",
                            Position = @"CON.11",
                            Name = @"Consent Status",
                            Length = 2,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"CNE",
                            DataTypeName = @"Coded with No Exceptions",
                            TableId = @"0498",
                            TableName = @"Consent Status",
                            Description = @"Indicates whether consent has been sought and granted.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"CON.11.1",
                            Type = @"Component",
                            Position = @"CON.11.1",
                            Name = @"Identifier",
                            Length = 20,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CNE.2. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CON.11.2",
                            Type = @"Component",
                            Position = @"CON.11.2",
                            Name = @"Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component contains the descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression. This is the corresponding text assigned by the coding system to the identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CON.11.3",
                            Type = @"Component",
                            Position = @"CON.11.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"The third component contains the code for the name of the coding system from which the value in CNE.1 is obtained.Refer to HL7 Table 0396 - Coding System s in section 2.16.4, ""Coding System Table"" for valid values. Each coding system is assigned a unique identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CON.11.4",
                            Type = @"Component",
                            Position = @"CON.11.4",
                            Name = @"Alternate Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Analogous to “Identifier” in component 1.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CON.11.5",
                            Type = @"Component",
                            Position = @"CON.11.5",
                            Name = @"Alternate Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. Analogous to ""Text"" in component 2.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CON.11.6",
                            Type = @"Component",
                            Position = @"CON.11.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component. Analogous to Name of Coding System in component 3. Refer to HL7 Table 0396 - Coding Systems in section 2.16.4, ""Coding System Table"" for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CON.11.7",
                            Type = @"Component",
                            Position = @"CON.11.7",
                            Name = @"Coding System Version Id",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"the version ID for the coding system identified by component 3. It belongs conceptually to components 1-3 and appears here only for reasons of backward compatibility.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CON.11.8",
                            Type = @"Component",
                            Position = @"CON.11.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"the version ID for the coding system identified by component 6. It belongs conceptually to the group of Alternate components (see note 2.A.1) and appears here only for reasons of backward compatibility.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CON.11.9",
                            Type = @"Component",
                            Position = @"CON.11.9",
                            Name = @"Original Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The original text that was available to an automated process or a human before a specific code was assigned.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CON.12",
                            Type = @"Field",
                            Position = @"CON.12",
                            Name = @"Consent Discussion Date/Time",
                            Length = 24,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DTM",
                            DataTypeName = @"Date/Time",
                            TableId = null,
                            TableName = null,
                            Description = @"Identifies the time when consent was discussed with the subject. This should only be specified if this differs from the time the consent decision is made.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CON.13",
                            Type = @"Field",
                            Position = @"CON.13",
                            Name = @"Consent Decision Date/Time",
                            Length = 24,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DTM",
                            DataTypeName = @"Date/Time",
                            TableId = null,
                            TableName = null,
                            Description = @"Identifies the time when the decision to grant/refuse consent was made. In the case of written consent, this is the time the consent form is signed.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CON.14",
                            Type = @"Field",
                            Position = @"CON.14",
                            Name = @"Consent Effective Date/Time",
                            Length = 24,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DTM",
                            DataTypeName = @"Date/Time",
                            TableId = null,
                            TableName = null,
                            Description = @"The time the consent becomes/became effective. This only needs to be specified if the time differs from the Consent Decision Date/Time",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CON.15",
                            Type = @"Field",
                            Position = @"CON.15",
                            Name = @"Consent End Date/Time",
                            Length = 24,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DTM",
                            DataTypeName = @"Date/Time",
                            TableId = null,
                            TableName = null,
                            Description = @"The time the consent becomes ineffective. If not specified, the consent is assumed to be indefinite. For consents relating to information release, the end date/time is the date by which the released information must be returned/destroyed.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CON.16",
                            Type = @"Field",
                            Position = @"CON.16",
                            Name = @"Subject Competence Indicator",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0136",
                            TableName = @"Yes/no indicator",
                            Description = @"Identifies whether the subject was deemed competent to provide consent. Refer to table HL7 table 0136 - Yes/No Indicator .",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CON.17",
                            Type = @"Field",
                            Position = @"CON.17",
                            Name = @"Translator Assistance Indicator",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0136",
                            TableName = @"Yes/no indicator",
                            Description = @"Identifies whether translation was (or will be) required to obtain informed consent from the subject. Refer to table HL7 table 0136 - Yes/No Indicator.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CON.18",
                            Type = @"Field",
                            Position = @"CON.18",
                            Name = @"Language Translated To",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded with Exceptions",
                            TableId = @"0296",
                            TableName = @"Primary Language",
                            Description = @"Identifies the language the consent material must be translated to. Refer to User-Defined Table 0296 - Language Translated Tofor values. This table may be populated with values similar to those that may be found in ISO table 639 - Language Codes.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"CON.18.1",
                            Type = @"Component",
                            Position = @"CON.18.1",
                            Name = @"Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CON.18.2",
                            Type = @"Component",
                            Position = @"CON.18.2",
                            Name = @"Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component contains the descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CON.18.3",
                            Type = @"Component",
                            Position = @"CON.18.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CON.18.4",
                            Type = @"Component",
                            Position = @"CON.18.4",
                            Name = @"Alternate Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"An alternate sequence of characters (the code) that uniquely identifies the item being referenced. Analogous to ""Identifier"" in component 1. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CON.18.5",
                            Type = @"Component",
                            Position = @"CON.18.5",
                            Name = @"Alternate Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. Analogous to ""Text"" in component 2. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CON.18.6",
                            Type = @"Component",
                            Position = @"CON.18.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component. Analogous to Name of Coding System above. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CON.18.7",
                            Type = @"Component",
                            Position = @"CON.18.7",
                            Name = @"Coding System Version Id",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID. If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CON.18.8",
                            Type = @"Component",
                            Position = @"CON.18.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 4-6.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CON.18.9",
                            Type = @"Component",
                            Position = @"CON.18.9",
                            Name = @"Original Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The original text that was available to an automated process or a human before a specific code was assigned.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CON.19",
                            Type = @"Field",
                            Position = @"CON.19",
                            Name = @"Informational Material Supplied Indicator",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0136",
                            TableName = @"Yes/no indicator",
                            Description = @"Identifies whether additional educational or reference material was provided to the subject as part of the consent process. Refer to table HL7 table 0136 - Yes/No Indicator .",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CON.20",
                            Type = @"Field",
                            Position = @"CON.20",
                            Name = @"Consent Bypass Reason",
                            Length = 705,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded with Exceptions",
                            TableId = @"0499",
                            TableName = @"Consent Bypass Reason",
                            Description = @"Identifies why the subjects consent was not sought. This field must be populated when CON-11 - Consent Status is B - Bypassed.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"CON.20.1",
                            Type = @"Component",
                            Position = @"CON.20.1",
                            Name = @"Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CON.20.2",
                            Type = @"Component",
                            Position = @"CON.20.2",
                            Name = @"Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component contains the descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CON.20.3",
                            Type = @"Component",
                            Position = @"CON.20.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CON.20.4",
                            Type = @"Component",
                            Position = @"CON.20.4",
                            Name = @"Alternate Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"An alternate sequence of characters (the code) that uniquely identifies the item being referenced. Analogous to ""Identifier"" in component 1. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CON.20.5",
                            Type = @"Component",
                            Position = @"CON.20.5",
                            Name = @"Alternate Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. Analogous to ""Text"" in component 2. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CON.20.6",
                            Type = @"Component",
                            Position = @"CON.20.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component. Analogous to Name of Coding System above. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CON.20.7",
                            Type = @"Component",
                            Position = @"CON.20.7",
                            Name = @"Coding System Version Id",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID. If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CON.20.8",
                            Type = @"Component",
                            Position = @"CON.20.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 4-6.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CON.20.9",
                            Type = @"Component",
                            Position = @"CON.20.9",
                            Name = @"Original Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The original text that was available to an automated process or a human before a specific code was assigned.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CON.21",
                            Type = @"Field",
                            Position = @"CON.21",
                            Name = @"Consent Disclosure Level",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0500",
                            TableName = @"Consent Disclosure Level",
                            Description = @"Identifies how much information was disclosed to the subject as part of the informed consent process.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CON.22",
                            Type = @"Field",
                            Position = @"CON.22",
                            Name = @"Consent Non-disclosure Reason",
                            Length = 705,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded with Exceptions",
                            TableId = @"0501",
                            TableName = @"Consent Non-Disclosure Reason",
                            Description = @"Identifies why the subject did not receive full disclosure. .",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"CON.22.1",
                            Type = @"Component",
                            Position = @"CON.22.1",
                            Name = @"Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CON.22.2",
                            Type = @"Component",
                            Position = @"CON.22.2",
                            Name = @"Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component contains the descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CON.22.3",
                            Type = @"Component",
                            Position = @"CON.22.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CON.22.4",
                            Type = @"Component",
                            Position = @"CON.22.4",
                            Name = @"Alternate Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"An alternate sequence of characters (the code) that uniquely identifies the item being referenced. Analogous to ""Identifier"" in component 1. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CON.22.5",
                            Type = @"Component",
                            Position = @"CON.22.5",
                            Name = @"Alternate Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. Analogous to ""Text"" in component 2. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CON.22.6",
                            Type = @"Component",
                            Position = @"CON.22.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component. Analogous to Name of Coding System above. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CON.22.7",
                            Type = @"Component",
                            Position = @"CON.22.7",
                            Name = @"Coding System Version Id",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID. If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CON.22.8",
                            Type = @"Component",
                            Position = @"CON.22.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 4-6.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CON.22.9",
                            Type = @"Component",
                            Position = @"CON.22.9",
                            Name = @"Original Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The original text that was available to an automated process or a human before a specific code was assigned.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CON.23",
                            Type = @"Field",
                            Position = @"CON.23",
                            Name = @"Non-subject Consenter Reason",
                            Length = 705,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded with Exceptions",
                            TableId = @"0502",
                            TableName = @"Non-Subject Consenter Reason",
                            Description = @"Identifies why consent was granted by a person other than the subject of the consent.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"CON.23.1",
                            Type = @"Component",
                            Position = @"CON.23.1",
                            Name = @"Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CON.23.2",
                            Type = @"Component",
                            Position = @"CON.23.2",
                            Name = @"Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component contains the descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CON.23.3",
                            Type = @"Component",
                            Position = @"CON.23.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CON.23.4",
                            Type = @"Component",
                            Position = @"CON.23.4",
                            Name = @"Alternate Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"An alternate sequence of characters (the code) that uniquely identifies the item being referenced. Analogous to ""Identifier"" in component 1. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CON.23.5",
                            Type = @"Component",
                            Position = @"CON.23.5",
                            Name = @"Alternate Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. Analogous to ""Text"" in component 2. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CON.23.6",
                            Type = @"Component",
                            Position = @"CON.23.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component. Analogous to Name of Coding System above. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CON.23.7",
                            Type = @"Component",
                            Position = @"CON.23.7",
                            Name = @"Coding System Version Id",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID. If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CON.23.8",
                            Type = @"Component",
                            Position = @"CON.23.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 4-6.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CON.23.9",
                            Type = @"Component",
                            Position = @"CON.23.9",
                            Name = @"Original Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The original text that was available to an automated process or a human before a specific code was assigned.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CON.24",
                            Type = @"Field",
                            Position = @"CON.24",
                            Name = @"Consenter ID",
                            Length = 250,
                            Usage = @"R",
                            Rpt = @"*",
                            DataType = @"XPN",
                            DataTypeName = @"Extended Person Name",
                            TableId = null,
                            TableName = null,
                            Description = @"Identification of the individual(s) who are consenting.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"CON.24.1",
                            Type = @"Component",
                            Position = @"CON.24.1",
                            Name = @"Family Name",
                            Length = 194,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"FN",
                            DataTypeName = @"Family Name",
                            TableId = null,
                            TableName = null,
                            Description = @"This component allows full specification of the surname of a person. Where appropriate, it differentiates the person's own surname from that of the person's partner or spouse, in cases where the person's name may contain elements from either name. It also permits messages to distinguish the surname prefix (such as ""van"" or ""de"") from the surname root. See section 2.A.30, ""FN - family name"".",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"CON.24.1.1",
                            Type = @"SubComponent",
                            Position = @"CON.24.1.1",
                            Name = @"Surname",
                            Length = 50,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"LastName",
                            TableName = @"LastName",
                            Description = @"The atomic element of the person's family name. In most Western usage, this is the person's last name.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CON.24.1.2",
                            Type = @"SubComponent",
                            Position = @"CON.24.1.2",
                            Name = @"Own Surname Prefix",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Internationalization usage for Germanic languages. This component is optional. An example of a <surname prefix> is the ""van"" in ""Ludwig van Beethoven"". Since the <surname prefix> doesn't sort completely alphabetically, it is reasonable to specify it as a separate sub-component of the PN and extended PN data types (XPN and XCN).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CON.24.1.3",
                            Type = @"SubComponent",
                            Position = @"CON.24.1.3",
                            Name = @"Own Surname",
                            Length = 50,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The portion of the surname (in most Western usage, the last name) that is derived from the person's own surname, as distinguished from any portion that is derived from the surname of the person's partner or spouse. This component is optional.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CON.24.1.4",
                            Type = @"SubComponent",
                            Position = @"CON.24.1.4",
                            Name = @"Surname Prefix From Partner/Spouse",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Internationalization usage for Germanic languages. This component is optional. An example of a <surname prefix> is the van in ""Ludwig van Beethoven"". Since the <surname prefix> doesn't sort completely alphabetically, it is reasonable to specify it as a separate sub-component of the PN and extended PN data types (XPN and XCN).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CON.24.1.5",
                            Type = @"SubComponent",
                            Position = @"CON.24.1.5",
                            Name = @"Surname From Partner/Spouse",
                            Length = 50,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The portion of the person's surname (in most Western usage, the last name) that is derived from the surname of the person's partner or spouse, as distinguished from the part derived from the person's own surname. This component is optional.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CON.24.2",
                            Type = @"Component",
                            Position = @"CON.24.2",
                            Name = @"Given Name",
                            Length = 30,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"FirstName",
                            TableName = @"First Name",
                            Description = @"First name.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CON.24.3",
                            Type = @"Component",
                            Position = @"CON.24.3",
                            Name = @"Second And Further Given Names Or Initials Thereof",
                            Length = 30,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Multiple middle names may be included by separating them with spaces.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CON.24.4",
                            Type = @"Component",
                            Position = @"CON.24.4",
                            Name = @"Suffix",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Used to specify a name suffix (e.g., Jr. or III).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CON.24.5",
                            Type = @"Component",
                            Position = @"CON.24.5",
                            Name = @"Prefix",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Used to specify a name prefix (e.g., Dr.).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CON.24.6",
                            Type = @"Component",
                            Position = @"CON.24.6",
                            Name = @"Degree",
                            Length = 6,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0360",
                            TableName = @"Degree/license/certificate",
                            Description = @"Retained for backward compatibility only as of v 2.5. See Professional Suffix component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CON.24.7",
                            Type = @"Component",
                            Position = @"CON.24.7",
                            Name = @"Name Type Code",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0200",
                            TableName = @"Name Type",
                            Description = @"A code that represents the type of name. Refer to HL7 Table 0200 - Name type for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CON.24.8",
                            Type = @"Component",
                            Position = @"CON.24.8",
                            Name = @"Name Representation Code",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0465",
                            TableName = @"Name/address representation",
                            Description = @"Different <name/address types> and representations of the same <name/address> should be described by repeating of this field, with different values of the <name/address type> and/or <name/address representation> component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CON.24.9",
                            Type = @"Component",
                            Position = @"CON.24.9",
                            Name = @"Name Context",
                            Length = 705,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded with Exceptions",
                            TableId = @"0448",
                            TableName = @"Name context",
                            Description = @"This component is used to designate the context in which a name is used. The main use case is in Australian healthcare for indigenous patients who prefer to use different names when attending different healthcare institutions. Another use case occurs in the US where health practitioners can be licensed under slightly different names and the reporting of the correct name is vital for administrative purposes. Refer to User-defined Table 0448 - Name context for suggested values.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"CON.24.9.1",
                            Type = @"SubComponent",
                            Position = @"CON.24.9.1",
                            Name = @"Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CON.24.9.2",
                            Type = @"SubComponent",
                            Position = @"CON.24.9.2",
                            Name = @"Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component contains the descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CON.24.9.3",
                            Type = @"SubComponent",
                            Position = @"CON.24.9.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CON.24.9.4",
                            Type = @"SubComponent",
                            Position = @"CON.24.9.4",
                            Name = @"Alternate Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"An alternate sequence of characters (the code) that uniquely identifies the item being referenced. Analogous to ""Identifier"" in component 1. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CON.24.9.5",
                            Type = @"SubComponent",
                            Position = @"CON.24.9.5",
                            Name = @"Alternate Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. Analogous to ""Text"" in component 2. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CON.24.9.6",
                            Type = @"SubComponent",
                            Position = @"CON.24.9.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component. Analogous to Name of Coding System above. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CON.24.9.7",
                            Type = @"SubComponent",
                            Position = @"CON.24.9.7",
                            Name = @"Coding System Version Id",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID. If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CON.24.9.8",
                            Type = @"SubComponent",
                            Position = @"CON.24.9.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 4-6.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CON.24.9.9",
                            Type = @"SubComponent",
                            Position = @"CON.24.9.9",
                            Name = @"Original Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The original text that was available to an automated process or a human before a specific code was assigned.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CON.24.10",
                            Type = @"Component",
                            Position = @"CON.24.10",
                            Name = @"Name Validity Range",
                            Length = 49,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"DR",
                            DataTypeName = @"Date/Time Range",
                            TableId = null,
                            TableName = null,
                            Description = @"This component cannot be fully expressed. Identified as v 2.4 erratum. Retained for backward compatibility only as of v 2.5. Refer to 2.A.88.12, ""Effective Date"" and 2.A.88.13, ""Expiration Date"" components.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"CON.24.10.1",
                            Type = @"SubComponent",
                            Position = @"CON.24.10.1",
                            Name = @"Range Start Date/Time",
                            Length = 24,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DTM",
                            DataTypeName = @"Date/Time",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component contains the earliest date/time (time stamp) in the specified range.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CON.24.10.2",
                            Type = @"SubComponent",
                            Position = @"CON.24.10.2",
                            Name = @"Range End Date/Time",
                            Length = 24,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DTM",
                            DataTypeName = @"Date/Time",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component contains the latest date/time in the specified range. Note that the DTM (time stamp) data type allows the specification of precision.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CON.24.11",
                            Type = @"Component",
                            Position = @"CON.24.11",
                            Name = @"Name Assembly Order",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0444",
                            TableName = @"Name assembly order",
                            Description = @"A code that represents the preferred display order of the components of this person name. Refer to HL7 0444 - Name assembly order for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CON.24.12",
                            Type = @"Component",
                            Position = @"CON.24.12",
                            Name = @"Effective Date",
                            Length = 24,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DTM",
                            DataTypeName = @"Date/Time",
                            TableId = null,
                            TableName = null,
                            Description = @"The first date, if known, on which the person name is valid and active.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CON.24.13",
                            Type = @"Component",
                            Position = @"CON.24.13",
                            Name = @"Expiration Date",
                            Length = 24,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DTM",
                            DataTypeName = @"Date/Time",
                            TableId = null,
                            TableName = null,
                            Description = @"The last date, if known, on which the person name is valid and active.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CON.24.14",
                            Type = @"Component",
                            Position = @"CON.24.14",
                            Name = @"Professional Suffix",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Used to specify an abbreviation, or a string of abbreviations denoting qualifications that support the persons profession, (e.g., licenses, certificates, degrees, affiliations with professional societies, etc.). The Professional Suffix normally follows the Family Name when the Person Name is used for display purposes. Please note that this component is an unformatted string and is used for display purposes only. Detailed information regarding the contents of Professional Suffix is obtained using appropriate segments in Chapter 15, Personnel Management.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CON.25",
                            Type = @"Field",
                            Position = @"CON.25",
                            Name = @"Relationship to Subject",
                            Length = 100,
                            Usage = @"R",
                            Rpt = @"*",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0548",
                            TableName = @"Signatory’s Relationship to Subject",
                            Description = @"Identification of the relationship of the consenter to the subject.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        };
            }
        }

        public HL7V26SegmentCON(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V26Field setIDCON;

public HL7V26Field SetIDCON
{
    get
    {
        if (setIDCON != null)
        {
            return setIDCON;
        }

        setIDCON = new HL7V26Field
        {
            field = message[@"CON"][1],
            Id = @"CON.1",
            Type = @"Field",
            Position = @"CON.1",
            Name = @"Set ID - CON",
            Length = 4,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"SI",
            DataTypeName = @"Sequence ID",
            TableId = null,
            TableName = null,
            Description = @"This field contains the number that identifies this segment instance within the message. For the first occurrence of the segment, the sequence number shall be one; for the second occurrence, the sequence number shall be two; etc.",
            Sample = @"",
        };

        

        

        

        return setIDCON;
    } 
}
internal HL7V26Field consentType;

public HL7V26Field ConsentType
{
    get
    {
        if (consentType != null)
        {
            return consentType;
        }

        consentType = new HL7V26Field
        {
            field = message[@"CON"][2],
            Id = @"CON.2",
            Type = @"Field",
            Position = @"CON.2",
            Name = @"Consent Type",
            Length = 705,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = @"0496",
            TableName = @"Consent Type",
            Description = @"This field describes what the subject is consenting to, i.e., what type of service, surgical procedure, information access/release or other event. For values see User-Defined Table 0496 - Consent Type.",
            Sample = @"",
        };

        

        

        

        return consentType;
    } 
}
internal HL7V26Field consentFormIDandVersion;

public HL7V26Field ConsentFormIDandVersion
{
    get
    {
        if (consentFormIDandVersion != null)
        {
            return consentFormIDandVersion;
        }

        consentFormIDandVersion = new HL7V26Field
        {
            field = message[@"CON"][3],
            Id = @"CON.3",
            Type = @"Field",
            Position = @"CON.3",
            Name = @"Consent Form ID and Version",
            Length = 40,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"Identifies a specific version of a consent form used to record the consent. A given version of a consent form implies a particular set of wording that appears on the form.",
            Sample = @"",
        };

        

        

        

        return consentFormIDandVersion;
    } 
}
internal HL7V26Field consentFormNumber;

public HL7V26Field ConsentFormNumber
{
    get
    {
        if (consentFormNumber != null)
        {
            return consentFormNumber;
        }

        consentFormNumber = new HL7V26Field
        {
            field = message[@"CON"][4],
            Id = @"CON.4",
            Type = @"Field",
            Position = @"CON.4",
            Name = @"Consent Form Number",
            Length = 427,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"EI",
            DataTypeName = @"Entity Identifier",
            TableId = null,
            TableName = null,
            Description = @"Uniquely identifies a specific recorded consent. This may be the number assigned to an electronic consent, or may be the number on a printed consent form.",
            Sample = @"",
        };

        

        

        

        return consentFormNumber;
    } 
}
internal HL7V26Field consentText;

public HL7V26Field ConsentText
{
    get
    {
        if (consentText != null)
        {
            return consentText;
        }

        consentText = new HL7V26Field
        {
            field = message[@"CON"][5],
            Id = @"CON.5",
            Type = @"Field",
            Position = @"CON.5",
            Name = @"Consent Text",
            Length = 65536,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"FT",
            DataTypeName = @"Formatted Text Data",
            TableId = null,
            TableName = null,
            Description = @"Describes the specific procedures/information releases/events the subject is consenting to.",
            Sample = @"",
        };

        

        

        

        return consentText;
    } 
}
internal HL7V26Field subjectspecificConsentText;

public HL7V26Field SubjectspecificConsentText
{
    get
    {
        if (subjectspecificConsentText != null)
        {
            return subjectspecificConsentText;
        }

        subjectspecificConsentText = new HL7V26Field
        {
            field = message[@"CON"][6],
            Id = @"CON.6",
            Type = @"Field",
            Position = @"CON.6",
            Name = @"Subject-specific Consent Text",
            Length = 65536,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"FT",
            DataTypeName = @"Formatted Text Data",
            TableId = null,
            TableName = null,
            Description = @"Describes any additions or variations to the standard procedures/information releases/events from a standard consent that are applicable to the subject whose consent is sought.",
            Sample = @"",
        };

        

        

        

        return subjectspecificConsentText;
    } 
}
internal HL7V26Field consentBackgroundInformation;

public HL7V26Field ConsentBackgroundInformation
{
    get
    {
        if (consentBackgroundInformation != null)
        {
            return consentBackgroundInformation;
        }

        consentBackgroundInformation = new HL7V26Field
        {
            field = message[@"CON"][7],
            Id = @"CON.7",
            Type = @"Field",
            Position = @"CON.7",
            Name = @"Consent Background Information",
            Length = 65535,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"FT",
            DataTypeName = @"Formatted Text Data",
            TableId = null,
            TableName = null,
            Description = @"Describes any additional information relating to the procedure/information release/event that needs to be understood by the subject for informed consent. May include the reason for the service, the expected benefit, risks, etc.",
            Sample = @"",
        };

        

        

        

        return consentBackgroundInformation;
    } 
}
internal HL7V26Field subjectspecificConsentBackgroundText;

public HL7V26Field SubjectspecificConsentBackgroundText
{
    get
    {
        if (subjectspecificConsentBackgroundText != null)
        {
            return subjectspecificConsentBackgroundText;
        }

        subjectspecificConsentBackgroundText = new HL7V26Field
        {
            field = message[@"CON"][8],
            Id = @"CON.8",
            Type = @"Field",
            Position = @"CON.8",
            Name = @"Subject-specific Consent Background Text",
            Length = 65535,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"FT",
            DataTypeName = @"Formatted Text Data",
            TableId = null,
            TableName = null,
            Description = @"Describes any additions or variations to the standard additional information that needs to be understood by the patient for informed consent. May include a description of benefits and risks that are specific to the subject from whom consent is sought. May also include an indication that there are no subject-specific risks/benefits.",
            Sample = @"",
        };

        

        

        

        return subjectspecificConsentBackgroundText;
    } 
}
internal HL7V26Field consenterimposedlimitations;

public HL7V26Field Consenterimposedlimitations
{
    get
    {
        if (consenterimposedlimitations != null)
        {
            return consenterimposedlimitations;
        }

        consenterimposedlimitations = new HL7V26Field
        {
            field = message[@"CON"][9],
            Id = @"CON.9",
            Type = @"Field",
            Position = @"CON.9",
            Name = @"Consenter-imposed limitations",
            Length = 65535,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"FT",
            DataTypeName = @"Formatted Text Data",
            TableId = null,
            TableName = null,
            Description = @"Describes any restrictions or limitations placed on their consent by the subject.",
            Sample = @"",
        };

        

        

        

        return consenterimposedlimitations;
    } 
}
internal HL7V26Field consentMode;

public HL7V26Field ConsentMode
{
    get
    {
        if (consentMode != null)
        {
            return consentMode;
        }

        consentMode = new HL7V26Field
        {
            field = message[@"CON"][10],
            Id = @"CON.10",
            Type = @"Field",
            Position = @"CON.10",
            Name = @"Consent Mode",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CNE",
            DataTypeName = @"Coded with No Exceptions",
            TableId = @"0497",
            TableName = @"Consent Mode",
            Description = @"The method in which a subject provides consent.",
            Sample = @"",
        };

        

        

        

        return consentMode;
    } 
}
internal HL7V26Field consentStatus;

public HL7V26Field ConsentStatus
{
    get
    {
        if (consentStatus != null)
        {
            return consentStatus;
        }

        consentStatus = new HL7V26Field
        {
            field = message[@"CON"][11],
            Id = @"CON.11",
            Type = @"Field",
            Position = @"CON.11",
            Name = @"Consent Status",
            Length = 2,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CNE",
            DataTypeName = @"Coded with No Exceptions",
            TableId = @"0498",
            TableName = @"Consent Status",
            Description = @"Indicates whether consent has been sought and granted.",
            Sample = @"",
        };

        

        

        

        return consentStatus;
    } 
}
internal HL7V26Field consentDiscussionDateTime;

public HL7V26Field ConsentDiscussionDateTime
{
    get
    {
        if (consentDiscussionDateTime != null)
        {
            return consentDiscussionDateTime;
        }

        consentDiscussionDateTime = new HL7V26Field
        {
            field = message[@"CON"][12],
            Id = @"CON.12",
            Type = @"Field",
            Position = @"CON.12",
            Name = @"Consent Discussion Date/Time",
            Length = 24,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DTM",
            DataTypeName = @"Date/Time",
            TableId = null,
            TableName = null,
            Description = @"Identifies the time when consent was discussed with the subject. This should only be specified if this differs from the time the consent decision is made.",
            Sample = @"",
        };

        

        

        

        return consentDiscussionDateTime;
    } 
}
internal HL7V26Field consentDecisionDateTime;

public HL7V26Field ConsentDecisionDateTime
{
    get
    {
        if (consentDecisionDateTime != null)
        {
            return consentDecisionDateTime;
        }

        consentDecisionDateTime = new HL7V26Field
        {
            field = message[@"CON"][13],
            Id = @"CON.13",
            Type = @"Field",
            Position = @"CON.13",
            Name = @"Consent Decision Date/Time",
            Length = 24,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DTM",
            DataTypeName = @"Date/Time",
            TableId = null,
            TableName = null,
            Description = @"Identifies the time when the decision to grant/refuse consent was made. In the case of written consent, this is the time the consent form is signed.",
            Sample = @"",
        };

        

        

        

        return consentDecisionDateTime;
    } 
}
internal HL7V26Field consentEffectiveDateTime;

public HL7V26Field ConsentEffectiveDateTime
{
    get
    {
        if (consentEffectiveDateTime != null)
        {
            return consentEffectiveDateTime;
        }

        consentEffectiveDateTime = new HL7V26Field
        {
            field = message[@"CON"][14],
            Id = @"CON.14",
            Type = @"Field",
            Position = @"CON.14",
            Name = @"Consent Effective Date/Time",
            Length = 24,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DTM",
            DataTypeName = @"Date/Time",
            TableId = null,
            TableName = null,
            Description = @"The time the consent becomes/became effective. This only needs to be specified if the time differs from the Consent Decision Date/Time",
            Sample = @"",
        };

        

        

        

        return consentEffectiveDateTime;
    } 
}
internal HL7V26Field consentEndDateTime;

public HL7V26Field ConsentEndDateTime
{
    get
    {
        if (consentEndDateTime != null)
        {
            return consentEndDateTime;
        }

        consentEndDateTime = new HL7V26Field
        {
            field = message[@"CON"][15],
            Id = @"CON.15",
            Type = @"Field",
            Position = @"CON.15",
            Name = @"Consent End Date/Time",
            Length = 24,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DTM",
            DataTypeName = @"Date/Time",
            TableId = null,
            TableName = null,
            Description = @"The time the consent becomes ineffective. If not specified, the consent is assumed to be indefinite. For consents relating to information release, the end date/time is the date by which the released information must be returned/destroyed.",
            Sample = @"",
        };

        

        

        

        return consentEndDateTime;
    } 
}
internal HL7V26Field subjectCompetenceIndicator;

public HL7V26Field SubjectCompetenceIndicator
{
    get
    {
        if (subjectCompetenceIndicator != null)
        {
            return subjectCompetenceIndicator;
        }

        subjectCompetenceIndicator = new HL7V26Field
        {
            field = message[@"CON"][16],
            Id = @"CON.16",
            Type = @"Field",
            Position = @"CON.16",
            Name = @"Subject Competence Indicator",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0136",
            TableName = @"Yes/no indicator",
            Description = @"Identifies whether the subject was deemed competent to provide consent. Refer to table HL7 table 0136 - Yes/No Indicator .",
            Sample = @"",
        };

        

        

        

        return subjectCompetenceIndicator;
    } 
}
internal HL7V26Field translatorAssistanceIndicator;

public HL7V26Field TranslatorAssistanceIndicator
{
    get
    {
        if (translatorAssistanceIndicator != null)
        {
            return translatorAssistanceIndicator;
        }

        translatorAssistanceIndicator = new HL7V26Field
        {
            field = message[@"CON"][17],
            Id = @"CON.17",
            Type = @"Field",
            Position = @"CON.17",
            Name = @"Translator Assistance Indicator",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0136",
            TableName = @"Yes/no indicator",
            Description = @"Identifies whether translation was (or will be) required to obtain informed consent from the subject. Refer to table HL7 table 0136 - Yes/No Indicator.",
            Sample = @"",
        };

        

        

        

        return translatorAssistanceIndicator;
    } 
}
internal HL7V26Field languageTranslatedTo;

public HL7V26Field LanguageTranslatedTo
{
    get
    {
        if (languageTranslatedTo != null)
        {
            return languageTranslatedTo;
        }

        languageTranslatedTo = new HL7V26Field
        {
            field = message[@"CON"][18],
            Id = @"CON.18",
            Type = @"Field",
            Position = @"CON.18",
            Name = @"Language Translated To",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = @"0296",
            TableName = @"Primary Language",
            Description = @"Identifies the language the consent material must be translated to. Refer to User-Defined Table 0296 - Language Translated Tofor values. This table may be populated with values similar to those that may be found in ISO table 639 - Language Codes.",
            Sample = @"",
        };

        

        

        

        return languageTranslatedTo;
    } 
}
internal HL7V26Field informationalMaterialSuppliedIndicator;

public HL7V26Field InformationalMaterialSuppliedIndicator
{
    get
    {
        if (informationalMaterialSuppliedIndicator != null)
        {
            return informationalMaterialSuppliedIndicator;
        }

        informationalMaterialSuppliedIndicator = new HL7V26Field
        {
            field = message[@"CON"][19],
            Id = @"CON.19",
            Type = @"Field",
            Position = @"CON.19",
            Name = @"Informational Material Supplied Indicator",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0136",
            TableName = @"Yes/no indicator",
            Description = @"Identifies whether additional educational or reference material was provided to the subject as part of the consent process. Refer to table HL7 table 0136 - Yes/No Indicator .",
            Sample = @"",
        };

        

        

        

        return informationalMaterialSuppliedIndicator;
    } 
}
internal HL7V26Field consentBypassReason;

public HL7V26Field ConsentBypassReason
{
    get
    {
        if (consentBypassReason != null)
        {
            return consentBypassReason;
        }

        consentBypassReason = new HL7V26Field
        {
            field = message[@"CON"][20],
            Id = @"CON.20",
            Type = @"Field",
            Position = @"CON.20",
            Name = @"Consent Bypass Reason",
            Length = 705,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = @"0499",
            TableName = @"Consent Bypass Reason",
            Description = @"Identifies why the subjects consent was not sought. This field must be populated when CON-11 - Consent Status is B - Bypassed.",
            Sample = @"",
        };

        

        

        

        return consentBypassReason;
    } 
}
internal HL7V26Field consentDisclosureLevel;

public HL7V26Field ConsentDisclosureLevel
{
    get
    {
        if (consentDisclosureLevel != null)
        {
            return consentDisclosureLevel;
        }

        consentDisclosureLevel = new HL7V26Field
        {
            field = message[@"CON"][21],
            Id = @"CON.21",
            Type = @"Field",
            Position = @"CON.21",
            Name = @"Consent Disclosure Level",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0500",
            TableName = @"Consent Disclosure Level",
            Description = @"Identifies how much information was disclosed to the subject as part of the informed consent process.",
            Sample = @"",
        };

        

        

        

        return consentDisclosureLevel;
    } 
}
internal HL7V26Field consentNondisclosureReason;

public HL7V26Field ConsentNondisclosureReason
{
    get
    {
        if (consentNondisclosureReason != null)
        {
            return consentNondisclosureReason;
        }

        consentNondisclosureReason = new HL7V26Field
        {
            field = message[@"CON"][22],
            Id = @"CON.22",
            Type = @"Field",
            Position = @"CON.22",
            Name = @"Consent Non-disclosure Reason",
            Length = 705,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = @"0501",
            TableName = @"Consent Non-Disclosure Reason",
            Description = @"Identifies why the subject did not receive full disclosure. .",
            Sample = @"",
        };

        

        

        

        return consentNondisclosureReason;
    } 
}
internal HL7V26Field nonsubjectConsenterReason;

public HL7V26Field NonsubjectConsenterReason
{
    get
    {
        if (nonsubjectConsenterReason != null)
        {
            return nonsubjectConsenterReason;
        }

        nonsubjectConsenterReason = new HL7V26Field
        {
            field = message[@"CON"][23],
            Id = @"CON.23",
            Type = @"Field",
            Position = @"CON.23",
            Name = @"Non-subject Consenter Reason",
            Length = 705,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = @"0502",
            TableName = @"Non-Subject Consenter Reason",
            Description = @"Identifies why consent was granted by a person other than the subject of the consent.",
            Sample = @"",
        };

        

        

        

        return nonsubjectConsenterReason;
    } 
}
internal HL7V26Field consenterID;

public HL7V26Field ConsenterID
{
    get
    {
        if (consenterID != null)
        {
            return consenterID;
        }

        consenterID = new HL7V26Field
        {
            field = message[@"CON"][24],
            Id = @"CON.24",
            Type = @"Field",
            Position = @"CON.24",
            Name = @"Consenter ID",
            Length = 250,
            Usage = @"R",
            Rpt = @"*",
            DataType = @"XPN",
            DataTypeName = @"Extended Person Name",
            TableId = null,
            TableName = null,
            Description = @"Identification of the individual(s) who are consenting.",
            Sample = @"",
        };

        

        

        

        return consenterID;
    } 
}
internal HL7V26Field relationshiptoSubject;

public HL7V26Field RelationshiptoSubject
{
    get
    {
        if (relationshiptoSubject != null)
        {
            return relationshiptoSubject;
        }

        relationshiptoSubject = new HL7V26Field
        {
            field = message[@"CON"][25],
            Id = @"CON.25",
            Type = @"Field",
            Position = @"CON.25",
            Name = @"Relationship to Subject",
            Length = 100,
            Usage = @"R",
            Rpt = @"*",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0548",
            TableName = @"Signatory’s Relationship to Subject",
            Description = @"Identification of the relationship of the consenter to the subject.",
            Sample = @"",
        };

        

        

        

        return relationshiptoSubject;
    } 
}

    }
}
