module Tests

open System
open Xunit
open FSLib

[<Fact>]
let ``My test`` () =
    Assert.True(true)

[<Fact>]
let ``My test 1`` () =
    let expectedOutput = "Appleyay"
    let actual = PigLatin.toPigLatin "Apple"

    Assert.Equal(expectedOutput, actual)
    Assert.True(true)
