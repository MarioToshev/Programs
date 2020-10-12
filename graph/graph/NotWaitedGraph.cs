using System;
using System.Collections.Generic;
using System.Text;

namespace graph
{
    class Graph<T>
    {
        private List<T> values;
        private Dictionary<int, HashSet<int>> connections;
        public Graph()
        {
            this.values = new List<T>();
            this.connections = new Dictionary<int, HashSet<int>>();
        }
        public void Add(T value)
        {
            this.values.Add(value);
            this.connections.Add(this.values.Count - 1, new HashSet<int>());
        }
        public void Connect(T parent, T child)
        {
            int parentIndex = this.values.IndexOf(parent);
            int childIndex = this.values.IndexOf(child);

            this.connections[parentIndex].Add(childIndex);
        }
        public void DFS(Action<T> action)
        {
            bool[] visited = new bool[this.values.Count];
            foreach (var item in this.connections)
            {
                this.DFS(item.Key, visited, action);
            }
        }
        private void DFS(int currentNodeIndex, bool[] visited, Action<T> action)
        {
            if (!visited[currentNodeIndex])
            {
                visited[currentNodeIndex] = true;

                foreach (var child in this.connections[currentNodeIndex])
                {
                    this.DFS(child, visited, action);
                }
                action.Invoke(this.values[currentNodeIndex]);
            }
        }

       public List<T> ToplogicalSort()
       {
            List<T> result = new List<T>();
            Dictionary<int, HashSet<int>> conn = connections;
            bool[] isVisited = new bool[values.Count];

            while (result.Count < values.Count)
            {
                for (int i = 0; i < values.Count; i++)
                {
                    if (isVisited[i]) continue;

                    bool isLeaf = true;

                    foreach (var connection in conn)
                    {

                        if (connection.Value.Contains(i))
                        {
                            isLeaf = false;
                        }
                    }
                    if (isLeaf)
                    {
                        conn.Remove(i);
                        result.Add(values[i]);
                        isVisited[i] = true;

                    }
                }
            }
            return result;
       }

        public List<T> sort()
        {
            List<T> result = new List<T>();
            Dictionary<int, HashSet<int>> conn = connections;
            bool[] visited = new bool[values.Count];

            while (result.Count < values.Count)
            {
                for (int i = 0; i < values.Count; i++)
                {
                    if (visited[i])
                    {
                        continue;
                    }

                    bool isLeaf = true;

                    foreach (var connection in conn)
                    {
                        if (connection.Value.Contains(i))
                        {
                            isLeaf = false;
                        }
                    }
                    if (isLeaf)
                    {
                        result.Add(values[i]);
                        conn.Remove(i);
                        visited[i] = true;
                    }
                }
            }
            return result;
        }
        

    }
}
