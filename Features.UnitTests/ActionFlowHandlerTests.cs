using System.Windows.Forms;
using NUnit.Framework;

namespace Features.UnitTests
{
    [TestFixture]
    public class ActionFlowHandlerTests
    {
        [TestCase("name")]
        [TestCase("NAME")]
        [TestCase("")]
        [TestCase("1")]
        [TestCase("0")]
        [TestCase("\r")]
        // [TestCase(null)]
        public void Add_InputName_ExistInListView(string actionName)
        {
            // Arrange.
            var listView = new ListView();
            var message = new EmptyMessage();
            var actionFlow = new ActionFlowHandler(listView, message);

            // Act.
            actionFlow.Clear();
            actionFlow.Add(actionName, () => { });

            // Assert.
            Assert.AreEqual(actionName, listView.Items[0].SubItems[1].Text);
        }

        [TestCase(1)]
        [TestCase(3)]
        [TestCase(5)]
        public void Add_InputName_TheFirstItemInListViewSelected(int actionNumber)
        {
            // Arrange.
            var listView = new ListView();
            var message = new EmptyMessage();
            var actionFlow = new ActionFlowHandler(listView, message);

            // Act.
            actionFlow.Clear();
            for (var i = 0; i < actionNumber; i++) actionFlow.Add("test", () => { });

            // Assert.
            Assert.IsTrue(listView.Items[0].Selected);
            for (var i = 1; i < actionNumber; i++) Assert.IsFalse(listView.Items[i].Selected);
        }

        [TestCase(3, 0)]
        [TestCase(3, 1)]
        [TestCase(3, 2)]
        [TestCase(9, 0)]
        [TestCase(9, 8)]
        [TestCase(1, 0)]
        // [TestCase(1,1)]
        public void Do_InputIndex_CallSpecifyMethod(int actionNumber, int targetActionIndex)
        {
            // Arrange.
            var listView = new ListView();
            var message = new EmptyMessage();
            var actionFlow = new ActionFlowHandler(listView, message)
            {
                ShowMessageBoforeAction = false,
                AutoNextAction = false
            };

            var actual = -1;

            // Act.
            actionFlow.Clear();
            for (var i = 0; i < actionNumber; i++)
            {
                var temp = i;
                actionFlow.Add("name", () => actual = temp);
            }

            actionFlow.Do(targetActionIndex);

            // Assert.
            Assert.AreEqual(targetActionIndex, actual);
        }

        [Test]
        [Ignore("ArgumentOutOfRangeException")]
        public void Do_DoAction_AutoNextAction()
        {
            // Arrange.
            var listView = new ListView
            {
                MultiSelect = false
            };
            var message = new EmptyMessage();
            var actionFlow = new ActionFlowHandler(listView, message)
            {
                ShowMessageBoforeAction = false,
                AutoNextAction = true
            };

            // Act.
            actionFlow.Clear();
            actionFlow.Add("test", () => { });
            actionFlow.Add("test", () => { });
            actionFlow.Add("test", () => { });
            listView.Items[0].Selected = true;
            actionFlow.Do(0);

            // Assert.
            Assert.IsTrue(listView.Items[1].Selected);
        }

        [TestCase(1)]
        [TestCase(3)]
        [TestCase(5)]
        public void DoEach_WhenCalled_CallEachMethod(int actionNumber)
        {
            // Arrange.
            var listView = new ListView();
            var message = new EmptyMessage();
            var actionFlow = new ActionFlowHandler(listView, message)
            {
                ShowMessageBoforeAction = false,
                AutoNextAction = false
            };

            var actual = 0;
            var expected = actual + actionNumber;

            // Act.
            actionFlow.Clear();
            for (var i = 0; i < actionNumber; i++) actionFlow.Add("a", () => ++actual);
            actionFlow.DoEach();

            // Assert.
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void UpdateListView_WhenCalled_UpdateListView()
        {
            // Arrange.
            var listView = new ListView();
            var message = new EmptyMessage();
            var actionFlow = new ActionFlowHandler(listView, message);

            var name0 = "action0";
            var name1 = "action1";
            var name2 = "action2";

            // Act.
            actionFlow.Clear();
            actionFlow.Add(name0, () => { });
            actionFlow.Add(name1, () => { });
            actionFlow.Add(name2, () => { });
            actionFlow.UpdateListView();

            // Assert.
            Assert.AreEqual(name0, listView.Items[0].SubItems[1].Text);
            Assert.AreEqual(name1, listView.Items[1].SubItems[1].Text);
            Assert.AreEqual(name2, listView.Items[2].SubItems[1].Text);
        }
    }
}