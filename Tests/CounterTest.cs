using System.Collections.Generic;
using Xunit;
namespace CountRepeatProject.Objects
{
  public class RepeatCounterTest
  {
    [Fact]
    public void Word_forStringInputNotContainingWord_0()
    {
      RepeatCounter newCountRepeat = new RepeatCounter ("test", "result should be 0");
      Assert.Equal(newCountRepeat.CountRepeats(), 0);
    }
    [Fact]
    public void Word_forStringInputIsWord_1()
    {
      RepeatCounter newCountRepeat = new RepeatCounter ("test", "test");
      Assert.Equal(newCountRepeat.CountRepeats(), 1);
    }
    [Fact]
    public void Word_forStringInputContainsWordOneTime_1()
    {
      RepeatCounter newCountRepeat = new RepeatCounter ("test", "this is the test");
       Assert.Equal(newCountRepeat.CountRepeats(), 1);
    }
    [Fact]
    public void Word_forStringInputContainsWordMutipleTimes_3()
    {
      RepeatCounter newCountRepeat = new RepeatCounter ("test", "this is a test that will test how many times this string contains test");
      Assert.Equal(newCountRepeat.CountRepeats(), 3);
    }
    [Fact]
    public void Word_forStringInputContainsWordMutipleTimesExactlyAsEntered_3()
    {
      RepeatCounter newCountRepeat = new RepeatCounter ("test", "test  t e s t  test  htrbgftest  test ");
      Assert.Equal(newCountRepeat.CountRepeats(), 3);
    }
  }
}
