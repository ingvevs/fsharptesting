namespace FSLib

open System

module PigLatin = 
    let toPigLatin (str: string) = 
        let vowels = set ['a';'e';'i';'o';'u']
        let firstChar = str.[0]

        if vowels.Contains(Char.ToLower firstChar) then
            str + "yay"
        else
            str.[1..] + Char.ToString(firstChar) + "ay"    

        
