//using DjikstraDLL;
//using System.Collections.ObjectModel;

//public class NodeList<T> : Collection<GraphNode<T>>
//{
//    public NodeList() : base() { }

//    public NodeList(int initialSize)
//    {
//        // Add the specified number of items
//        for (int i = 0; i < initialSize; i++)
//            base.Items.Add(default(GraphNode<T>));
//    }

//    public GraphNode<T> FindByValue(T value)
//    {
//        // search the list for the value
//        foreach (GraphNode<T> node in Items)
//            if (node.Value.Equals(value))
//                return node;

//        // if we reached here, we didn't find a matching node
//        return null;
//    }

//}