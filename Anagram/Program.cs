﻿using System;
using System.Linq;
using System.Runtime.Intrinsics.Arm;

namespace Anagram{

    class DoAnagramStuffHere{

        protected string[] firstWords = {"cinema", "host", "bab", "train"};
        protected string[] secondWords = {"iceman", "shot", "aba", "rain"};

        static void Main(){
            string[] firstWords = new DoAnagramStuffHere().firstWords;
            string[] secondWords = new DoAnagramStuffHere().secondWords;
            var Output = "";

            for(int i = 0; i < firstWords.Length; i++){
                
                string Current1 = String.Concat(firstWords[i].OrderBy(c=>c));
                string Current2 = String.Concat(secondWords[i].OrderBy(c=>c));

                if (Current1 == Current2){
                    Output += "1";
                } else {
                    Output += "0";
                }
                
            }
            Console.WriteLine(Output);

        }

    }

}