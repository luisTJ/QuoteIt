using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuoteIt
{
    public class Input
    {
        private char[] custom_tokenizer_seperators = { ',', ' ' };
        private String[] customTokens;

        public bool Tokenizer_Comma { get; set; }
        public bool Tokenizer_LineFeed { get; set; }
        public bool Tokenizer_Tab { get; set; }
        public bool Tokenizer_CarriageReturn { get; set; }
        public bool Tokenizer_Space { get; set; }
        public string LeftQuote { get; set; }
        public string RightQuote { get; set; }
        public string Seperator { get; set; }
        public string Prefix { get; set; }
        public string Suffix { get; set; }
        public string default_sample_input { get; set; }
        public string Tokenizer_Custom
        {
            get
            {
                return String.Join(", ", customTokens);
            }
            set
            {
                if (value == null)
                    this.customTokens = new String[0];
                this.customTokens = value.Split(new String[] { " ", "," }, StringSplitOptions.RemoveEmptyEntries);
            }
        }

        public String Text { get; set; }


        public Input()
        {
            LeftQuote = "\"";
            RightQuote = "\"";
            Seperator = ", ";
            Prefix = "";
            Suffix = "";
            Tokenizer_Comma = true;
            Tokenizer_LineFeed = true;
            Tokenizer_Space = true;
            Tokenizer_CarriageReturn = true;
            Tokenizer_Space = true;
            Tokenizer_Tab = true;
            Tokenizer_Custom = "";
            default_sample_input = "Value1,Value2 Value3\tValue4\r\nValue5\nValue6\rValue7";
            Text = default_sample_input;
        }

        internal string[] getTokenizer()
        {
            List<String> tokenizers = new List<string>();
            if (Tokenizer_Comma)
                tokenizers.Add(",");
            if (Tokenizer_LineFeed)
                tokenizers.Add("\n");
            if (Tokenizer_CarriageReturn)
                tokenizers.Add("\r");
            if(Tokenizer_Space)
                tokenizers.Add(" ");
            if(Tokenizer_Tab)
                tokenizers.Add("\t");
            if (!String.IsNullOrWhiteSpace(Tokenizer_Custom))
            {
                tokenizers.AddRange(Tokenizer_Custom.Split(custom_tokenizer_seperators,StringSplitOptions.RemoveEmptyEntries));
            }
            return tokenizers.ToArray();
        }

        public override bool Equals(object obj)
        {
            if (obj == null || obj.GetType() != typeof(Input))
                return false;
            var that = (Input)obj;
            
            return this.Tokenizer_Comma == that.Tokenizer_Comma
                && this.Tokenizer_LineFeed == that.Tokenizer_LineFeed
                && this.Tokenizer_Tab == that.Tokenizer_Tab
                && this.Tokenizer_CarriageReturn == that.Tokenizer_CarriageReturn
                && this.Tokenizer_Space == that.Tokenizer_Space
                && String.Equals(this.LeftQuote, that.LeftQuote)
                && String.Equals(this.RightQuote, that.RightQuote)
                && String.Equals(this.Seperator, that.Seperator)
                && String.Equals(this.Prefix, that.Prefix)
                && String.Equals(this.Suffix, that.Suffix)
                && String.Equals(this.Tokenizer_Custom, that.Tokenizer_Custom
                );
        }
    }
}
