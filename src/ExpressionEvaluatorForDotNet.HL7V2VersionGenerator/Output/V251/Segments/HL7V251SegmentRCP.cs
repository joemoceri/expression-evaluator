using System.Linq;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251SegmentRCP
    {
        public readonly HL7V2Message message;

        public string Id { get { return @"RCP"; } }

        public string SegmentId { get { return @"RCP"; } }
        
        public string LongName { get { return @"Response Control Parameter"; } }
        
        public string Description { get { return @"The RCP segment is used to restrict the amount of data that should be returned in response to query."; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_05",
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
                            Id = @"RCP.1",
                            Type = @"Field",
                            Position = @"RCP.1",
                            Name = @"Query Priority",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0091",
                            TableName = @"Query priority",
                            Description = @"This field contains the time frame in which the response is expected. Refer to HL7 Table 0091 - Query priority for valid values. Table values and subsequent fields specify time frames for response.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RCP.2",
                            Type = @"Field",
                            Position = @"RCP.2",
                            Name = @"Quantity Limited Request",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CQ",
                            DataTypeName = @"Composite Quantity with Units",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the maximum length of the response that can be accepted by the requesting system. Valid entries are numerical values (in the first component) given in the units specified in the second component. Default is LI (lines).",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"RCP.2.1",
                            Type = @"Component",
                            Position = @"RCP.2.1",
                            Name = @"Quantity",
                            Length = 16,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This component specifies the numeric quantity or amount of an entity.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RCP.2.2",
                            Type = @"Component",
                            Position = @"RCP.2.2",
                            Name = @"Units",
                            Length = 483,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This component species the units in which the quantity is expressed. Field-by-field, default units may be defined within the specifications. When the quantity is measured in the default units, the units need not be transmitted. If the quantity is recorded in units different from the default, the units must be transmitted.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"RCP.2.2.1",
                            Type = @"SubComponent",
                            Position = @"RCP.2.2.1",
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
                            Id = @"RCP.2.2.2",
                            Type = @"SubComponent",
                            Position = @"RCP.2.2.2",
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
                            Id = @"RCP.2.2.3",
                            Type = @"SubComponent",
                            Position = @"RCP.2.2.3",
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
                            Id = @"RCP.2.2.4",
                            Type = @"SubComponent",
                            Position = @"RCP.2.2.4",
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
                            Id = @"RCP.2.2.5",
                            Type = @"SubComponent",
                            Position = @"RCP.2.2.5",
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
                            Id = @"RCP.2.2.6",
                            Type = @"SubComponent",
                            Position = @"RCP.2.2.6",
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
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RCP.3",
                            Type = @"Field",
                            Position = @"RCP.3",
                            Name = @"Response Modality",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0394",
                            TableName = @"Response modality",
                            Description = @"This field specifies the timing and grouping of the response message(s). Refer to HL7 Table 0394 - Response modality for valid values.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"RCP.3.1",
                            Type = @"Component",
                            Position = @"RCP.3.1",
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
                            Id = @"RCP.3.2",
                            Type = @"Component",
                            Position = @"RCP.3.2",
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
                            Id = @"RCP.3.3",
                            Type = @"Component",
                            Position = @"RCP.3.3",
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
                            Id = @"RCP.3.4",
                            Type = @"Component",
                            Position = @"RCP.3.4",
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
                            Id = @"RCP.3.5",
                            Type = @"Component",
                            Position = @"RCP.3.5",
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
                            Id = @"RCP.3.6",
                            Type = @"Component",
                            Position = @"RCP.3.6",
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
                            Id = @"RCP.4",
                            Type = @"Field",
                            Position = @"RCP.4",
                            Name = @"Execution and Delivery Time",
                            Length = 26,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"Specifies the time the response is to be returned.  This field is only valued when RCP-1-Query priority contains the value D (Deferred). ",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"RCP.4.1",
                            Type = @"Component",
                            Position = @"RCP.4.1",
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
                            Id = @"RCP.4.2",
                            Type = @"Component",
                            Position = @"RCP.4.2",
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
                            Id = @"RCP.5",
                            Type = @"Field",
                            Position = @"RCP.5",
                            Name = @"Modify Indicator",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0395",
                            TableName = @"Modify indicator",
                            Description = @"This field specifies whether the subscription is new or is being modified. Refer to HL7 Table 0395 - Modify indicator for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RCP.6",
                            Type = @"Field",
                            Position = @"RCP.6",
                            Name = @"Sort-by Field",
                            Length = 512,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"SRT",
                            DataTypeName = @"Sort Order",
                            TableId = null,
                            TableName = null,
                            Description = @"For queries requesting a tabular response, this field specifies by which fields the response is to be sorted, and the order(s) in which sorting is to be performed. When the QSC variant is not in use, the values specified for the first component in this field are derived from the ColName field of the Output Specification and Commentary. When the QSC variant is used, the values are derived from the ColName field of the Input/Output Specification and Commentary.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"RCP.6.1",
                            Type = @"Component",
                            Position = @"RCP.6.1",
                            Name = @"Sort-by Field",
                            Length = 12,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Identifies the field by which the response will be sorted. In a tabular response, this will be the column name to sort by. In the Segment Pattern and the Display Response, this will be the segment field name to sort by. See QIP in Section 2.A.59.1, ""Segment Field Name (ST)"" for segment field name definition.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RCP.6.2",
                            Type = @"Component",
                            Position = @"RCP.6.2",
                            Name = @"Sequencing",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0397",
                            TableName = @"Sequencing",
                            Description = @"Identifies how the field or parameter will be sorted; and, if sorted, whether the sort will be case sensitive (the default) or not. Refer to HL7 Table 0397 - Sequencing for valid values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RCP.7",
                            Type = @"Field",
                            Position = @"RCP.7",
                            Name = @"Segment group inclusion",
                            Length = 256,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0391",
                            TableName = @"Segment group",
                            Description = @"Specifies those optional segment groups which are to be included in the response. Refer to HL7 Table 0391Segment group for values for Segment Group. This is a repeating field, to accommodate inclusion of multiple segment groups. The default for this field, not present, means that all relevant groups are included.

Note: Although the codes for segment groups are taken from HL7 Table 0391, the exact segment-level definition of a segment group (e.g. PIDG) is given only in the conformance statement of the query in which this segment group appears.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        };
            }
        }

        public HL7V251SegmentRCP(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V251Field queryPriority;

public HL7V251Field QueryPriority
{
    get
    {
        if (queryPriority != null)
        {
            return queryPriority;
        }

        queryPriority = new HL7V251Field
        {
            field = message[@"RCP"][1],
            Id = @"RCP.1",
            Type = @"Field",
            Position = @"RCP.1",
            Name = @"Query Priority",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0091",
            TableName = @"Query priority",
            Description = @"This field contains the time frame in which the response is expected. Refer to HL7 Table 0091 - Query priority for valid values. Table values and subsequent fields specify time frames for response.",
            Sample = @"",
        };

        

        

        

        return queryPriority;
    } 
}
internal HL7V251Field quantityLimitedRequest;

public HL7V251Field QuantityLimitedRequest
{
    get
    {
        if (quantityLimitedRequest != null)
        {
            return quantityLimitedRequest;
        }

        quantityLimitedRequest = new HL7V251Field
        {
            field = message[@"RCP"][2],
            Id = @"RCP.2",
            Type = @"Field",
            Position = @"RCP.2",
            Name = @"Quantity Limited Request",
            Length = 10,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CQ",
            DataTypeName = @"Composite Quantity with Units",
            TableId = null,
            TableName = null,
            Description = @"This field contains the maximum length of the response that can be accepted by the requesting system. Valid entries are numerical values (in the first component) given in the units specified in the second component. Default is LI (lines).",
            Sample = @"",
        };

        

        

        

        return quantityLimitedRequest;
    } 
}
internal HL7V251Field responseModality;

public HL7V251Field ResponseModality
{
    get
    {
        if (responseModality != null)
        {
            return responseModality;
        }

        responseModality = new HL7V251Field
        {
            field = message[@"RCP"][3],
            Id = @"RCP.3",
            Type = @"Field",
            Position = @"RCP.3",
            Name = @"Response Modality",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0394",
            TableName = @"Response modality",
            Description = @"This field specifies the timing and grouping of the response message(s). Refer to HL7 Table 0394 - Response modality for valid values.",
            Sample = @"",
        };

        

        

        

        return responseModality;
    } 
}
internal HL7V251Field executionandDeliveryTime;

public HL7V251Field ExecutionandDeliveryTime
{
    get
    {
        if (executionandDeliveryTime != null)
        {
            return executionandDeliveryTime;
        }

        executionandDeliveryTime = new HL7V251Field
        {
            field = message[@"RCP"][4],
            Id = @"RCP.4",
            Type = @"Field",
            Position = @"RCP.4",
            Name = @"Execution and Delivery Time",
            Length = 26,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"Specifies the time the response is to be returned.  This field is only valued when RCP-1-Query priority contains the value D (Deferred). ",
            Sample = @"",
        };

        

        

        

        return executionandDeliveryTime;
    } 
}
internal HL7V251Field modifyIndicator;

public HL7V251Field ModifyIndicator
{
    get
    {
        if (modifyIndicator != null)
        {
            return modifyIndicator;
        }

        modifyIndicator = new HL7V251Field
        {
            field = message[@"RCP"][5],
            Id = @"RCP.5",
            Type = @"Field",
            Position = @"RCP.5",
            Name = @"Modify Indicator",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0395",
            TableName = @"Modify indicator",
            Description = @"This field specifies whether the subscription is new or is being modified. Refer to HL7 Table 0395 - Modify indicator for valid values.",
            Sample = @"",
        };

        

        

        

        return modifyIndicator;
    } 
}
internal HL7V251Field sortbyField;

public HL7V251Field SortbyField
{
    get
    {
        if (sortbyField != null)
        {
            return sortbyField;
        }

        sortbyField = new HL7V251Field
        {
            field = message[@"RCP"][6],
            Id = @"RCP.6",
            Type = @"Field",
            Position = @"RCP.6",
            Name = @"Sort-by Field",
            Length = 512,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"SRT",
            DataTypeName = @"Sort Order",
            TableId = null,
            TableName = null,
            Description = @"For queries requesting a tabular response, this field specifies by which fields the response is to be sorted, and the order(s) in which sorting is to be performed. When the QSC variant is not in use, the values specified for the first component in this field are derived from the ColName field of the Output Specification and Commentary. When the QSC variant is used, the values are derived from the ColName field of the Input/Output Specification and Commentary.",
            Sample = @"",
        };

        

        

        

        return sortbyField;
    } 
}
internal HL7V251Field segmentgroupinclusion;

public HL7V251Field Segmentgroupinclusion
{
    get
    {
        if (segmentgroupinclusion != null)
        {
            return segmentgroupinclusion;
        }

        segmentgroupinclusion = new HL7V251Field
        {
            field = message[@"RCP"][7],
            Id = @"RCP.7",
            Type = @"Field",
            Position = @"RCP.7",
            Name = @"Segment group inclusion",
            Length = 256,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0391",
            TableName = @"Segment group",
            Description = @"Specifies those optional segment groups which are to be included in the response. Refer to HL7 Table 0391Segment group for values for Segment Group. This is a repeating field, to accommodate inclusion of multiple segment groups. The default for this field, not present, means that all relevant groups are included.

Note: Although the codes for segment groups are taken from HL7 Table 0391, the exact segment-level definition of a segment group (e.g. PIDG) is given only in the conformance statement of the query in which this segment group appears.",
            Sample = @"",
        };

        

        

        

        return segmentgroupinclusion;
    } 
}

    }
}
