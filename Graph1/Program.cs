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
//Graph<string> graph = new Graph<string>(false, true);
//Node<string> nodeB1 = graph.AddNode("B1");
//Node<string> nodeB2 = graph.AddNode("B2");
//Node<string> nodeB3 = graph.AddNode("B3");
//Node<string> nodeB4 = graph.AddNode("B4");
//Node<string> nodeB5 = graph.AddNode("B5");
//Node<string> nodeB6 = graph.AddNode("B6");
//Node<string> nodeR1 = graph.AddNode("R1");
//Node<string> nodeR2 = graph.AddNode("R2");
//Node<string> nodeR3 = graph.AddNode("R3");
//Node<string> nodeR4 = graph.AddNode("R4");
//Node<string> nodeR5 = graph.AddNode("R5");
//Node<string> nodeR6 = graph.AddNode("R6");

//graph.AddEdge(nodeB1, nodeB2, 2);
//graph.AddEdge(nodeB1, nodeB3, 20);
//graph.AddEdge(nodeB1, nodeB4, 30);
//graph.AddEdge(nodeB2, nodeB4, 20);
//graph.AddEdge(nodeB2, nodeB3, 30);
//graph.AddEdge(nodeB2, nodeR2, 25);
//graph.AddEdge(nodeB4, nodeB4, 25);
//graph.AddEdge(nodeR4, nodeR3, 1);
//graph.AddEdge(nodeR3, nodeR2, 1);
//graph.AddEdge(nodeR2, nodeR1, 1);
//graph.AddEdge(nodeR1, nodeR5, 75);
//graph.AddEdge(nodeR5, nodeR6, 3);
//graph.AddEdge(nodeR3, nodeR6, 100);
//graph.AddEdge(nodeR6, nodeB5, 3);
//graph.AddEdge(nodeB5, nodeB6, 6);
//graph.AddEdge(nodeR6, nodeB6, 10);

////Алгоритм Крускала
//List<Edge<string>> mstKruskal = graph.MinimumSpanningTreeKruskal();
//mstKruskal.ForEach(e => Console.WriteLine(e));
//Console.WriteLine("Total cost:"+mstKruskal.Sum(e=>e.Weight));

////Алгоритм Прима
//List<Edge<string>> mstPrima = graph.MinimumSpanningTreePrim();
//mstPrima.ForEach(e => Console.WriteLine(e));
//Console.WriteLine("Total cost:" + mstPrima.Sum(e => e.Weight));
#endregion

#region TelecommunicationCable
//Console.WriteLine("\nРаскраска графа:");
//Graph<int> graph = new Graph<int>(false, false);
//Node<int> node1 = graph.AddNode(1);
//Node<int> node2 = graph.AddNode(2);
//Node<int> node3 = graph.AddNode(3);
//Node<int> node4 = graph.AddNode(4);
//Node<int> node5 = graph.AddNode(5);
//Node<int> node6 = graph.AddNode(6);
//Node<int> node7 = graph.AddNode(7);
//Node<int> node8 = graph.AddNode(8);
//graph.AddEdge(node1, node2);
//graph.AddEdge(node1, node3);
//graph.AddEdge(node3, node4);
//graph.AddEdge(node2, node4);
//graph.AddEdge(node4, node5);
//graph.AddEdge(node4, node8);
//graph.AddEdge(node5, node8);
//graph.AddEdge(node5, node6);
//graph.AddEdge(node5, node7);
//graph.AddEdge(node6, node7);
//graph.AddEdge(node7, node8);
//int[] colors = graph.Color();
//for(int i=0;i<colors.Length; i++)
//{
//    Console.WriteLine($"Узел:{graph.Nodes[i].Data}:{colors[i]}");
//}
#endregion

#region ShipMap
//Graph<string> graph = new Graph<string>(false, false);
//Node<string> nodePK = graph.AddNode("PK");
//Node<string> nodeLU = graph.AddNode("LU");
//Node<string> nodePD = graph.AddNode("PD");
//Node<string> nodeWM = graph.AddNode("WM");
//Node<string> nodeMZ = graph.AddNode("MZ");
//Node<string> nodeSW = graph.AddNode("SW");
//Node<string> nodeMA = graph.AddNode("MA");
//Node<string> nodeSL = graph.AddNode("SL");
//Node<string> nodeLD = graph.AddNode("LD");
//Node<string> nodeKP = graph.AddNode("KP");
//Node<string> nodePM = graph.AddNode("PM");
//Node<string> nodeZP = graph.AddNode("ZP");
//Node<string> nodeWP = graph.AddNode("WP");
//Node<string> nodeLB = graph.AddNode("LB");
//Node<string> nodeDS = graph.AddNode("DS");
//Node<string> nodeOP = graph.AddNode("OP");

//graph.AddEdge(nodePK, nodeLU);
//graph.AddEdge(nodePK, nodeSW);
//graph.AddEdge(nodePK, nodeMA);
//graph.AddEdge(nodeLU, nodeSW);
//graph.AddEdge(nodeLU, nodeMZ);
//graph.AddEdge(nodeLU, nodePD);
//graph.AddEdge(nodePD, nodeMZ);
//graph.AddEdge(nodePD, nodeWM);
//graph.AddEdge(nodeWM, nodeKP);
//graph.AddEdge(nodeWM, nodePM);
//graph.AddEdge(nodeWM, nodeMZ);
//graph.AddEdge(nodeMZ, nodeKP);
//graph.AddEdge(nodeMZ, nodeLD);
//graph.AddEdge(nodeMZ, nodeSW);
//graph.AddEdge(nodeSW, nodeLD);
//graph.AddEdge(nodeSW, nodeSL);
//graph.AddEdge(nodeSW, nodeMA);
//graph.AddEdge(nodeMA, nodeSL);
//graph.AddEdge(nodeSL, nodeOP);
//graph.AddEdge(nodeSL, nodeLD);
//graph.AddEdge(nodeLD, nodeOP);
//graph.AddEdge(nodeLD, nodeWP);
//graph.AddEdge(nodeLD, nodeKP);
//graph.AddEdge(nodeKP, nodeWP);
//graph.AddEdge(nodeKP, nodePM);
//graph.AddEdge(nodePM, nodeZP);
//graph.AddEdge(nodePM, nodeLB);
//graph.AddEdge(nodePM, nodeWP);
//graph.AddEdge(nodeZP, nodeLB);
//graph.AddEdge(nodeWP, nodeDS);
//graph.AddEdge(nodeWP, nodeOP);
//graph.AddEdge(nodeWP, nodeLB);
//graph.AddEdge(nodeLB, nodeDS);
//graph.AddEdge(nodeDS, nodeOP);
//int[] colors = graph.Color();
//for (int i = 0; i < colors.Length; i++)
//{
//    Console.WriteLine($"{graph.Nodes[i].Data}: {colors[i]}");
//}
#endregion

#region Shortest Path

#endregion







