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
 *                This class contains questions and answers about         *
 *                Chemistry domain. The correct answer for each           *
 *                question starts with "*".                               *
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

namespace Chemistryy
{
    /// <summary>
    /// Class with questions and answers for Chemistry domain
    /// </summary>
    public class Chemistry : Domain
    {
        //private readonly string _domainName;
        private string[,] _questions = new string[20, 5];
        public override string DomainName
        {
            get
            {
                return "Chemistry";
            }

        }

        public override void Questions()
        {
            //raspunsurile corecte sunt notate cu * si vor fi ascunse de jucatori
            //ne vor ajuta la calcularea scorului
            Console.WriteLine("Chemistry questions.");
            _questions[0, 0] = " What is the most common isotope of hydrogen?";
            _questions[0, 1] = "Deuterium";
            _questions[0, 2] = "Tritum";
            _questions[0, 3] = "*Protium";
            _questions[0, 4] = "Hydrogen only has one isotope!";
            //
            _questions[1, 0] = "You can't live without water! What is its chemical formula?";
            _questions[1, 1] = "H2";
            _questions[1, 2] = "*H2O";
            _questions[1, 3] = "H2O2";
            _questions[1, 4] = "O2";
            //
            _questions[2, 0] = "Which of these elements is a nonmetal?";
            _questions[2, 1] = "*Sulfur";
            _questions[2, 2] = "Manganese";
            _questions[2, 3] = "Aluminium";
            _questions[2, 4] = "Beryllium";
            //
            _questions[3, 0] = "Organic chemistry is the study of the compounds that make up living organisms. All organic molecules contain:";
            _questions[3, 1] = "*Carbon and Hydrogen";
            _questions[3, 2] = "Carbon Only";
            _questions[3, 3] = "Carbon and Nitrogen";
            _questions[3, 4] = "Carbon, Hydrogen, and Oxygen";
            //
            _questions[4, 0] = "The symbol Ag stands for which element?";
            _questions[4, 1] = "Magnesium";
            _questions[4, 2] = "Gallium";
            _questions[4, 3] = "*Silver";
            _questions[4, 4] = "Gold";
            //
            _questions[5, 0] = "A mole contains Avogadro's number of items. What is Avogadro's number?";
            _questions[5, 1] = "6023";
            _questions[5, 2] = "*6.023 x 10^23";
            _questions[5, 3] = "3 x 10^8";
            _questions[5, 4] = "6.02 x 10^-23";
            //
            _questions[6, 0] = " What do you call an atom that has more protons than electrons?";
            _questions[6, 1] = "a molecule";
            _questions[6, 2] = "*a cation";
            _questions[6, 3] = "an isotope";
            _questions[6, 4] = "an anion";
            //
            _questions[7, 0] = "Sulphur is not present in";
            _questions[7, 1] = "iron pyrites";
            _questions[7, 2] = "gypsum";
            _questions[7, 3] = "coal";
            _questions[7, 4] = "*chlorapatite";
            //
            _questions[8, 0] = "All of the following are amino acids except:";
            _questions[8, 1] = "Tyrosine";
            _questions[8, 2] = "Tryptophan";
            _questions[8, 3] = "Leucine";
            _questions[8, 4] = "*Adenine";
            //
            _questions[9, 0] = "In a solution of saltwater (a saline solution), salt is the:";
            _questions[9, 1] = "*Solute";
            _questions[9, 2] = "Solvent";
            _questions[9, 3] = "Sol";
            _questions[9, 4] = "Colloid";
            //
            _questions[10, 0] = "Penicillin is widely used as";
            _questions[10, 1] = "an insecticide";
            _questions[10, 2] = "an antiseptic";
            _questions[10, 3] = "a disinfectant";
            _questions[10, 4] = "*an antibiotic";
            //
            _questions[11, 0] = "The nucleus of an atom consists of";
            _questions[11, 1] = "electrons and neutrons";
            _questions[11, 2] = "electrons and protons";
            _questions[11, 3] = "*protons and neutrons";
            _questions[11, 4] = "All of the these";
            //
            _questions[12, 0] = "The number of moles of solute present in 1 kg of a solvent is called its";
            _questions[12, 1] = "*molality";
            _questions[12, 2] = "molarity";
            _questions[12, 3] = "normality";
            _questions[12, 4] = "formality";
            //
            _questions[13, 0] = "The most electronegative element among the following is";
            _questions[13, 1] = "sodium";
            _questions[13, 2] = "bromine";
            _questions[13, 3] = "*fluorine";
            _questions[13, 4] = "oxygen";
            //
            _questions[14, 0] = "The metal used to recover copper from a solution of copper sulphate is";
            _questions[14, 1] = "Na";
            _questions[14, 2] = "Ag";
            _questions[14, 3] = "Hg";
            _questions[14, 4] = "*Fe";
            //
            _questions[15, 0] = "The metallurgical process in which a metal is obtained in a fused state is called";
            _questions[15, 1] = "*smelting";
            _questions[15, 2] = "roasting";
            _questions[15, 3] = "calcinations";
            _questions[15, 4] = "froth floatation";
            //
            _questions[16, 0] = "The most commonly used bleaching agent is";
            _questions[16, 1] = "alcohol";
            _questions[16, 2] = "carbon dioxide";
            _questions[16, 3] = "*chlorine";
            _questions[16, 4] = "sodium chlorine";
            //
            _questions[17, 0] = "The nucleus of a hydrogen atom consists of";
            _questions[17, 1] = "*1 proton only";
            _questions[17, 2] = "1 proton + 2 neutron";
            _questions[17, 3] = "1 neutron only";
            _questions[17, 4] = "1 electron only";
            //
            _questions[18, 0] = "The nuclear particles which are assumed to hold the nucleons together are";
            _questions[18, 1] = "electrons";
            _questions[18, 2] = "positrons";
            _questions[18, 3] = "neutrons";
            _questions[18, 4] = "*mesons";
            //
            _questions[19, 0] = "The metal that is used as a catalyst in the hydrogenation of oils is ";
            _questions[19, 1] = "*Ni";
            _questions[19, 2] = "Pb";
            _questions[19, 3] = "Cu";
            _questions[19, 4] = "Pt";
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
