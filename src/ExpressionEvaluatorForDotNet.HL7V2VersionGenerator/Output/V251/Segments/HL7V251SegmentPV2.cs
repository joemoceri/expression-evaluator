using System.Linq;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251SegmentPV2
    {
        public readonly HL7V2Message message;

        public string Id { get { return @"PV2"; } }

        public string SegmentId { get { return @"PV2"; } }
        
        public string LongName { get { return @"Patient Visit - Additional Information"; } }
        
        public string Description { get { return @"The PV2 segment is a continuation of information contained on the PV1 segment."; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_03",
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
                            Id = @"PV2.1",
                            Type = @"Field",
                            Position = @"PV2.1",
                            Name = @"Prior Pending Location",
                            Length = 80,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"PL",
                            DataTypeName = @"Person Location",
                            TableId = null,
                            TableName = null,
                            Description = @"This field is required for cancel pending transfer (A26) messages.  In all other events it is optional.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"PV2.1.1",
                            Type = @"Component",
                            Position = @"PV2.1.1",
                            Name = @"Point Of Care",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0302",
                            TableName = @"Point of care",
                            Description = @"This component specifies the code for the point where patient care is administered. It is conditional on PL.6 Person Location Type (e.g., nursing unit or department or clinic). After floor, it is the most general patient location designation. Refer to User-defined Table 0302 - Point of care for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.1.2",
                            Type = @"Component",
                            Position = @"PV2.1.2",
                            Name = @"Room",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0303",
                            TableName = @"Room",
                            Description = @"This component specifies the code for the patient's room. After point of care, it is the most general person location designation. Refer to User-defined Table 0303 - Room for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.1.3",
                            Type = @"Component",
                            Position = @"PV2.1.3",
                            Name = @"Bed",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0304",
                            TableName = @"Bed",
                            Description = @"This component specifies the code for the patient's bed. After room, it is the most general person location designation. Refer to User-defined Table 0304 - Bed for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.1.4",
                            Type = @"Component",
                            Position = @"PV2.1.4",
                            Name = @"Facility",
                            Length = 227,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"This component is subject to site interpretation but generally describes the highest level physical designation of an institution, medical center or enterprise. It is the most general person location designation.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"PV2.1.4.1",
                            Type = @"SubComponent",
                            Position = @"PV2.1.4.1",
                            Name = @"Namespace Id",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"Namespace ID is used as the HL7 identifier for the user-defined table of values for this component.

Note: When the HD is used in a given segment (either as a field or as a component of another data type) this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.1.4.2",
                            Type = @"SubComponent",
                            Position = @"PV2.1.4.2",
                            Name = @"Universal Id",
                            Length = 199,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HDs second component, <universal ID> (UID), is a string formatted according to the scheme defined by the third component, <universal ID type> (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.1.4.3",
                            Type = @"SubComponent",
                            Position = @"PV2.1.4.3",
                            Name = @"Universal Id Type",
                            Length = 6,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.1.5",
                            Type = @"Component",
                            Position = @"PV2.1.5",
                            Name = @"Location Status",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0306",
                            TableName = @"Location status",
                            Description = @"This component specifies the code for the status or availability of the location. For example, it may convey bed status. Refer to User-defined Table 0306 - Location status for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.1.6",
                            Type = @"Component",
                            Position = @"PV2.1.6",
                            Name = @"Person Location Type",
                            Length = 20,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0305",
                            TableName = @"Person location type",
                            Description = @"Person location type is the categorization of the persons location defined by facility, building, floor, point of care, room or bed. Although not a required field, when used, it may be the only populated field. It usually includes values such as nursing unit, department, clinic, SNF, physicians office. Refer to User-defined Table 0305 - Person location type for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.1.7",
                            Type = @"Component",
                            Position = @"PV2.1.7",
                            Name = @"Building",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0307",
                            TableName = @"Building",
                            Description = @"This component specifies the code for the building where the person is located. After facility, it is the most general person location designation. Refer to User-defined Table 0307 - Building for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.1.8",
                            Type = @"Component",
                            Position = @"PV2.1.8",
                            Name = @"Floor",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0308",
                            TableName = @"Floor",
                            Description = @"This component specifies the code for the floor where the person is located. After building, it is the most general person location designation. Refer to User-defined Table 0308 - Floor for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.1.9",
                            Type = @"Component",
                            Position = @"PV2.1.9",
                            Name = @"Location Description",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component describes the location in free text.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.1.10",
                            Type = @"Component",
                            Position = @"PV2.1.10",
                            Name = @"Comprehensive Location Identifier",
                            Length = 427,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"EI",
                            DataTypeName = @"Entity Identifier",
                            TableId = null,
                            TableName = null,
                            Description = @"The unique identifier that represents the physical location as a whole without regard for the individual components. This accommodates sites that may have a different method of defining physical units or who may code at a less granular level. For example, point of care, room, and bed may be 1 indivisible code.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"PV2.1.10.1",
                            Type = @"SubComponent",
                            Position = @"PV2.1.10.1",
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
                            Id = @"PV2.1.10.2",
                            Type = @"SubComponent",
                            Position = @"PV2.1.10.2",
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
                            Id = @"PV2.1.10.3",
                            Type = @"SubComponent",
                            Position = @"PV2.1.10.3",
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
                            Id = @"PV2.1.10.4",
                            Type = @"SubComponent",
                            Position = @"PV2.1.10.4",
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
                            Id = @"PV2.1.11",
                            Type = @"Component",
                            Position = @"PV2.1.11",
                            Name = @"Assigning Authority For Location",
                            Length = 227,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"The entity that creates the data for the individual physical location components. If populated, it should be the authority for all components populated. Refer to User-defined Table 0363 - Assigning authority for suggested values for the first sub-component of the HD component, <namespace ID>.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"PV2.1.11.1",
                            Type = @"SubComponent",
                            Position = @"PV2.1.11.1",
                            Name = @"Namespace Id",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"Namespace ID is used as the HL7 identifier for the user-defined table of values for this component.

Note: When the HD is used in a given segment (either as a field or as a component of another data type) this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.1.11.2",
                            Type = @"SubComponent",
                            Position = @"PV2.1.11.2",
                            Name = @"Universal Id",
                            Length = 199,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HDs second component, <universal ID> (UID), is a string formatted according to the scheme defined by the third component, <universal ID type> (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.1.11.3",
                            Type = @"SubComponent",
                            Position = @"PV2.1.11.3",
                            Name = @"Universal Id Type",
                            Length = 6,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.2",
                            Type = @"Field",
                            Position = @"PV2.2",
                            Name = @"Accommodation Code",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0129",
                            TableName = @"Accommodation code",
                            Description = @"This field indicates the specific patient accommodations for this visit. Refer to User-defined Table 0129 - Accommodation Code for suggested values.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"PV2.2.1",
                            Type = @"Component",
                            Position = @"PV2.2.1",
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
                            Id = @"PV2.2.2",
                            Type = @"Component",
                            Position = @"PV2.2.2",
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
                            Id = @"PV2.2.3",
                            Type = @"Component",
                            Position = @"PV2.2.3",
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
                            Id = @"PV2.2.4",
                            Type = @"Component",
                            Position = @"PV2.2.4",
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
                            Id = @"PV2.2.5",
                            Type = @"Component",
                            Position = @"PV2.2.5",
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
                            Id = @"PV2.2.6",
                            Type = @"Component",
                            Position = @"PV2.2.6",
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
                            Id = @"PV2.3",
                            Type = @"Field",
                            Position = @"PV2.3",
                            Name = @"Admit Reason",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the short description of the reason for patient admission.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"PV2.3.1",
                            Type = @"Component",
                            Position = @"PV2.3.1",
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
                            Id = @"PV2.3.2",
                            Type = @"Component",
                            Position = @"PV2.3.2",
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
                            Id = @"PV2.3.3",
                            Type = @"Component",
                            Position = @"PV2.3.3",
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
                            Id = @"PV2.3.4",
                            Type = @"Component",
                            Position = @"PV2.3.4",
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
                            Id = @"PV2.3.5",
                            Type = @"Component",
                            Position = @"PV2.3.5",
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
                            Id = @"PV2.3.6",
                            Type = @"Component",
                            Position = @"PV2.3.6",
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
                            Id = @"PV2.4",
                            Type = @"Field",
                            Position = @"PV2.4",
                            Name = @"Transfer Reason",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the short description of the reason for a patient location change.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"PV2.4.1",
                            Type = @"Component",
                            Position = @"PV2.4.1",
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
                            Id = @"PV2.4.2",
                            Type = @"Component",
                            Position = @"PV2.4.2",
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
                            Id = @"PV2.4.3",
                            Type = @"Component",
                            Position = @"PV2.4.3",
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
                            Id = @"PV2.4.4",
                            Type = @"Component",
                            Position = @"PV2.4.4",
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
                            Id = @"PV2.4.5",
                            Type = @"Component",
                            Position = @"PV2.4.5",
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
                            Id = @"PV2.4.6",
                            Type = @"Component",
                            Position = @"PV2.4.6",
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
                            Id = @"PV2.5",
                            Type = @"Field",
                            Position = @"PV2.5",
                            Name = @"Patient Valuables",
                            Length = 25,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the short description of patient valuables checked in during admission.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.6",
                            Type = @"Field",
                            Position = @"PV2.6",
                            Name = @"Patient Valuables Location",
                            Length = 25,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field indicates the location of the patients valuables.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.7",
                            Type = @"Field",
                            Position = @"PV2.7",
                            Name = @"Visit User Code",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0130",
                            TableName = @"Visit User Code",
                            Description = @"This field further categorizes a patients visit with respect to an individual institutions needs, and is expected to be site-specific. Refer to User-defined Table 0130 - Visit User Code for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.8",
                            Type = @"Field",
                            Position = @"PV2.8",
                            Name = @"Expected Admit Date/Time",
                            Length = 26,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the date and time that the patient is expected to be admitted. This field is also used to reflect the date/time of an outpatient/emergency patient registration.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"PV2.8.1",
                            Type = @"Component",
                            Position = @"PV2.8.1",
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
                            Id = @"PV2.8.2",
                            Type = @"Component",
                            Position = @"PV2.8.2",
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
                            Id = @"PV2.9",
                            Type = @"Field",
                            Position = @"PV2.9",
                            Name = @"Expected Discharge Date/Time",
                            Length = 26,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the date and time that the patient is expected to be discharged. This is a non-event related date used by ancillaries to determine more accurately the projected workloads. This field is also used to reflect the anticipated discharge date/time of an outpatient/emergency patient, or an inpatient.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"PV2.9.1",
                            Type = @"Component",
                            Position = @"PV2.9.1",
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
                            Id = @"PV2.9.2",
                            Type = @"Component",
                            Position = @"PV2.9.2",
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
                            Id = @"PV2.10",
                            Type = @"Field",
                            Position = @"PV2.10",
                            Name = @"Estimated Length of Inpatient Stay",
                            Length = 3,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field specifies the estimated days of inpatient stays.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.11",
                            Type = @"Field",
                            Position = @"PV2.11",
                            Name = @"Actual Length of Inpatient Stay",
                            Length = 3,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the actual days of inpatient stays. The actual length of the inpatient stay may not be calculated from the admission and discharge dates because of possible leaves of absence.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.12",
                            Type = @"Field",
                            Position = @"PV2.12",
                            Name = @"Visit Description",
                            Length = 50,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains a brief user-defined description of the visit.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.13",
                            Type = @"Field",
                            Position = @"PV2.13",
                            Name = @"Referral Source Code",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"XCN",
                            DataTypeName = @"Extended Composite ID Number and Name for Persons",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the name and the identification numbers of the person or organization that made the referral. This person/organization is not the same as the referring doctor. For example, Joe Smith referred me to the Clinic (or to Dr. Jones at the Clinic).",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"PV2.13.1",
                            Type = @"Component",
                            Position = @"PV2.13.1",
                            Name = @"Id Number",
                            Length = 15,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This string refers to the coded ID according to a user-defined table, defined by the 9th component. If the first component is present, either the source table or the assigning authority must be valued.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.13.2",
                            Type = @"Component",
                            Position = @"PV2.13.2",
                            Name = @"Family Name",
                            Length = 194,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"FN",
                            DataTypeName = @"Family Name",
                            TableId = null,
                            TableName = null,
                            Description = @"This component allows full specification of the surname of a person. Where appropriate, it differentiates the person's own surname from that of the person's partner or spouse, in cases where the person's name may contain elements from either name. It also permits messages to distinguish the surname prefix (such as ""van"" or ""de"") from the surname root. See section 2.A.30, "" FN - family name"".",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"PV2.13.2.1",
                            Type = @"SubComponent",
                            Position = @"PV2.13.2.1",
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
                            Id = @"PV2.13.2.2",
                            Type = @"SubComponent",
                            Position = @"PV2.13.2.2",
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
                            Id = @"PV2.13.2.3",
                            Type = @"SubComponent",
                            Position = @"PV2.13.2.3",
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
                            Id = @"PV2.13.2.4",
                            Type = @"SubComponent",
                            Position = @"PV2.13.2.4",
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
                            Id = @"PV2.13.2.5",
                            Type = @"SubComponent",
                            Position = @"PV2.13.2.5",
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
                            Id = @"PV2.13.3",
                            Type = @"Component",
                            Position = @"PV2.13.3",
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
                            Id = @"PV2.13.4",
                            Type = @"Component",
                            Position = @"PV2.13.4",
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
                            Id = @"PV2.13.5",
                            Type = @"Component",
                            Position = @"PV2.13.5",
                            Name = @"Suffix (e.g., Jr Or Iii)",
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
                            Id = @"PV2.13.6",
                            Type = @"Component",
                            Position = @"PV2.13.6",
                            Name = @"Prefix (e.g., Dr)",
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
                            Id = @"PV2.13.7",
                            Type = @"Component",
                            Position = @"PV2.13.7",
                            Name = @"Degree (e.g., Md)",
                            Length = 5,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0360",
                            TableName = @"Degree/license/certificate",
                            Description = @"Retained for backward compatibility only as of v 2.5. See Professional Suffix component.

Used to specify an educational degree (e.g., MD). Refer to User-defined Table 0360 – Degree for suggested values. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.13.8",
                            Type = @"Component",
                            Position = @"PV2.13.8",
                            Name = @"Source Table",
                            Length = 4,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0297",
                            TableName = @"CN ID source",
                            Description = @"CN ID source is used as the HL7 identifier for the user-defined table of values for this component. Used to delineate the first component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.13.9",
                            Type = @"Component",
                            Position = @"PV2.13.9",
                            Name = @"Assigning Authority",
                            Length = 227,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = @"0363",
                            TableName = @"Assigning authority",
                            Description = @"The assigning authority is a unique identifier of the system (or organization or agency of department) that creates the data. User-defined Table 0363 - Assigning authority is used as the HL7 identifier for the user-defined table of values for the first sub-component of the HD component, <namespace ID>.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"PV2.13.9.1",
                            Type = @"SubComponent",
                            Position = @"PV2.13.9.1",
                            Name = @"Namespace Id",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"Namespace ID is used as the HL7 identifier for the user-defined table of values for this component.

Note: When the HD is used in a given segment (either as a field or as a component of another data type) this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.13.9.2",
                            Type = @"SubComponent",
                            Position = @"PV2.13.9.2",
                            Name = @"Universal Id",
                            Length = 199,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HDs second component, <universal ID> (UID), is a string formatted according to the scheme defined by the third component, <universal ID type> (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.13.9.3",
                            Type = @"SubComponent",
                            Position = @"PV2.13.9.3",
                            Name = @"Universal Id Type",
                            Length = 6,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.13.10",
                            Type = @"Component",
                            Position = @"PV2.13.10",
                            Name = @"Name Type Code",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0200",
                            TableName = @"Name type",
                            Description = @"A code that represents the type of name. Refer to HL7 Table 0200 - Name type for valid values. See Section 2.A.88.7, "" Name Type Code (ID) "".",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.13.11",
                            Type = @"Component",
                            Position = @"PV2.13.11",
                            Name = @"Identifier Check Digit",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The check digit in this data type is not an add-on produced by the message processor. It is the check digit that is part of the identifying number used in the sending application. If the sending application does not include a self-generated check digit in the identifying number, this component should be valued null.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.13.12",
                            Type = @"Component",
                            Position = @"PV2.13.12",
                            Name = @"Check Digit Scheme",
                            Length = 3,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0061",
                            TableName = @"Check digit scheme",
                            Description = @"Contains the code identifying the check digit scheme employed.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.13.13",
                            Type = @"Component",
                            Position = @"PV2.13.13",
                            Name = @"Identifier Type Code",
                            Length = 5,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0203",
                            TableName = @"Identifier type",
                            Description = @"A code corresponding to the type of identifier. In some cases, this code may be used as a qualifier to the <assigning authority> component. Refer to HL7 Table 0203 - Identifier type for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.13.14",
                            Type = @"Component",
                            Position = @"PV2.13.14",
                            Name = @"Assigning Facility",
                            Length = 227,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"The place or location identifier where the identifier was first assigned to the person. This component is not an inherent part of the identifier but rather part of the history of the identifier: as part of this data type, its existence is a convenience for certain intercommunicating systems.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"PV2.13.14.1",
                            Type = @"SubComponent",
                            Position = @"PV2.13.14.1",
                            Name = @"Namespace Id",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"Namespace ID is used as the HL7 identifier for the user-defined table of values for this component.

Note: When the HD is used in a given segment (either as a field or as a component of another data type) this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.13.14.2",
                            Type = @"SubComponent",
                            Position = @"PV2.13.14.2",
                            Name = @"Universal Id",
                            Length = 199,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HDs second component, <universal ID> (UID), is a string formatted according to the scheme defined by the third component, <universal ID type> (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.13.14.3",
                            Type = @"SubComponent",
                            Position = @"PV2.13.14.3",
                            Name = @"Universal Id Type",
                            Length = 6,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.13.15",
                            Type = @"Component",
                            Position = @"PV2.13.15",
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
                            Id = @"PV2.13.16",
                            Type = @"Component",
                            Position = @"PV2.13.16",
                            Name = @"Name Context",
                            Length = 483,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0448",
                            TableName = @"Name context",
                            Description = @"This component is used to designate the context in which a name is used. The main use case is in Australian healthcare for indigenous patients who prefer to use different names when attending different healthcare institutions. Another use case occurs in the US where health practitioners can be licensed under slightly different names and the reporting of the correct name is vital for administrative purposes. Refer to User-defined Table 0448 - Name context for suggested values.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"PV2.13.16.1",
                            Type = @"SubComponent",
                            Position = @"PV2.13.16.1",
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
                            Id = @"PV2.13.16.2",
                            Type = @"SubComponent",
                            Position = @"PV2.13.16.2",
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
                            Id = @"PV2.13.16.3",
                            Type = @"SubComponent",
                            Position = @"PV2.13.16.3",
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
                            Id = @"PV2.13.16.4",
                            Type = @"SubComponent",
                            Position = @"PV2.13.16.4",
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
                            Id = @"PV2.13.16.5",
                            Type = @"SubComponent",
                            Position = @"PV2.13.16.5",
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
                            Id = @"PV2.13.16.6",
                            Type = @"SubComponent",
                            Position = @"PV2.13.16.6",
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
                            Id = @"PV2.13.17",
                            Type = @"Component",
                            Position = @"PV2.13.17",
                            Name = @"Name Validity Range",
                            Length = 53,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"DR",
                            DataTypeName = @"Date/Time Range",
                            TableId = null,
                            TableName = null,
                            Description = @"Retained for backward compatibility only as of v 2.5. Refer to XCN.19 Effective Date and XCN.20 Expiration Date instead. This component cannot be fully expressed and has been identified as v 2.4 erratum.

This component contains the start and end date/times that define the period during which this name was valid. See section 2.A.20, "" DR - date/time range "" for description of subcomponents.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"PV2.13.17.1",
                            Type = @"SubComponent",
                            Position = @"PV2.13.17.1",
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
                            Id = @"PV2.13.17.1",
                            Type = @"SubComponent",
                            Position = @"PV2.13.17.1",
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
                            Id = @"PV2.13.17.2",
                            Type = @"SubComponent",
                            Position = @"PV2.13.17.2",
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
                            Id = @"PV2.13.17.2",
                            Type = @"SubComponent",
                            Position = @"PV2.13.17.2",
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
                            Id = @"PV2.13.17.1",
                            Type = @"SubComponent",
                            Position = @"PV2.13.17.1",
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
                            Id = @"PV2.13.17.2",
                            Type = @"SubComponent",
                            Position = @"PV2.13.17.2",
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
                            Id = @"PV2.13.18",
                            Type = @"Component",
                            Position = @"PV2.13.18",
                            Name = @"Name Assembly Order",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0444",
                            TableName = @"Name assembly order",
                            Description = @"A code that represents the preferred display order of the components of this person name. Refer to HL7 Table 0444 - Name Assembly Order for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.13.19",
                            Type = @"Component",
                            Position = @"PV2.13.19",
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
                            Id = @"PV2.13.19.1",
                            Type = @"SubComponent",
                            Position = @"PV2.13.19.1",
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
                            Id = @"PV2.13.19.2",
                            Type = @"SubComponent",
                            Position = @"PV2.13.19.2",
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
                            Id = @"PV2.13.20",
                            Type = @"Component",
                            Position = @"PV2.13.20",
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
                            Id = @"PV2.13.20.1",
                            Type = @"SubComponent",
                            Position = @"PV2.13.20.1",
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
                            Id = @"PV2.13.20.2",
                            Type = @"SubComponent",
                            Position = @"PV2.13.20.2",
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
                            Id = @"PV2.13.21",
                            Type = @"Component",
                            Position = @"PV2.13.21",
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
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.13.22",
                            Type = @"Component",
                            Position = @"PV2.13.22",
                            Name = @"Assigning Jurisdiction",
                            Length = 705,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded with Exceptions",
                            TableId = null,
                            TableName = null,
                            Description = @"The geo-political body that assigned the identifier in component 1.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"PV2.13.22.1",
                            Type = @"SubComponent",
                            Position = @"PV2.13.22.1",
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
                            Id = @"PV2.13.22.2",
                            Type = @"SubComponent",
                            Position = @"PV2.13.22.2",
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
                            Id = @"PV2.13.22.3",
                            Type = @"SubComponent",
                            Position = @"PV2.13.22.3",
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
                            Id = @"PV2.13.22.4",
                            Type = @"SubComponent",
                            Position = @"PV2.13.22.4",
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
                            Id = @"PV2.13.22.5",
                            Type = @"SubComponent",
                            Position = @"PV2.13.22.5",
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
                            Id = @"PV2.13.22.6",
                            Type = @"SubComponent",
                            Position = @"PV2.13.22.6",
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
                            Id = @"PV2.13.22.7",
                            Type = @"SubComponent",
                            Position = @"PV2.13.22.7",
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
                            Id = @"PV2.13.22.8",
                            Type = @"SubComponent",
                            Position = @"PV2.13.22.8",
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
                            Id = @"PV2.13.22.9",
                            Type = @"SubComponent",
                            Position = @"PV2.13.22.9",
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
                            Id = @"PV2.13.23",
                            Type = @"Component",
                            Position = @"PV2.13.23",
                            Name = @"Assigning Agency Or Department",
                            Length = 705,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded with Exceptions",
                            TableId = null,
                            TableName = null,
                            Description = @"The agency or department that assigned the identifier in component 1.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"PV2.13.23.1",
                            Type = @"SubComponent",
                            Position = @"PV2.13.23.1",
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
                            Id = @"PV2.13.23.2",
                            Type = @"SubComponent",
                            Position = @"PV2.13.23.2",
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
                            Id = @"PV2.13.23.3",
                            Type = @"SubComponent",
                            Position = @"PV2.13.23.3",
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
                            Id = @"PV2.13.23.4",
                            Type = @"SubComponent",
                            Position = @"PV2.13.23.4",
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
                            Id = @"PV2.13.23.5",
                            Type = @"SubComponent",
                            Position = @"PV2.13.23.5",
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
                            Id = @"PV2.13.23.6",
                            Type = @"SubComponent",
                            Position = @"PV2.13.23.6",
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
                            Id = @"PV2.13.23.7",
                            Type = @"SubComponent",
                            Position = @"PV2.13.23.7",
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
                            Id = @"PV2.13.23.8",
                            Type = @"SubComponent",
                            Position = @"PV2.13.23.8",
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
                            Id = @"PV2.13.23.9",
                            Type = @"SubComponent",
                            Position = @"PV2.13.23.9",
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
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.14",
                            Type = @"Field",
                            Position = @"PV2.14",
                            Name = @"Previous Service Date",
                            Length = 8,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DT",
                            DataTypeName = @"Date",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the date of previous service for the same recurring condition. This may be a required field for billing certain illnesses (e.g., accident related) to a third party.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.15",
                            Type = @"Field",
                            Position = @"PV2.15",
                            Name = @"Employment Illness Related Indicator",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0136",
                            TableName = @"Yes/no indicator",
                            Description = @"This field specifies whether a patients illness was job-related. Refer to HL7 Table 0136 - Yes/no Indicator for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.16",
                            Type = @"Field",
                            Position = @"PV2.16",
                            Name = @"Purge Status Code",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0213",
                            TableName = @"Purge Status Code",
                            Description = @"This field contains the purge status code for the account. It is used by the application program to determine purge processing. Refer to User-defined Table 0213 - Purge Status Code for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.17",
                            Type = @"Field",
                            Position = @"PV2.17",
                            Name = @"Purge Status Date",
                            Length = 8,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DT",
                            DataTypeName = @"Date",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the date on which the data will be purged from the system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.18",
                            Type = @"Field",
                            Position = @"PV2.18",
                            Name = @"Special Program Code",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0214",
                            TableName = @"Special Program Code",
                            Description = @"This field designates the specific health insurance program for a visit required for healthcare reimbursement. Refer to User-defined Table 0214 - Special Program Codes for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.19",
                            Type = @"Field",
                            Position = @"PV2.19",
                            Name = @"Retention Indicator",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0136",
                            TableName = @"Yes/no indicator",
                            Description = @"This field allows the user to control the financial and demographic purge processes at the visit. It is used to preserve demographic and financial data on specific, high priority visits. Refer to HL7 Table 0136 - Yes/no Indicator for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.20",
                            Type = @"Field",
                            Position = @"PV2.20",
                            Name = @"Expected Number of Insurance Plans",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the number of insurance plans that may provide coverage for this visit.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.21",
                            Type = @"Field",
                            Position = @"PV2.21",
                            Name = @"Visit Publicity Code",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0215",
                            TableName = @"Publicity Code",
                            Description = @"This field contains a user-defined code indicating what level of publicity is allowed for a specific visit. Refer to User-defined Table 0215 - Publicity Code for suggested values. Refer to PD1-11 - Publicity Code for the patient level publicity code.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.22",
                            Type = @"Field",
                            Position = @"PV2.22",
                            Name = @"Visit Protection Indicator",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0136",
                            TableName = @"Yes/no indicator",
                            Description = @"This field identifies the persons protection that determines, in turn, whether access to information about this person should be kept from users who do not have adequate authority for a specific visit. Refer to HL7 Table 0136 - Yes/no Indicator for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.23",
                            Type = @"Field",
                            Position = @"PV2.23",
                            Name = @"Clinic Organization Name",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"XON",
                            DataTypeName = @"Extended Composite Name and Identification Number for Organizations",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the organization name or sub-unit and identifier that is associated with the (visit) episode of care. For example, the Allergy or Oncology Clinic within the healthcare facility might be named.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"PV2.23.1",
                            Type = @"Component",
                            Position = @"PV2.23.1",
                            Name = @"Organization Name",
                            Length = 50,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The name of the specified organization.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.23.2",
                            Type = @"Component",
                            Position = @"PV2.23.2",
                            Name = @"Organization Name Type Code",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0204",
                            TableName = @"Organizational name type",
                            Description = @"A code that represents the type of name i.e., legal name, display name. Refer to User-defined Table 0204 - Organizational Name Type for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.23.3",
                            Type = @"Component",
                            Position = @"PV2.23.3",
                            Name = @"Id Number",
                            Length = 4,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This component has been retained for backward compatibility only as of v 2.5. It is recommended to use component 10 Organization identifier that accommodates alphanumeric identifiers.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.23.4",
                            Type = @"Component",
                            Position = @"PV2.23.4",
                            Name = @"Check Digit",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"The check digit in this data type is not an add-on produced by the message processor. It is the check digit that is part of the identifying number used in the sending application. If the sending application does not include a self-generated check digit in the identifying number, this component should be valued null.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.23.5",
                            Type = @"Component",
                            Position = @"PV2.23.5",
                            Name = @"Check Digit Scheme",
                            Length = 3,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0061",
                            TableName = @"Check digit scheme",
                            Description = @"Contains the code identifying the check digit scheme employed.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.23.6",
                            Type = @"Component",
                            Position = @"PV2.23.6",
                            Name = @"Assigning Authority",
                            Length = 227,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = @"0363",
                            TableName = @"Assigning authority",
                            Description = @"The assigning authority is a unique identifier of the system (or organization or agency or department) that creates the data. Assigning authorities are unique across a given HL7 implementation. Refer to User-defined Table 0363 - Assigning Authority for suggested values.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"PV2.23.6.1",
                            Type = @"SubComponent",
                            Position = @"PV2.23.6.1",
                            Name = @"Namespace Id",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"Namespace ID is used as the HL7 identifier for the user-defined table of values for this component.

Note: When the HD is used in a given segment (either as a field or as a component of another data type) this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.23.6.2",
                            Type = @"SubComponent",
                            Position = @"PV2.23.6.2",
                            Name = @"Universal Id",
                            Length = 199,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HDs second component, <universal ID> (UID), is a string formatted according to the scheme defined by the third component, <universal ID type> (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.23.6.3",
                            Type = @"SubComponent",
                            Position = @"PV2.23.6.3",
                            Name = @"Universal Id Type",
                            Length = 6,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.23.7",
                            Type = @"Component",
                            Position = @"PV2.23.7",
                            Name = @"Identifier Type Code",
                            Length = 5,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0203",
                            TableName = @"Identifier type",
                            Description = @"A code corresponding to the type of identifier. In some cases, this code may be used as a qualifier to the ""Assigning authority"" component. Refer to HL7 Table 0203 - Identifier type for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.23.8",
                            Type = @"Component",
                            Position = @"PV2.23.8",
                            Name = @"Assigning Facility",
                            Length = 227,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"The place or location identifier where the identifier was first assigned to the person. This component is not an inherent part of the identifier but rather part of the history of the identifier: as part of this data type, its existence is a convenience for certain intercommunicating systems.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"PV2.23.8.1",
                            Type = @"SubComponent",
                            Position = @"PV2.23.8.1",
                            Name = @"Namespace Id",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"Namespace ID is used as the HL7 identifier for the user-defined table of values for this component.

Note: When the HD is used in a given segment (either as a field or as a component of another data type) this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.23.8.2",
                            Type = @"SubComponent",
                            Position = @"PV2.23.8.2",
                            Name = @"Universal Id",
                            Length = 199,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HDs second component, <universal ID> (UID), is a string formatted according to the scheme defined by the third component, <universal ID type> (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.23.8.3",
                            Type = @"SubComponent",
                            Position = @"PV2.23.8.3",
                            Name = @"Universal Id Type",
                            Length = 6,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.23.9",
                            Type = @"Component",
                            Position = @"PV2.23.9",
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
                            Id = @"PV2.23.10",
                            Type = @"Component",
                            Position = @"PV2.23.10",
                            Name = @"Organization Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component contains the sequence of characters (the code) that uniquely identifies the item being referenced by XON.1 Organization Name. This component replaces XON.3 ID Number as of v 2.5.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.24",
                            Type = @"Field",
                            Position = @"PV2.24",
                            Name = @"Patient Status Code",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0216",
                            TableName = @"Patient Status Code",
                            Description = @"This field indicates the status of the episode of care. Refer to User-defined Table 0216 - Patient Status for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.25",
                            Type = @"Field",
                            Position = @"PV2.25",
                            Name = @"Visit Priority Code",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0217",
                            TableName = @"Visit Priority Code",
                            Description = @"This field contains the priority of the visit. Refer to User-defined Table 0217 - Visit Priority Code for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.26",
                            Type = @"Field",
                            Position = @"PV2.26",
                            Name = @"Previous Treatment Date",
                            Length = 8,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DT",
                            DataTypeName = @"Date",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the date that the patient last had treatment for any condition prior to this visit. In the case of a prior hospital visit, it is likely to be the previous discharge date.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.27",
                            Type = @"Field",
                            Position = @"PV2.27",
                            Name = @"Expected Discharge Disposition",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0112",
                            TableName = @"Discharge Disposition",
                            Description = @"This field describes what the patients disposition is expected to be at the end of the visit. Refer to User-defined Table 0112 - Discharge Disposition for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.28",
                            Type = @"Field",
                            Position = @"PV2.28",
                            Name = @"Signature on File Date",
                            Length = 8,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DT",
                            DataTypeName = @"Date",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the date on which a signature was obtained for insurance billing purposes.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.29",
                            Type = @"Field",
                            Position = @"PV2.29",
                            Name = @"First Similar Illness Date",
                            Length = 8,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DT",
                            DataTypeName = @"Date",
                            TableId = null,
                            TableName = null,
                            Description = @"This field is used to determine if the patient has a pre-existing condition.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.30",
                            Type = @"Field",
                            Position = @"PV2.30",
                            Name = @"Patient Charge Adjustment Code",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0218",
                            TableName = @"Patient Charge Adjustment",
                            Description = @"This field contains a user-defined code that indicates which adjustments should be made to this patients charges. Refer to User-defined Table 0218 - Charge Adjustment for suggested values. This field is the same as GT1-26 - Guarantor Charge Adjustment Code.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"PV2.30.1",
                            Type = @"Component",
                            Position = @"PV2.30.1",
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
                            Id = @"PV2.30.2",
                            Type = @"Component",
                            Position = @"PV2.30.2",
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
                            Id = @"PV2.30.3",
                            Type = @"Component",
                            Position = @"PV2.30.3",
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
                            Id = @"PV2.30.4",
                            Type = @"Component",
                            Position = @"PV2.30.4",
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
                            Id = @"PV2.30.5",
                            Type = @"Component",
                            Position = @"PV2.30.5",
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
                            Id = @"PV2.30.6",
                            Type = @"Component",
                            Position = @"PV2.30.6",
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
                            Id = @"PV2.31",
                            Type = @"Field",
                            Position = @"PV2.31",
                            Name = @"Recurring Service Code",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0219",
                            TableName = @"Recurring Service Code",
                            Description = @"This field indicates whether the treatment is continuous. Refer to User-defined Table 0219 - Recurring Service for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.32",
                            Type = @"Field",
                            Position = @"PV2.32",
                            Name = @"Billing Media Code",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0136",
                            TableName = @"Yes/no indicator",
                            Description = @"This field indicates if the account is to be rejected from tape billing. Refer to HL7 Table 0136 - Yes/no Indicator for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.33",
                            Type = @"Field",
                            Position = @"PV2.33",
                            Name = @"Expected Surgery Date and Time",
                            Length = 26,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the date and time on which the surgery is expected to occur.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"PV2.33.1",
                            Type = @"Component",
                            Position = @"PV2.33.1",
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
                            Id = @"PV2.33.2",
                            Type = @"Component",
                            Position = @"PV2.33.2",
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
                            Id = @"PV2.34",
                            Type = @"Field",
                            Position = @"PV2.34",
                            Name = @"Military Partnership Code",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0136",
                            TableName = @"Yes/no indicator",
                            Description = @"This field indicates that a military healthcare facility has contracted with a non-military healthcare facility for the use of its services. Refer to HL7 Table 0136 - Yes/no Indicator for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.35",
                            Type = @"Field",
                            Position = @"PV2.35",
                            Name = @"Military Non-Availability Code",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0136",
                            TableName = @"Yes/no indicator",
                            Description = @"This field indicates whether a patient has permission to use a non-military healthcare facility for treatment. Refer to HL7 Table 0136 - Yes/no Indicator for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.36",
                            Type = @"Field",
                            Position = @"PV2.36",
                            Name = @"Newborn Baby Indicator",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0136",
                            TableName = @"Yes/no indicator",
                            Description = @"This field indicates whether the patient is a baby. Refer to HL7 Table 0136 - Yes/no Indicator for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.37",
                            Type = @"Field",
                            Position = @"PV2.37",
                            Name = @"Baby Detained Indicator",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0136",
                            TableName = @"Yes/no indicator",
                            Description = @"This field indicates if the baby is detained after the mothers discharge. Refer to HL7 Table 0136 - Yes/no Indicator for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.38",
                            Type = @"Field",
                            Position = @"PV2.38",
                            Name = @"Mode of Arrival Code",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0430",
                            TableName = @"Mode of Arrival Code",
                            Description = @"Identifies how the patient was brought to the healthcare facility. Refer to User-defined Table 0430 - Mode of Arrival Code for suggested values.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"PV2.38.1",
                            Type = @"Component",
                            Position = @"PV2.38.1",
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
                            Id = @"PV2.38.2",
                            Type = @"Component",
                            Position = @"PV2.38.2",
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
                            Id = @"PV2.38.3",
                            Type = @"Component",
                            Position = @"PV2.38.3",
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
                            Id = @"PV2.38.4",
                            Type = @"Component",
                            Position = @"PV2.38.4",
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
                            Id = @"PV2.38.5",
                            Type = @"Component",
                            Position = @"PV2.38.5",
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
                            Id = @"PV2.38.6",
                            Type = @"Component",
                            Position = @"PV2.38.6",
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
                            Id = @"PV2.39",
                            Type = @"Field",
                            Position = @"PV2.39",
                            Name = @"Recreational Drug Use Code",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0431",
                            TableName = @"Recreational Drug Use Code",
                            Description = @"This field indicates what recreational drugs the patient uses. It is used for the purpose of room assignment. Refer to User-defined Table 0431 - Recreational Drug Use Code for suggested values.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"PV2.39.1",
                            Type = @"Component",
                            Position = @"PV2.39.1",
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
                            Id = @"PV2.39.2",
                            Type = @"Component",
                            Position = @"PV2.39.2",
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
                            Id = @"PV2.39.3",
                            Type = @"Component",
                            Position = @"PV2.39.3",
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
                            Id = @"PV2.39.4",
                            Type = @"Component",
                            Position = @"PV2.39.4",
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
                            Id = @"PV2.39.5",
                            Type = @"Component",
                            Position = @"PV2.39.5",
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
                            Id = @"PV2.39.6",
                            Type = @"Component",
                            Position = @"PV2.39.6",
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
                            Id = @"PV2.40",
                            Type = @"Field",
                            Position = @"PV2.40",
                            Name = @"Admission Level of Care Code",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0432",
                            TableName = @"Admission Level of Care Code",
                            Description = @"This field indicates the acuity level assigned to the patient at the time of admission. Refer to User-defined Table 0432 - Admission Level of Care Code for suggested values.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"PV2.40.1",
                            Type = @"Component",
                            Position = @"PV2.40.1",
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
                            Id = @"PV2.40.2",
                            Type = @"Component",
                            Position = @"PV2.40.2",
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
                            Id = @"PV2.40.3",
                            Type = @"Component",
                            Position = @"PV2.40.3",
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
                            Id = @"PV2.40.4",
                            Type = @"Component",
                            Position = @"PV2.40.4",
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
                            Id = @"PV2.40.5",
                            Type = @"Component",
                            Position = @"PV2.40.5",
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
                            Id = @"PV2.40.6",
                            Type = @"Component",
                            Position = @"PV2.40.6",
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
                            Id = @"PV2.41",
                            Type = @"Field",
                            Position = @"PV2.41",
                            Name = @"Precaution Code",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0433",
                            TableName = @"Precaution Code",
                            Description = @"This field indicates non-clinical precautions that need to be taken with the patient. Refer to User-defined Table 0433 - Precaution Code for suggested values.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"PV2.41.1",
                            Type = @"Component",
                            Position = @"PV2.41.1",
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
                            Id = @"PV2.41.2",
                            Type = @"Component",
                            Position = @"PV2.41.2",
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
                            Id = @"PV2.41.3",
                            Type = @"Component",
                            Position = @"PV2.41.3",
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
                            Id = @"PV2.41.4",
                            Type = @"Component",
                            Position = @"PV2.41.4",
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
                            Id = @"PV2.41.5",
                            Type = @"Component",
                            Position = @"PV2.41.5",
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
                            Id = @"PV2.41.6",
                            Type = @"Component",
                            Position = @"PV2.41.6",
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
                            Id = @"PV2.42",
                            Type = @"Field",
                            Position = @"PV2.42",
                            Name = @"Patient Condition Code",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0434",
                            TableName = @"Patient Condition Code",
                            Description = @"This field indicates the patients current medical condition for the purpose of communicating to non-medical outside parties, e.g. family, employer, religious minister, media, etc. Refer to User-defined Table 0434 - Patient Condition Code for suggested values.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"PV2.42.1",
                            Type = @"Component",
                            Position = @"PV2.42.1",
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
                            Id = @"PV2.42.2",
                            Type = @"Component",
                            Position = @"PV2.42.2",
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
                            Id = @"PV2.42.3",
                            Type = @"Component",
                            Position = @"PV2.42.3",
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
                            Id = @"PV2.42.4",
                            Type = @"Component",
                            Position = @"PV2.42.4",
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
                            Id = @"PV2.42.5",
                            Type = @"Component",
                            Position = @"PV2.42.5",
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
                            Id = @"PV2.42.6",
                            Type = @"Component",
                            Position = @"PV2.42.6",
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
                            Id = @"PV2.43",
                            Type = @"Field",
                            Position = @"PV2.43",
                            Name = @"Living Will Code",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0315",
                            TableName = @"Living Will Code",
                            Description = @"This field indicates whether or not the patient has a living will and, if so, whether a copy of the living will is on file at the healthcare facility. If the patient does not have a living will, the value of this field indicates whether the patient was provided information on living wills. Refer to User-defined Table 0315 - Living Will Code for suggested values. See also PD1-7 - Living Will.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.44",
                            Type = @"Field",
                            Position = @"PV2.44",
                            Name = @"Organ Donor Code",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0316",
                            TableName = @"Organ Donor Code",
                            Description = @"This field indicate whether the patient wants to donate his/her organs and whether an organ donor card or similar documentation is on file with the healthcare organization. Refer to User-defined Table 0316 - Organ Donor Code for suggested values. See also PD1-8 - Organ Donor.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.45",
                            Type = @"Field",
                            Position = @"PV2.45",
                            Name = @"Advance Directive Code",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0435",
                            TableName = @"Advance Directive Code",
                            Description = @"This field indicates the patients instructions to the healthcare facility. Refer to User-defined Table 0435 - Advance Directive Code for suggested values. See also PD1-15 - Advance Directive Code.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"PV2.45.1",
                            Type = @"Component",
                            Position = @"PV2.45.1",
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
                            Id = @"PV2.45.2",
                            Type = @"Component",
                            Position = @"PV2.45.2",
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
                            Id = @"PV2.45.3",
                            Type = @"Component",
                            Position = @"PV2.45.3",
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
                            Id = @"PV2.45.4",
                            Type = @"Component",
                            Position = @"PV2.45.4",
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
                            Id = @"PV2.45.5",
                            Type = @"Component",
                            Position = @"PV2.45.5",
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
                            Id = @"PV2.45.6",
                            Type = @"Component",
                            Position = @"PV2.45.6",
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
                            Id = @"PV2.46",
                            Type = @"Field",
                            Position = @"PV2.46",
                            Name = @"Patient Status Effective Date",
                            Length = 8,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DT",
                            DataTypeName = @"Date",
                            TableId = null,
                            TableName = null,
                            Description = @"This field indicates the effective date for PV2-24 - Patient Status.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV2.47",
                            Type = @"Field",
                            Position = @"PV2.47",
                            Name = @"Expected LOA Return Date/Time",
                            Length = 26,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"This field is conditionally required for A21 - Patient goes on LOA. It may be populated in A22 - Patient returns from LOA as well as in the A53 - Cancel LOA for a patient and the A54 - Cancel patient returns from LOA triggers. This field contains the date/time that the patient is expected to return from LOA.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"PV2.47.1",
                            Type = @"Component",
                            Position = @"PV2.47.1",
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
                            Id = @"PV2.47.2",
                            Type = @"Component",
                            Position = @"PV2.47.2",
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
                            Id = @"PV2.48",
                            Type = @"Field",
                            Position = @"PV2.48",
                            Name = @"Expected Pre-admission Testing Date/Time",
                            Length = 26,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the date/time that the patient is expected for pre-admission testing.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"PV2.48.1",
                            Type = @"Component",
                            Position = @"PV2.48.1",
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
                            Id = @"PV2.48.2",
                            Type = @"Component",
                            Position = @"PV2.48.2",
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
                            Id = @"PV2.49",
                            Type = @"Field",
                            Position = @"PV2.49",
                            Name = @"Notify Clergy Code",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0534",
                            TableName = @"Notify Clergy Code",
                            Description = @"This field allows the user to indicate whether the clergy should be notified. Refer to User-defined Table 0534 - Notify Clergy Code for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        };
            }
        }

        public HL7V251SegmentPV2(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V251Field priorPendingLocation;

public HL7V251Field PriorPendingLocation
{
    get
    {
        if (priorPendingLocation != null)
        {
            return priorPendingLocation;
        }

        priorPendingLocation = new HL7V251Field
        {
            field = message[@"PV2"][1],
            Id = @"PV2.1",
            Type = @"Field",
            Position = @"PV2.1",
            Name = @"Prior Pending Location",
            Length = 80,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"PL",
            DataTypeName = @"Person Location",
            TableId = null,
            TableName = null,
            Description = @"This field is required for cancel pending transfer (A26) messages.  In all other events it is optional.",
            Sample = @"",
        };

        

        

        

        return priorPendingLocation;
    } 
}
internal HL7V251Field accommodationCode;

public HL7V251Field AccommodationCode
{
    get
    {
        if (accommodationCode != null)
        {
            return accommodationCode;
        }

        accommodationCode = new HL7V251Field
        {
            field = message[@"PV2"][2],
            Id = @"PV2.2",
            Type = @"Field",
            Position = @"PV2.2",
            Name = @"Accommodation Code",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0129",
            TableName = @"Accommodation code",
            Description = @"This field indicates the specific patient accommodations for this visit. Refer to User-defined Table 0129 - Accommodation Code for suggested values.",
            Sample = @"",
        };

        

        

        

        return accommodationCode;
    } 
}
internal HL7V251Field admitReason;

public HL7V251Field AdmitReason
{
    get
    {
        if (admitReason != null)
        {
            return admitReason;
        }

        admitReason = new HL7V251Field
        {
            field = message[@"PV2"][3],
            Id = @"PV2.3",
            Type = @"Field",
            Position = @"PV2.3",
            Name = @"Admit Reason",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains the short description of the reason for patient admission.",
            Sample = @"",
        };

        

        

        

        return admitReason;
    } 
}
internal HL7V251Field transferReason;

public HL7V251Field TransferReason
{
    get
    {
        if (transferReason != null)
        {
            return transferReason;
        }

        transferReason = new HL7V251Field
        {
            field = message[@"PV2"][4],
            Id = @"PV2.4",
            Type = @"Field",
            Position = @"PV2.4",
            Name = @"Transfer Reason",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains the short description of the reason for a patient location change.",
            Sample = @"",
        };

        

        

        

        return transferReason;
    } 
}
internal HL7V251Field patientValuables;

public HL7V251Field PatientValuables
{
    get
    {
        if (patientValuables != null)
        {
            return patientValuables;
        }

        patientValuables = new HL7V251Field
        {
            field = message[@"PV2"][5],
            Id = @"PV2.5",
            Type = @"Field",
            Position = @"PV2.5",
            Name = @"Patient Valuables",
            Length = 25,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the short description of patient valuables checked in during admission.",
            Sample = @"",
        };

        

        

        

        return patientValuables;
    } 
}
internal HL7V251Field patientValuablesLocation;

public HL7V251Field PatientValuablesLocation
{
    get
    {
        if (patientValuablesLocation != null)
        {
            return patientValuablesLocation;
        }

        patientValuablesLocation = new HL7V251Field
        {
            field = message[@"PV2"][6],
            Id = @"PV2.6",
            Type = @"Field",
            Position = @"PV2.6",
            Name = @"Patient Valuables Location",
            Length = 25,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field indicates the location of the patients valuables.",
            Sample = @"",
        };

        

        

        

        return patientValuablesLocation;
    } 
}
internal HL7V251Field visitUserCode;

public HL7V251Field VisitUserCode
{
    get
    {
        if (visitUserCode != null)
        {
            return visitUserCode;
        }

        visitUserCode = new HL7V251Field
        {
            field = message[@"PV2"][7],
            Id = @"PV2.7",
            Type = @"Field",
            Position = @"PV2.7",
            Name = @"Visit User Code",
            Length = 2,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0130",
            TableName = @"Visit User Code",
            Description = @"This field further categorizes a patients visit with respect to an individual institutions needs, and is expected to be site-specific. Refer to User-defined Table 0130 - Visit User Code for suggested values.",
            Sample = @"",
        };

        

        

        

        return visitUserCode;
    } 
}
internal HL7V251Field expectedAdmitDateTime;

public HL7V251Field ExpectedAdmitDateTime
{
    get
    {
        if (expectedAdmitDateTime != null)
        {
            return expectedAdmitDateTime;
        }

        expectedAdmitDateTime = new HL7V251Field
        {
            field = message[@"PV2"][8],
            Id = @"PV2.8",
            Type = @"Field",
            Position = @"PV2.8",
            Name = @"Expected Admit Date/Time",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date and time that the patient is expected to be admitted. This field is also used to reflect the date/time of an outpatient/emergency patient registration.",
            Sample = @"",
        };

        

        

        

        return expectedAdmitDateTime;
    } 
}
internal HL7V251Field expectedDischargeDateTime;

public HL7V251Field ExpectedDischargeDateTime
{
    get
    {
        if (expectedDischargeDateTime != null)
        {
            return expectedDischargeDateTime;
        }

        expectedDischargeDateTime = new HL7V251Field
        {
            field = message[@"PV2"][9],
            Id = @"PV2.9",
            Type = @"Field",
            Position = @"PV2.9",
            Name = @"Expected Discharge Date/Time",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date and time that the patient is expected to be discharged. This is a non-event related date used by ancillaries to determine more accurately the projected workloads. This field is also used to reflect the anticipated discharge date/time of an outpatient/emergency patient, or an inpatient.",
            Sample = @"",
        };

        

        

        

        return expectedDischargeDateTime;
    } 
}
internal HL7V251Field estimatedLengthofInpatientStay;

public HL7V251Field EstimatedLengthofInpatientStay
{
    get
    {
        if (estimatedLengthofInpatientStay != null)
        {
            return estimatedLengthofInpatientStay;
        }

        estimatedLengthofInpatientStay = new HL7V251Field
        {
            field = message[@"PV2"][10],
            Id = @"PV2.10",
            Type = @"Field",
            Position = @"PV2.10",
            Name = @"Estimated Length of Inpatient Stay",
            Length = 3,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field specifies the estimated days of inpatient stays.",
            Sample = @"",
        };

        

        

        

        return estimatedLengthofInpatientStay;
    } 
}
internal HL7V251Field actualLengthofInpatientStay;

public HL7V251Field ActualLengthofInpatientStay
{
    get
    {
        if (actualLengthofInpatientStay != null)
        {
            return actualLengthofInpatientStay;
        }

        actualLengthofInpatientStay = new HL7V251Field
        {
            field = message[@"PV2"][11],
            Id = @"PV2.11",
            Type = @"Field",
            Position = @"PV2.11",
            Name = @"Actual Length of Inpatient Stay",
            Length = 3,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the actual days of inpatient stays. The actual length of the inpatient stay may not be calculated from the admission and discharge dates because of possible leaves of absence.",
            Sample = @"",
        };

        

        

        

        return actualLengthofInpatientStay;
    } 
}
internal HL7V251Field visitDescription;

public HL7V251Field VisitDescription
{
    get
    {
        if (visitDescription != null)
        {
            return visitDescription;
        }

        visitDescription = new HL7V251Field
        {
            field = message[@"PV2"][12],
            Id = @"PV2.12",
            Type = @"Field",
            Position = @"PV2.12",
            Name = @"Visit Description",
            Length = 50,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains a brief user-defined description of the visit.",
            Sample = @"",
        };

        

        

        

        return visitDescription;
    } 
}
internal HL7V251Field referralSourceCode;

public HL7V251Field ReferralSourceCode
{
    get
    {
        if (referralSourceCode != null)
        {
            return referralSourceCode;
        }

        referralSourceCode = new HL7V251Field
        {
            field = message[@"PV2"][13],
            Id = @"PV2.13",
            Type = @"Field",
            Position = @"PV2.13",
            Name = @"Referral Source Code",
            Length = 250,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XCN",
            DataTypeName = @"Extended Composite ID Number and Name for Persons",
            TableId = null,
            TableName = null,
            Description = @"This field contains the name and the identification numbers of the person or organization that made the referral. This person/organization is not the same as the referring doctor. For example, Joe Smith referred me to the Clinic (or to Dr. Jones at the Clinic).",
            Sample = @"",
        };

        

        

        

        return referralSourceCode;
    } 
}
internal HL7V251Field previousServiceDate;

public HL7V251Field PreviousServiceDate
{
    get
    {
        if (previousServiceDate != null)
        {
            return previousServiceDate;
        }

        previousServiceDate = new HL7V251Field
        {
            field = message[@"PV2"][14],
            Id = @"PV2.14",
            Type = @"Field",
            Position = @"PV2.14",
            Name = @"Previous Service Date",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date of previous service for the same recurring condition. This may be a required field for billing certain illnesses (e.g., accident related) to a third party.",
            Sample = @"",
        };

        

        

        

        return previousServiceDate;
    } 
}
internal HL7V251Field employmentIllnessRelatedIndicator;

public HL7V251Field EmploymentIllnessRelatedIndicator
{
    get
    {
        if (employmentIllnessRelatedIndicator != null)
        {
            return employmentIllnessRelatedIndicator;
        }

        employmentIllnessRelatedIndicator = new HL7V251Field
        {
            field = message[@"PV2"][15],
            Id = @"PV2.15",
            Type = @"Field",
            Position = @"PV2.15",
            Name = @"Employment Illness Related Indicator",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0136",
            TableName = @"Yes/no indicator",
            Description = @"This field specifies whether a patients illness was job-related. Refer to HL7 Table 0136 - Yes/no Indicator for valid values.",
            Sample = @"",
        };

        

        

        

        return employmentIllnessRelatedIndicator;
    } 
}
internal HL7V251Field purgeStatusCode;

public HL7V251Field PurgeStatusCode
{
    get
    {
        if (purgeStatusCode != null)
        {
            return purgeStatusCode;
        }

        purgeStatusCode = new HL7V251Field
        {
            field = message[@"PV2"][16],
            Id = @"PV2.16",
            Type = @"Field",
            Position = @"PV2.16",
            Name = @"Purge Status Code",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0213",
            TableName = @"Purge Status Code",
            Description = @"This field contains the purge status code for the account. It is used by the application program to determine purge processing. Refer to User-defined Table 0213 - Purge Status Code for suggested values.",
            Sample = @"",
        };

        

        

        

        return purgeStatusCode;
    } 
}
internal HL7V251Field purgeStatusDate;

public HL7V251Field PurgeStatusDate
{
    get
    {
        if (purgeStatusDate != null)
        {
            return purgeStatusDate;
        }

        purgeStatusDate = new HL7V251Field
        {
            field = message[@"PV2"][17],
            Id = @"PV2.17",
            Type = @"Field",
            Position = @"PV2.17",
            Name = @"Purge Status Date",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date on which the data will be purged from the system.",
            Sample = @"",
        };

        

        

        

        return purgeStatusDate;
    } 
}
internal HL7V251Field specialProgramCode;

public HL7V251Field SpecialProgramCode
{
    get
    {
        if (specialProgramCode != null)
        {
            return specialProgramCode;
        }

        specialProgramCode = new HL7V251Field
        {
            field = message[@"PV2"][18],
            Id = @"PV2.18",
            Type = @"Field",
            Position = @"PV2.18",
            Name = @"Special Program Code",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0214",
            TableName = @"Special Program Code",
            Description = @"This field designates the specific health insurance program for a visit required for healthcare reimbursement. Refer to User-defined Table 0214 - Special Program Codes for suggested values.",
            Sample = @"",
        };

        

        

        

        return specialProgramCode;
    } 
}
internal HL7V251Field retentionIndicator;

public HL7V251Field RetentionIndicator
{
    get
    {
        if (retentionIndicator != null)
        {
            return retentionIndicator;
        }

        retentionIndicator = new HL7V251Field
        {
            field = message[@"PV2"][19],
            Id = @"PV2.19",
            Type = @"Field",
            Position = @"PV2.19",
            Name = @"Retention Indicator",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0136",
            TableName = @"Yes/no indicator",
            Description = @"This field allows the user to control the financial and demographic purge processes at the visit. It is used to preserve demographic and financial data on specific, high priority visits. Refer to HL7 Table 0136 - Yes/no Indicator for valid values.",
            Sample = @"",
        };

        

        

        

        return retentionIndicator;
    } 
}
internal HL7V251Field expectedNumberofInsurancePlans;

public HL7V251Field ExpectedNumberofInsurancePlans
{
    get
    {
        if (expectedNumberofInsurancePlans != null)
        {
            return expectedNumberofInsurancePlans;
        }

        expectedNumberofInsurancePlans = new HL7V251Field
        {
            field = message[@"PV2"][20],
            Id = @"PV2.20",
            Type = @"Field",
            Position = @"PV2.20",
            Name = @"Expected Number of Insurance Plans",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the number of insurance plans that may provide coverage for this visit.",
            Sample = @"",
        };

        

        

        

        return expectedNumberofInsurancePlans;
    } 
}
internal HL7V251Field visitPublicityCode;

public HL7V251Field VisitPublicityCode
{
    get
    {
        if (visitPublicityCode != null)
        {
            return visitPublicityCode;
        }

        visitPublicityCode = new HL7V251Field
        {
            field = message[@"PV2"][21],
            Id = @"PV2.21",
            Type = @"Field",
            Position = @"PV2.21",
            Name = @"Visit Publicity Code",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0215",
            TableName = @"Publicity Code",
            Description = @"This field contains a user-defined code indicating what level of publicity is allowed for a specific visit. Refer to User-defined Table 0215 - Publicity Code for suggested values. Refer to PD1-11 - Publicity Code for the patient level publicity code.",
            Sample = @"",
        };

        

        

        

        return visitPublicityCode;
    } 
}
internal HL7V251Field visitProtectionIndicator;

public HL7V251Field VisitProtectionIndicator
{
    get
    {
        if (visitProtectionIndicator != null)
        {
            return visitProtectionIndicator;
        }

        visitProtectionIndicator = new HL7V251Field
        {
            field = message[@"PV2"][22],
            Id = @"PV2.22",
            Type = @"Field",
            Position = @"PV2.22",
            Name = @"Visit Protection Indicator",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0136",
            TableName = @"Yes/no indicator",
            Description = @"This field identifies the persons protection that determines, in turn, whether access to information about this person should be kept from users who do not have adequate authority for a specific visit. Refer to HL7 Table 0136 - Yes/no Indicator for valid values.",
            Sample = @"",
        };

        

        

        

        return visitProtectionIndicator;
    } 
}
internal HL7V251Field clinicOrganizationName;

public HL7V251Field ClinicOrganizationName
{
    get
    {
        if (clinicOrganizationName != null)
        {
            return clinicOrganizationName;
        }

        clinicOrganizationName = new HL7V251Field
        {
            field = message[@"PV2"][23],
            Id = @"PV2.23",
            Type = @"Field",
            Position = @"PV2.23",
            Name = @"Clinic Organization Name",
            Length = 250,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XON",
            DataTypeName = @"Extended Composite Name and Identification Number for Organizations",
            TableId = null,
            TableName = null,
            Description = @"This field contains the organization name or sub-unit and identifier that is associated with the (visit) episode of care. For example, the Allergy or Oncology Clinic within the healthcare facility might be named.",
            Sample = @"",
        };

        

        

        

        return clinicOrganizationName;
    } 
}
internal HL7V251Field patientStatusCode;

public HL7V251Field PatientStatusCode
{
    get
    {
        if (patientStatusCode != null)
        {
            return patientStatusCode;
        }

        patientStatusCode = new HL7V251Field
        {
            field = message[@"PV2"][24],
            Id = @"PV2.24",
            Type = @"Field",
            Position = @"PV2.24",
            Name = @"Patient Status Code",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0216",
            TableName = @"Patient Status Code",
            Description = @"This field indicates the status of the episode of care. Refer to User-defined Table 0216 - Patient Status for suggested values.",
            Sample = @"",
        };

        

        

        

        return patientStatusCode;
    } 
}
internal HL7V251Field visitPriorityCode;

public HL7V251Field VisitPriorityCode
{
    get
    {
        if (visitPriorityCode != null)
        {
            return visitPriorityCode;
        }

        visitPriorityCode = new HL7V251Field
        {
            field = message[@"PV2"][25],
            Id = @"PV2.25",
            Type = @"Field",
            Position = @"PV2.25",
            Name = @"Visit Priority Code",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0217",
            TableName = @"Visit Priority Code",
            Description = @"This field contains the priority of the visit. Refer to User-defined Table 0217 - Visit Priority Code for suggested values.",
            Sample = @"",
        };

        

        

        

        return visitPriorityCode;
    } 
}
internal HL7V251Field previousTreatmentDate;

public HL7V251Field PreviousTreatmentDate
{
    get
    {
        if (previousTreatmentDate != null)
        {
            return previousTreatmentDate;
        }

        previousTreatmentDate = new HL7V251Field
        {
            field = message[@"PV2"][26],
            Id = @"PV2.26",
            Type = @"Field",
            Position = @"PV2.26",
            Name = @"Previous Treatment Date",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date that the patient last had treatment for any condition prior to this visit. In the case of a prior hospital visit, it is likely to be the previous discharge date.",
            Sample = @"",
        };

        

        

        

        return previousTreatmentDate;
    } 
}
internal HL7V251Field expectedDischargeDisposition;

public HL7V251Field ExpectedDischargeDisposition
{
    get
    {
        if (expectedDischargeDisposition != null)
        {
            return expectedDischargeDisposition;
        }

        expectedDischargeDisposition = new HL7V251Field
        {
            field = message[@"PV2"][27],
            Id = @"PV2.27",
            Type = @"Field",
            Position = @"PV2.27",
            Name = @"Expected Discharge Disposition",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0112",
            TableName = @"Discharge Disposition",
            Description = @"This field describes what the patients disposition is expected to be at the end of the visit. Refer to User-defined Table 0112 - Discharge Disposition for suggested values.",
            Sample = @"",
        };

        

        

        

        return expectedDischargeDisposition;
    } 
}
internal HL7V251Field signatureonFileDate;

public HL7V251Field SignatureonFileDate
{
    get
    {
        if (signatureonFileDate != null)
        {
            return signatureonFileDate;
        }

        signatureonFileDate = new HL7V251Field
        {
            field = message[@"PV2"][28],
            Id = @"PV2.28",
            Type = @"Field",
            Position = @"PV2.28",
            Name = @"Signature on File Date",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date on which a signature was obtained for insurance billing purposes.",
            Sample = @"",
        };

        

        

        

        return signatureonFileDate;
    } 
}
internal HL7V251Field firstSimilarIllnessDate;

public HL7V251Field FirstSimilarIllnessDate
{
    get
    {
        if (firstSimilarIllnessDate != null)
        {
            return firstSimilarIllnessDate;
        }

        firstSimilarIllnessDate = new HL7V251Field
        {
            field = message[@"PV2"][29],
            Id = @"PV2.29",
            Type = @"Field",
            Position = @"PV2.29",
            Name = @"First Similar Illness Date",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = @"This field is used to determine if the patient has a pre-existing condition.",
            Sample = @"",
        };

        

        

        

        return firstSimilarIllnessDate;
    } 
}
internal HL7V251Field patientChargeAdjustmentCode;

public HL7V251Field PatientChargeAdjustmentCode
{
    get
    {
        if (patientChargeAdjustmentCode != null)
        {
            return patientChargeAdjustmentCode;
        }

        patientChargeAdjustmentCode = new HL7V251Field
        {
            field = message[@"PV2"][30],
            Id = @"PV2.30",
            Type = @"Field",
            Position = @"PV2.30",
            Name = @"Patient Charge Adjustment Code",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0218",
            TableName = @"Patient Charge Adjustment",
            Description = @"This field contains a user-defined code that indicates which adjustments should be made to this patients charges. Refer to User-defined Table 0218 - Charge Adjustment for suggested values. This field is the same as GT1-26 - Guarantor Charge Adjustment Code.",
            Sample = @"",
        };

        

        

        

        return patientChargeAdjustmentCode;
    } 
}
internal HL7V251Field recurringServiceCode;

public HL7V251Field RecurringServiceCode
{
    get
    {
        if (recurringServiceCode != null)
        {
            return recurringServiceCode;
        }

        recurringServiceCode = new HL7V251Field
        {
            field = message[@"PV2"][31],
            Id = @"PV2.31",
            Type = @"Field",
            Position = @"PV2.31",
            Name = @"Recurring Service Code",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0219",
            TableName = @"Recurring Service Code",
            Description = @"This field indicates whether the treatment is continuous. Refer to User-defined Table 0219 - Recurring Service for suggested values.",
            Sample = @"",
        };

        

        

        

        return recurringServiceCode;
    } 
}
internal HL7V251Field billingMediaCode;

public HL7V251Field BillingMediaCode
{
    get
    {
        if (billingMediaCode != null)
        {
            return billingMediaCode;
        }

        billingMediaCode = new HL7V251Field
        {
            field = message[@"PV2"][32],
            Id = @"PV2.32",
            Type = @"Field",
            Position = @"PV2.32",
            Name = @"Billing Media Code",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0136",
            TableName = @"Yes/no indicator",
            Description = @"This field indicates if the account is to be rejected from tape billing. Refer to HL7 Table 0136 - Yes/no Indicator for valid values.",
            Sample = @"",
        };

        

        

        

        return billingMediaCode;
    } 
}
internal HL7V251Field expectedSurgeryDateandTime;

public HL7V251Field ExpectedSurgeryDateandTime
{
    get
    {
        if (expectedSurgeryDateandTime != null)
        {
            return expectedSurgeryDateandTime;
        }

        expectedSurgeryDateandTime = new HL7V251Field
        {
            field = message[@"PV2"][33],
            Id = @"PV2.33",
            Type = @"Field",
            Position = @"PV2.33",
            Name = @"Expected Surgery Date and Time",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date and time on which the surgery is expected to occur.",
            Sample = @"",
        };

        

        

        

        return expectedSurgeryDateandTime;
    } 
}
internal HL7V251Field militaryPartnershipCode;

public HL7V251Field MilitaryPartnershipCode
{
    get
    {
        if (militaryPartnershipCode != null)
        {
            return militaryPartnershipCode;
        }

        militaryPartnershipCode = new HL7V251Field
        {
            field = message[@"PV2"][34],
            Id = @"PV2.34",
            Type = @"Field",
            Position = @"PV2.34",
            Name = @"Military Partnership Code",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0136",
            TableName = @"Yes/no indicator",
            Description = @"This field indicates that a military healthcare facility has contracted with a non-military healthcare facility for the use of its services. Refer to HL7 Table 0136 - Yes/no Indicator for valid values.",
            Sample = @"",
        };

        

        

        

        return militaryPartnershipCode;
    } 
}
internal HL7V251Field militaryNonAvailabilityCode;

public HL7V251Field MilitaryNonAvailabilityCode
{
    get
    {
        if (militaryNonAvailabilityCode != null)
        {
            return militaryNonAvailabilityCode;
        }

        militaryNonAvailabilityCode = new HL7V251Field
        {
            field = message[@"PV2"][35],
            Id = @"PV2.35",
            Type = @"Field",
            Position = @"PV2.35",
            Name = @"Military Non-Availability Code",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0136",
            TableName = @"Yes/no indicator",
            Description = @"This field indicates whether a patient has permission to use a non-military healthcare facility for treatment. Refer to HL7 Table 0136 - Yes/no Indicator for valid values.",
            Sample = @"",
        };

        

        

        

        return militaryNonAvailabilityCode;
    } 
}
internal HL7V251Field newbornBabyIndicator;

public HL7V251Field NewbornBabyIndicator
{
    get
    {
        if (newbornBabyIndicator != null)
        {
            return newbornBabyIndicator;
        }

        newbornBabyIndicator = new HL7V251Field
        {
            field = message[@"PV2"][36],
            Id = @"PV2.36",
            Type = @"Field",
            Position = @"PV2.36",
            Name = @"Newborn Baby Indicator",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0136",
            TableName = @"Yes/no indicator",
            Description = @"This field indicates whether the patient is a baby. Refer to HL7 Table 0136 - Yes/no Indicator for valid values.",
            Sample = @"",
        };

        

        

        

        return newbornBabyIndicator;
    } 
}
internal HL7V251Field babyDetainedIndicator;

public HL7V251Field BabyDetainedIndicator
{
    get
    {
        if (babyDetainedIndicator != null)
        {
            return babyDetainedIndicator;
        }

        babyDetainedIndicator = new HL7V251Field
        {
            field = message[@"PV2"][37],
            Id = @"PV2.37",
            Type = @"Field",
            Position = @"PV2.37",
            Name = @"Baby Detained Indicator",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0136",
            TableName = @"Yes/no indicator",
            Description = @"This field indicates if the baby is detained after the mothers discharge. Refer to HL7 Table 0136 - Yes/no Indicator for valid values.",
            Sample = @"",
        };

        

        

        

        return babyDetainedIndicator;
    } 
}
internal HL7V251Field modeofArrivalCode;

public HL7V251Field ModeofArrivalCode
{
    get
    {
        if (modeofArrivalCode != null)
        {
            return modeofArrivalCode;
        }

        modeofArrivalCode = new HL7V251Field
        {
            field = message[@"PV2"][38],
            Id = @"PV2.38",
            Type = @"Field",
            Position = @"PV2.38",
            Name = @"Mode of Arrival Code",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0430",
            TableName = @"Mode of Arrival Code",
            Description = @"Identifies how the patient was brought to the healthcare facility. Refer to User-defined Table 0430 - Mode of Arrival Code for suggested values.",
            Sample = @"",
        };

        

        

        

        return modeofArrivalCode;
    } 
}
internal HL7V251Field recreationalDrugUseCode;

public HL7V251Field RecreationalDrugUseCode
{
    get
    {
        if (recreationalDrugUseCode != null)
        {
            return recreationalDrugUseCode;
        }

        recreationalDrugUseCode = new HL7V251Field
        {
            field = message[@"PV2"][39],
            Id = @"PV2.39",
            Type = @"Field",
            Position = @"PV2.39",
            Name = @"Recreational Drug Use Code",
            Length = 250,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0431",
            TableName = @"Recreational Drug Use Code",
            Description = @"This field indicates what recreational drugs the patient uses. It is used for the purpose of room assignment. Refer to User-defined Table 0431 - Recreational Drug Use Code for suggested values.",
            Sample = @"",
        };

        

        

        

        return recreationalDrugUseCode;
    } 
}
internal HL7V251Field admissionLevelofCareCode;

public HL7V251Field AdmissionLevelofCareCode
{
    get
    {
        if (admissionLevelofCareCode != null)
        {
            return admissionLevelofCareCode;
        }

        admissionLevelofCareCode = new HL7V251Field
        {
            field = message[@"PV2"][40],
            Id = @"PV2.40",
            Type = @"Field",
            Position = @"PV2.40",
            Name = @"Admission Level of Care Code",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0432",
            TableName = @"Admission Level of Care Code",
            Description = @"This field indicates the acuity level assigned to the patient at the time of admission. Refer to User-defined Table 0432 - Admission Level of Care Code for suggested values.",
            Sample = @"",
        };

        

        

        

        return admissionLevelofCareCode;
    } 
}
internal HL7V251Field precautionCode;

public HL7V251Field PrecautionCode
{
    get
    {
        if (precautionCode != null)
        {
            return precautionCode;
        }

        precautionCode = new HL7V251Field
        {
            field = message[@"PV2"][41],
            Id = @"PV2.41",
            Type = @"Field",
            Position = @"PV2.41",
            Name = @"Precaution Code",
            Length = 250,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0433",
            TableName = @"Precaution Code",
            Description = @"This field indicates non-clinical precautions that need to be taken with the patient. Refer to User-defined Table 0433 - Precaution Code for suggested values.",
            Sample = @"",
        };

        

        

        

        return precautionCode;
    } 
}
internal HL7V251Field patientConditionCode;

public HL7V251Field PatientConditionCode
{
    get
    {
        if (patientConditionCode != null)
        {
            return patientConditionCode;
        }

        patientConditionCode = new HL7V251Field
        {
            field = message[@"PV2"][42],
            Id = @"PV2.42",
            Type = @"Field",
            Position = @"PV2.42",
            Name = @"Patient Condition Code",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0434",
            TableName = @"Patient Condition Code",
            Description = @"This field indicates the patients current medical condition for the purpose of communicating to non-medical outside parties, e.g. family, employer, religious minister, media, etc. Refer to User-defined Table 0434 - Patient Condition Code for suggested values.",
            Sample = @"",
        };

        

        

        

        return patientConditionCode;
    } 
}
internal HL7V251Field livingWillCode;

public HL7V251Field LivingWillCode
{
    get
    {
        if (livingWillCode != null)
        {
            return livingWillCode;
        }

        livingWillCode = new HL7V251Field
        {
            field = message[@"PV2"][43],
            Id = @"PV2.43",
            Type = @"Field",
            Position = @"PV2.43",
            Name = @"Living Will Code",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0315",
            TableName = @"Living Will Code",
            Description = @"This field indicates whether or not the patient has a living will and, if so, whether a copy of the living will is on file at the healthcare facility. If the patient does not have a living will, the value of this field indicates whether the patient was provided information on living wills. Refer to User-defined Table 0315 - Living Will Code for suggested values. See also PD1-7 - Living Will.",
            Sample = @"",
        };

        

        

        

        return livingWillCode;
    } 
}
internal HL7V251Field organDonorCode;

public HL7V251Field OrganDonorCode
{
    get
    {
        if (organDonorCode != null)
        {
            return organDonorCode;
        }

        organDonorCode = new HL7V251Field
        {
            field = message[@"PV2"][44],
            Id = @"PV2.44",
            Type = @"Field",
            Position = @"PV2.44",
            Name = @"Organ Donor Code",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0316",
            TableName = @"Organ Donor Code",
            Description = @"This field indicate whether the patient wants to donate his/her organs and whether an organ donor card or similar documentation is on file with the healthcare organization. Refer to User-defined Table 0316 - Organ Donor Code for suggested values. See also PD1-8 - Organ Donor.",
            Sample = @"",
        };

        

        

        

        return organDonorCode;
    } 
}
internal HL7V251Field advanceDirectiveCode;

public HL7V251Field AdvanceDirectiveCode
{
    get
    {
        if (advanceDirectiveCode != null)
        {
            return advanceDirectiveCode;
        }

        advanceDirectiveCode = new HL7V251Field
        {
            field = message[@"PV2"][45],
            Id = @"PV2.45",
            Type = @"Field",
            Position = @"PV2.45",
            Name = @"Advance Directive Code",
            Length = 250,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0435",
            TableName = @"Advance Directive Code",
            Description = @"This field indicates the patients instructions to the healthcare facility. Refer to User-defined Table 0435 - Advance Directive Code for suggested values. See also PD1-15 - Advance Directive Code.",
            Sample = @"",
        };

        

        

        

        return advanceDirectiveCode;
    } 
}
internal HL7V251Field patientStatusEffectiveDate;

public HL7V251Field PatientStatusEffectiveDate
{
    get
    {
        if (patientStatusEffectiveDate != null)
        {
            return patientStatusEffectiveDate;
        }

        patientStatusEffectiveDate = new HL7V251Field
        {
            field = message[@"PV2"][46],
            Id = @"PV2.46",
            Type = @"Field",
            Position = @"PV2.46",
            Name = @"Patient Status Effective Date",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = @"This field indicates the effective date for PV2-24 - Patient Status.",
            Sample = @"",
        };

        

        

        

        return patientStatusEffectiveDate;
    } 
}
internal HL7V251Field expectedLOAReturnDateTime;

public HL7V251Field ExpectedLOAReturnDateTime
{
    get
    {
        if (expectedLOAReturnDateTime != null)
        {
            return expectedLOAReturnDateTime;
        }

        expectedLOAReturnDateTime = new HL7V251Field
        {
            field = message[@"PV2"][47],
            Id = @"PV2.47",
            Type = @"Field",
            Position = @"PV2.47",
            Name = @"Expected LOA Return Date/Time",
            Length = 26,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field is conditionally required for A21 - Patient goes on LOA. It may be populated in A22 - Patient returns from LOA as well as in the A53 - Cancel LOA for a patient and the A54 - Cancel patient returns from LOA triggers. This field contains the date/time that the patient is expected to return from LOA.",
            Sample = @"",
        };

        

        

        

        return expectedLOAReturnDateTime;
    } 
}
internal HL7V251Field expectedPreadmissionTestingDateTime;

public HL7V251Field ExpectedPreadmissionTestingDateTime
{
    get
    {
        if (expectedPreadmissionTestingDateTime != null)
        {
            return expectedPreadmissionTestingDateTime;
        }

        expectedPreadmissionTestingDateTime = new HL7V251Field
        {
            field = message[@"PV2"][48],
            Id = @"PV2.48",
            Type = @"Field",
            Position = @"PV2.48",
            Name = @"Expected Pre-admission Testing Date/Time",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date/time that the patient is expected for pre-admission testing.",
            Sample = @"",
        };

        

        

        

        return expectedPreadmissionTestingDateTime;
    } 
}
internal HL7V251Field notifyClergyCode;

public HL7V251Field NotifyClergyCode
{
    get
    {
        if (notifyClergyCode != null)
        {
            return notifyClergyCode;
        }

        notifyClergyCode = new HL7V251Field
        {
            field = message[@"PV2"][49],
            Id = @"PV2.49",
            Type = @"Field",
            Position = @"PV2.49",
            Name = @"Notify Clergy Code",
            Length = 20,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0534",
            TableName = @"Notify Clergy Code",
            Description = @"This field allows the user to indicate whether the clergy should be notified. Refer to User-defined Table 0534 - Notify Clergy Code for suggested values.",
            Sample = @"",
        };

        

        

        

        return notifyClergyCode;
    } 
}

    }
}
