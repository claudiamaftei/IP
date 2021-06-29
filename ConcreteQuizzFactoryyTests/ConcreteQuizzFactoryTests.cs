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
 *               This is a UnitTest class for ConcreteQuizzFactory        *
 *               class.                                                   *
 *                                                                        *
 *  This code and information is provided "as is" without warranty of     *
 *  any kind, either expressed or implied, including but not limited      *
 *  to the implied warranties of merchantability or fitness for a         *
 *  particular purpose. You are free to use this source code in your      *
 *  applications as long as the original copyright notice is included.    *
 *                                                                        *
 **************************************************************************/
using Domainn;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConcreteQuizzFactoryy;

namespace quizz.Tests
{
    [TestClass()]
    public class ConcreteQuizzFactoryTests
    {
        [TestMethod()]
        public void getDomainTest()
        {
            ConcreteQuizzFactory quizFactory = new ConcreteQuizzFactory();
            Domain domain = quizFactory.GetDomain("chimie");
            Assert.IsNotNull(domain);
        }

        [TestMethod()]
        public void getDomainTest1()
        {
            ConcreteQuizzFactory quizFactory = new ConcreteQuizzFactory();
            Domain domain = quizFactory.GetDomain("istorie");
            Assert.IsNotNull(domain);
        }
    }
}