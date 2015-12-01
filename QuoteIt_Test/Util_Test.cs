using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuoteIt;

namespace QuoteIt_Test
{
    [TestClass]
    public class Util_Test
    {
        [TestMethod]
        public void deSerializeArgs_should_split_space_properly()
        {
            QuoteIt.Util util = new Util();
            util.argsToInput("\"hello hello\" \"my name is hello\" hiya");
        }

        [TestMethod]
        public void parsing_args_array_to_Input_should_work_properly()
        {
            QuoteIt.Util util = new Util();
            String[] args1 = { "leftQ","rightQ","sep","pre","suf","y","y","y","y","y","custom"};
            String[] args2 = { "leftQ", "rightQ", "sep", "pre", "suf", "n", "n", "n", "n", "n", "custom" };

            Input expected_input1 = new Input() { LeftQuote = "leftQ", RightQuote = "rightQ", Seperator = "sep", Prefix = "pre", Suffix = "suf", Tokenizer_Comma = true, Tokenizer_LineFeed = true, Tokenizer_Space = true, Tokenizer_CarriageReturn = true, Tokenizer_Tab = true, Tokenizer_Custom = "custom" };
            Input expected_input2 = new Input() { LeftQuote = "leftQ", RightQuote = "rightQ", Seperator = "sep", Prefix = "pre", Suffix = "suf", Tokenizer_Comma = false, Tokenizer_LineFeed = false, Tokenizer_Space = false, Tokenizer_CarriageReturn = false, Tokenizer_Tab = false, Tokenizer_Custom = "custom" };

            Assert.AreEqual(expected_input1, util.argsToInput(args1));
            Assert.AreEqual(expected_input2, util.argsToInput(args2));
            Assert.AreNotEqual(util.argsToInput(args1), util.argsToInput(args2));
        }

        [TestMethod]
        public void parsing_args_to_Input_should_work_properly()
        {
            QuoteIt.Util util = new Util();
            String args1 = String.Format("{0} {1} {2} {3} {4} {5} {6} {7} {8} {9} {10}", "leftQ", "rightQ", "sep", "pre", "suf", "y", "y", "y", "y", "y", "custom");
            String args2 = String.Format("{0} {1} {2} {3} {4} {5} {6} {7} {8} {9} {10}", "leftQ", "rightQ", "sep", "pre", "suf", "n", "n", "n", "n", "n", "custom");

            String args3 = String.Format("\"{0}\" \"{1}\" \"{2}\" \"{3}\" \"{4}\" \"{5}\" \"{6}\" \"{7}\" \"{8}\" \"{9}\" \"{10}\"", "leftQ", "rightQ", "sep", "pre", "suf", "y", "y", "y", "y", "y", "custom");
            String args4 = String.Format("\"{0}\" \"{1}\" \"{2}\" \"{3}\" \"{4}\" \"{5}\" \"{6}\" \"{7}\" \"{8}\" \"{9}\" \"{10}\"", "_Q_leftQ_Q_", "_Q_rightQ_Q_", "_Q_sep_Q_", "_Q_pre_Q_", "_Q_suf_Q_", "y", "y", "y", "y", "y", "_Q_custom_Q_");
            String args5 = String.Format("\"{0}\" \"{1}\" \"{2}\" \"{3}\" \"{4}\" \"{5}\" \"{6}\" \"{7}\" \"{8}\" \"{9}\" \"{10}\"", "_Q_\\rleftQ\\r_Q_", "_Q_\\rrightQ\\r_Q_", "_Q_\\rsep\\r_Q_", "_Q_\\rpre\\r_Q_", "_Q_\\rsuf\\r_Q_", "y", "y", "y", "y", "y", "_Q_\\rcustom\\r_Q_");
            String args6 = String.Format("\"{0}\" \"{1}\" \"{2}\" \"{3}\" \"{4}\" \"{5}\" \"{6}\" \"{7}\" \"{8}\" \"{9}\" \"{10}\"", "_Q_\\nleftQ\\n_Q_", "_Q_\\nrightQ\\n_Q_", "_Q_\\nsep\\n_Q_", "_Q_\\npre\\n_Q_", "_Q_\\nsuf\\n_Q_", "y", "y", "y", "y", "y", "_Q_\\ncustom\\n_Q_");

            Input expected_input1 = new Input() { LeftQuote = "leftQ", RightQuote = "rightQ", Seperator = "sep", Prefix = "pre", Suffix = "suf", Tokenizer_Comma = true, Tokenizer_LineFeed = true, Tokenizer_Space = true, Tokenizer_CarriageReturn = true, Tokenizer_Tab = true, Tokenizer_Custom = "custom" };
            Input expected_input2 = new Input() { LeftQuote = "leftQ", RightQuote = "rightQ", Seperator = "sep", Prefix = "pre", Suffix = "suf", Tokenizer_Comma = false, Tokenizer_LineFeed = false, Tokenizer_Space = false, Tokenizer_CarriageReturn = false, Tokenizer_Tab = false, Tokenizer_Custom = "custom" };
            Input expected_input3 = new Input() { LeftQuote = "leftQ", RightQuote = "rightQ", Seperator = "sep", Prefix = "pre", Suffix = "suf", Tokenizer_Comma = true, Tokenizer_LineFeed = true, Tokenizer_Space = true, Tokenizer_CarriageReturn = true, Tokenizer_Tab = true, Tokenizer_Custom = "custom" };
            Input expected_input4 = new Input() { LeftQuote = "\"leftQ\"", RightQuote = "\"rightQ\"", Seperator = "\"sep\"", Prefix = "\"pre\"", Suffix = "\"suf\"", Tokenizer_Comma = true, Tokenizer_LineFeed = true, Tokenizer_Space = true, Tokenizer_CarriageReturn = true, Tokenizer_Tab = true, Tokenizer_Custom = "\"custom\"" };
            Input expected_input5 = new Input() { LeftQuote = "\"\rleftQ\r\"", RightQuote = "\"\rrightQ\r\"", Seperator = "\"\rsep\r\"", Prefix = "\"\rpre\r\"", Suffix = "\"\rsuf\r\"", Tokenizer_Comma = true, Tokenizer_LineFeed = true, Tokenizer_Space = true, Tokenizer_CarriageReturn = true, Tokenizer_Tab = true, Tokenizer_Custom = "\"\rcustom\r\"" };
            Input expected_input6 = new Input() { LeftQuote = "\"\nleftQ\n\"", RightQuote = "\"\nrightQ\n\"", Seperator = "\"\nsep\n\"", Prefix = "\"\npre\n\"", Suffix = "\"\nsuf\n\"", Tokenizer_Comma = true, Tokenizer_LineFeed = true, Tokenizer_Space = true, Tokenizer_CarriageReturn = true, Tokenizer_Tab = true, Tokenizer_Custom = "\"\ncustom\n\"" };

            Assert.AreEqual(expected_input1, util.argsToInput(args1));
            Assert.AreEqual(expected_input2, util.argsToInput(args2));
            Assert.AreNotEqual(util.argsToInput(args1), util.argsToInput(args2));
            Assert.AreEqual(expected_input3, util.argsToInput(args3));
            Assert.AreEqual(expected_input4, util.argsToInput(args4));
            Assert.AreEqual(expected_input5, util.argsToInput(args5));
            Assert.AreEqual(expected_input6, util.argsToInput(args6));
        }

    }
}
