using System;
using Xunit;
using BinaryTree;

namespace BinaryTreeTest
{
    public class BinaryTreeTest
    {
        [Fact]
        public void BinaryTreeCreated()
        {
            //Act
            var bt = new BinaryTree.BinaryTree(1);

            //Assert
            Assert.NotNull(bt);
        }

        [Fact]
        public void BinaryTreeValue()
        {
            //Act
            var bt = new BinaryTree.BinaryTree(1);

            //Assert
            Assert.Equal("1", bt.ToString());
        }

        [Fact]
        public void BinaryTreeInsert()
        {
            //Arrange
            var bt = new BinaryTree.BinaryTree(1);

            //Act
            bt.Insert(2);

            //Assert
            Assert.Equal("2 1", bt.ToString());
        }

        [Fact]
        public void BinaryTreeInsertMultipleItems()
        {
            //Arrange
            var bt = new BinaryTree.BinaryTree();

            //Act
            bt.Insert(1);
            bt.Insert(2);
            bt.Insert(3);
            bt.Insert(4);
            bt.Insert(5);

            //Assert
            Assert.Equal("4 2 5 1 3", bt.ToString());
        }

        [Fact]
        public void BinaryTreeInOrder()
        {
            //Arrange
            var bt = new BinaryTree.BinaryTree();

            //Act
            bt.Insert(1);
            bt.Insert(2);
            bt.Insert(3);
            bt.Insert(4);
            bt.Insert(5);

            //Assert
            Assert.Equal("4 2 5 1 3", bt.ToStringInOrder());
        }

        [Fact]
        public void BinaryTreePostOrder()
        {
            //Arrange
            var bt = new BinaryTree.BinaryTree();

            //Act
            bt.Insert(1);
            bt.Insert(2);
            bt.Insert(3);
            bt.Insert(4);
            bt.Insert(5);

            //Assert
            Assert.Equal("4 5 2 3 1", bt.ToStringPostOrder());
        }

        [Fact]
        public void BinaryTreePreOrder()
        {
            //Arrange
            var bt = new BinaryTree.BinaryTree();

            //Act
            bt.Insert(1);
            bt.Insert(2);
            bt.Insert(3);
            bt.Insert(4);
            bt.Insert(5);

            //Assert
            Assert.Equal("1 2 4 5 3", bt.ToStringPreOrder());
        }

        [Fact]
        public void BinaryTreeBreadthFirst()
        {
            //Arrange
            var bt = new BinaryTree.BinaryTree();

            //Act
            bt.Insert(1);
            bt.Insert(2);
            bt.Insert(3);
            bt.Insert(4);
            bt.Insert(5);

            //Assert
            Assert.Equal("1 2 3 4 5", bt.ToStringBreadthFirst());
        }
    }
}
