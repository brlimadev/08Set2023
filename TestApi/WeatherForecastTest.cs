using _08Set2023.Controllers;

namespace TestApi
{
    public class WeatherForecastTest
    {
        [Fact]
        public void DeveFazerGetComSucesso()
        {
            var controller = new WeatherForecastController();
            var result = controller.Get();

            Assert.True(result.Count() > 0);
        }
    }
}