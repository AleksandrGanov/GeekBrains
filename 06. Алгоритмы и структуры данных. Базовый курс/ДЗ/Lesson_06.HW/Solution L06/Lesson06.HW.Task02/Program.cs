/* Описание задания:
Ганов Александр Анатольевич
====================
2. Переписать программу, реализующую двоичное дерево поиска.
а) Добавить в него обход дерева различными способами;
б) Реализовать поиск в двоичном дереве поиска; 
*/

using System;

namespace Lesson06.HW.Task02
{
    class Program
    {
        static void Main()
        {
            BinTree<int> binTree = new BinTree<int>();
            binTree.Add(6);
            binTree.Add(2);
            binTree.Add(8);
            binTree.Add(1);
            binTree.Add(4);
            binTree.Add(7);
            binTree.Add(9);
            binTree.Add(3);
            binTree.Add(5);

            binTree.PrintTree();
            Console.WriteLine();
            binTree.PrintTreeСircumvent(CircType.КореньЛевыйПравый);
            binTree.PrintTreeСircumvent(CircType.ЛевыйКореньПравый);
            binTree.PrintTreeСircumvent(CircType.ЛевыйПравыйКорень);

            #region unused
            //Console.WriteLine(new string('-', 20));
            //binTree.Remove(3);
            //binTree.PrintTree();

            //Console.WriteLine(new string('-', 20));
            //binTree.Remove(8);
            //binTree.PrintTree(); 
            #endregion
            Console.ReadLine();
        }
    }
    public enum Side
    {
        Left,
        Right
    }
    public enum CircType
    {
        КореньЛевыйПравый,
        ЛевыйКореньПравый,
        ЛевыйПравыйКорень
    }
    public class BinNode<T> where T : IComparable
    {
        public T Data { get; set; }
        public int Level { get; set; }
        public BinNode<T> LeftNode { get; set; }
        public BinNode<T> RightNode { get; set; }
        public BinNode<T> ParentNode { get; set; }
        public Side? NodeSide =>
            ParentNode == null ?
                (Side?)null
                : ParentNode.LeftNode == this
                    ? Side.Left
                    : Side.Right;

        public BinNode(T data) => Data = data;

        public override string ToString() => Data.ToString();
    }
    public class BinTree<T> where T : IComparable
    {
        public int MaxLevel { get; set; }
        public BinNode<T> RootNode { get; set; }

