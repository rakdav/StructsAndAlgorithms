using BinaryTree;
using static System.Runtime.InteropServices.JavaScript.JSType;

BinaryTree<QuizItem> tree = GetTree();
BinaryTreeNode<QuizItem> node = tree.Root;
while (node != null)
{
    if(node.Left!= null || node.Right != null)
    {
        Console.WriteLine(node.Data.Text);
        switch (Console.ReadKey(true).Key)
        {
            case ConsoleKey.Y:
                Console.WriteLine("Yes");
                node=node.Left!;
                break;
            case ConsoleKey.N:
                Console.WriteLine("No");
                node = node.Right;
                break;
        }
    }
    else
    {
        Console.WriteLine(node.Data.Text);
        node = null!;
    }
}

BinaryTree <QuizItem> GetTree()
{
    BinaryTree<QuizItem> tree = new BinaryTree<QuizItem>();
    tree.Root = new BinaryTreeNode<QuizItem>()
    {
        Data = new QuizItem("Есть ли у вас опыт в разработке программного обеспечения?"),
        Children=new List<TreeNode<QuizItem>>()
        {
            new BinaryTreeNode<QuizItem>()
            {
                Data=new QuizItem("У вас есть опыт разработки более 5 лет?"),
                Children=new List<TreeNode<QuizItem>>(){
                    new BinaryTreeNode<QuizItem>()
                    {
                        Data=new QuizItem("Вы сеньор!")
                    },
                     new BinaryTreeNode<QuizItem>()
                    {
                        Data=new QuizItem("Вы миддл!")
                    },
                }
            },
            new BinaryTreeNode<QuizItem>()
            {
                 Data=new QuizItem("Вы закончили университет?"),
                 Children=new List<TreeNode<QuizItem>>()
                 {
                     new BinaryTreeNode<QuizItem>()
                     {
                        Data=new QuizItem("Вы джун!")
                     },
                      new BinaryTreeNode<QuizItem>()
                     {
                        Data=new QuizItem("Ты нашел время в семестре?"),
                        Children=new List<TreeNode<QuizItem>>()
                        {
                            new BinaryTreeNode<QuizItem>()
                            {
                                Data=new QuizItem("Вы закончили курсы повышения!")
                            },
                            new BinaryTreeNode<QuizItem>()
                            {
                                Data=new QuizItem("Вы закончили стажировку!")
                            }
                        }
                     }
                 }
            }
        },
    };
    tree.Count = 9;
    return tree;
}
