﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WikitionaryParser.Src.Phrases
{
    /// <summary>
    /// A phrase parsed on wikitionary
    /// </summary>
    public class Phrase: WikitionaryEntity
    {
        // Properties -------------------------

        public string Name { get; set; }
        public List<DefinitionAndExamples> DefinitionsAndExamples { get; set; }
        public List<string> Synonyms { get; set; }


        // Methods ----------------------------

        /// <summary>
        /// Prints this entity in the console
        /// </summary>
        public void Print()
        {
            Console.WriteLine(Name);
            if (DefinitionsAndExamples.Any())
            {
                Console.WriteLine("-- Defs:");
                foreach (var definitionAndExamples in DefinitionsAndExamples)
                {
                    definitionAndExamples.Print();
                } 
            }
            if (Synonyms.Any())
            {
                Console.WriteLine("-- Syns:");
                foreach (var synonym in Synonyms)
                {
                    Console.WriteLine(synonym);
                } 
            }
            Console.WriteLine("-----------");
        }
    }
}
