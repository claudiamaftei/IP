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
 *               This class contains questions and answers about          *
 *                IT domain. The correct answer for each question         *
 *                starts with "*".                                        *
 *                                                                        *
 *  This code and information is provided "as is" without warranty of     *
 *  any kind, either expressed or implied, including but not limited      *
 *  to the implied warranties of merchantability or fitness for a         *
 *  particular purpose. You are free to use this source code in your      *
 *  applications as long as the original copyright notice is included.    *
 *                                                                        *
 **************************************************************************/


using System;
using Domainn;

namespace ITT
{
    /// <summary>
    /// Class with questions and answers for IT domain
    /// </summary>
    public class IT : Domain
    {

        private string[,] _questions = new string[20, 5];
        public override string DomainName
        {
            get
            {
                return "IT";
            }
        }

        public override void Questions()
        {
            //raspunsurile corecte sunt notate cu * si vor fi ascunse de jucatori
            //ne vor ajuta la calcularea scorului
            Console.WriteLine("IT questions.");
            _questions[0, 0] = "Which one is te first search engine in internet?";
            _questions[0, 1] = "Google";
            _questions[0, 2] = "*Archie";
            _questions[0, 3] = "Altavista";
            _questions[0, 4] = "WAIS";
            //
            _questions[1, 0] = "Number of bit used by the IPv6 address is:";
            _questions[1, 1] = "32 bit";
            _questions[1, 2] = "62 bit";
            _questions[1, 3] = "*128 bit";
            _questions[1, 4] = "256 bit";
            //
            _questions[2, 0] = "Which one is the frst web browser invented in 1990";
            _questions[2, 1] = "*Nexus";
            _questions[2, 2] = "Internet Explorer";
            _questions[2, 3] = "Mozilla";
            _questions[2, 4] = "Mosaic";
            //
            _questions[3, 0] = "Which of the following programming languages is used to create programs like applets?";
            _questions[3, 1] = "*Java";
            _questions[3, 2] = "C";
            _questions[3, 3] = "COBOL";
            _questions[3, 4] = "BASIC";
            //
            _questions[4, 0] = "First computer virus is known as:";
            _questions[4, 1] = "Rabbit";
            _questions[4, 2] = "*Creeper Virus";
            _questions[4, 3] = "Elk Cloner";
            _questions[4, 4] = "SCA Virus";
            //
            _questions[5, 0] = "Which one programming language is exclusively used for artificial intelligence";
            _questions[5, 1] = "C";
            _questions[5, 2] = "*Prolog";
            _questions[5, 3] = "Java";
            _questions[5, 4] = "J2EE";
            //
            _questions[6, 0] = "Firewall in computer is used for:";
            _questions[6, 1] = "*Security";
            _questions[6, 2] = "Data Transmission";
            _questions[6, 3] = "Authentication";
            _questions[6, 4] = "Monitoring";
            //
            _questions[7, 0] = "A dual layer Blue-ray Disc can store data upto";
            _questions[7, 1] = "20GB";
            _questions[7, 2] = "35GB";
            _questions[7, 3] = "15GB";
            _questions[7, 4] = "*50GB";
            //
            _questions[8, 0] = "Which of the following is not an operating system?";
            _questions[8, 1] = "DOS";
            _questions[8, 2] = "Mac";
            _questions[8, 3] = "Linux";
            _questions[8, 4] = "*C";
            //
            _questions[9, 0] = "Which of the following is not a database management software?";
            _questions[9, 1] = "MySQL";
            _questions[9, 2] = "Oracle";
            _questions[9, 3] = "Sybase";
            _questions[9, 4] = "*COBOL";
            //
            _questions[10, 0] = "Number of layers in the OSI(Open Systems Inerconnection) Model";
            _questions[10, 1] = "11";
            _questions[10, 2] = "9";
            _questions[10, 3] = "4";
            _questions[10, 4] = "*7";
            //
            _questions[11, 0] = "How many modes of operation are there in 8255 PPI? ";
            _questions[11, 1] = "1";
            _questions[11, 2] = "2";
            _questions[11, 3] = "*3";
            _questions[11, 4] = "4";
            //
            _questions[12, 0] = "Microprocessor 8085 is enhanced version of …. With essentially the same construction set.";
            _questions[12, 1] = "6800";
            _questions[12, 2] = "68000";
            _questions[12, 3] = "*8080";
            _questions[12, 4] = "8000";
            //
            _questions[13, 0] = "Which of the following is not the part of standard office suite?";
            _questions[13, 1] = "Word Processor";
            _questions[13, 2] = "Data base";
            _questions[13, 3] = "Image editor";
            _questions[13, 4] = "*File manager";
            //
            _questions[14, 0] = "How many bytes are there in 1011 1001 0110 1110 numbers?";
            _questions[14, 1] = "1";
            _questions[14, 2] = "*2";
            _questions[14, 3] = "4";
            _questions[14, 4] = "8";
            //
            _questions[15, 0] = "Transmission of data in one direction is called ";
            _questions[15, 1] = "*Simplex";
            _questions[15, 2] = "Duplex";
            _questions[15, 3] = "Triplex";
            _questions[15, 4] = "None of these";
            //
            _questions[16, 0] = "This type of memory is commonly called temporary or volatile storage";
            _questions[16, 1] = "ROM";
            _questions[16, 2] = "*RAM";
            _questions[16, 3] = "Flash Memory";
            _questions[16, 4] = "Virtual Memory";
            //
            _questions[17, 0] = ". —— is the heart of the computer and this is where all the computing is done.";
            _questions[17, 1] = "Keyboard";
            _questions[17, 2] = "Mouse";
            _questions[17, 3] = "*CPU";
            _questions[17, 4] = "Printer";
            //
            _questions[18, 0] = "What is the full form of IP?";
            _questions[18, 1] = "Internet program";
            _questions[18, 2] = "*Internet Protocol";
            _questions[18, 3] = "Interface program";
            _questions[18, 4] = "Interface program";
            //
            _questions[19, 0] = "The micro processor was introduced in";
            _questions[19, 1] = "first generation computers";
            _questions[19, 2] = "second generation computers";
            _questions[19, 3] = "third generation computers";
            _questions[19, 4] = "*fourth generation computers";
        }

        public override string GetQuestion(int i)
        {
            return _questions[i, 0];
        }

        public override string GetAnswer(int i, int j)
        {
            return _questions[i, j];
        }

        //am nevoie de numarul de intrebari in cazul unei schimbari a numarului intrebarilor in cod
        public override int GetQuestionNumber
        {
            get
            {
                return _questions.GetLength(0);
            }

        }
    }

}
