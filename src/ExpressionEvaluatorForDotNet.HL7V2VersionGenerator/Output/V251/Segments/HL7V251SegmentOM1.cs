using System.Linq;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251SegmentOM1
    {
        public readonly HL7V2Message message;

        public string Id { get { return @"OM1"; } }

        public string SegmentId { get { return @"OM1"; } }
        
        public string LongName { get { return @"General Segment"; } }
        
        public string Description { get { return @"The OM1 segment contains the attributes that apply to the definition of most observations.  This segment also contains the field attributes that specify what additional segments might also be defined for this observation. "; } }
        
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
                            Id = @"OM1.1",
                            Type = @"Field",
                            Position = @"OM1.1",
                            Name = @"Sequence Number - Test/Observation Master File",
                            Length = 4,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the first OM1 segment in a message and is described as 1, the second as 2, and so on.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.2",
                            Type = @"Field",
                            Position = @"OM1.2",
                            Name = @"Producer's Service/Test/Observation ID",
                            Length = 250,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the producers usual or preferred identification of the test or observation. Only three components should be included: <ID code>^<service text name/description>^<source list of code> . All components should be non-null. The source list may be any of those included in ASTM Tables 3 and 5, or a local code.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"OM1.2.1",
                            Type = @"Component",
                            Position = @"OM1.2.1",
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
                            Id = @"OM1.2.2",
                            Type = @"Component",
                            Position = @"OM1.2.2",
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
                            Id = @"OM1.2.3",
                            Type = @"Component",
                            Position = @"OM1.2.3",
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
                            Id = @"OM1.2.4",
                            Type = @"Component",
                            Position = @"OM1.2.4",
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
                            Id = @"OM1.2.5",
                            Type = @"Component",
                            Position = @"OM1.2.5",
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
                            Id = @"OM1.2.6",
                            Type = @"Component",
                            Position = @"OM1.2.6",
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
                            Id = @"OM1.3",
                            Type = @"Field",
                            Position = @"OM1.3",
                            Name = @"Permitted Data Types",
                            Length = 12,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0125",
                            TableName = @"Value type",
                            Description = @"This field contains the allowed data type(s) for this observation. The codes are the same as those listed for OBX (a given observation may, under different circumstances, take on different data types). Indeed, under limited circumstances, an observation can consist of one or more fragments of different data types. When an observation may have more than one data type, e.g., coded (CE) and numeric (NM) the allowable data types should be separated by repeat delimiters. Refer to HL7 table 0125 - Value type for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.4",
                            Type = @"Field",
                            Position = @"OM1.4",
                            Name = @"Specimen Required",
                            Length = 1,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0136",
                            TableName = @"Yes/no indicator",
                            Description = @"This field contains a flag indicating whether or not at least one specimen is required for the service/test/observation. Refer to HL7 table 0136 - Yes/no indicator.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.5",
                            Type = @"Field",
                            Position = @"OM1.5",
                            Name = @"Producer ID",
                            Length = 250,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This field uniquely identifies the service producing the observation described in this segment. Three components should be included: an identifying code, the name of the producer, and the identity of the coding system (e.g., 323-5678^Acme Special Lab^MC). The identity of the coding system will usually be MC (Medicare provider number or HIBCC site codes) in the United States. Each country may want to specify its preferred coding system and define a coding system ID to identify it.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"OM1.5.1",
                            Type = @"Component",
                            Position = @"OM1.5.1",
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
                            Id = @"OM1.5.2",
                            Type = @"Component",
                            Position = @"OM1.5.2",
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
                            Id = @"OM1.5.3",
                            Type = @"Component",
                            Position = @"OM1.5.3",
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
                            Id = @"OM1.5.4",
                            Type = @"Component",
                            Position = @"OM1.5.4",
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
                            Id = @"OM1.5.5",
                            Type = @"Component",
                            Position = @"OM1.5.5",
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
                            Id = @"OM1.5.6",
                            Type = @"Component",
                            Position = @"OM1.5.6",
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
                            Id = @"OM1.6",
                            Type = @"Field",
                            Position = @"OM1.6",
                            Name = @"Observation Description",
                            Length = 200,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TX",
                            DataTypeName = @"Text Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains a text description of this observation.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.7",
                            Type = @"Field",
                            Position = @"OM1.7",
                            Name = @"Other Service/Test/Observation IDs for the Observation",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains all alias codes/identifiers for this observation. If more than one alias code needs to be specified, multiple three-component, CE-format entries (<code 1>^<name 1>^<code system 1>) may be given, separated by repeat delimiters. An observation may have as many names/codes as are applicable (e.g., ICD9, ACR-NEMA, SNOMED, and READ). We encourage the inclusion of as many different codes as may apply to assist cross-system mapping of terminology. All components of each triplet should be non-null (that is, names and coding system IDs within the CE data type are required in addition to codes). The source list may be any of those included in ASTM Tables 3 and 5.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"OM1.7.1",
                            Type = @"Component",
                            Position = @"OM1.7.1",
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
                            Id = @"OM1.7.2",
                            Type = @"Component",
                            Position = @"OM1.7.2",
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
                            Id = @"OM1.7.3",
                            Type = @"Component",
                            Position = @"OM1.7.3",
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
                            Id = @"OM1.7.4",
                            Type = @"Component",
                            Position = @"OM1.7.4",
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
                            Id = @"OM1.7.5",
                            Type = @"Component",
                            Position = @"OM1.7.5",
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
                            Id = @"OM1.7.6",
                            Type = @"Component",
                            Position = @"OM1.7.6",
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
                            Id = @"OM1.8",
                            Type = @"Field",
                            Position = @"OM1.8",
                            Name = @"Other Names",
                            Length = 200,
                            Usage = @"R",
                            Rpt = @"*",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains any test aliases or synonyms for the name in the context of the ordering service. These are alternative names, not associated with a particular coding system, by which the battery, test, or observation (e.g., measurement, test, diagnostic study, treatment, etc.) is known to users of the system. Multiple names in this list are separated by repeat delimiters.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.9",
                            Type = @"Field",
                            Position = @"OM1.9",
                            Name = @"Preferred Report Name for the Observation",
                            Length = 30,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the preferred name for reporting the observation or battery. The name can contain up to 30 characters (including blanks). It is the preferred name for columnar reports that require a maximum name size.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.10",
                            Type = @"Field",
                            Position = @"OM1.10",
                            Name = @"Preferred Short Name or Mnemonic for Observation",
                            Length = 8,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the name that can be used in space-limited reports (e.g., specimen labels) to identify the observation for the convenience of human readers. The name can contain up to eight characters.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.11",
                            Type = @"Field",
                            Position = @"OM1.11",
                            Name = @"Preferred Long Name for the Observation",
                            Length = 200,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the fully-specified name for the observation or battery. It may include the full (unabbreviated) multiple-word names and contain up to 200 characters. It should be as scientifically precise as possible.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.12",
                            Type = @"Field",
                            Position = @"OM1.12",
                            Name = @"Orderability",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0136",
                            TableName = @"Yes/no indicator",
                            Description = @"This field indicates whether or not a service/test/observation is an orderable code. Refer to HL7 table 0136 - Yes/no indicator for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.13",
                            Type = @"Field",
                            Position = @"OM1.13",
                            Name = @"Identity of Instrument Used to Perform this Study",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"When applicable, this field identifies the instrument or device that is used to generate this observation or battery. Examples are the automated instrument in the laboratory, the imaging device and model number in radiology, and the automatic blood pressure machine on the ward. The instrument is specified as a coded entry in anticipation that these identifiers could be specified as codes. Initially, we expect that most of the information about devices will be transmitted as text in the second component of the CE identifier. If more than one kind of instrument is used, all of them can be listed, separated by repeat delimiters.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"OM1.13.1",
                            Type = @"Component",
                            Position = @"OM1.13.1",
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
                            Id = @"OM1.13.2",
                            Type = @"Component",
                            Position = @"OM1.13.2",
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
                            Id = @"OM1.13.3",
                            Type = @"Component",
                            Position = @"OM1.13.3",
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
                            Id = @"OM1.13.4",
                            Type = @"Component",
                            Position = @"OM1.13.4",
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
                            Id = @"OM1.13.5",
                            Type = @"Component",
                            Position = @"OM1.13.5",
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
                            Id = @"OM1.13.6",
                            Type = @"Component",
                            Position = @"OM1.13.6",
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
                            Id = @"OM1.14",
                            Type = @"Field",
                            Position = @"OM1.14",
                            Name = @"Coded Representation of Method",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the method(s) used to produce the observation and should be recorded in a computer-understandable (coded) form here. This field should report the same method(s) reported in narrative in the following field. More than one method may be listed, but only if they produce results that are clinically indistinguishable. Multiple methods must be separated by repeat delimiters.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"OM1.14.1",
                            Type = @"Component",
                            Position = @"OM1.14.1",
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
                            Id = @"OM1.14.2",
                            Type = @"Component",
                            Position = @"OM1.14.2",
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
                            Id = @"OM1.14.3",
                            Type = @"Component",
                            Position = @"OM1.14.3",
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
                            Id = @"OM1.14.4",
                            Type = @"Component",
                            Position = @"OM1.14.4",
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
                            Id = @"OM1.14.5",
                            Type = @"Component",
                            Position = @"OM1.14.5",
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
                            Id = @"OM1.14.6",
                            Type = @"Component",
                            Position = @"OM1.14.6",
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
                            Id = @"OM1.15",
                            Type = @"Field",
                            Position = @"OM1.15",
                            Name = @"Portable Device Indicator",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0136",
                            TableName = @"Yes/no indicator",
                            Description = @"This field indicates whether or not a portable device may be used for the service/test/observation. Refer to HL7 table 0136 - Yes/no indicator for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.16",
                            Type = @"Field",
                            Position = @"OM1.16",
                            Name = @"Observation Producing Department/Section",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This field permits the sorting of observation orders and values by the providing services department/section. It provides ""source oriented"" reporting when required. The codes for this field should be taken from ASTM Table 15 (Diagnostic Service Codes). Free text may be used instead of these codes, but in that case, they should be recorded as the second ""component"" of the field to distinguish them from the standard codes. Multiple codes in this field are separated by repeat delimiters.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"OM1.16.1",
                            Type = @"Component",
                            Position = @"OM1.16.1",
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
                            Id = @"OM1.16.2",
                            Type = @"Component",
                            Position = @"OM1.16.2",
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
                            Id = @"OM1.16.3",
                            Type = @"Component",
                            Position = @"OM1.16.3",
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
                            Id = @"OM1.16.4",
                            Type = @"Component",
                            Position = @"OM1.16.4",
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
                            Id = @"OM1.16.5",
                            Type = @"Component",
                            Position = @"OM1.16.5",
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
                            Id = @"OM1.16.6",
                            Type = @"Component",
                            Position = @"OM1.16.6",
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
                            Id = @"OM1.17",
                            Type = @"Field",
                            Position = @"OM1.17",
                            Name = @"Telephone Number of Section",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"XTN",
                            DataTypeName = @"Extended Telecommunication Number",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the telephone number for calling responsible parties in this section to ask results or advice about the use of this test.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"OM1.17.1",
                            Type = @"Component",
                            Position = @"OM1.17.1",
                            Name = @"Telephone Number",
                            Length = 199,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"PhoneNumber",
                            TableName = @"Phone Number",
                            Description = @"This component has been retained for backward compatibility only as of version 2.3. 

Specifies the telephone number in a predetermined format that includes an optional extension, beeper number and comment.

Format: [NNN] [(999)]999-9999 [X99999] [B99999] [C any text] ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.17.2",
                            Type = @"Component",
                            Position = @"OM1.17.2",
                            Name = @"Telecommunication Use Code",
                            Length = 3,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0201",
                            TableName = @"Telecommunication use code",
                            Description = @"A code that represents a specific use of a telecommunicationnumber. Refer to HL7 Table 0201 - Telecommunication use code for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.17.3",
                            Type = @"Component",
                            Position = @"OM1.17.3",
                            Name = @"Telecommunication Equipment Type",
                            Length = 8,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0202",
                            TableName = @"Telecommunication equipment type",
                            Description = @"A code that represents the type of telecommunicationequipment. Refer to HL7 Table 0202 - Telecommunication equipment type for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.17.4",
                            Type = @"Component",
                            Position = @"OM1.17.4",
                            Name = @"Email Address",
                            Length = 199,
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
                            Id = @"OM1.17.5",
                            Type = @"Component",
                            Position = @"OM1.17.5",
                            Name = @"Country Code",
                            Length = 3,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.17.6",
                            Type = @"Component",
                            Position = @"OM1.17.6",
                            Name = @"Area/City Code",
                            Length = 5,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.17.7",
                            Type = @"Component",
                            Position = @"OM1.17.7",
                            Name = @"Local Number",
                            Length = 9,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.17.8",
                            Type = @"Component",
                            Position = @"OM1.17.8",
                            Name = @"Extension",
                            Length = 5,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"Contains comments with respect to the telephone number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.17.9",
                            Type = @"Component",
                            Position = @"OM1.17.9",
                            Name = @"Any Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The characters established within a companys internal telephone system network used as a prefix to the Extension component for internal dialing. Note that the use of Extension Prefix requires that the Extension component be valued and that digits, as well as special characters (e.g., *, #) may be used.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.17.10",
                            Type = @"Component",
                            Position = @"OM1.17.10",
                            Name = @"Extension Prefix",
                            Length = 4,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The characters established within a companys internal telephone system used in place of the (external) telephone number to facilitate calling because its length is shorter than that of the telephone number. Note that digits, as well as special characters (e.g., *, #) may be used.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.17.11",
                            Type = @"Component",
                            Position = @"OM1.17.11",
                            Name = @"Speed Dial Code",
                            Length = 6,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"An expression of the telephone number as an unparsible string.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.17.12",
                            Type = @"Component",
                            Position = @"OM1.17.12",
                            Name = @"Unformatted Telephone Number",
                            Length = 199,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @" An expression of the telephone number as an unparsible string

Example: |^^^^^^^^^^^1-800-Dentist| ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.18",
                            Type = @"Field",
                            Position = @"OM1.18",
                            Name = @"Nature of Service/Test/Observation",
                            Length = 1,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0174",
                            TableName = @"Nature of Service/Test/Observation",
                            Description = @"This field indicates whether the definition entry identifies a test battery, an entire functional procedure or study, a single test value (observation), multiple test batteries or functional procedures as an orderable unit (profile), or a single test value (observation) calculated from other independent observations. Refer to User-defined Table 0174 - Nature of service/test/observation for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.19",
                            Type = @"Field",
                            Position = @"OM1.19",
                            Name = @"Report Subheader",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains an optional string that defines the preferred header under which this observation should be listed on a standard display. For example, if the test is hemoglobin, this string might be ""Complete blood count."" It is represented as a coded data type so that a battery can be a header. Only the description part of the string may be included in case the subheader does not have an associated code. When a series of observations is displayed according to the sort order given below, the subheader that groups those observations is presented whenever the subheader changes.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"OM1.19.1",
                            Type = @"Component",
                            Position = @"OM1.19.1",
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
                            Id = @"OM1.19.2",
                            Type = @"Component",
                            Position = @"OM1.19.2",
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
                            Id = @"OM1.19.3",
                            Type = @"Component",
                            Position = @"OM1.19.3",
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
                            Id = @"OM1.19.4",
                            Type = @"Component",
                            Position = @"OM1.19.4",
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
                            Id = @"OM1.19.5",
                            Type = @"Component",
                            Position = @"OM1.19.5",
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
                            Id = @"OM1.19.6",
                            Type = @"Component",
                            Position = @"OM1.19.6",
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
                            Id = @"OM1.20",
                            Type = @"Field",
                            Position = @"OM1.20",
                            Name = @"Report Display Order",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains an optional string that defines the sort order in which this observation is presented in a standard report or display that contains the many observations.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.21",
                            Type = @"Field",
                            Position = @"OM1.21",
                            Name = @"Date/Time Stamp for any change in Definition for the Observation",
                            Length = 26,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the date and time that the last of any field change was made and in the hosts record corresponding to the OM1 segment.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"OM1.21.1",
                            Type = @"Component",
                            Position = @"OM1.21.1",
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
                            Id = @"OM1.21.2",
                            Type = @"Component",
                            Position = @"OM1.21.2",
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
                            Id = @"OM1.22",
                            Type = @"Field",
                            Position = @"OM1.22",
                            Name = @"Effective Date/Time of Change",
                            Length = 26,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the date and time of the last change in the test procedure that would make previous results incompatible with new results, e.g., the last time that normal reference range or units changed for a numeric test/observation.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"OM1.22.1",
                            Type = @"Component",
                            Position = @"OM1.22.1",
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
                            Id = @"OM1.22.2",
                            Type = @"Component",
                            Position = @"OM1.22.2",
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
                            Id = @"OM1.23",
                            Type = @"Field",
                            Position = @"OM1.23",
                            Name = @"Typical Turn-Around Time",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the typical processing time for single test/observation. This field indicates the time from the delivery of a specimen or transport of a patient to a diagnostic service and the completion of the study. It includes the usual waiting time. The units are measured in minutes.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.24",
                            Type = @"Field",
                            Position = @"OM1.24",
                            Name = @"Processing Time",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the usual length of time (in minutes) between the start of a test process and its completion.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.25",
                            Type = @"Field",
                            Position = @"OM1.25",
                            Name = @"Processing Priority",
                            Length = 40,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0168",
                            TableName = @"Processing priority",
                            Description = @"This field contains one or more available priorities for performing the observation or test. This is the priority that can be placed in TQ1-9 - Priority. Multiple priorities may be given, separated by repeat delimiters. For example, S~A~R~P~T indicates that the test may be ordered using codes S, A, R, P, or T. Refer to HL7 table 0168 - Processing priority for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.26",
                            Type = @"Field",
                            Position = @"OM1.26",
                            Name = @"Reporting Priority",
                            Length = 5,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0169",
                            TableName = @"Reporting priority",
                            Description = @"This field contains the available priorities reporting the test results when the user is asked to specify the reporting priority independent of the processing priority. Refer to HL7 Table 0169 - Reporting priority for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.27",
                            Type = @"Field",
                            Position = @"OM1.27",
                            Name = @"Outside Site(s) Where Observation may be Performed ",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the identification(s) of the outside service(s) that produce(s) the observation. The format of this CE field uses the producer ID (as defined in OM1-5 - Producer ID ) and the name of the service separated by component delimiters. An example is |39221^ACME lab^MC|... If multiple services are used, they should be separated by repeat delimiter(s).",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"OM1.27.1",
                            Type = @"Component",
                            Position = @"OM1.27.1",
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
                            Id = @"OM1.27.2",
                            Type = @"Component",
                            Position = @"OM1.27.2",
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
                            Id = @"OM1.27.3",
                            Type = @"Component",
                            Position = @"OM1.27.3",
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
                            Id = @"OM1.27.4",
                            Type = @"Component",
                            Position = @"OM1.27.4",
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
                            Id = @"OM1.27.5",
                            Type = @"Component",
                            Position = @"OM1.27.5",
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
                            Id = @"OM1.27.6",
                            Type = @"Component",
                            Position = @"OM1.27.6",
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
                            Id = @"OM1.28",
                            Type = @"Field",
                            Position = @"OM1.28",
                            Name = @"Address of Outside Site(s)",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"XAD",
                            DataTypeName = @"Extended Address",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the address of the outside services listed in OM1-28 - Address of Outside Site(s) where observation may be performed. If multiple services are recorded in that field, their addresses should be separated by repeat delimiters, and the addresses should appear in the same order in which the services appear in the preceding field.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"OM1.28.1",
                            Type = @"Component",
                            Position = @"OM1.28.1",
                            Name = @"Street Address",
                            Length = 184,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"SAD",
                            DataTypeName = @"Street Address",
                            TableId = @"Street",
                            TableName = @"Street",
                            Description = null,
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"OM1.28.1.1",
                            Type = @"SubComponent",
                            Position = @"OM1.28.1.1",
                            Name = @"Street Or Mailing Address",
                            Length = 120,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component specifies the street or mailing address of a person or institution. When referencing an institution, this first component is used to specify the institution name. When used in connection with a person, this component specifies the first line of the address.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.28.1.2",
                            Type = @"SubComponent",
                            Position = @"OM1.28.1.2",
                            Name = @"Street Name",
                            Length = 50,
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
                            Id = @"OM1.28.1.3",
                            Type = @"SubComponent",
                            Position = @"OM1.28.1.3",
                            Name = @"Dwelling Number",
                            Length = 12,
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
                            Id = @"OM1.28.2",
                            Type = @"Component",
                            Position = @"OM1.28.2",
                            Name = @"Other Designation",
                            Length = 120,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Second line of address. In US usage, it qualifies address. Examples: Suite 555 or Fourth Floor. When referencing an institution, this component specifies the street address.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.28.3",
                            Type = @"Component",
                            Position = @"OM1.28.3",
                            Name = @"City",
                            Length = 50,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"City",
                            TableName = @"City",
                            Description = @"This component specifies the city, or district or place where the addressee is located depending upon the national convention for formatting addresses for postal usage.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.28.4",
                            Type = @"Component",
                            Position = @"OM1.28.4",
                            Name = @"State Or Province",
                            Length = 50,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"State",
                            TableName = @"State",
                            Description = @"This component specifies the state or province where the addressee is located. State or province should be represented by the official postal service codes for that country.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.28.5",
                            Type = @"Component",
                            Position = @"OM1.28.5",
                            Name = @"Zip Or Postal Code",
                            Length = 12,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"ZipCode",
                            TableName = @"Zip Code",
                            Description = @"This component specifies the zip or postal code where the addressee is located. Zip or postal codes should be represented by the official codes for that country. In the US, the zip code takes the form 99999[-9999], while the Canadian postal code takes the form A9A9A9, and the Australian Postcode takes the form 9999.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.28.6",
                            Type = @"Component",
                            Position = @"OM1.28.6",
                            Name = @"Country",
                            Length = 3,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0399",
                            TableName = @"Country code",
                            Description = @"This component specifies the country where the addressee is locatedHL7 specifies that the 3-character (alphabetic) form of ISO 3166 be used for the country code. Refer to HL7 Table 0399 - Country code in section 2.15.9.17 for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.28.7",
                            Type = @"Component",
                            Position = @"OM1.28.7",
                            Name = @"Address Type",
                            Length = 3,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0190",
                            TableName = @"Address type",
                            Description = @"This component specifies the kind or type of address. Refer to HL7 Table 0190 - Address type for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.28.8",
                            Type = @"Component",
                            Position = @"OM1.28.8",
                            Name = @"Other Geographic Designation",
                            Length = 50,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component specifies any other geographic designation. It includes county, bioregion, SMSA, etc.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.28.9",
                            Type = @"Component",
                            Position = @"OM1.28.9",
                            Name = @"County/Parish Code",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0289",
                            TableName = @"County/parish",
                            Description = @"A code that represents the county in which the specified address resides. User-defined Table 0289 - County/parish is used as the HL7 identifier for the user-defined table of values for this component. When this component is used to represent the county (or parish), component 8 <other geographic designation> should not duplicate it (i.e., the use of <other geographic designation> to represent the county is allowed only for the purpose of backward compatibility, and should be discouraged in this and future versions of HL7).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.28.10",
                            Type = @"Component",
                            Position = @"OM1.28.10",
                            Name = @"Census Tract",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0288",
                            TableName = @"Census tract",
                            Description = @"A code that represents the census tract in which the specified address resides. User-defined Table 0288 - Census tract is used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.28.11",
                            Type = @"Component",
                            Position = @"OM1.28.11",
                            Name = @"Address Representation Code",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0465",
                            TableName = @"Name/address representation",
                            Description = @"Different <name/address types> and representations of the same name/address should be described by repeating of this field, with different values of the <name/address type> and/or <name/address representation> component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.28.12",
                            Type = @"Component",
                            Position = @"OM1.28.12",
                            Name = @"Address Validity Range",
                            Length = 53,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"DR",
                            DataTypeName = @"Date/Time Range",
                            TableId = null,
                            TableName = null,
                            Description = @"This component cannot be fully expressed. Identified as v 2.4 erratum. Retained for backward compatibility only as of v 2.5. Refer to Effective Date and Expiration Date components.

This component contains the start and end date/times, which define the period in which this address was valid. ",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"OM1.28.12.1",
                            Type = @"SubComponent",
                            Position = @"OM1.28.12.1",
                            Name = @"Range Start Date/Time",
                            Length = 26,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component contains the earliest date/time (time stamp) in the specified range.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"OM1.28.12.1",
                            Type = @"SubComponent",
                            Position = @"OM1.28.12.1",
                            Name = @"Time",
                            Length = 24,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"DTM",
                            DataTypeName = @"Date/Time",
                            TableId = null,
                            TableName = null,
                            Description = @"The point in time.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.28.12.2",
                            Type = @"SubComponent",
                            Position = @"OM1.28.12.2",
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
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.28.12.2",
                            Type = @"SubComponent",
                            Position = @"OM1.28.12.2",
                            Name = @"Range End Date/Time",
                            Length = 26,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component contains the latest date/time in the specified range. Note that the TS (time stamp) data type allows the specification of precision.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"OM1.28.12.1",
                            Type = @"SubComponent",
                            Position = @"OM1.28.12.1",
                            Name = @"Time",
                            Length = 24,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"DTM",
                            DataTypeName = @"Date/Time",
                            TableId = null,
                            TableName = null,
                            Description = @"The point in time.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.28.12.2",
                            Type = @"SubComponent",
                            Position = @"OM1.28.12.2",
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
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.28.13",
                            Type = @"Component",
                            Position = @"OM1.28.13",
                            Name = @"Effective Date",
                            Length = 26,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"The first date, if known, on which the address is valid and active.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"OM1.28.13.1",
                            Type = @"SubComponent",
                            Position = @"OM1.28.13.1",
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
                            Id = @"OM1.28.13.2",
                            Type = @"SubComponent",
                            Position = @"OM1.28.13.2",
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
                            Id = @"OM1.28.14",
                            Type = @"Component",
                            Position = @"OM1.28.14",
                            Name = @"Expiration Date",
                            Length = 26,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"The last date, if known, on which the address is valid and active.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"OM1.28.14.1",
                            Type = @"SubComponent",
                            Position = @"OM1.28.14.1",
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
                            Id = @"OM1.28.14.2",
                            Type = @"SubComponent",
                            Position = @"OM1.28.14.2",
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
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.29",
                            Type = @"Field",
                            Position = @"OM1.29",
                            Name = @"Phone Number of Outside Site",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"XTN",
                            DataTypeName = @"Extended Telecommunication Number",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the telephone number of the outside site.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"OM1.29.1",
                            Type = @"Component",
                            Position = @"OM1.29.1",
                            Name = @"Telephone Number",
                            Length = 199,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"PhoneNumber",
                            TableName = @"Phone Number",
                            Description = @"This component has been retained for backward compatibility only as of version 2.3. 

Specifies the telephone number in a predetermined format that includes an optional extension, beeper number and comment.

Format: [NNN] [(999)]999-9999 [X99999] [B99999] [C any text] ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.29.2",
                            Type = @"Component",
                            Position = @"OM1.29.2",
                            Name = @"Telecommunication Use Code",
                            Length = 3,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0201",
                            TableName = @"Telecommunication use code",
                            Description = @"A code that represents a specific use of a telecommunicationnumber. Refer to HL7 Table 0201 - Telecommunication use code for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.29.3",
                            Type = @"Component",
                            Position = @"OM1.29.3",
                            Name = @"Telecommunication Equipment Type",
                            Length = 8,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0202",
                            TableName = @"Telecommunication equipment type",
                            Description = @"A code that represents the type of telecommunicationequipment. Refer to HL7 Table 0202 - Telecommunication equipment type for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.29.4",
                            Type = @"Component",
                            Position = @"OM1.29.4",
                            Name = @"Email Address",
                            Length = 199,
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
                            Id = @"OM1.29.5",
                            Type = @"Component",
                            Position = @"OM1.29.5",
                            Name = @"Country Code",
                            Length = 3,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.29.6",
                            Type = @"Component",
                            Position = @"OM1.29.6",
                            Name = @"Area/City Code",
                            Length = 5,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.29.7",
                            Type = @"Component",
                            Position = @"OM1.29.7",
                            Name = @"Local Number",
                            Length = 9,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.29.8",
                            Type = @"Component",
                            Position = @"OM1.29.8",
                            Name = @"Extension",
                            Length = 5,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"Contains comments with respect to the telephone number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.29.9",
                            Type = @"Component",
                            Position = @"OM1.29.9",
                            Name = @"Any Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The characters established within a companys internal telephone system network used as a prefix to the Extension component for internal dialing. Note that the use of Extension Prefix requires that the Extension component be valued and that digits, as well as special characters (e.g., *, #) may be used.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.29.10",
                            Type = @"Component",
                            Position = @"OM1.29.10",
                            Name = @"Extension Prefix",
                            Length = 4,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The characters established within a companys internal telephone system used in place of the (external) telephone number to facilitate calling because its length is shorter than that of the telephone number. Note that digits, as well as special characters (e.g., *, #) may be used.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.29.11",
                            Type = @"Component",
                            Position = @"OM1.29.11",
                            Name = @"Speed Dial Code",
                            Length = 6,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"An expression of the telephone number as an unparsible string.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.29.12",
                            Type = @"Component",
                            Position = @"OM1.29.12",
                            Name = @"Unformatted Telephone Number",
                            Length = 199,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @" An expression of the telephone number as an unparsible string

Example: |^^^^^^^^^^^1-800-Dentist| ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.30",
                            Type = @"Field",
                            Position = @"OM1.30",
                            Name = @"Confidentiality Code",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded with Exceptions",
                            TableId = @"0177",
                            TableName = @"Confidentiality code",
                            Description = @"This field contains the degree to which special confidentiality protection should be applied to the observation. For example, a tighter control may be applied to an HIV test than to a CBC. Refer to User-defined Table 0177 - Confidentiality code for suggested values.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"OM1.30.1",
                            Type = @"Component",
                            Position = @"OM1.30.1",
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
                            Id = @"OM1.30.2",
                            Type = @"Component",
                            Position = @"OM1.30.2",
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
                            Id = @"OM1.30.3",
                            Type = @"Component",
                            Position = @"OM1.30.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the identifier component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.30.4",
                            Type = @"Component",
                            Position = @"OM1.30.4",
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
                            Id = @"OM1.30.5",
                            Type = @"Component",
                            Position = @"OM1.30.5",
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
                            Id = @"OM1.30.6",
                            Type = @"Component",
                            Position = @"OM1.30.6",
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
                            Id = @"OM1.30.7",
                            Type = @"Component",
                            Position = @"OM1.30.7",
                            Name = @"Coding System Version Id",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This is the version ID for the coding system identified by components 1-3. It belongs conceptually to the group of component 1-3 and appears here only for reasons of backward compatibility.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.30.8",
                            Type = @"Component",
                            Position = @"OM1.30.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This is the version ID for the coding system identified by components 4-6. It belongs conceptually to the group of alternate components (See usage note in section introduction) and appears here only for reasons of backward compatibility.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.30.9",
                            Type = @"Component",
                            Position = @"OM1.30.9",
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
                            Id = @"OM1.31",
                            Type = @"Field",
                            Position = @"OM1.31",
                            Name = @"Observations Required to Interpret the Observation",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the list of variables that the diagnostic service needs to interpret the results of an ordered study. The observations specified here should be sent to the diagnostic service as OBX segments along with the order (OBR) segment.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"OM1.31.1",
                            Type = @"Component",
                            Position = @"OM1.31.1",
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
                            Id = @"OM1.31.2",
                            Type = @"Component",
                            Position = @"OM1.31.2",
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
                            Id = @"OM1.31.3",
                            Type = @"Component",
                            Position = @"OM1.31.3",
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
                            Id = @"OM1.31.4",
                            Type = @"Component",
                            Position = @"OM1.31.4",
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
                            Id = @"OM1.31.5",
                            Type = @"Component",
                            Position = @"OM1.31.5",
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
                            Id = @"OM1.31.6",
                            Type = @"Component",
                            Position = @"OM1.31.6",
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
                            Id = @"OM1.32",
                            Type = @"Field",
                            Position = @"OM1.32",
                            Name = @"Interpretation of Observations",
                            Length = 65536,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TX",
                            DataTypeName = @"Text Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the clinical information about interpreting test results. Examples are the conditions (drugs) that may cause false abnormals, and the information about the sensitivity and specificity of the test for diagnoses.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.33",
                            Type = @"Field",
                            Position = @"OM1.33",
                            Name = @"Contraindications to Observations",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the diagnosis or problem for which the test is a contraindication or of possible danger (e.g., pacemaker, pregnancy, diabetes). For example, if the test identified in OM1 was an intravenous pyelogram, this field would include warnings about the use of contrast media in diabetes. The contraindication diagnoses should be separated by repeat delimiters.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"OM1.33.1",
                            Type = @"Component",
                            Position = @"OM1.33.1",
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
                            Id = @"OM1.33.2",
                            Type = @"Component",
                            Position = @"OM1.33.2",
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
                            Id = @"OM1.33.3",
                            Type = @"Component",
                            Position = @"OM1.33.3",
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
                            Id = @"OM1.33.4",
                            Type = @"Component",
                            Position = @"OM1.33.4",
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
                            Id = @"OM1.33.5",
                            Type = @"Component",
                            Position = @"OM1.33.5",
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
                            Id = @"OM1.33.6",
                            Type = @"Component",
                            Position = @"OM1.33.6",
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
                            Id = @"OM1.34",
                            Type = @"Field",
                            Position = @"OM1.34",
                            Name = @"Reflex Tests/Observations",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the test names as type CE (i.e., <code>^<text name>^<coding system>) that may be ordered automatically by the diagnostic service, depending on the results obtained from the ordered battery. A screening CBC might trigger a reticulocyte count if the Hgb is less than 12. Multiple reflex tests are separated by repeat delimiters.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"OM1.34.1",
                            Type = @"Component",
                            Position = @"OM1.34.1",
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
                            Id = @"OM1.34.2",
                            Type = @"Component",
                            Position = @"OM1.34.2",
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
                            Id = @"OM1.34.3",
                            Type = @"Component",
                            Position = @"OM1.34.3",
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
                            Id = @"OM1.34.4",
                            Type = @"Component",
                            Position = @"OM1.34.4",
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
                            Id = @"OM1.34.5",
                            Type = @"Component",
                            Position = @"OM1.34.5",
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
                            Id = @"OM1.34.6",
                            Type = @"Component",
                            Position = @"OM1.34.6",
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
                            Id = @"OM1.35",
                            Type = @"Field",
                            Position = @"OM1.35",
                            Name = @"Rules that Trigger Reflex Testing",
                            Length = 80,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TX",
                            DataTypeName = @"Text Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the rules that trigger the reflex tests listed above. If multiple reflex tests are listed in OM1-34 - Reflex Text/Observations separated by repeat delimiters, a set of corresponding rules will be included in this section. The first rule will apply to the first test, the second to the second test, and so on.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.36",
                            Type = @"Field",
                            Position = @"OM1.36",
                            Name = @"Fixed Canned Message",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the codes and a fixed text message that is always associated with an abbreviation. The field may include multiple messages separated by repeat delimiters.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"OM1.36.1",
                            Type = @"Component",
                            Position = @"OM1.36.1",
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
                            Id = @"OM1.36.2",
                            Type = @"Component",
                            Position = @"OM1.36.2",
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
                            Id = @"OM1.36.3",
                            Type = @"Component",
                            Position = @"OM1.36.3",
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
                            Id = @"OM1.36.4",
                            Type = @"Component",
                            Position = @"OM1.36.4",
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
                            Id = @"OM1.36.5",
                            Type = @"Component",
                            Position = @"OM1.36.5",
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
                            Id = @"OM1.36.6",
                            Type = @"Component",
                            Position = @"OM1.36.6",
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
                            Id = @"OM1.37",
                            Type = @"Field",
                            Position = @"OM1.37",
                            Name = @"Patient Preparation",
                            Length = 200,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TX",
                            DataTypeName = @"Text Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the tests or observations that require special patient preparation, diet, or medications. For GI contrast studies, this field would contain the pretest diet, e.g., low residue for two days, NPO before study, and the preferred purgatives. Each separate med, diet, or preparation should be delimited by a repeat delimiter. Separate each requirement by a repeat delimiter. Example for a sigmoidectomy:",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.38",
                            Type = @"Field",
                            Position = @"OM1.38",
                            Name = @"Procedure Medication",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the treatments that may be needed as part of the procedure. Examples are radioactive iodine for a thyroid screen, and methacholine for a methacholine spirometry challenge. This field should be identified as a CE data type.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"OM1.38.1",
                            Type = @"Component",
                            Position = @"OM1.38.1",
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
                            Id = @"OM1.38.2",
                            Type = @"Component",
                            Position = @"OM1.38.2",
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
                            Id = @"OM1.38.3",
                            Type = @"Component",
                            Position = @"OM1.38.3",
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
                            Id = @"OM1.38.4",
                            Type = @"Component",
                            Position = @"OM1.38.4",
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
                            Id = @"OM1.38.5",
                            Type = @"Component",
                            Position = @"OM1.38.5",
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
                            Id = @"OM1.38.6",
                            Type = @"Component",
                            Position = @"OM1.38.6",
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
                            Id = @"OM1.39",
                            Type = @"Field",
                            Position = @"OM1.39",
                            Name = @"Factors that may Affect the Observation",
                            Length = 200,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TX",
                            DataTypeName = @"Text Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the text description of the foods, diagnoses, drugs, or other conditions that may influence the interpretation of the observation. Information about the direction of the effect, and any recommendation about altering the diet, conditions, or drug before initiating the test observation.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.40",
                            Type = @"Field",
                            Position = @"OM1.40",
                            Name = @"Service/Test/Observation Performance Schedule",
                            Length = 60,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the diagnostic studies/tests that are performed only at certain times during the course of a work day or work week. This field indicates the maximum interval between successive test performances (the test may actually be performed more frequently). If necessary, multiple codes may be given, separated by repeat delimiters. The use of multiple codes indicates that the test is performed at multiple concurrent intervals. For example, Q6H indicates that the test is performed at least once every 6 hours around the clock. QJ1 indicates that the test is performed at least every week on Mondays. QAM~QPM indicates that the test is performed at least once every morning and every evening. QJ1~QJ3~QJ5 indicates that the test is performed at least every week on Mondays, Wednesdays, and Fridays. C indicates that the test is performed continuously, 7 days per week.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.41",
                            Type = @"Field",
                            Position = @"OM1.41",
                            Name = @"Description of Test Methods",
                            Length = 65536,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TX",
                            DataTypeName = @"Text Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the text description of the methods used to perform the text and generate the observations. Bibliographic citations may be included.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.42",
                            Type = @"Field",
                            Position = @"OM1.42",
                            Name = @"Kind of Quantity Observed",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0254",
                            TableName = @"Kind of quantity",
                            Description = @"This optional attribute describes the underlying kind of property represented by this observation.  This attribute distinguishes concentrations from total amounts, molar concentrations from mass concentrations, partial pressures from colors, and so forth.  These are discussed more fully in the LOINC Users’ Manual.  They are derived from the approach described in 1995 edition of the IUPAC Silver Book.2 These distinctions are used in IUPAC and LOINC standard codes.  Defined categories are listed in HL7 table 0254 - Kind of quantity. ",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"OM1.42.1",
                            Type = @"Component",
                            Position = @"OM1.42.1",
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
                            Id = @"OM1.42.2",
                            Type = @"Component",
                            Position = @"OM1.42.2",
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
                            Id = @"OM1.42.3",
                            Type = @"Component",
                            Position = @"OM1.42.3",
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
                            Id = @"OM1.42.4",
                            Type = @"Component",
                            Position = @"OM1.42.4",
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
                            Id = @"OM1.42.5",
                            Type = @"Component",
                            Position = @"OM1.42.5",
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
                            Id = @"OM1.42.6",
                            Type = @"Component",
                            Position = @"OM1.42.6",
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
                            Id = @"OM1.43",
                            Type = @"Field",
                            Position = @"OM1.43",
                            Name = @"Point Versus Interval",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0255",
                            TableName = @"Duration categories",
                            Description = @"This optional attribute allows master files to classify observations as measuring the patients state at a point in time (e.g., spot urines, random urines, serum potassium), or averaged over a interval of time (e.g., concentration, total amount, or clearance over a 24-hour collection). Interval measures most often apply to urine and stool specimens (e.g., 24-hour urines, 3-day stool fats). They also apply to clinical measurements such as urine outputs, which are reported as shift totals and 24-hour totals, and event counts on physiologic monitors such as the number of PVCs on a 24-hour Holter monitor.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"OM1.43.1",
                            Type = @"Component",
                            Position = @"OM1.43.1",
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
                            Id = @"OM1.43.2",
                            Type = @"Component",
                            Position = @"OM1.43.2",
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
                            Id = @"OM1.43.3",
                            Type = @"Component",
                            Position = @"OM1.43.3",
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
                            Id = @"OM1.43.4",
                            Type = @"Component",
                            Position = @"OM1.43.4",
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
                            Id = @"OM1.43.5",
                            Type = @"Component",
                            Position = @"OM1.43.5",
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
                            Id = @"OM1.43.6",
                            Type = @"Component",
                            Position = @"OM1.43.6",
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
                            Id = @"OM1.44",
                            Type = @"Field",
                            Position = @"OM1.44",
                            Name = @"Challenge Information",
                            Length = 200,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TX",
                            DataTypeName = @"Text Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Definition:  This optional attribute provides information for classifying observations by the challenge component of the test, if a challenge does speciate the observation.  For example, distinguishing tests that have a challenge component in database. There co-ascribes the physiologic or drug challenge that is intrinsic to the measurement. To identify, for example, tests that include a glucose challenge.   

To construct this text string, use the following template.  (Note:  This field is not constructed of formally defined components; it is a free text field.  Component delimiters are not used and it is not necessary to supply placeholders if some ""components"" are not used.) 

The time delay follows the syntax: n<S|M|H|D|W> where n is a number (possibly a decimal); S denotes seconds; M denotes minutes; H denotes hours; D denotes days; and W denotes weeks.  The time delay can be preceded by a ‘greater than’ (>) sign, e.g. >4H. 

HL7 Table 0256 - Time delay post challenge lists possible values for time delay. 

For drug peak and trough measures the nature of the substance challenged is the same as the analyte name, and need not be included.  
We denote the route of the challenge via abbreviations for medication routes (see HL7 table 0162 - Route of administration).  An oral route of administration would be denoted by ""PO,"" an intravenous route by ""IV.""  

Details of the drug dose, time the dose was given, route of administration, etc., would be noted in separate OBX, and would have corresponding master observation definitions stored in the observation master file map to different records stored in the master file segments contained in the drug level message.

The nature of a physiologic (non-drug) challenge may also be specified, using the terms in HL7 Table 0257 - Nature of challenge. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM1.45",
                            Type = @"Field",
                            Position = @"OM1.45",
                            Name = @"Relationship Modifier",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0258",
                            TableName = @"Relationship modifier",
                            Description = @"This optional attribute provides a mechanism for classifying observations according to the subject, in relation to the patient whose results might be stored with as ""patient"" data. It is standard practice, for example, to report values for controls, donors, and blood product units as well as the patients own values, and store them in the patients record. (This may not be the best way to model such information, but it is the way it is usually reported.) This should be valued when two values (e.g., one for patient and one for a blood product unit) could otherwise be confused.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"OM1.45.1",
                            Type = @"Component",
                            Position = @"OM1.45.1",
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
                            Id = @"OM1.45.2",
                            Type = @"Component",
                            Position = @"OM1.45.2",
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
                            Id = @"OM1.45.3",
                            Type = @"Component",
                            Position = @"OM1.45.3",
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
                            Id = @"OM1.45.4",
                            Type = @"Component",
                            Position = @"OM1.45.4",
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
                            Id = @"OM1.45.5",
                            Type = @"Component",
                            Position = @"OM1.45.5",
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
                            Id = @"OM1.45.6",
                            Type = @"Component",
                            Position = @"OM1.45.6",
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
                            Id = @"OM1.46",
                            Type = @"Field",
                            Position = @"OM1.46",
                            Name = @"Target Anatomic Site Of Test",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This optional attribute formally indicates the site of the observation (to make it easy for a system to find all tests related to one anatomic site). It can be used to classify the observation by target site of the examination. For example, ""heart"" might be recorded as the target of the electrocardiogram, cardiac echo, and thallium exercise test. This attribute would be applicable to most imaging and electro-physiologic examinations. The SNOMED topology axis is an example of a coding system for anatomic sites. User-defined tables may also apply here.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"OM1.46.1",
                            Type = @"Component",
                            Position = @"OM1.46.1",
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
                            Id = @"OM1.46.2",
                            Type = @"Component",
                            Position = @"OM1.46.2",
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
                            Id = @"OM1.46.3",
                            Type = @"Component",
                            Position = @"OM1.46.3",
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
                            Id = @"OM1.46.4",
                            Type = @"Component",
                            Position = @"OM1.46.4",
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
                            Id = @"OM1.46.5",
                            Type = @"Component",
                            Position = @"OM1.46.5",
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
                            Id = @"OM1.46.6",
                            Type = @"Component",
                            Position = @"OM1.46.6",
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
                            Id = @"OM1.47",
                            Type = @"Field",
                            Position = @"OM1.47",
                            Name = @"Modality Of Imaging Measurement",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0259",
                            TableName = @"Modality",
                            Description = @"This optional attribute describes the modality used to classify the observations, e.g., radiograph, ultrasound, CT scan, NMR, etc. This attribute is especially important for imaging studies. Refer to User-defined Table 0259 - Modality for suggested values; they are adopted from DICOM C.7.3.1.1.1 Modality. If these are used, the code source ID would be DCM.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"OM1.47.1",
                            Type = @"Component",
                            Position = @"OM1.47.1",
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
                            Id = @"OM1.47.2",
                            Type = @"Component",
                            Position = @"OM1.47.2",
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
                            Id = @"OM1.47.3",
                            Type = @"Component",
                            Position = @"OM1.47.3",
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
                            Id = @"OM1.47.4",
                            Type = @"Component",
                            Position = @"OM1.47.4",
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
                            Id = @"OM1.47.5",
                            Type = @"Component",
                            Position = @"OM1.47.5",
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
                            Id = @"OM1.47.6",
                            Type = @"Component",
                            Position = @"OM1.47.6",
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
                        };
            }
        }

        public HL7V251SegmentOM1(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V251Field sequenceNumberTestObservationMasterFile;

public HL7V251Field SequenceNumberTestObservationMasterFile
{
    get
    {
        if (sequenceNumberTestObservationMasterFile != null)
        {
            return sequenceNumberTestObservationMasterFile;
        }

        sequenceNumberTestObservationMasterFile = new HL7V251Field
        {
            field = message[@"OM1"][1],
            Id = @"OM1.1",
            Type = @"Field",
            Position = @"OM1.1",
            Name = @"Sequence Number - Test/Observation Master File",
            Length = 4,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the first OM1 segment in a message and is described as 1, the second as 2, and so on.",
            Sample = @"",
        };

        

        

        

        return sequenceNumberTestObservationMasterFile;
    } 
}
internal HL7V251Field producer'sServiceTestObservationID;

public HL7V251Field Producer'sServiceTestObservationID
{
    get
    {
        if (producer'sServiceTestObservationID != null)
        {
            return producer'sServiceTestObservationID;
        }

        producer'sServiceTestObservationID = new HL7V251Field
        {
            field = message[@"OM1"][2],
            Id = @"OM1.2",
            Type = @"Field",
            Position = @"OM1.2",
            Name = @"Producer's Service/Test/Observation ID",
            Length = 250,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains the producers usual or preferred identification of the test or observation. Only three components should be included: <ID code>^<service text name/description>^<source list of code> . All components should be non-null. The source list may be any of those included in ASTM Tables 3 and 5, or a local code.",
            Sample = @"",
        };

        

        

        

        return producer'sServiceTestObservationID;
    } 
}
internal HL7V251Field permittedDataTypes;

public HL7V251Field PermittedDataTypes
{
    get
    {
        if (permittedDataTypes != null)
        {
            return permittedDataTypes;
        }

        permittedDataTypes = new HL7V251Field
        {
            field = message[@"OM1"][3],
            Id = @"OM1.3",
            Type = @"Field",
            Position = @"OM1.3",
            Name = @"Permitted Data Types",
            Length = 12,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0125",
            TableName = @"Value type",
            Description = @"This field contains the allowed data type(s) for this observation. The codes are the same as those listed for OBX (a given observation may, under different circumstances, take on different data types). Indeed, under limited circumstances, an observation can consist of one or more fragments of different data types. When an observation may have more than one data type, e.g., coded (CE) and numeric (NM) the allowable data types should be separated by repeat delimiters. Refer to HL7 table 0125 - Value type for valid values.",
            Sample = @"",
        };

        

        

        

        return permittedDataTypes;
    } 
}
internal HL7V251Field specimenRequired;

public HL7V251Field SpecimenRequired
{
    get
    {
        if (specimenRequired != null)
        {
            return specimenRequired;
        }

        specimenRequired = new HL7V251Field
        {
            field = message[@"OM1"][4],
            Id = @"OM1.4",
            Type = @"Field",
            Position = @"OM1.4",
            Name = @"Specimen Required",
            Length = 1,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0136",
            TableName = @"Yes/no indicator",
            Description = @"This field contains a flag indicating whether or not at least one specimen is required for the service/test/observation. Refer to HL7 table 0136 - Yes/no indicator.",
            Sample = @"",
        };

        

        

        

        return specimenRequired;
    } 
}
internal HL7V251Field producerID;

public HL7V251Field ProducerID
{
    get
    {
        if (producerID != null)
        {
            return producerID;
        }

        producerID = new HL7V251Field
        {
            field = message[@"OM1"][5],
            Id = @"OM1.5",
            Type = @"Field",
            Position = @"OM1.5",
            Name = @"Producer ID",
            Length = 250,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field uniquely identifies the service producing the observation described in this segment. Three components should be included: an identifying code, the name of the producer, and the identity of the coding system (e.g., 323-5678^Acme Special Lab^MC). The identity of the coding system will usually be MC (Medicare provider number or HIBCC site codes) in the United States. Each country may want to specify its preferred coding system and define a coding system ID to identify it.",
            Sample = @"",
        };

        

        

        

        return producerID;
    } 
}
internal HL7V251Field observationDescription;

public HL7V251Field ObservationDescription
{
    get
    {
        if (observationDescription != null)
        {
            return observationDescription;
        }

        observationDescription = new HL7V251Field
        {
            field = message[@"OM1"][6],
            Id = @"OM1.6",
            Type = @"Field",
            Position = @"OM1.6",
            Name = @"Observation Description",
            Length = 200,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TX",
            DataTypeName = @"Text Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains a text description of this observation.",
            Sample = @"",
        };

        

        

        

        return observationDescription;
    } 
}
internal HL7V251Field otherServiceTestObservationIDsfortheObservation;

public HL7V251Field OtherServiceTestObservationIDsfortheObservation
{
    get
    {
        if (otherServiceTestObservationIDsfortheObservation != null)
        {
            return otherServiceTestObservationIDsfortheObservation;
        }

        otherServiceTestObservationIDsfortheObservation = new HL7V251Field
        {
            field = message[@"OM1"][7],
            Id = @"OM1.7",
            Type = @"Field",
            Position = @"OM1.7",
            Name = @"Other Service/Test/Observation IDs for the Observation",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains all alias codes/identifiers for this observation. If more than one alias code needs to be specified, multiple three-component, CE-format entries (<code 1>^<name 1>^<code system 1>) may be given, separated by repeat delimiters. An observation may have as many names/codes as are applicable (e.g., ICD9, ACR-NEMA, SNOMED, and READ). We encourage the inclusion of as many different codes as may apply to assist cross-system mapping of terminology. All components of each triplet should be non-null (that is, names and coding system IDs within the CE data type are required in addition to codes). The source list may be any of those included in ASTM Tables 3 and 5.",
            Sample = @"",
        };

        

        

        

        return otherServiceTestObservationIDsfortheObservation;
    } 
}
internal HL7V251Field otherNames;

public HL7V251Field OtherNames
{
    get
    {
        if (otherNames != null)
        {
            return otherNames;
        }

        otherNames = new HL7V251Field
        {
            field = message[@"OM1"][8],
            Id = @"OM1.8",
            Type = @"Field",
            Position = @"OM1.8",
            Name = @"Other Names",
            Length = 200,
            Usage = @"R",
            Rpt = @"*",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains any test aliases or synonyms for the name in the context of the ordering service. These are alternative names, not associated with a particular coding system, by which the battery, test, or observation (e.g., measurement, test, diagnostic study, treatment, etc.) is known to users of the system. Multiple names in this list are separated by repeat delimiters.",
            Sample = @"",
        };

        

        

        

        return otherNames;
    } 
}
internal HL7V251Field preferredReportNamefortheObservation;

public HL7V251Field PreferredReportNamefortheObservation
{
    get
    {
        if (preferredReportNamefortheObservation != null)
        {
            return preferredReportNamefortheObservation;
        }

        preferredReportNamefortheObservation = new HL7V251Field
        {
            field = message[@"OM1"][9],
            Id = @"OM1.9",
            Type = @"Field",
            Position = @"OM1.9",
            Name = @"Preferred Report Name for the Observation",
            Length = 30,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the preferred name for reporting the observation or battery. The name can contain up to 30 characters (including blanks). It is the preferred name for columnar reports that require a maximum name size.",
            Sample = @"",
        };

        

        

        

        return preferredReportNamefortheObservation;
    } 
}
internal HL7V251Field preferredShortNameorMnemonicforObservation;

public HL7V251Field PreferredShortNameorMnemonicforObservation
{
    get
    {
        if (preferredShortNameorMnemonicforObservation != null)
        {
            return preferredShortNameorMnemonicforObservation;
        }

        preferredShortNameorMnemonicforObservation = new HL7V251Field
        {
            field = message[@"OM1"][10],
            Id = @"OM1.10",
            Type = @"Field",
            Position = @"OM1.10",
            Name = @"Preferred Short Name or Mnemonic for Observation",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the name that can be used in space-limited reports (e.g., specimen labels) to identify the observation for the convenience of human readers. The name can contain up to eight characters.",
            Sample = @"",
        };

        

        

        

        return preferredShortNameorMnemonicforObservation;
    } 
}
internal HL7V251Field preferredLongNamefortheObservation;

public HL7V251Field PreferredLongNamefortheObservation
{
    get
    {
        if (preferredLongNamefortheObservation != null)
        {
            return preferredLongNamefortheObservation;
        }

        preferredLongNamefortheObservation = new HL7V251Field
        {
            field = message[@"OM1"][11],
            Id = @"OM1.11",
            Type = @"Field",
            Position = @"OM1.11",
            Name = @"Preferred Long Name for the Observation",
            Length = 200,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the fully-specified name for the observation or battery. It may include the full (unabbreviated) multiple-word names and contain up to 200 characters. It should be as scientifically precise as possible.",
            Sample = @"",
        };

        

        

        

        return preferredLongNamefortheObservation;
    } 
}
internal HL7V251Field orderability;

public HL7V251Field Orderability
{
    get
    {
        if (orderability != null)
        {
            return orderability;
        }

        orderability = new HL7V251Field
        {
            field = message[@"OM1"][12],
            Id = @"OM1.12",
            Type = @"Field",
            Position = @"OM1.12",
            Name = @"Orderability",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0136",
            TableName = @"Yes/no indicator",
            Description = @"This field indicates whether or not a service/test/observation is an orderable code. Refer to HL7 table 0136 - Yes/no indicator for valid values.",
            Sample = @"",
        };

        

        

        

        return orderability;
    } 
}
internal HL7V251Field identityofInstrumentUsedtoPerformthisStudy;

public HL7V251Field IdentityofInstrumentUsedtoPerformthisStudy
{
    get
    {
        if (identityofInstrumentUsedtoPerformthisStudy != null)
        {
            return identityofInstrumentUsedtoPerformthisStudy;
        }

        identityofInstrumentUsedtoPerformthisStudy = new HL7V251Field
        {
            field = message[@"OM1"][13],
            Id = @"OM1.13",
            Type = @"Field",
            Position = @"OM1.13",
            Name = @"Identity of Instrument Used to Perform this Study",
            Length = 250,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"When applicable, this field identifies the instrument or device that is used to generate this observation or battery. Examples are the automated instrument in the laboratory, the imaging device and model number in radiology, and the automatic blood pressure machine on the ward. The instrument is specified as a coded entry in anticipation that these identifiers could be specified as codes. Initially, we expect that most of the information about devices will be transmitted as text in the second component of the CE identifier. If more than one kind of instrument is used, all of them can be listed, separated by repeat delimiters.",
            Sample = @"",
        };

        

        

        

        return identityofInstrumentUsedtoPerformthisStudy;
    } 
}
internal HL7V251Field codedRepresentationofMethod;

public HL7V251Field CodedRepresentationofMethod
{
    get
    {
        if (codedRepresentationofMethod != null)
        {
            return codedRepresentationofMethod;
        }

        codedRepresentationofMethod = new HL7V251Field
        {
            field = message[@"OM1"][14],
            Id = @"OM1.14",
            Type = @"Field",
            Position = @"OM1.14",
            Name = @"Coded Representation of Method",
            Length = 250,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains the method(s) used to produce the observation and should be recorded in a computer-understandable (coded) form here. This field should report the same method(s) reported in narrative in the following field. More than one method may be listed, but only if they produce results that are clinically indistinguishable. Multiple methods must be separated by repeat delimiters.",
            Sample = @"",
        };

        

        

        

        return codedRepresentationofMethod;
    } 
}
internal HL7V251Field portableDeviceIndicator;

public HL7V251Field PortableDeviceIndicator
{
    get
    {
        if (portableDeviceIndicator != null)
        {
            return portableDeviceIndicator;
        }

        portableDeviceIndicator = new HL7V251Field
        {
            field = message[@"OM1"][15],
            Id = @"OM1.15",
            Type = @"Field",
            Position = @"OM1.15",
            Name = @"Portable Device Indicator",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0136",
            TableName = @"Yes/no indicator",
            Description = @"This field indicates whether or not a portable device may be used for the service/test/observation. Refer to HL7 table 0136 - Yes/no indicator for valid values.",
            Sample = @"",
        };

        

        

        

        return portableDeviceIndicator;
    } 
}
internal HL7V251Field observationProducingDepartmentSection;

public HL7V251Field ObservationProducingDepartmentSection
{
    get
    {
        if (observationProducingDepartmentSection != null)
        {
            return observationProducingDepartmentSection;
        }

        observationProducingDepartmentSection = new HL7V251Field
        {
            field = message[@"OM1"][16],
            Id = @"OM1.16",
            Type = @"Field",
            Position = @"OM1.16",
            Name = @"Observation Producing Department/Section",
            Length = 250,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field permits the sorting of observation orders and values by the providing services department/section. It provides ""source oriented"" reporting when required. The codes for this field should be taken from ASTM Table 15 (Diagnostic Service Codes). Free text may be used instead of these codes, but in that case, they should be recorded as the second ""component"" of the field to distinguish them from the standard codes. Multiple codes in this field are separated by repeat delimiters.",
            Sample = @"",
        };

        

        

        

        return observationProducingDepartmentSection;
    } 
}
internal HL7V251Field telephoneNumberofSection;

public HL7V251Field TelephoneNumberofSection
{
    get
    {
        if (telephoneNumberofSection != null)
        {
            return telephoneNumberofSection;
        }

        telephoneNumberofSection = new HL7V251Field
        {
            field = message[@"OM1"][17],
            Id = @"OM1.17",
            Type = @"Field",
            Position = @"OM1.17",
            Name = @"Telephone Number of Section",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"XTN",
            DataTypeName = @"Extended Telecommunication Number",
            TableId = null,
            TableName = null,
            Description = @"This field contains the telephone number for calling responsible parties in this section to ask results or advice about the use of this test.",
            Sample = @"",
        };

        

        

        

        return telephoneNumberofSection;
    } 
}
internal HL7V251Field natureofServiceTestObservation;

public HL7V251Field NatureofServiceTestObservation
{
    get
    {
        if (natureofServiceTestObservation != null)
        {
            return natureofServiceTestObservation;
        }

        natureofServiceTestObservation = new HL7V251Field
        {
            field = message[@"OM1"][18],
            Id = @"OM1.18",
            Type = @"Field",
            Position = @"OM1.18",
            Name = @"Nature of Service/Test/Observation",
            Length = 1,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0174",
            TableName = @"Nature of Service/Test/Observation",
            Description = @"This field indicates whether the definition entry identifies a test battery, an entire functional procedure or study, a single test value (observation), multiple test batteries or functional procedures as an orderable unit (profile), or a single test value (observation) calculated from other independent observations. Refer to User-defined Table 0174 - Nature of service/test/observation for suggested values.",
            Sample = @"",
        };

        

        

        

        return natureofServiceTestObservation;
    } 
}
internal HL7V251Field reportSubheader;

public HL7V251Field ReportSubheader
{
    get
    {
        if (reportSubheader != null)
        {
            return reportSubheader;
        }

        reportSubheader = new HL7V251Field
        {
            field = message[@"OM1"][19],
            Id = @"OM1.19",
            Type = @"Field",
            Position = @"OM1.19",
            Name = @"Report Subheader",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains an optional string that defines the preferred header under which this observation should be listed on a standard display. For example, if the test is hemoglobin, this string might be ""Complete blood count."" It is represented as a coded data type so that a battery can be a header. Only the description part of the string may be included in case the subheader does not have an associated code. When a series of observations is displayed according to the sort order given below, the subheader that groups those observations is presented whenever the subheader changes.",
            Sample = @"",
        };

        

        

        

        return reportSubheader;
    } 
}
internal HL7V251Field reportDisplayOrder;

public HL7V251Field ReportDisplayOrder
{
    get
    {
        if (reportDisplayOrder != null)
        {
            return reportDisplayOrder;
        }

        reportDisplayOrder = new HL7V251Field
        {
            field = message[@"OM1"][20],
            Id = @"OM1.20",
            Type = @"Field",
            Position = @"OM1.20",
            Name = @"Report Display Order",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains an optional string that defines the sort order in which this observation is presented in a standard report or display that contains the many observations.",
            Sample = @"",
        };

        

        

        

        return reportDisplayOrder;
    } 
}
internal HL7V251Field dateTimeStampforanychangeinDefinitionfortheObservation;

public HL7V251Field DateTimeStampforanychangeinDefinitionfortheObservation
{
    get
    {
        if (dateTimeStampforanychangeinDefinitionfortheObservation != null)
        {
            return dateTimeStampforanychangeinDefinitionfortheObservation;
        }

        dateTimeStampforanychangeinDefinitionfortheObservation = new HL7V251Field
        {
            field = message[@"OM1"][21],
            Id = @"OM1.21",
            Type = @"Field",
            Position = @"OM1.21",
            Name = @"Date/Time Stamp for any change in Definition for the Observation",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date and time that the last of any field change was made and in the hosts record corresponding to the OM1 segment.",
            Sample = @"",
        };

        

        

        

        return dateTimeStampforanychangeinDefinitionfortheObservation;
    } 
}
internal HL7V251Field effectiveDateTimeofChange;

public HL7V251Field EffectiveDateTimeofChange
{
    get
    {
        if (effectiveDateTimeofChange != null)
        {
            return effectiveDateTimeofChange;
        }

        effectiveDateTimeofChange = new HL7V251Field
        {
            field = message[@"OM1"][22],
            Id = @"OM1.22",
            Type = @"Field",
            Position = @"OM1.22",
            Name = @"Effective Date/Time of Change",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date and time of the last change in the test procedure that would make previous results incompatible with new results, e.g., the last time that normal reference range or units changed for a numeric test/observation.",
            Sample = @"",
        };

        

        

        

        return effectiveDateTimeofChange;
    } 
}
internal HL7V251Field typicalTurnAroundTime;

public HL7V251Field TypicalTurnAroundTime
{
    get
    {
        if (typicalTurnAroundTime != null)
        {
            return typicalTurnAroundTime;
        }

        typicalTurnAroundTime = new HL7V251Field
        {
            field = message[@"OM1"][23],
            Id = @"OM1.23",
            Type = @"Field",
            Position = @"OM1.23",
            Name = @"Typical Turn-Around Time",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the typical processing time for single test/observation. This field indicates the time from the delivery of a specimen or transport of a patient to a diagnostic service and the completion of the study. It includes the usual waiting time. The units are measured in minutes.",
            Sample = @"",
        };

        

        

        

        return typicalTurnAroundTime;
    } 
}
internal HL7V251Field processingTime;

public HL7V251Field ProcessingTime
{
    get
    {
        if (processingTime != null)
        {
            return processingTime;
        }

        processingTime = new HL7V251Field
        {
            field = message[@"OM1"][24],
            Id = @"OM1.24",
            Type = @"Field",
            Position = @"OM1.24",
            Name = @"Processing Time",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the usual length of time (in minutes) between the start of a test process and its completion.",
            Sample = @"",
        };

        

        

        

        return processingTime;
    } 
}
internal HL7V251Field processingPriority;

public HL7V251Field ProcessingPriority
{
    get
    {
        if (processingPriority != null)
        {
            return processingPriority;
        }

        processingPriority = new HL7V251Field
        {
            field = message[@"OM1"][25],
            Id = @"OM1.25",
            Type = @"Field",
            Position = @"OM1.25",
            Name = @"Processing Priority",
            Length = 40,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0168",
            TableName = @"Processing priority",
            Description = @"This field contains one or more available priorities for performing the observation or test. This is the priority that can be placed in TQ1-9 - Priority. Multiple priorities may be given, separated by repeat delimiters. For example, S~A~R~P~T indicates that the test may be ordered using codes S, A, R, P, or T. Refer to HL7 table 0168 - Processing priority for valid values.",
            Sample = @"",
        };

        

        

        

        return processingPriority;
    } 
}
internal HL7V251Field reportingPriority;

public HL7V251Field ReportingPriority
{
    get
    {
        if (reportingPriority != null)
        {
            return reportingPriority;
        }

        reportingPriority = new HL7V251Field
        {
            field = message[@"OM1"][26],
            Id = @"OM1.26",
            Type = @"Field",
            Position = @"OM1.26",
            Name = @"Reporting Priority",
            Length = 5,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0169",
            TableName = @"Reporting priority",
            Description = @"This field contains the available priorities reporting the test results when the user is asked to specify the reporting priority independent of the processing priority. Refer to HL7 Table 0169 - Reporting priority for valid values.",
            Sample = @"",
        };

        

        

        

        return reportingPriority;
    } 
}
internal HL7V251Field outsideSite(s)WhereObservationmaybePerformed;

public HL7V251Field OutsideSite(s)WhereObservationmaybePerformed
{
    get
    {
        if (outsideSite(s)WhereObservationmaybePerformed != null)
        {
            return outsideSite(s)WhereObservationmaybePerformed;
        }

        outsideSite(s)WhereObservationmaybePerformed = new HL7V251Field
        {
            field = message[@"OM1"][27],
            Id = @"OM1.27",
            Type = @"Field",
            Position = @"OM1.27",
            Name = @"Outside Site(s) Where Observation may be Performed ",
            Length = 250,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains the identification(s) of the outside service(s) that produce(s) the observation. The format of this CE field uses the producer ID (as defined in OM1-5 - Producer ID ) and the name of the service separated by component delimiters. An example is |39221^ACME lab^MC|... If multiple services are used, they should be separated by repeat delimiter(s).",
            Sample = @"",
        };

        

        

        

        return outsideSite(s)WhereObservationmaybePerformed;
    } 
}
internal HL7V251Field addressofOutsideSite(s);

public HL7V251Field AddressofOutsideSite(s)
{
    get
    {
        if (addressofOutsideSite(s) != null)
        {
            return addressofOutsideSite(s);
        }

        addressofOutsideSite(s) = new HL7V251Field
        {
            field = message[@"OM1"][28],
            Id = @"OM1.28",
            Type = @"Field",
            Position = @"OM1.28",
            Name = @"Address of Outside Site(s)",
            Length = 250,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XAD",
            DataTypeName = @"Extended Address",
            TableId = null,
            TableName = null,
            Description = @"This field contains the address of the outside services listed in OM1-28 - Address of Outside Site(s) where observation may be performed. If multiple services are recorded in that field, their addresses should be separated by repeat delimiters, and the addresses should appear in the same order in which the services appear in the preceding field.",
            Sample = @"",
        };

        

        

        

        return addressofOutsideSite(s);
    } 
}
internal HL7V251Field phoneNumberofOutsideSite;

public HL7V251Field PhoneNumberofOutsideSite
{
    get
    {
        if (phoneNumberofOutsideSite != null)
        {
            return phoneNumberofOutsideSite;
        }

        phoneNumberofOutsideSite = new HL7V251Field
        {
            field = message[@"OM1"][29],
            Id = @"OM1.29",
            Type = @"Field",
            Position = @"OM1.29",
            Name = @"Phone Number of Outside Site",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"XTN",
            DataTypeName = @"Extended Telecommunication Number",
            TableId = null,
            TableName = null,
            Description = @"This field contains the telephone number of the outside site.",
            Sample = @"",
        };

        

        

        

        return phoneNumberofOutsideSite;
    } 
}
internal HL7V251Field confidentialityCode;

public HL7V251Field ConfidentialityCode
{
    get
    {
        if (confidentialityCode != null)
        {
            return confidentialityCode;
        }

        confidentialityCode = new HL7V251Field
        {
            field = message[@"OM1"][30],
            Id = @"OM1.30",
            Type = @"Field",
            Position = @"OM1.30",
            Name = @"Confidentiality Code",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = @"0177",
            TableName = @"Confidentiality code",
            Description = @"This field contains the degree to which special confidentiality protection should be applied to the observation. For example, a tighter control may be applied to an HIV test than to a CBC. Refer to User-defined Table 0177 - Confidentiality code for suggested values.",
            Sample = @"",
        };

        

        

        

        return confidentialityCode;
    } 
}
internal HL7V251Field observationsRequiredtoInterprettheObservation;

public HL7V251Field ObservationsRequiredtoInterprettheObservation
{
    get
    {
        if (observationsRequiredtoInterprettheObservation != null)
        {
            return observationsRequiredtoInterprettheObservation;
        }

        observationsRequiredtoInterprettheObservation = new HL7V251Field
        {
            field = message[@"OM1"][31],
            Id = @"OM1.31",
            Type = @"Field",
            Position = @"OM1.31",
            Name = @"Observations Required to Interpret the Observation",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains the list of variables that the diagnostic service needs to interpret the results of an ordered study. The observations specified here should be sent to the diagnostic service as OBX segments along with the order (OBR) segment.",
            Sample = @"",
        };

        

        

        

        return observationsRequiredtoInterprettheObservation;
    } 
}
internal HL7V251Field interpretationofObservations;

public HL7V251Field InterpretationofObservations
{
    get
    {
        if (interpretationofObservations != null)
        {
            return interpretationofObservations;
        }

        interpretationofObservations = new HL7V251Field
        {
            field = message[@"OM1"][32],
            Id = @"OM1.32",
            Type = @"Field",
            Position = @"OM1.32",
            Name = @"Interpretation of Observations",
            Length = 65536,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TX",
            DataTypeName = @"Text Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the clinical information about interpreting test results. Examples are the conditions (drugs) that may cause false abnormals, and the information about the sensitivity and specificity of the test for diagnoses.",
            Sample = @"",
        };

        

        

        

        return interpretationofObservations;
    } 
}
internal HL7V251Field contraindicationstoObservations;

public HL7V251Field ContraindicationstoObservations
{
    get
    {
        if (contraindicationstoObservations != null)
        {
            return contraindicationstoObservations;
        }

        contraindicationstoObservations = new HL7V251Field
        {
            field = message[@"OM1"][33],
            Id = @"OM1.33",
            Type = @"Field",
            Position = @"OM1.33",
            Name = @"Contraindications to Observations",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains the diagnosis or problem for which the test is a contraindication or of possible danger (e.g., pacemaker, pregnancy, diabetes). For example, if the test identified in OM1 was an intravenous pyelogram, this field would include warnings about the use of contrast media in diabetes. The contraindication diagnoses should be separated by repeat delimiters.",
            Sample = @"",
        };

        

        

        

        return contraindicationstoObservations;
    } 
}
internal HL7V251Field reflexTestsObservations;

public HL7V251Field ReflexTestsObservations
{
    get
    {
        if (reflexTestsObservations != null)
        {
            return reflexTestsObservations;
        }

        reflexTestsObservations = new HL7V251Field
        {
            field = message[@"OM1"][34],
            Id = @"OM1.34",
            Type = @"Field",
            Position = @"OM1.34",
            Name = @"Reflex Tests/Observations",
            Length = 250,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains the test names as type CE (i.e., <code>^<text name>^<coding system>) that may be ordered automatically by the diagnostic service, depending on the results obtained from the ordered battery. A screening CBC might trigger a reticulocyte count if the Hgb is less than 12. Multiple reflex tests are separated by repeat delimiters.",
            Sample = @"",
        };

        

        

        

        return reflexTestsObservations;
    } 
}
internal HL7V251Field rulesthatTriggerReflexTesting;

public HL7V251Field RulesthatTriggerReflexTesting
{
    get
    {
        if (rulesthatTriggerReflexTesting != null)
        {
            return rulesthatTriggerReflexTesting;
        }

        rulesthatTriggerReflexTesting = new HL7V251Field
        {
            field = message[@"OM1"][35],
            Id = @"OM1.35",
            Type = @"Field",
            Position = @"OM1.35",
            Name = @"Rules that Trigger Reflex Testing",
            Length = 80,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TX",
            DataTypeName = @"Text Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the rules that trigger the reflex tests listed above. If multiple reflex tests are listed in OM1-34 - Reflex Text/Observations separated by repeat delimiters, a set of corresponding rules will be included in this section. The first rule will apply to the first test, the second to the second test, and so on.",
            Sample = @"",
        };

        

        

        

        return rulesthatTriggerReflexTesting;
    } 
}
internal HL7V251Field fixedCannedMessage;

public HL7V251Field FixedCannedMessage
{
    get
    {
        if (fixedCannedMessage != null)
        {
            return fixedCannedMessage;
        }

        fixedCannedMessage = new HL7V251Field
        {
            field = message[@"OM1"][36],
            Id = @"OM1.36",
            Type = @"Field",
            Position = @"OM1.36",
            Name = @"Fixed Canned Message",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains the codes and a fixed text message that is always associated with an abbreviation. The field may include multiple messages separated by repeat delimiters.",
            Sample = @"",
        };

        

        

        

        return fixedCannedMessage;
    } 
}
internal HL7V251Field patientPreparation;

public HL7V251Field PatientPreparation
{
    get
    {
        if (patientPreparation != null)
        {
            return patientPreparation;
        }

        patientPreparation = new HL7V251Field
        {
            field = message[@"OM1"][37],
            Id = @"OM1.37",
            Type = @"Field",
            Position = @"OM1.37",
            Name = @"Patient Preparation",
            Length = 200,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TX",
            DataTypeName = @"Text Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the tests or observations that require special patient preparation, diet, or medications. For GI contrast studies, this field would contain the pretest diet, e.g., low residue for two days, NPO before study, and the preferred purgatives. Each separate med, diet, or preparation should be delimited by a repeat delimiter. Separate each requirement by a repeat delimiter. Example for a sigmoidectomy:",
            Sample = @"",
        };

        

        

        

        return patientPreparation;
    } 
}
internal HL7V251Field procedureMedication;

public HL7V251Field ProcedureMedication
{
    get
    {
        if (procedureMedication != null)
        {
            return procedureMedication;
        }

        procedureMedication = new HL7V251Field
        {
            field = message[@"OM1"][38],
            Id = @"OM1.38",
            Type = @"Field",
            Position = @"OM1.38",
            Name = @"Procedure Medication",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains the treatments that may be needed as part of the procedure. Examples are radioactive iodine for a thyroid screen, and methacholine for a methacholine spirometry challenge. This field should be identified as a CE data type.",
            Sample = @"",
        };

        

        

        

        return procedureMedication;
    } 
}
internal HL7V251Field factorsthatmayAffecttheObservation;

public HL7V251Field FactorsthatmayAffecttheObservation
{
    get
    {
        if (factorsthatmayAffecttheObservation != null)
        {
            return factorsthatmayAffecttheObservation;
        }

        factorsthatmayAffecttheObservation = new HL7V251Field
        {
            field = message[@"OM1"][39],
            Id = @"OM1.39",
            Type = @"Field",
            Position = @"OM1.39",
            Name = @"Factors that may Affect the Observation",
            Length = 200,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TX",
            DataTypeName = @"Text Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the text description of the foods, diagnoses, drugs, or other conditions that may influence the interpretation of the observation. Information about the direction of the effect, and any recommendation about altering the diet, conditions, or drug before initiating the test observation.",
            Sample = @"",
        };

        

        

        

        return factorsthatmayAffecttheObservation;
    } 
}
internal HL7V251Field serviceTestObservationPerformanceSchedule;

public HL7V251Field ServiceTestObservationPerformanceSchedule
{
    get
    {
        if (serviceTestObservationPerformanceSchedule != null)
        {
            return serviceTestObservationPerformanceSchedule;
        }

        serviceTestObservationPerformanceSchedule = new HL7V251Field
        {
            field = message[@"OM1"][40],
            Id = @"OM1.40",
            Type = @"Field",
            Position = @"OM1.40",
            Name = @"Service/Test/Observation Performance Schedule",
            Length = 60,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the diagnostic studies/tests that are performed only at certain times during the course of a work day or work week. This field indicates the maximum interval between successive test performances (the test may actually be performed more frequently). If necessary, multiple codes may be given, separated by repeat delimiters. The use of multiple codes indicates that the test is performed at multiple concurrent intervals. For example, Q6H indicates that the test is performed at least once every 6 hours around the clock. QJ1 indicates that the test is performed at least every week on Mondays. QAM~QPM indicates that the test is performed at least once every morning and every evening. QJ1~QJ3~QJ5 indicates that the test is performed at least every week on Mondays, Wednesdays, and Fridays. C indicates that the test is performed continuously, 7 days per week.",
            Sample = @"",
        };

        

        

        

        return serviceTestObservationPerformanceSchedule;
    } 
}
internal HL7V251Field descriptionofTestMethods;

public HL7V251Field DescriptionofTestMethods
{
    get
    {
        if (descriptionofTestMethods != null)
        {
            return descriptionofTestMethods;
        }

        descriptionofTestMethods = new HL7V251Field
        {
            field = message[@"OM1"][41],
            Id = @"OM1.41",
            Type = @"Field",
            Position = @"OM1.41",
            Name = @"Description of Test Methods",
            Length = 65536,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TX",
            DataTypeName = @"Text Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the text description of the methods used to perform the text and generate the observations. Bibliographic citations may be included.",
            Sample = @"",
        };

        

        

        

        return descriptionofTestMethods;
    } 
}
internal HL7V251Field kindofQuantityObserved;

public HL7V251Field KindofQuantityObserved
{
    get
    {
        if (kindofQuantityObserved != null)
        {
            return kindofQuantityObserved;
        }

        kindofQuantityObserved = new HL7V251Field
        {
            field = message[@"OM1"][42],
            Id = @"OM1.42",
            Type = @"Field",
            Position = @"OM1.42",
            Name = @"Kind of Quantity Observed",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0254",
            TableName = @"Kind of quantity",
            Description = @"This optional attribute describes the underlying kind of property represented by this observation.  This attribute distinguishes concentrations from total amounts, molar concentrations from mass concentrations, partial pressures from colors, and so forth.  These are discussed more fully in the LOINC Users’ Manual.  They are derived from the approach described in 1995 edition of the IUPAC Silver Book.2 These distinctions are used in IUPAC and LOINC standard codes.  Defined categories are listed in HL7 table 0254 - Kind of quantity. ",
            Sample = @"",
        };

        

        

        

        return kindofQuantityObserved;
    } 
}
internal HL7V251Field pointVersusInterval;

public HL7V251Field PointVersusInterval
{
    get
    {
        if (pointVersusInterval != null)
        {
            return pointVersusInterval;
        }

        pointVersusInterval = new HL7V251Field
        {
            field = message[@"OM1"][43],
            Id = @"OM1.43",
            Type = @"Field",
            Position = @"OM1.43",
            Name = @"Point Versus Interval",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0255",
            TableName = @"Duration categories",
            Description = @"This optional attribute allows master files to classify observations as measuring the patients state at a point in time (e.g., spot urines, random urines, serum potassium), or averaged over a interval of time (e.g., concentration, total amount, or clearance over a 24-hour collection). Interval measures most often apply to urine and stool specimens (e.g., 24-hour urines, 3-day stool fats). They also apply to clinical measurements such as urine outputs, which are reported as shift totals and 24-hour totals, and event counts on physiologic monitors such as the number of PVCs on a 24-hour Holter monitor.",
            Sample = @"",
        };

        

        

        

        return pointVersusInterval;
    } 
}
internal HL7V251Field challengeInformation;

public HL7V251Field ChallengeInformation
{
    get
    {
        if (challengeInformation != null)
        {
            return challengeInformation;
        }

        challengeInformation = new HL7V251Field
        {
            field = message[@"OM1"][44],
            Id = @"OM1.44",
            Type = @"Field",
            Position = @"OM1.44",
            Name = @"Challenge Information",
            Length = 200,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TX",
            DataTypeName = @"Text Data",
            TableId = null,
            TableName = null,
            Description = @"Definition:  This optional attribute provides information for classifying observations by the challenge component of the test, if a challenge does speciate the observation.  For example, distinguishing tests that have a challenge component in database. There co-ascribes the physiologic or drug challenge that is intrinsic to the measurement. To identify, for example, tests that include a glucose challenge.   

To construct this text string, use the following template.  (Note:  This field is not constructed of formally defined components; it is a free text field.  Component delimiters are not used and it is not necessary to supply placeholders if some ""components"" are not used.) 

The time delay follows the syntax: n<S|M|H|D|W> where n is a number (possibly a decimal); S denotes seconds; M denotes minutes; H denotes hours; D denotes days; and W denotes weeks.  The time delay can be preceded by a ‘greater than’ (>) sign, e.g. >4H. 

HL7 Table 0256 - Time delay post challenge lists possible values for time delay. 

For drug peak and trough measures the nature of the substance challenged is the same as the analyte name, and need not be included.  
We denote the route of the challenge via abbreviations for medication routes (see HL7 table 0162 - Route of administration).  An oral route of administration would be denoted by ""PO,"" an intravenous route by ""IV.""  

Details of the drug dose, time the dose was given, route of administration, etc., would be noted in separate OBX, and would have corresponding master observation definitions stored in the observation master file map to different records stored in the master file segments contained in the drug level message.

The nature of a physiologic (non-drug) challenge may also be specified, using the terms in HL7 Table 0257 - Nature of challenge. ",
            Sample = @"",
        };

        

        

        

        return challengeInformation;
    } 
}
internal HL7V251Field relationshipModifier;

public HL7V251Field RelationshipModifier
{
    get
    {
        if (relationshipModifier != null)
        {
            return relationshipModifier;
        }

        relationshipModifier = new HL7V251Field
        {
            field = message[@"OM1"][45],
            Id = @"OM1.45",
            Type = @"Field",
            Position = @"OM1.45",
            Name = @"Relationship Modifier",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0258",
            TableName = @"Relationship modifier",
            Description = @"This optional attribute provides a mechanism for classifying observations according to the subject, in relation to the patient whose results might be stored with as ""patient"" data. It is standard practice, for example, to report values for controls, donors, and blood product units as well as the patients own values, and store them in the patients record. (This may not be the best way to model such information, but it is the way it is usually reported.) This should be valued when two values (e.g., one for patient and one for a blood product unit) could otherwise be confused.",
            Sample = @"",
        };

        

        

        

        return relationshipModifier;
    } 
}
internal HL7V251Field targetAnatomicSiteOfTest;

public HL7V251Field TargetAnatomicSiteOfTest
{
    get
    {
        if (targetAnatomicSiteOfTest != null)
        {
            return targetAnatomicSiteOfTest;
        }

        targetAnatomicSiteOfTest = new HL7V251Field
        {
            field = message[@"OM1"][46],
            Id = @"OM1.46",
            Type = @"Field",
            Position = @"OM1.46",
            Name = @"Target Anatomic Site Of Test",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This optional attribute formally indicates the site of the observation (to make it easy for a system to find all tests related to one anatomic site). It can be used to classify the observation by target site of the examination. For example, ""heart"" might be recorded as the target of the electrocardiogram, cardiac echo, and thallium exercise test. This attribute would be applicable to most imaging and electro-physiologic examinations. The SNOMED topology axis is an example of a coding system for anatomic sites. User-defined tables may also apply here.",
            Sample = @"",
        };

        

        

        

        return targetAnatomicSiteOfTest;
    } 
}
internal HL7V251Field modalityOfImagingMeasurement;

public HL7V251Field ModalityOfImagingMeasurement
{
    get
    {
        if (modalityOfImagingMeasurement != null)
        {
            return modalityOfImagingMeasurement;
        }

        modalityOfImagingMeasurement = new HL7V251Field
        {
            field = message[@"OM1"][47],
            Id = @"OM1.47",
            Type = @"Field",
            Position = @"OM1.47",
            Name = @"Modality Of Imaging Measurement",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0259",
            TableName = @"Modality",
            Description = @"This optional attribute describes the modality used to classify the observations, e.g., radiograph, ultrasound, CT scan, NMR, etc. This attribute is especially important for imaging studies. Refer to User-defined Table 0259 - Modality for suggested values; they are adopted from DICOM C.7.3.1.1.1 Modality. If these are used, the code source ID would be DCM.",
            Sample = @"",
        };

        

        

        

        return modalityOfImagingMeasurement;
    } 
}

    }
}
