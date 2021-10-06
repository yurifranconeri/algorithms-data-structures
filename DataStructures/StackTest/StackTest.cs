using System;
using Stack;
using Xunit;

namespace StackTest
{
    public class StackTest
    {
        [Fact]
        public void StackEmpty()
        {
            //Act
            var stack = new Stack.Stack();

            //Assert
            Assert.True(stack.IsEmpty());
        }

        [Fact]
        public void StackNotEmpty()
        {
            //Act
            var stack = new Stack.Stack(1);

            //Assert
            Assert.False(stack.IsEmpty());
        }

        [Fact]
        public void StackPush()
        {
            //Arrange
            var stack = new Stack.Stack(1);

            //Act
            stack.Push(0);

            //Assert
            Assert.Equal("0 1 ", stack.ToString());
        }

        [Fact]
        public void StackPushEmpty()
        {
            //Arrange
            var stack = new Stack.Stack();

            //Act
            stack.Push(0);

            //Assert
            Assert.Equal("0 ", stack.ToString());
        }

        [Fact]
        public void StackPop()
        {
            //Arrange
            var stack = new Stack.Stack(1);

            //Act
            var value = stack.Pop();

            //Assert
            Assert.Equal(1, value);
        }

        [Fact]
        public void StackPopEmpty()
        {
            //Arrange
            var stack = new Stack.Stack();

            //Assert
            Assert.Throws<InvalidOperationException>(() => stack.Pop());
        }
        [Fact]
        public void StackPopTwoItems()
        {
            //Arrange
            var stack = new Stack.Stack(1);
            stack.Push(0);

            //Act
            var value0 = stack.Pop();
            var value1 = stack.Pop();

            //Assert
            Assert.Equal(0, value0);
            Assert.Equal(1, value1);
        }

        [Fact]
        public void StackPeek()
        {
            //Arrange
            var stack = new Stack.Stack(1);

            //Act
            var value = stack.Peek();

            //Assert
            Assert.Equal(1, value);
        }

        [Fact]
        public void StackPeekTwice()
        {
            //Arrange
            var stack = new Stack.Stack(1);

            //Act
            var value = stack.Peek();
            var valueAgain = stack.Peek();

            //Assert
            Assert.Equal(1, value);
            Assert.Equal(1, valueAgain);
        }


        [Fact]
        public void StackClear()
        {
            //Arrange
            var stack = new Stack.Stack(1);
            stack.Push(2);

            //Act
            stack.Clear();

            //Assert
            Assert.True(stack.IsEmpty());
        }
    }
}
