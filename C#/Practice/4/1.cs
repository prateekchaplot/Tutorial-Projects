/* Route Between Nodes
 * ===================
 * Given a directed graph, design an algorithm to find out whether there is a route between two nodes.
 */

class Solution
{
    enum State { Unvisited, Visiting, Visited };

    bool Search(Graph graph, Node start, Node end)
    {
        if (start == end) return true;

        for (int i = 0; i < graph.Nodes.Count(); i++)
        {
            Node n = graph.Nodes[i];
            n.State = State.Unvisited;
        }

        Queue<Node> q = new Queue<Node>();
        q.Enqueue(start);
        start.State = State.Visiting;

        while (!q.IsEmtpy())
        {
            Node n = q.Dequeue();
            for (int i = 0; i < n.AdjacentNodes.Count(); i++)
            {
                Node adj = n.AdjacentNodes[i];
                if (adj.State == State.Unvisited)
                {
                    if (adj == end) return true;
                    q.Enqueue(adj);
                    adj.State = State.Visiting;
                }
            }
            n.State = State.Visited;
        }

        return false;
    }
}
