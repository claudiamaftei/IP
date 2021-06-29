/**************************************************************************
 *                                                                        *
 *  File:        FormStart.cs                                             *
 *  Copyright:   (c) 2020, IP Project                                     *
 *  Authors:       Fechet Paula                                           *
 *                 Maftei Claudia                                         *
 *                 Radu Cosmina                                           *
 *                 Burbulea Ioana                                         *
 *                                                                        *
 *  Description: General Knowldege Quiz using Fabric Method Pattern       *
 *               This is a UnitTest class for Arts class.                 *
 *                                                                        *
 *  This code and information is provided "as is" without warranty of     *
 *  any kind, either expressed or implied, including but not limited      *
 *  to the implied warranties of merchantability or fitness for a         *
 *  particular purpose. You are free to use this source code in your      *
 *  applications as long as the original copyright notice is included.    *
 *                                                                        *
 **************************************************************************/
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Artss;

namespace quizz.Tests
{
    [TestClass()]
    public class ArtsTests
    {
        [TestMethod()]
        public void getQuestionTest()
        {
            Arts arts = new Arts();
            arts.Questions();
            Assert.AreEqual("What nationality was painter Frida Kahlo ? ", arts.GetQuestion(1));
        }

        [TestMethod()]
        public void getQuestionTest1()
        {
            Arts arts = new Arts();
            arts.Questions();
            Assert.AreEqual("A Russian woman was arrested in Paris in August 2009 for throwing a cup of tea at which work of art?", arts.GetQuestion(5));
        }

        [TestMethod()]
        public void domainNameTest()
        {
            Arts arts = new Arts();
            Assert.AreEqual("Arts", arts.DomainName);
        }

        [TestMethod()]
        public void getAnswerTest()
        {
            Arts arts = new Arts();
            arts.Questions();
            Assert.AreEqual("New York", arts.GetAnswer(2, 3));
        }

        [TestMethod()]
        public void getQuestionNumberTest()
        {
            Arts arts = new Arts();
            Assert.AreEqual(20, arts.GetQuestionNumber);
        }

    }
}