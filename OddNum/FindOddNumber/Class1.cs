﻿using System;

namespace FindOddNumber
{
    public static class Kata
    {
        public static int Find(int[] seq)
        {
            for (int i = 0; i < seq.Length; i++) 
            { 
              int count = 0; 
              
            for (int j = 0; j < seq.Length; j++) 
            { 
                if (seq[i] == seq[j]) 
                    count++; 
            } 
            if (count % 2 != 0) 
                return seq[i]; 
        } 
        return -1;
        }
    }
}
