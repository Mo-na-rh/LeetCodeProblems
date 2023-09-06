namespace UnitTestProjectLeetCode.UtilClasses
{
    class UnionFind
    {
        int[] par;
        int[] rank;

        public int FindCircleNum(int[][] isConnected)
        {
            int n = isConnected.Length;
            par = new int[n];
            rank = new int[n];

            for (int i = 0; i < n; i++)
            {
                // make each node it's own parent..
                par[i] = i;
                // rank is the number of nodes it points to..
                rank[i] = 1;
            }

            int groups = n;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (isConnected[i][j] == 1)
                        // for each edge check if it is in a union
                        // or add it to an existing union set
                        // if added to an existing union set,
                        // returns 1 which is decremented from res...
                        // finally, the number of unions will be
                        // res - the count of edges for which we added to previous union set.
                        groups -= Union_find(i, j);
                }
            }
            return groups;
        }

        int Union_find(int n1, int n2)
        {
            int p1 = Find(n1);

            int p2 = Find(n2);

            // the nodes that are already in a union set will have same parent
            if (p1 == p2)
                return 0;

            // higher ranked node will be the parent of the lower rank node.. 
            if (rank[p1] > rank[p2])
            {
                // change the parent of lower rank node
                par[p2] = p1;
                // increase the rank up to lower ranked node.. 
                rank[p1] += rank[p2];
            }
            else
            {
                par[p1] = p2;
                rank[p2] += rank[p1];
            }
            return 1;
        }

        /// <summary>
        /// Find the topmost ancestor
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        int Find(int x)
        {
            // find the top most parent of the current node
            // top most parent will have itself as it's parent
            while (par[x] != x)
            {
                // basically it will be like a linkedlist..
                // optimization is to first check the grand parent of the node.
                par[x] = par[par[x]];
                x = par[x];
            }
            return x;
        }
    }
}