        public BinNode<T> Add(BinNode<T> node, BinNode<T> currentNode = null)
        {
            if (RootNode == null)
            {
                node.ParentNode = null;
                node.Level = 1;
                return RootNode = node;
            }

            currentNode = currentNode ?? RootNode;
            node.ParentNode = currentNode;
            node.Level = node.ParentNode.Level + 1;
            if (node.Level > MaxLevel) MaxLevel = node.Level;
            int result;
            return (result = node.Data.CompareTo(currentNode.Data)) == 0 ?
                currentNode :
                    result < 0 ?
                        currentNode.LeftNode == null ? currentNode.LeftNode = node : Add(node, currentNode.LeftNode)
                        : currentNode.RightNode == null ? currentNode.RightNode = node : Add(node, currentNode.RightNode);
        }
        public BinNode<T> Add(T data)
        {
            return Add(new BinNode<T>(data));
        }
        public void Remove(BinNode<T> node)
        {
            if (node == null)
            {
                return;
            }

            var currentNodeSide = node.NodeSide;
            //если у узла нет подузлов, можно его удалить
            if (node.LeftNode == null && node.RightNode == null)
            {
                if (currentNodeSide == Side.Left)
                {
                    node.ParentNode.LeftNode = null;
                }
                else
                {
                    node.ParentNode.RightNode = null;
                }
            }
            //если нет левого, то правый ставим на место удаляемого 
            else if (node.LeftNode == null)
            {
                if (currentNodeSide == Side.Left)
                {
                    node.ParentNode.LeftNode = node.RightNode;
                }
                else
                {
                    node.ParentNode.RightNode = node.RightNode;
                }

                node.RightNode.ParentNode = node.ParentNode;
            }
            //если нет правого, то левый ставим на место удаляемого 
            else if (node.RightNode == null)
            {
                if (currentNodeSide == Side.Left)
                {
                    node.ParentNode.LeftNode = node.LeftNode;
                }
                else
                {
                    node.ParentNode.RightNode = node.LeftNode;
                }

                node.LeftNode.ParentNode = node.ParentNode;
            }
            //если оба дочерних присутствуют,  то правый становится на место удаляемого, а левый вставляется в правый
            else
            {
                switch (currentNodeSide)
                {
                    case Side.Left:
                        node.ParentNode.LeftNode = node.RightNode;
                        node.RightNode.ParentNode = node.ParentNode;
                        Add(node.LeftNode, node.RightNode);
                        break;
                    case Side.Right:
                        node.ParentNode.RightNode = node.RightNode;
                        node.RightNode.ParentNode = node.ParentNode;
                        Add(node.LeftNode, node.RightNode);
                        break;
                    default:
                        var bufLeft = node.LeftNode;
                        var bufRightLeft = node.RightNode.LeftNode;
                        var bufRightRight = node.RightNode.RightNode;
                        node.Data = node.RightNode.Data;
                        node.RightNode = bufRightRight;
                        node.LeftNode = bufRightLeft;
                        Add(bufLeft, node);
                        break;
                }
            }
        }
        public void Remove(T data)
        {
            var foundNode = FindNode(data);
            Remove(foundNode);
        }
        public BinNode<T> FindNode(T data, BinNode<T> startWithNode = null)
        {
            startWithNode = startWithNode ?? RootNode;
            int result;
            return (result = data.CompareTo(startWithNode.Data)) == 0 ?
                startWithNode
                : result < 0 ?
                    startWithNode.LeftNode == null ?
                        null
                        : FindNode(data, startWithNode.LeftNode)
                    : startWithNode.RightNode == null
                        ? null
                        : FindNode(data, startWithNode.RightNode);
        }
        public void PrintTree()
        {
            Console.WriteLine("Вывод \"псевдодерево\"");
            PrintTree(RootNode);
        }
        public void PrintTree(BinNode<T> startNode, string indent = "", Side? side = null)
        {
            if (startNode != null)
            {
                const int indentStep = 1;
                string delim = indent == "" ? "" : ":";
                string maxLevel = indent == "" ? $" (max.height:{MaxLevel - 1})" : "";
                string nodeLevel = indent != "" ? $" (level:{startNode.Level})" : "";
                var nodeSide = side == null ? "" : side == Side.Left ? "L" : "R";
                Console.Write($"{startNode.Level}|");
                Console.WriteLine($"{indent}{nodeSide}{delim}{startNode.Data}{maxLevel}{nodeLevel}");
                indent += new string(' ', indentStep);
                //рекурсивный вызов для левой и правой веток
                PrintTree(startNode.LeftNode, indent, Side.Left);
                PrintTree(startNode.RightNode, indent, Side.Right);
            }
        }
        public void PrintTreeСircumvent(CircType type)
        {
            switch ((int)type)
            {
                case (0):
                    Console.Write($"КореньЛевыйПравый: ");
                    PrintTreeСirc01(RootNode);
                    break;
                case (1):
                    Console.Write($"ЛевыйКореньПравый: ");
                    PrintTreeСirc02(RootNode);
                    break;
                case (2):
                    Console.Write($"ЛевыйПравыйКорень: ");
                    PrintTreeСirc03(RootNode);
                    break;
                default:
                    Console.Write($"\nОбход дерева: ");
                    break;
            }
            Console.WriteLine("");
        }
        public void PrintTreeСirc01(BinNode<T> startNode)
        {
            if (startNode != null)
            {
                Console.Write(startNode.Data);
                PrintTreeСirc01(startNode.LeftNode);
                PrintTreeСirc01(startNode.RightNode);
            }
        }
        public void PrintTreeСirc02(BinNode<T> startNode)
        {
            if (startNode != null)
            {
                PrintTreeСirc02(startNode.LeftNode);
                Console.Write(startNode.Data);
                PrintTreeСirc02(startNode.RightNode);
            }
        }
        public void PrintTreeСirc03(BinNode<T> startNode)
        {
            if (startNode != null)
            {
                PrintTreeСirc03(startNode.LeftNode);
                PrintTreeСirc03(startNode.RightNode);
                Console.Write(startNode.Data);
            }
        }
    }
}