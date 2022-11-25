using health_calc_pack_dotnet;
namespace health_calc_test_xunit
{
    public class IMCTest
    {
        [Fact]
        public void When_RequestIMCCalcWithValidData_ThenReturnIMCIndex()
        {
            //Arrange
            var Imc = new IMC();
            var height= 1.68;
            var weight = 85;
            var Expected = 30.12;

            //Act
            var result = Imc.Calc(height, weight);

            //Assert
            Assert.Equal(Expected, result);
        }
        [Fact]
        public void When_RequestIMCCalcWithValidData_ThenReturnIMCIndexWithRangeAssert()
        {
            //Arrange
            var Imc = new IMC();
            var height = 1.68;
            var weight = 85;
            var ExpectedMin = 30.10;
            var ExpectedMax = 30.14;
            //Act
            var result = Imc.Calc(height, weight);

            //Assert
            Assert.InRange(result, ExpectedMin, ExpectedMax);
           
        }
        [Fact]
        public void When_RequestIMCCalcWithInValidData_ThenReturnNaN()
        {
            //Arrange
            var Imc = new IMC();
            var height = 0.0;
            var weight = 0.0;
            var Expected = double.NaN;

            //Act
            var result = Imc.Calc(height, weight);

            //Assert
            Assert.Equal(Expected, result);
        }
        [Fact]
        public void When_RequestIMCCalcWithInValidData_ThenThrowException()
        {
            //Arrange
            var Imc = new IMC();
            var height = 0.0;
            var weight = 85;
          //  var Expected = double.NaN;

            //Act
           // var result = Imc.Calc(height, weight);

            //Assert
            Assert.Throws<Exception>(()=>Imc.Calc(height, weight));
        }

    }
}