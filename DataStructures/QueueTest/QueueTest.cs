using System;
using Queue;
using Xunit;

namespace QueueTest
{
    public class QueueTest
    {
        [Fact]
        public void QueueCreated()
        {
            //Arrange
            var value = 1;
            var queue = new Queue.Queue(value);
            //Assert
            Assert.NotNull(queue);
        }

        [Fact]
        public void QueuePeek()
        {
            //Arrange
            var value = 1;
            var queue = new Queue.Queue(value);

            //Act
            var result = queue.Peek();
            
            //Assert
            Assert.Equal(value, result);
        }

        [Fact]
        public void QueueEnqueue()
        {
            //Arrange
            var value = 1;
            var queue = new Queue.Queue(value);

            //Act
            queue.Enqueue(2);

            //Assert
            Assert.Equal("2 1 ", queue.ToString());
        }

        [Fact]
        public void QueueDequeue()
        {
            //Arrange
            var value = 1;
            var queue = new Queue.Queue(value);

            //Act
            var result = queue.Dequeue();

            //Assert
            Assert.Equal(value, result);
        }

        [Fact]
        public void QueueNotEmpty()
        {
            //Arrange
            var value = 1;
            var queue = new Queue.Queue(value);

            //Assert
            Assert.False(queue.IsEmpty());
        }


        [Fact]
        public void QueueEmpty()
        {
            //Arrange
            var value = 1;
            var queue = new Queue.Queue(value);
            queue.Dequeue();

            //Assert
            Assert.True(queue.IsEmpty());
        }

        [Fact]
        public void QueueCount()
        {
            //Arrange
            var value = 1;
            var queue = new Queue.Queue(value);

            //Assert
            Assert.Equal(1, queue.Count());
        }

        [Fact]
        public void QueueCountMultipleItems()
        {
            //Arrange
            var value = 1;
            var queue = new Queue.Queue(value);
            queue.Enqueue(2);

            //Assert
            Assert.Equal(2, queue.Count());
        }


        [Fact]
        public void QueueCountZero()
        {
            //Arrange
            var value = 1;
            var queue = new Queue.Queue(value);
            _ = queue.Dequeue();

            //Assert
            Assert.Equal(0, queue.Count());
        }
    }
}
