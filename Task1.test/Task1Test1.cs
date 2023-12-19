namespace lab1v15.test
{
    public class Task1Test1
    {
        [Fact]
        public void IsNegativeCountValid()
        {
            Task1 task1 = new Task1();
            double[] array = { 0.55, -0.1, -0.56, -4567.1, -5666 };
            Assert.Equal(4, task1.CountNegativeElements(array));
            Assert.Equal(0, task1.CountNegativeElements(null));
        }

        [Fact]
        public void IsSumOfModulesAfterMinElementValid()
        {
            Task1 task1 = new Task1();
            double[] array = { 0.55, -0.1, 0.5, -0.5, 1, -1 };
            Assert.Equal(3, task1.SumOfModulesAfterMinElement(array));
            Assert.Equal(0, task1.SumOfModulesAfterMinElement(null));
        }

        [Fact]
        public void IsProcessArrayValid()
        {
            Task1 task1 = new Task1();
            double[] array = { 0.55, -0.1, 0.5, -0.5, 1, -1 };
            double[] validArray = { 0.1*0.1, 0.5*0.5, 0.5, 0.55, 1, 1 };
            Assert.Equal(validArray, task1.ProcessArray(array));
            Assert.Equal(0, task1.SumOfModulesAfterMinElement(null));
        }
    }
}