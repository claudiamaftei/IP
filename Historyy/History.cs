using System;
using Domainn;

namespace Historyy
{
    /// <summary>
    /// Class with questions and answers for History domain
    /// </summary>
    public class History:Domain
    {
        private string[,] _questions = new string[20, 5];

        public override string DomainName
        {
            get
            {
                return "History";
            }
        }

        public override void Questions()
        {
            //raspunsurile corecte sunt notate cu * si vor fi ascunse de jucatori
            //ne vor ajuta la calcularea scorului
            Console.WriteLine("History questions.");
            //
            _questions[0, 0] = "In what year did Christopher Columbus discover the New World?";
            _questions[0, 1] = "1495";
            _questions[0, 2] = "*1492";
            _questions[0, 3] = "1460";
            _questions[0, 4] = "1462";
            //
            _questions[1, 0] = "On September 24, 1906 President Theodore Roosevelt established the first US national monument. What was it?";
            _questions[1, 1] = "*Devils Tower in Wyoming";
            _questions[1, 2] = "Bandelier";
            _questions[1, 3] = "Browns Canyon";
            _questions[1, 4] = "Buck Island Reef";
            //
            _questions[2, 0] = "Which city is traditionally said to be built on seven hills?";
            _questions[2, 1] = "Paris";
            _questions[2, 2] = "*Rome";
            _questions[2, 3] = "New York";
            _questions[2, 4] = "Bucharest";
            //
            _questions[3, 0] = "The atomic bomb was dropped on Hiroshima in which decade?";
            _questions[3, 1] = "*1940's";
            _questions[3, 2] = "1960's";
            _questions[3, 3] = "1980's";
            _questions[3, 4] = "1950's";
            //
            _questions[4, 0] = "In 1893, which country became the first to give women the right to vote?";
            _questions[4, 1] = "Romania";
            _questions[4, 2] = "*New Zealand";
            _questions[4, 3] = "Italy";
            _questions[4, 4] = "Germany";
            //
            _questions[5, 0] = "What famous actor became Governor of California in 2003?";
            _questions[5, 1] = "Leonardo DiCaprio";
            _questions[5, 2] = "Tom Hanks";
            _questions[5, 3] = "*Arnold Schwarzenegger";
            _questions[5, 4] = "Robert De Niro";
            //
            _questions[6, 0] = "In what year did Fidel Castro die?";
            _questions[6, 1] = "2017";
            _questions[6, 2] = "2015";
            _questions[6, 3] = "2013";
            _questions[6, 4] = "*2016";
            //
            _questions[7, 0] = "On September 24, 1906 President Theodore Roosevelt established the first US national monument. What was it?";
            _questions[7, 1] = "*Devils Tower in Wyoming";
            _questions[7, 2] = "Bandelier";
            _questions[7, 3] = "Browns Canyon";
            _questions[7, 4] = "Buck Island Reef";
            //
            _questions[8, 0] = "How many heads of executive departments make up the president's cabinet - 10, 15, or 25?";
            _questions[8, 1] = "*15";
            _questions[8, 2] = "20";
            _questions[8, 3] = "10";
            _questions[8, 4] = "18";
            //
            _questions[9, 0] = "Who was the first US President to declare war?";
            _questions[9, 1] = "*James Madison";
            _questions[9, 2] = "James Monroe";
            _questions[9, 3] = "Andrew Jackson";
            _questions[9, 4] = "Martin Van Buren";
            //
            _questions[10, 0] = "The second atomic bomb ever used in war-time was dropped on what city?";
            _questions[10, 1] = "Jackson";
            _questions[10, 2] = "*Nagasaki";
            _questions[10, 3] = "Denver";
            _questions[10, 4] = "London";
            //
            _questions[11, 0] = "Who did Henry VIII first marry?";
            _questions[11, 1] ="*Catherine of Aragon";
            _questions[11, 2] ="Meghan Markle";
            _questions[11, 3] ="Kate Middleton";
            _questions[11, 4] ="Holly Willoughby";
            //
            _questions[12, 0] = "Who was the second man to walk on the moon?";
            _questions[12, 1] ="*Buzz Aldrin";
            _questions[12, 2] ="Neil Armstrong";
            _questions[12, 3] ="Mark Hamill";
            _questions[12, 4] ="Astronaut Audrey";
            //
            _questions[13, 0] = "Where was the explorer Captain James Cook from?";
            _questions[13, 1] ="*England";
            _questions[13, 2] ="Denmark";
            _questions[13, 3] ="Germany";
            _questions[13, 4] ="Poland";
            //
            _questions[14, 0] = "Which country gave the Statue of Liberty as a gift to the United States of America?";
            _questions[14, 1] ="England";
            _questions[14, 2] ="*France";
            _questions[14, 3] ="Canada";
            _questions[14, 4] ="Mexico";
            //
            _questions[15, 0] = "Which war started in 1939 and ended in 1945?";
            _questions[15, 1] ="World War I";
            _questions[15, 2] ="The Vietnam War";
            _questions[15, 3] ="*World War II";
            _questions[15, 4] ="The Falklands War";
            //
            _questions[16, 0] = "Who kept a diary during the Great Fire of London in 1666?";
            _questions[16, 1] ="Jeremy Clarkson";
            _questions[16, 2] ="*Samuel Pepys";
            _questions[16, 3] ="Dr. Seuss";
            _questions[16, 4] ="Prince Charles";
            //
            _questions[17, 0] = "Who was the first President of the United States of America?";
            _questions[17, 1] ="George Bush";
            _questions[17, 2] ="George W.Bush";
            _questions[17, 3] ="*George Washington";
            _questions[17, 4] ="Ronald Reagan";
            //
            _questions[18, 0] = "In which country was the Battle of Hastings fought?";
            _questions[18, 1] ="Scotland";
            _questions[18, 2] ="Wales";
            _questions[18, 3] ="*England";
            _questions[18, 4] ="France";
            //
            _questions[19, 0] = "Which Roman emperor built a gigantic wall across the North East of England in 122 AD?";
            _questions[19, 1] ="Augustus";
            _questions[19, 2] ="*Hadrian";
            _questions[19, 3] ="Nero";
            _questions[19, 4] ="Caesar";

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
