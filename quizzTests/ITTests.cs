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
    public class ITTests
    {
        [TestMethod()]
        public void getQuestionTest()
        {
            IT it = new IT();
            it.Questions();
            Assert.AreEqual("Firewall in computer is used for:", it.getQuestion(6));
        }

        [TestMethod()]
        public void domainNameTest()
        {
            IT it = new IT();
            Assert.AreEqual("IT", it.domainName);
        }

        [TestMethod()]
        public void getAnswerTest()
        {
            IT it = new IT();
            it.Questions();
            Assert.AreEqual("Mozilla", it.getAnswer(2, 3));
        }

        [TestMethod()]
        public void getQuestionNumberTest()
        {
            IT it = new IT();
            Assert.AreEqual(20, it.getQuestionNumber);
        }

    }
}