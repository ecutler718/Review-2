using System.Collections.Generic;
using Xunit;
namespace CountProject.Objects
{
  public class CountTest
  {
    [Fact]
    public void Word_forStringInputNotContainingWord_0()
    {
      Count newCount = new Count ("test", "result should be 0");
      Assert.Equal(newCount.Repeats(), 0);
    }
    [Fact]
    public void Word_forStringInputIsWord_1()
    {
      Count newCount = new Count ("test", "test");
      Assert.Equal(newCount.Repeats(), 1);
    }
    [Fact]
    public void Word_forStringInputContainsWordOneTime_1()
    {
      Count newCount = new Count ("test", "this is the test");
       Assert.Equal(newCount.Repeats(), 1);
    }
    [Fact]
    public void Word_forStringInputContainsWordMutipleTimes_3()
    {
      Count newCount = new Count ("test", "this is a test that will test how many times this string contains test");
      Assert.Equal(newCount.Repeats(), 3);
    }
    [Fact]
    public void Word_forStringInputContainsWordMutipleTimesExactlyAsEntered_3()
    {
      Count newCount = new Count ("test", "test || t e s t || test || htrbgftest || test ");
      Assert.Equal(newCount.Repeats(), 2);
    }
  }
}
