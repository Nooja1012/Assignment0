
namespace MyApiApp.Tests;
    public class LeapTests{

    [Fact]
       public void Leapyear_Given_4_Returns_True(){
            var sut=new LeapYear();

            var result = sut.isLeapYear(4);

            result.Should().Be(true);
       }

[Fact]
       public void Leapyear_Given_100_Returns_False(){
             var sut=new LeapYear();

            var result = sut.isLeapYear(100);

            result.Should().Be(false);
       }

       [Fact]
       public void Leapyear_Given_400_Returns_True(){
             var sut=new LeapYear();

            var result = sut.isLeapYear(400);

            result.Should().Be(true);
       }

    }
