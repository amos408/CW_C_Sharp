//DNA to RNA Conversion
//Ribonucleic acid, RNA, is the primary messenger molecule in cells.
//RNA differs slightly from DNA its chemical structure and contains no Thymine. In RNA Thymine is replaced by another nucleic acid Uracil ('U').

//Create a function which translates a given DNA string into RNA.

//For example: "GCAT"  =>  "GCAU"
//The input string can be of arbitrary length - in particular, it may be empty.
//All input is guaranteed to be valid, i.e. each input string will only ever
//consist of 'G', 'C', 'A' and/or 'T'.


using System;
using System.Collections.Generic;
namespace Converter
{
    public class Converter
    {
        public string dnaToRna(string dna)
        {
            // Have fun! ^_^
            Dictionary<char, char> dnaToRna = new()
            {
                { 'G', 'G' },
                { 'C', 'C' },
                { 'A', 'A' },
                { 'T', 'U' }
            };

            char[] dnaArray = dna.ToCharArray();
            char[] rnaArray = new char[dnaArray.Length];
            for (int i = 0; i < dnaArray.Length; i += 1)
            {
                rnaArray[i] = dnaToRna[dnaArray[i]];
            }
            return String.Concat(rnaArray);
            
        }
    }
}
