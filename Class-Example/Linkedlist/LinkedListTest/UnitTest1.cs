using System;
using Xunit;
using Linkedlist;
using Linkedlist.Node;

namespace LinkedListTest
{
    public class UnitTest1
    {
        [Fact]
        public void NodeClassHasValueProperty()
        {
            //Arrange
            Node node = new Node();
            //Act

            //Assert    
            Assert.IsType<int>(node.value);
        }
        [Fact]
        public void CanGetValueOfValuePropertyInNode()
        {
            Node node = new Node();
            node.value = 10;

            Assert.Equal(10, node.value);
        }

        [Fact]
        public void CanChangeAndSetValueOfValuePropertyInNode()
        {
            Node node = new Node();
            node.value = 10;
            node.value = 15;

            Assert.Equal(15, node.value);
        }

        [Fact]
        public void NodeClasshasNextProperty()
        {
            Node node = new Node();
            Assert.Null(node.Next);
        }

        [Fact]
        public void NextPropertyOnNodeCanBeSet()
        {
            Node node = new Node();
            node.value = 18;

            Node node2 = new Node();
            node.Next = node2;

            Assert.Equal(node.Next, node2);
        }

        [Fact]
        public void LinkedListHasHeadProperty()
        {
            LinkList linklist = new LinkList();

            Assert.Null(linklist.head);
        }

        [Fact]
        public void CAnAddNewNodeToLinkedListAsHead()
        {
            LinkList ll = new LinkList();
            ll.Insert(10);
            ll.Insert(20);

            Assert.Equal(20, ll.head.value);

        }
        [Fact]
        public void CanFindNodeWithValueInt() 
        {
            // Arrange
            LinkList ll = new LinkList();
            ll.Insert(20);
            ll.Insert(20);
            ll.Insert(30);
            ll.Insert(40);


            Assert.True(ll.Includes(30));
        }
        [Fact]
        public void CannotFindNodeWIthValueInt()
        {
            // Arrange
            LinkList ll = new LinkList();
            ll.Insert(20);
            ll.Insert(20);
            ll.Insert(30);
            ll.Insert(40);
            bool chekc = ll.Includes(32);
            Assert.False(chekc);
        }

    }
}
