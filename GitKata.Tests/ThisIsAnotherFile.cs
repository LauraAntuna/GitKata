using GitKata.Tests.SillyFolder;
using Moq;

namespace GitKata.Tests
{
    public class Class1Tests
    {
        private Mock<TestyMcTestFace> _myMoq;

        public Class1Tests()
        {
            _myMoq = new Mock<TestyMcTestFace>();
        }
    }
}
