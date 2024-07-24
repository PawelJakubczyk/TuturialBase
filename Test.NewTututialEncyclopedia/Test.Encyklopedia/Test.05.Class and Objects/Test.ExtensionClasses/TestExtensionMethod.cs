using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewTututialEncyklopedia.Classes.ExtensionClasses;
using FluentAssertions;

namespace Test.NewTututialEncyclopedia.Test.Encyklopedia.Test._05.Class_and_Objects.Test.ExtensionClasses;

public class TestExtensionMethod
{
    [Fact]
    public void ChangeBaseElement_ResoultShoudReturnArrayStringFilledWithFourEmptyString_WhenTypeIsStringAndinputIsEmptyString()
    {
        //Arrange
        string[] testString = ["", "", "", ""];
        string[] resoultString = new string[testString.Length];

        //Act
        string[]? resoult = resoultString.ChangeBaseElement("");

        //Assert
        for (int i = 0; i < testString.Length; i++)
        {
            resoult[i].Should().Be(testString[i]);
        }
    }
    //[Fact]
    //public void ChangeBaseElement_ResoultShoudReturnArrayStringFilledWithFourEmptyString_WhenTypeIsStringSizeIsFourAndinputIsEmptyString()
    //{
    //    //Arrange
    //    string[] testString = ["", "", "", ""];
    //    string[] resoultString = new string[testString.Length];

    //    //Act
    //    string[]? resoult = resoultString.ChangeBaseElement(4, "");

    //    //Assert
    //    resoult[0].Should().Be("");
    //    resoult[1].Should().Be("");
    //    resoult[2].Should().Be("");
    //    resoult[3].Should().Be("");

    //}
    //[Fact]
    //public void ChangeBaseElement_ResoultShoudReturnArrayStringFilledWithFourNullString_WhenTypeIsStringSizeIsFourAndinputIsEmptyString()
    //{
    //    //Arrange
    //    string[] testString = ["", "", "", ""];
    //    string[] resoultString = new string[testString.Length];

    //    //Act
    //    string[]? resoult = resoultString.ChangeBaseElement(4, "");

    //    //Assert
    //    resoult[0].Should().Be("");
    //    resoult[1].Should().Be("");
    //    resoult[2].Should().Be("");
    //    resoult[3].Should().Be("");

    //}
}

