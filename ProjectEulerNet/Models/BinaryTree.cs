using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEulerNet.Models
{
    public class BinaryTree<T>
    {
        public T Value { get; set; }

        public int Level { get; set; }

        public BinaryTree<T> Parent { get; set; }

        public BinaryTree<T> Left { get; set; }

        public BinaryTree<T> Right { get; set; }

        public BinaryTree()
        {
        }

        /// <summary>
        /// Input should be space separated in-line, and newline separated for next level.
        /// TParser is a function that converts strings to T
        /// </summary>
        /// <param name="stringRepresentation"></param>
        /// <param name="TParser"></param>
        public static BinaryTree<T> Parse(string stringRepresentation, Func<string, T> TParser)
        {
            var lines = stringRepresentation.Split(Environment.NewLine);

            var tree = new BinaryTree<T>();

            var list = new List<BinaryTree<T>>
            {
                tree
            };

            for (var i = 0; i < lines.Length; i++)
            {
                var entries = lines[i].Split(' ');

                var nextLevel = new List<BinaryTree<T>>();

                var entryIndex = 0;
                foreach (var t in list)
                {
                    if (entryIndex >= entries.Length)
                    {
                        break;
                    }
                    t.Value = TParser(entries[entryIndex++]);
                    t.Level = i;
                    if (i < lines.Length - 1)
                    {
                        t.Left = new BinaryTree<T>
                        {
                            Parent = t
                        };
                        t.Right = new BinaryTree<T>
                        {
                            Parent = t
                        };
                        nextLevel.Add(t.Left);
                        nextLevel.Add(t.Right);
                    }
                }

                list = nextLevel;
            }

            return tree;
        }
        
        
        /// <summary>
        /// Input should be space separated in-line, and newline separated for next level.
        /// TParser is a function that converts strings to T
        /// </summary>
        /// <param name="stringRepresentation"></param>
        /// <param name="TParser"></param>
        public static BinaryTree<T> ParsePyramid(string stringRepresentation, Func<string, T> TParser)
        {
            var lines = stringRepresentation.Split(Environment.NewLine);

            var tree = new BinaryTree<T>();

            var list = new List<BinaryTree<T>>
            {
                tree
            };

            for (var i = 0; i < lines.Length; i++)
            {
                var entries = lines[i].Split(' ');

                var nextLevel = new List<BinaryTree<T>>();

                var entryIndex = 0;
                foreach (var t in list)
                {
                    if (entryIndex >= entries.Length)
                    {
                        break;
                    }
                    t.Value = TParser(entries[entryIndex++]);
                    t.Level = i;
                    if (i < lines.Length - 1)
                    {
                        t.Left = new BinaryTree<T>
                        {
                            Parent = t
                        };
                        t.Right = new BinaryTree<T>
                        {
                            Parent = t
                        };
                        nextLevel.Add(t.Left);
                        nextLevel.Add(t.Right);
                    }
                }

                list = nextLevel;
            }

            return tree;
        }
    }
}
