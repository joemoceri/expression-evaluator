using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24Table0323
    {
        public string Id { get { return @"0323"; } }

        public string TableId { get { return @"0323"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Action code"; } }

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

        public IList<HL7V2TableEntry> Entries 
        { 
            get 
            { 
                return new[]
                    {
                        new HL7V2TableEntry
                        {
                            Value = @"A",
                            Description = @"Add/Insert",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"D",
                            Description = @"Delete",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"U",
                            Description = @"Update",
                            Comment = null
                        },
                    };
            } 
        }
    }
}