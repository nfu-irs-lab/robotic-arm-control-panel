using NUnit.Framework;

namespace Features.UnitTests
{
    [TestFixture]
    public class ActionFlowHandlerTests
    {
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
    }
}