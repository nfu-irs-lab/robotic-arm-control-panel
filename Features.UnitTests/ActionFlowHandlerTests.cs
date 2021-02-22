using NUnit.Framework;
using NSubstitute;

namespace Features.UnitTests
{
    [TestFixture]
    public class ActionFlowHandlerTests
    {
        public interface ITestClass
        {
            void TestMethodA();

            void TestMethodB();
        }

        [Test]
        public void Add_InputName_ExistInListView()
        {
            // Arrange.
            System.Windows.Forms.ListView listView = new System.Windows.Forms.ListView();
            IMessage message = new EmptyMessage();
            IActionFlowHandler actionFlow = new ActionFlowHandler(listView, message);

            string name = "Test";

            // Act.
            actionFlow.Clear();
            actionFlow.Add(name, () => { });

            // Assert.
            Assert.AreEqual(name, listView.Items[0].SubItems[1].Text);
        }

        [Test]
        public void Add_InputName_TheFirstItemInListViewSelected()
        {
            // Arrange.
            System.Windows.Forms.ListView listView = new System.Windows.Forms.ListView();
            IMessage message = new EmptyMessage();
            IActionFlowHandler actionFlow = new ActionFlowHandler(listView, message);

            string name = "Test";

            // Act.
            actionFlow.Clear();
            actionFlow.Add(name, () => { });
            actionFlow.Add(name, () => { });
            actionFlow.Add(name, () => { });

            // Assert.
            Assert.IsTrue(listView.Items[0].Selected);
        }

        [Test]
        [Ignore("There is a problem with this test.")]
        public void Do_InputIndex_CallSpecifyMethod()
        {
            // Arrange.
            ITestClass testClass = Substitute.For<ITestClass>();
            IActionFlowHandler actionFlow = Substitute.For<IActionFlowHandler>();

            actionFlow.ShowMessageBoforeAction = false;
            actionFlow.AutoNextAction = false;

            actionFlow.Clear();
            actionFlow.Add("a", () => testClass.TestMethodA());
            actionFlow.Add("b", () => { });
            actionFlow.Add("c", () => { });

            // Act.
            actionFlow.Do(0);

            // Assert.
            testClass.Received().TestMethodA();
        }
    }
}