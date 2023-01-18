namespace AssessmentTest
{
    public class Test
    {
        [Theory]
        [InlineData("{}")]
        [InlineData("}{")]
        [InlineData("{{}")]
        [InlineData("")]
        [InlineData("{{{{{{{{{}}}}}}}}}     }")]
        [InlineData("{abc...xyz}\n{}")]
        public void ValidateInputForBracket(string input)
        {
            Assert.True(Assessment.BracketChecker.IsValidText(input));
        }
    }
}