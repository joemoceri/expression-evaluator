using System.Linq;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22SegmentQRD
    {
        public readonly HL7V2Message message;

        public string Id { get { return @"QRD"; } }

        public string SegmentId { get { return @"QRD"; } }
        
        public string LongName { get { return @"Query Definition"; } }
        
        public string Description { get { return @""; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_02",
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
                            Id = @"QRD.1",
                            Type = @"Field",
                            Position = @"QRD.1",
                            Name = @"Query Date / Time",
                            Length = 26,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"date the query was generated by the application program",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"QRD.1.1",
                            Type = @"Component",
                            Position = @"QRD.1.1",
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
                            Id = @"QRD.1.2",
                            Type = @"Component",
                            Position = @"QRD.1.2",
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
                            Id = @"QRD.2",
                            Type = @"Field",
                            Position = @"QRD.2",
                            Name = @"Query Format Code",
                            Length = 1,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0106",
                            TableName = @"QUERY FORMAT CODE",
                            Description = @"refer to table 0106 - query format code for valid codes",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QRD.3",
                            Type = @"Field",
                            Position = @"QRD.3",
                            Name = @"Query Priority",
                            Length = 1,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0091",
                            TableName = @"QUERY PRIORITY",
                            Description = @"time frame in which the response is expected.  Refer to table 0091 - query priority for valid codes.  Table values and subsequent fields specify time frames for response",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QRD.4",
                            Type = @"Field",
                            Position = @"QRD.4",
                            Name = @"Query Id",
                            Length = 10,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"unique identifier for the query.  Assigned by the querying application.  Returned intact by the responding application.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QRD.5",
                            Type = @"Field",
                            Position = @"QRD.5",
                            Name = @"Deferred Response Type",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0107",
                            TableName = @"DEFERRED RESPONSE TYPE",
                            Description = @"refer to table 0107 - deferred response type for valid entries",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QRD.6",
                            Type = @"Field",
                            Position = @"QRD.6",
                            Name = @"Deferred Response Date / Time",
                            Length = 26,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"date/time before or after which to send a deferred response.  If not present, the response can be sent when its available",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"QRD.6.1",
                            Type = @"Component",
                            Position = @"QRD.6.1",
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
                            Id = @"QRD.6.2",
                            Type = @"Component",
                            Position = @"QRD.6.2",
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
                            Id = @"QRD.7",
                            Type = @"Field",
                            Position = @"QRD.7",
                            Name = @"Quantity Limited Request",
                            Length = 10,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"CQ",
                            DataTypeName = @"Composite Quantity With Units",
                            TableId = null,
                            TableName = null,
                            Description = @"maximum length of the response that can be accepted by the requesting system.  Valid responses are numerical values given in the units specified in the second component.  Refer to table 0126 - quantity limited request for valid entries.  Default is LI lines",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"QRD.7.1",
                            Type = @"Component",
                            Position = @"QRD.7.1",
                            Name = @"Quantity",
                            Length = 0,
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
                            Id = @"QRD.7.2",
                            Type = @"Component",
                            Position = @"QRD.7.2",
                            Name = @"Units",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The units in which the quantity is expressed.  Field-by-field, default units may be defined within the specifications.  When the observation is measured in the default units, the units need not be transmitted.  If the measure is recorded in units different from the default, the measurement units must be transmitted as the second component.  If the units are ISO+ units, then units should be recorded as lowercase abbreviations as specified in Chapter 7.  If the units are ANSI or local, the units and the source table must be recorded as specified in Chapter 7.  But in these cases the component separator should be replaced by the subcomponent delimiter ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QRD.8",
                            Type = @"Field",
                            Position = @"QRD.8",
                            Name = @"Who Subject Filter",
                            Length = 20,
                            Usage = @"R",
                            Rpt = @"*",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"identifies the subject, or who the inquiry is about",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QRD.9",
                            Type = @"Field",
                            Position = @"QRD.9",
                            Name = @"What Subject Filter",
                            Length = 3,
                            Usage = @"R",
                            Rpt = @"*",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0048",
                            TableName = @"WHAT SUBJECT FILTER",
                            Description = @"describes the kind of information that is required to satisfy the request.  Valid codes define the type of transaction inquiry and may be extended locally during implementation",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QRD.10",
                            Type = @"Field",
                            Position = @"QRD.10",
                            Name = @"What Department Data Code",
                            Length = 20,
                            Usage = @"R",
                            Rpt = @"*",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"possible contents include test number, procedure number, drug code, item number, order number, etc.  The contents of this field are determined by the contents of the previous field. This field could contain multiple occurrences separated by repetition delimiters",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QRD.11",
                            Type = @"Field",
                            Position = @"QRD.11",
                            Name = @"What Data Code Value Qualifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"CM_VR",
                            DataTypeName = @"Value Qualifier",
                            TableId = null,
                            TableName = null,
                            Description = @"what data code value qualifier.  A window or range to further refine the inquiry.  This field would contain start/stop separated by component separators",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"QRD.11.1",
                            Type = @"Component",
                            Position = @"QRD.11.1",
                            Name = @"First Data Code Value",
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
                            Id = @"QRD.11.2",
                            Type = @"Component",
                            Position = @"QRD.11.2",
                            Name = @"Last Data Code Calue",
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
                            Id = @"QRD.12",
                            Type = @"Field",
                            Position = @"QRD.12",
                            Name = @"Query Results Level",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0108",
                            TableName = @"QUERY RESULTS LEVEL",
                            Description = @"used to control level of detail in results.  Refer to table 0108 - query results level for valid codes",
                            Sample = @"",
                            FieldDatas = null
                        },
                        };
            }
        }

        public HL7V22SegmentQRD(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V22Field queryDateTime;

public HL7V22Field QueryDateTime
{
    get
    {
        if (queryDateTime != null)
        {
            return queryDateTime;
        }

        queryDateTime = new HL7V22Field
        {
            field = message[@"QRD"][1],
            Id = @"QRD.1",
            Type = @"Field",
            Position = @"QRD.1",
            Name = @"Query Date / Time",
            Length = 26,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"date the query was generated by the application program",
            Sample = @"",
        };

        

        

        

        return queryDateTime;
    } 
}
internal HL7V22Field queryFormatCode;

public HL7V22Field QueryFormatCode
{
    get
    {
        if (queryFormatCode != null)
        {
            return queryFormatCode;
        }

        queryFormatCode = new HL7V22Field
        {
            field = message[@"QRD"][2],
            Id = @"QRD.2",
            Type = @"Field",
            Position = @"QRD.2",
            Name = @"Query Format Code",
            Length = 1,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0106",
            TableName = @"QUERY FORMAT CODE",
            Description = @"refer to table 0106 - query format code for valid codes",
            Sample = @"",
        };

        

        

        

        return queryFormatCode;
    } 
}
internal HL7V22Field queryPriority;

public HL7V22Field QueryPriority
{
    get
    {
        if (queryPriority != null)
        {
            return queryPriority;
        }

        queryPriority = new HL7V22Field
        {
            field = message[@"QRD"][3],
            Id = @"QRD.3",
            Type = @"Field",
            Position = @"QRD.3",
            Name = @"Query Priority",
            Length = 1,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0091",
            TableName = @"QUERY PRIORITY",
            Description = @"time frame in which the response is expected.  Refer to table 0091 - query priority for valid codes.  Table values and subsequent fields specify time frames for response",
            Sample = @"",
        };

        

        

        

        return queryPriority;
    } 
}
internal HL7V22Field queryId;

public HL7V22Field QueryId
{
    get
    {
        if (queryId != null)
        {
            return queryId;
        }

        queryId = new HL7V22Field
        {
            field = message[@"QRD"][4],
            Id = @"QRD.4",
            Type = @"Field",
            Position = @"QRD.4",
            Name = @"Query Id",
            Length = 10,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"unique identifier for the query.  Assigned by the querying application.  Returned intact by the responding application.",
            Sample = @"",
        };

        

        

        

        return queryId;
    } 
}
internal HL7V22Field deferredResponseType;

public HL7V22Field DeferredResponseType
{
    get
    {
        if (deferredResponseType != null)
        {
            return deferredResponseType;
        }

        deferredResponseType = new HL7V22Field
        {
            field = message[@"QRD"][5],
            Id = @"QRD.5",
            Type = @"Field",
            Position = @"QRD.5",
            Name = @"Deferred Response Type",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0107",
            TableName = @"DEFERRED RESPONSE TYPE",
            Description = @"refer to table 0107 - deferred response type for valid entries",
            Sample = @"",
        };

        

        

        

        return deferredResponseType;
    } 
}
internal HL7V22Field deferredResponseDateTime;

public HL7V22Field DeferredResponseDateTime
{
    get
    {
        if (deferredResponseDateTime != null)
        {
            return deferredResponseDateTime;
        }

        deferredResponseDateTime = new HL7V22Field
        {
            field = message[@"QRD"][6],
            Id = @"QRD.6",
            Type = @"Field",
            Position = @"QRD.6",
            Name = @"Deferred Response Date / Time",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"date/time before or after which to send a deferred response.  If not present, the response can be sent when its available",
            Sample = @"",
        };

        

        

        

        return deferredResponseDateTime;
    } 
}
internal HL7V22Field quantityLimitedRequest;

public HL7V22Field QuantityLimitedRequest
{
    get
    {
        if (quantityLimitedRequest != null)
        {
            return quantityLimitedRequest;
        }

        quantityLimitedRequest = new HL7V22Field
        {
            field = message[@"QRD"][7],
            Id = @"QRD.7",
            Type = @"Field",
            Position = @"QRD.7",
            Name = @"Quantity Limited Request",
            Length = 10,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CQ",
            DataTypeName = @"Composite Quantity With Units",
            TableId = null,
            TableName = null,
            Description = @"maximum length of the response that can be accepted by the requesting system.  Valid responses are numerical values given in the units specified in the second component.  Refer to table 0126 - quantity limited request for valid entries.  Default is LI lines",
            Sample = @"",
        };

        

        

        

        return quantityLimitedRequest;
    } 
}
internal HL7V22Field whoSubjectFilter;

public HL7V22Field WhoSubjectFilter
{
    get
    {
        if (whoSubjectFilter != null)
        {
            return whoSubjectFilter;
        }

        whoSubjectFilter = new HL7V22Field
        {
            field = message[@"QRD"][8],
            Id = @"QRD.8",
            Type = @"Field",
            Position = @"QRD.8",
            Name = @"Who Subject Filter",
            Length = 20,
            Usage = @"R",
            Rpt = @"*",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"identifies the subject, or who the inquiry is about",
            Sample = @"",
        };

        

        

        

        return whoSubjectFilter;
    } 
}
internal HL7V22Field whatSubjectFilter;

public HL7V22Field WhatSubjectFilter
{
    get
    {
        if (whatSubjectFilter != null)
        {
            return whatSubjectFilter;
        }

        whatSubjectFilter = new HL7V22Field
        {
            field = message[@"QRD"][9],
            Id = @"QRD.9",
            Type = @"Field",
            Position = @"QRD.9",
            Name = @"What Subject Filter",
            Length = 3,
            Usage = @"R",
            Rpt = @"*",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0048",
            TableName = @"WHAT SUBJECT FILTER",
            Description = @"describes the kind of information that is required to satisfy the request.  Valid codes define the type of transaction inquiry and may be extended locally during implementation",
            Sample = @"",
        };

        

        

        

        return whatSubjectFilter;
    } 
}
internal HL7V22Field whatDepartmentDataCode;

public HL7V22Field WhatDepartmentDataCode
{
    get
    {
        if (whatDepartmentDataCode != null)
        {
            return whatDepartmentDataCode;
        }

        whatDepartmentDataCode = new HL7V22Field
        {
            field = message[@"QRD"][10],
            Id = @"QRD.10",
            Type = @"Field",
            Position = @"QRD.10",
            Name = @"What Department Data Code",
            Length = 20,
            Usage = @"R",
            Rpt = @"*",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"possible contents include test number, procedure number, drug code, item number, order number, etc.  The contents of this field are determined by the contents of the previous field. This field could contain multiple occurrences separated by repetition delimiters",
            Sample = @"",
        };

        

        

        

        return whatDepartmentDataCode;
    } 
}
internal HL7V22Field whatDataCodeValueQualifier;

public HL7V22Field WhatDataCodeValueQualifier
{
    get
    {
        if (whatDataCodeValueQualifier != null)
        {
            return whatDataCodeValueQualifier;
        }

        whatDataCodeValueQualifier = new HL7V22Field
        {
            field = message[@"QRD"][11],
            Id = @"QRD.11",
            Type = @"Field",
            Position = @"QRD.11",
            Name = @"What Data Code Value Qualifier",
            Length = 20,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CM_VR",
            DataTypeName = @"Value Qualifier",
            TableId = null,
            TableName = null,
            Description = @"what data code value qualifier.  A window or range to further refine the inquiry.  This field would contain start/stop separated by component separators",
            Sample = @"",
        };

        

        

        

        return whatDataCodeValueQualifier;
    } 
}
internal HL7V22Field queryResultsLevel;

public HL7V22Field QueryResultsLevel
{
    get
    {
        if (queryResultsLevel != null)
        {
            return queryResultsLevel;
        }

        queryResultsLevel = new HL7V22Field
        {
            field = message[@"QRD"][12],
            Id = @"QRD.12",
            Type = @"Field",
            Position = @"QRD.12",
            Name = @"Query Results Level",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0108",
            TableName = @"QUERY RESULTS LEVEL",
            Description = @"used to control level of detail in results.  Refer to table 0108 - query results level for valid codes",
            Sample = @"",
        };

        

        

        

        return queryResultsLevel;
    } 
}

    }
}
