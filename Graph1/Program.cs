using GraphProject;

//неориентированный без весов
//Graph<int> graph = new Graph<int>(false, false);

//Node<int> n1 = graph.AddNode(1);
//Node<int> n2 = graph.AddNode(2);
//Node<int> n3 = graph.AddNode(3);
//Node<int> n4 = graph.AddNode(4);
//Node<int> n5 = graph.AddNode(5);
//Node<int> n6 = graph.AddNode(6);
//Node<int> n7 = graph.AddNode(7);
//Node<int> n8 = graph.AddNode(8);

//graph.AddEdge(n1, n2);
//graph.AddEdge(n1, n3);
//graph.AddEdge(n3, n4);
//graph.AddEdge(n2, n4);
//graph.AddEdge(n4, n5);
//graph.AddEdge(n5, n8);
//graph.AddEdge(n5, n6);
//graph.AddEdge(n5, n7);
//graph.AddEdge(n7, n8);
//graph.AddEdge(n6, n7);

//ориентированный с весами
//Graph<int> graph = new Graph<int>(true, true);
//Node<int> n1 = graph.AddNode(1);
//Node<int> n2 = graph.AddNode(2);
//Node<int> n3 = graph.AddNode(3);
//Node<int> n4 = graph.AddNode(4);
//Node<int> n5 = graph.AddNode(5);
//Node<int> n6 = graph.AddNode(6);
//Node<int> n7 = graph.AddNode(7);
//Node<int> n8 = graph.AddNode(8);

//graph.AddEdge(n1, n2,9);
//graph.AddEdge(n2, n1, 3);
//graph.AddEdge(n1, n3, 5);
//graph.AddEdge(n2, n4, 18);
//graph.AddEdge(n4, n2, 2);
//graph.AddEdge(n3, n4, 12);
//graph.AddEdge(n4, n8, 8);
//graph.AddEdge(n5, n4, 9);
//graph.AddEdge(n5, n8, 3);
//graph.AddEdge(n8,n5, 3);
//graph.AddEdge(n7, n8, 6);
//graph.AddEdge(n5, n7, 5);
//graph.AddEdge(n7, n5, 4);
//graph.AddEdge(n6, n7, 1);
//graph.AddEdge(n5, n6, 2);

//поиск в глубину и ширину
//List<Node<int>> dfsnodes= graph.DFS();
//dfsnodes.ForEach(n => Console.WriteLine(n));
//Console.WriteLine();
//List<Node<int>> bfsnodes = graph.BFS();
//bfsnodes.ForEach(n => Console.WriteLine(n));

//Остовные деревья

//Graph<int> graph = new Graph<int>(true, true);

//Node<int> n1 = graph.AddNode(1);
//Node<int> n2 = graph.AddNode(2);
//Node<int> n3 = graph.AddNode(3);
//Node<int> n4 = graph.AddNode(4);
//Node<int> n5 = graph.AddNode(5);
//Node<int> n6 = graph.AddNode(6);
//Node<int> n7 = graph.AddNode(7);
//Node<int> n8 = graph.AddNode(8);

//graph.AddEdge(n1, n2, 9);
//graph.AddEdge(n1, n3, 5);
//graph.AddEdge(n2, n1, 3);
//graph.AddEdge(n2, n4, 18);
//graph.AddEdge(n3, n4, 12);
//graph.AddEdge(n4, n2, 2);
//graph.AddEdge(n4, n8, 8);
//graph.AddEdge(n5, n4, 9);
//graph.AddEdge(n5, n6, 2);
//graph.AddEdge(n5, n7, 5);
//graph.AddEdge(n5, n8, 3);
//graph.AddEdge(n6, n7, 1);
//graph.AddEdge(n7, n5, 4);
//graph.AddEdge(n7, n8, 6);
//graph.AddEdge(n8, n5, 3);

//Алгоритм Крускала
//List<Edge<int>> mstKruskal = graph.MinimumSpanningTreeKruskal();
//mstKruskal.ForEach(e => Console.WriteLine(e));

//Алгоритм Прима
//List<Edge<int>> mstPrima = graph.MinimumSpanningTreePrim();
//mstPrima.ForEach(e => Console.WriteLine(e));

#region TelecommunicationCable
Graph<string> graph = new Graph<string>(false, true);
Node<string> nodeB1 = graph.AddNode("B1");
Node<string> nodeB2 = graph.AddNode("B2");
Node<string> nodeB3 = graph.AddNode("B3");
Node<string> nodeB4 = graph.AddNode("B4");
Node<string> nodeB5 = graph.AddNode("B5");
Node<string> nodeB6 = graph.AddNode("B6");
Node<string> nodeR1 = graph.AddNode("R1");
Node<string> nodeR2 = graph.AddNode("R2");
Node<string> nodeR3 = graph.AddNode("R3");
Node<string> nodeR4 = graph.AddNode("R4");
Node<string> nodeR5 = graph.AddNode("R5");
Node<string> nodeR6 = graph.AddNode("R6");

graph.AddEdge(nodeB1, nodeB2, 2);
graph.AddEdge(nodeB1, nodeB3, 20);
graph.AddEdge(nodeB1, nodeB4, 30);
graph.AddEdge(nodeB2, nodeB4, 20);
graph.AddEdge(nodeB2, nodeB3, 30);
graph.AddEdge(nodeB2, nodeR2, 25);
graph.AddEdge(nodeB4, nodeB4, 25);
graph.AddEdge(nodeR4, nodeR3, 1);
graph.AddEdge(nodeR3, nodeR2, 1);
graph.AddEdge(nodeR2, nodeR1, 1);
graph.AddEdge(nodeR1, nodeR5, 75);
graph.AddEdge(nodeR5, nodeR6, 3);
graph.AddEdge(nodeR3, nodeR6, 100);
graph.AddEdge(nodeR6, nodeB5, 3);
graph.AddEdge(nodeB5, nodeB6, 6);
graph.AddEdge(nodeR6, nodeB6, 10);

//Алгоритм Крускала
List<Edge<string>> mstKruskal = graph.MinimumSpanningTreeKruskal();
mstKruskal.ForEach(e => Console.WriteLine(e));
Console.WriteLine("Total cost:"+mstKruskal.Sum(e=>e.Weight));

//Алгоритм Прима
List<Edge<string>> mstPrima = graph.MinimumSpanningTreePrim();
mstPrima.ForEach(e => Console.WriteLine(e));
Console.WriteLine("Total cost:" + mstPrima.Sum(e => e.Weight));
#endregion







