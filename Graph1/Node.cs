using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph1
{
    public class Node<T>
    {
        public int Index {  get; set; }
        public T? Data { get; set; }
        public List<Node<T>> Neightbors {  get; set; }=new List<Node<T>>();
        public List<int> Weights {  get; set; } = new List<int>();
        public override string? ToString()
        {
            return $"Узел с индексом {Index}:{Data}, соседей {Neightbors.Count}";
        }
    }
}
