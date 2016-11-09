using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordRead
{
    class Tree<T>
    {
        public Tree()
        {
            nodes = new List<Tree<T>>();
        }

        public Tree(T data)
        {
            this.Data = data;
            nodes = new List<Tree<T>>();
        }
       
        private Tree<T> parent;
        /// <summary>
        /// 父结点
        /// </summary>
        public Tree<T> Parent
        {
            get { return parent; }
        }
        /// <summary>
        /// 结点数据
        /// </summary>
        public T Data { get; set; }

        private List<Tree<T>> nodes;
        /// <summary>
        /// 子结点
        /// </summary>
        public List<Tree<T>> Nodes
        {
            get { return nodes; }
        }
        /// <summary>
        /// 添加结点
        /// </summary>
        /// <param name="node">结点</param>
        public void AddNode(Tree<T> node)
        {
            if (!nodes.Contains(node))
            {
                node.parent = this;
                nodes.Add(node);
            }
        }
        /// <summary>
        /// 添加结点
        /// </summary>
        /// <param name="nodes">结点集合</param>
        public void AddNode(List<Tree<T>> nodes)
        {
            foreach (var node in nodes)
            {
                if (!nodes.Contains(node))
                {
                    node.parent = this;
                    nodes.Add(node);
                }
            }
        }
        /// <summary>
        /// 移除结点
        /// </summary>
        /// <param name="node"></param>
        public void Remove(Tree<T> node)
        {
            if (nodes.Contains(node))
                nodes.Remove(node);
        }
        /// <summary>
        /// 清空结点集合
        /// </summary>
        public void RemoveAll()
        {
            nodes.Clear();
        }
    }
}
