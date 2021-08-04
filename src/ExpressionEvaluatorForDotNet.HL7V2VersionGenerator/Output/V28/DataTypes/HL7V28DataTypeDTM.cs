using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V28DataType
    {
        public string Id { get { return @"DTM"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Date/time"; } }

        public string Description { get { return @"Specifies a point in time using a 24-hour clock notation. 

The number of characters populated (excluding the time zone specification) specifies the precision. 

Format: YYYY[MM[DD[HH[MM[SS[.S[S[S[S]]]]]]]]][+/-ZZZZ]. 

The time zone (+/-ZZZZ) is represented as +/-HHMM offset from Coordinated Universal Time (UTC) (formerly Greenwich Mean Time (GMT)), where +0000 or -0000 both represent UTC (without offset). The specific data representations used in the HL7 encoding rules are compatible with ISO 8824-1987(E).
Note that if the time zone is not included, the time zone defaults to that of the local time zone of the sender. Also note that a DTM valued field with the HHMM part set to ""0000"" represents midnight of the night extending from the previous day to the day given by the YYYYMMDD part.

The HL7 Standard strongly recommends that all systems routinely send the time zone offset but does not require it. All HL7 systems are required to accept the time zone offset, but its implementation is application specific. For many applications the time of interest is the local time of the sender. For example, an application in the Eastern Standard Time zone receiving notification of an admission that takes place at 11:00 PM in San Francisco on December 11 would prefer to treat the admission as having occurred on December 11 rather than advancing the date to December 12.

Note: The time zone [+/-ZZZZ], when used, is restricted to legally-defined time zones and is represented in HHMM format.

One exception to this rule would be a clinical system that processed patient data collected in a clinic and a nearby hospital that happens to be in a different time zone. Such applications may choose to convert the data to a common representation. Similar concerns apply to the transitions to and from daylight saving time. HL7 supports such requirements by requiring that the time zone information be present when the information is sent. It does not, however, specify which of the treatments discussed here will be applied by the receiving system. 

The DTM data type does not follow the normal truncation pattern, and the truncation character is never valid in the DTM data type. Instead, the truncation behavior is based on the semantics of dates and times. 

Unless otherwise specified in the context where the DTM type is used, the DTM type may be truncated to a day. When a DTM is truncated, the truncated form SHALL still be a valid DTM type. Systems should always be able to persist full date / time information including the timezone. Refer to Chapter 2, section 2.5.5.2 ""Truncation Pattern"" for further information."; } }

        public string DataType { get { return null; } }

        public string DataTypeName { get { return null; } }

        public int Length { get { return 24; } }

        public string Usage { get { return null; } }

        public string Rpt { get { return null; } }

        public string TableId { get { return null; } }

        public string TableName { get { return null; } }

        public string Sample { get { return @""; } }

        public IList<HL7V2FieldData> Fields 
        { 
            get 
            {
                return null;
            }
        }
    }
}
