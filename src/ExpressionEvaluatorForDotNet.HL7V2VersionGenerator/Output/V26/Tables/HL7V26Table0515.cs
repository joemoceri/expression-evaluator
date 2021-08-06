using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26Table0515
    {
        public string Id { get { return @"0515"; } }

        public string TableId { get { return @"0515"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Transfusion Interrupted Reason"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_04",
                    };
            } 
        }

        public IList<HL7V2TableEntry> Entries 
        { 
            get 
            { 
                return null;
            } 
        }
    }
}