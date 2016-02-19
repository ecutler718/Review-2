using System.Collections.Generic;
using Xunit;
namespace CountProject.Objects
{
  public class CountTest
  {
    [Fact]
    public void Word_forStringInput NotContainingWord_0()
    {
     the test should pass if there is no repeating word
    }
    [Fact]
    public void Word_forStringInput IsWord_1()
    {
     the test should pass if the input equals the input is the given string 
    }
    [Fact]
    public void Word_forStringInput ContainsWordOneTime()
    {
     the test should pass if the input is in the string once but does not equal the string
    }
    [Fact]
    public void Word_forStringInput ContainsWordMutipleTimes_3()
    {
      the test should pass if the word is in the string multipe times
    }
    [Fact]
    public void Word_forStringInput ContainsWordMutipleTimesExactlyAsEntered()
    {
      the test should pass if the word is in the string multiple times exactly as entered
    }
  }
}
