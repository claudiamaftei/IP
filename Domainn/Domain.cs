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
 *                This is an abstract class that contains methods         *
 *                for creating ARTS,IT,Chemistry and History classes.     *
 *                                                                        *
 *                                                                        *
 *  This code and information is provided "as is" without warranty of     *
 *  any kind, either expressed or implied, including but not limited      *
 *  to the implied warranties of merchantability or fitness for a         *
 *  particular purpose. You are free to use this source code in your      *
 *  applications as long as the original copyright notice is included.    *
 *                                                                        *
 **************************************************************************/


namespace Domainn
{
    /// <summary>
    /// Abstract class used to create each domain with questions
    /// </summary>
    public abstract class Domain
    {

        public abstract string DomainName { get; }
        public abstract void Questions();
        public abstract string GetQuestion(int i);
        public abstract string GetAnswer(int i, int j);
        public abstract int GetQuestionNumber { get; }
    }
}
