using LinkedList;
using System;
using Xunit;

namespace LinkedListTest
{
    public class LinkedListTest
    {
        [Fact]
        public void LinkedListCreate()
        {
            //Act
            var linkedList = new LinkedList.LinkedList(1);

            //Assert
            var response = $"1 ";
            Assert.Equal(response, linkedList.ToString());
        }

        [Fact]
        public void LinkedListPushOneValue()
        {
            //Arrange
            var linkedList = new LinkedList.LinkedList(1);

            //Act
            linkedList.Push(0);

            //Assert
            var response = $"0 1 ";
            Assert.Equal(response, linkedList.ToString());
        }

        [Fact]
        public void LinkedListPushMultipleValues()
        {
            //Arrange
            var linkedList = new LinkedList.LinkedList(4);

            //Act
            linkedList.Push(3);
            linkedList.Push(2);
            linkedList.Push(1);

            //Assert
            var response = $"1 2 3 4 ";
            Assert.Equal(response, linkedList.ToString());
        }

        [Fact]
        public void LinkedListAppendOneValue()
        {
            //Arrange
            var linkedList = new LinkedList.LinkedList(1);

            //Act
            linkedList.Append(2);

            //Assert
            var response = $"1 2 ";
            Assert.Equal(response, linkedList.ToString());
        }

        [Fact]
        public void LinkedListAppendMultipleValues()
        {
            //Arrange
            var linkedList = new LinkedList.LinkedList(1);

            //Act
            linkedList.Append(2);
            linkedList.Append(3);
            linkedList.Append(4);

            //Assert
            var response = $"1 2 3 4 ";
            Assert.Equal(response, linkedList.ToString());
        }

        [Fact]
        public void LinkedListDeleteHead()
        {
            //Arrange
            var linkedList = new LinkedList.LinkedList(1);

            //Act
            linkedList.Delete(1);

            //Assert
            Assert.Equal(string.Empty, linkedList.ToString());
        }

        [Fact]
        public void LinkedListDeleteFirstItem()
        {
            //Arrange
            var linkedList = new LinkedList.LinkedList(1);
            linkedList.Append(2);


            //Act
            linkedList.Delete(1);

            //Assert
            Assert.Equal("2 ", linkedList.ToString());
        }

        [Fact]
        public void LinkedListDeleteLastItem()
        {
            //Arrange
            var linkedList = new LinkedList.LinkedList(1);
            linkedList.Append(2);


            //Act
            linkedList.Delete(2);

            //Assert
            Assert.Equal("1 ", linkedList.ToString());
        }

        [Fact]
        public void LinkedListDeleteMiddleItem()
        {
            //Arrange
            var linkedList = new LinkedList.LinkedList(1);
            linkedList.Append(2);
            linkedList.Append(3);

            //Act
            linkedList.Delete(2);

            //Assert
            Assert.Equal("1 3 ", linkedList.ToString());
        }


        [Fact]
        public void LinkedListDeleteEmptyList()
        {
            //Arrange
            var linkedList = new LinkedList.LinkedList(1);

            //Act
            linkedList.Delete(1);
            linkedList.Delete(1);

            //Assert
            Assert.Equal(string.Empty, linkedList.ToString());
        }

        [Fact]
        public void LinkedListDeleteNotExistItem()
        {
            //Arrange
            var linkedList = new LinkedList.LinkedList(1);

            //Act
            linkedList.Delete(2);

            //Assert
            Assert.Equal("1 ", linkedList.ToString());
        }

        [Fact]
        public void LinkedListAddAfterValue()
        {
            //Arrange
            var linkedList = new LinkedList.LinkedList(1);

            //Act
            linkedList.InsertAfter(1, 2);

            //Assert
            var response = $"1 2 ";
            Assert.Equal(response, linkedList.ToString());
        }

        [Fact]
        public void LinkedListAddAfterNotFoundValue()
        {
            //Arrange
            var linkedList = new LinkedList.LinkedList(1);

            //Act
            linkedList.InsertAfter(2, 3);

            //Assert
            var response = $"1 ";
            Assert.Equal(response, linkedList.ToString());
        }

        [Fact]
        public void LinkedListInsertAtMiddle()
        {
            //Arrange
            var linkedList = new LinkedList.LinkedList(2);
            linkedList.Push(0);
            //Act
            linkedList.InsertAt(1, 1);

            //Assert
            Assert.Equal("0 1 2 ", linkedList.ToString());
        }

        [Fact]
        public void LinkedListInsertAtTail()
        {
            //Arrange
            var linkedList = new LinkedList.LinkedList(1);

            //Act
            linkedList.InsertAt(1, 2);

            //Assert
            Assert.Equal("1 2 ", linkedList.ToString());
        }

        [Fact]
        public void LinkedListInsertAtHead()
        {
            //Arrange
            var linkedList = new LinkedList.LinkedList(1);

            //Act
            linkedList.InsertAt(0, 3);

            //Assert
            Assert.Equal("3 1 ", linkedList.ToString());
        }

        [Fact]
        public void LinkedListInsertAtNotFoundValue()
        {
            //Arrange
            var linkedList = new LinkedList.LinkedList(1);

            //Assert
            Assert.Throws<InvalidOperationException>(() => linkedList.InsertAt(2, 3));

        }

        [Fact]
        public void LinkedListLength()
        {
            //Arrange
            var linkedList = new LinkedList.LinkedList(1);

            //Assert
            Assert.Equal(1, linkedList.Length);
        }


        [Fact]
        public void LinkedListLengthEmpty()
        {
            //Arrange
            var linkedList = new LinkedList.LinkedList(1);

            //Act
            linkedList.Delete(1);

            //Assert
            Assert.Equal(0, linkedList.Length);
        }

        [Fact]
        public void LinkedListCount()
        {
            //Arrange
            var linkedList = new LinkedList.LinkedList(1);

            //Assert
            Assert.Equal(1, linkedList.Count());
        }


        [Fact]
        public void LinkedListCountEmpty()
        {
            //Arrange
            var linkedList = new LinkedList.LinkedList(1);

            //Act
            linkedList.Delete(1);

            //Assert
            Assert.Equal(0, linkedList.Count());
        }

        [Fact]
        public void LinkedListExistsHead()
        {
            //Arrange
            var linkedList = new LinkedList.LinkedList(1);

            //Act
            bool response = linkedList.Exists(1);

            //Assert
            Assert.True(response);
        }

        [Fact]
        public void LinkedListExistsTail()
        {
            //Arrange
            var linkedList = new LinkedList.LinkedList(1);

            //Act
            linkedList.Append(2);
            bool response = linkedList.Exists(2);

            //Assert
            Assert.True(response);
        }

        [Fact]
        public void LinkedListDestroy()
        {
            //Arrange
            var linkedList = new LinkedList.LinkedList(1);

            //Act
            linkedList.Clear();

            //Assert
            Assert.Equal(string.Empty, linkedList.ToString());
        }


        [Fact]
        public void LinkedListToString()
        {
            //Arrange
            var linkedList = new LinkedList.LinkedList(1);
            var push = 0;
            var append = 2;

            //Act
            linkedList.Push(push);
            linkedList.Append(append);

            //Assert
            var response = $"0 1 2 ";
            Assert.Equal(response, linkedList.ToString());

        }
    }
}
