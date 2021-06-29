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
 *                This is an class that returns ARTS, IT,                 *
 *                Chemistry or History class.                             *
 *                                                                        *
 *                                                                        *
 *  This code and information is provided "as is" without warranty of     *
 *  any kind, either expressed or implied, including but not limited      *
 *  to the implied warranties of merchantability or fitness for a         *
 *  particular purpose. You are free to use this source code in your      *
 *  applications as long as the original copyright notice is included.    *
 *                                                                        *
 **************************************************************************/
using Domainn;
using ITT;
using Artss;
using Historyy;
using Chemistryy;
using System;
using QuizzFactoryy;

namespace ConcreteQuizzFactoryy
{
    /// <summary>
    /// Class for instantiate the chosen domain by the user
    /// </summary>
    public class ConcreteQuizzFactory : QuizzFactory
    {
        public override Domain GetDomain(string domain)
        {
            switch (domain)
            {
                case "it":
                    return new IT();
                case "chimie":
                    return new Chemistry();
                case "istorie":
                    return new History();
                case "arte":
                    return new Arts();
                default:
                    throw new ApplicationException(string.Format("Domain '{0}' could not be created", domain));
            }

        }

    }
}

