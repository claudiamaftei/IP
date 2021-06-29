using Microsoft.VisualStudio.TestTools.UnitTesting;
using quizz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quizz.Tests
{
    [TestClass()]
    public class ChemistryTests
    {
        [TestMethod()]
        public void getQuestionTest()
        {
            Chemistry chemistry = new Chemistry();
            chemistry.Questions();
            Assert.AreEqual("You can't live without water! What is its chemical formula?", chemistry.getQuestion(1));
        }

        [TestMethod()]
        public void domainNameTest()
        {
            Chemistry chemistry = new Chemistry();
            Assert.AreEqual("Chemistry", chemistry.domainName);
        }

        [TestMethod()]
        public void getAnswerTest()
        {
            Chemistry chemistry = new Chemistry();
            chemistry.Questions();
            Assert.AreEqual("Carbon and Nitrogen", chemistry.getAnswer(3, 3));
        }

        [TestMethod()]
        public void getQuestionNumberTest()
        {
            Chemistry chemistry = new Chemistry();
            Assert.AreEqual(20, chemistry.getQuestionNumber);
        }

    }
}