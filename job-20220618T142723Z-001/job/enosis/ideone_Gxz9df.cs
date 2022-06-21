using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Tree
    {
        // generated already By Enosois
        public List<AnsStruct> Ans = new List<AnsStruct>();

        // Need To Write This Method
        public void GenerateTree(List<Node> inputNodes)
        {
            Dictionary<int,Node> trackNodesBasedOnId = new Dictionary<int, Node>();
            foreach (var node in inputNodes)
            {
                trackNodesBasedOnId[node.Id] = node;
            }

            foreach (var node in inputNodes)
            {
                if (node.Parent_Id != -1)
                {
                    addNode(node, trackNodesBasedOnId[node.Parent_Id]);
                }
                else
                {
                    addNode(node);
                }
            }
        }

        // Method That will be generated already By Enosois
        public void addNode(Node node)
        {
            AnsStruct structure = new AnsStruct();
            structure.CurrentNode = node;
            Node temp = new Node();
            temp.Name = "No Parent";
            structure.ParentNode = temp;
            Ans.Add(structure);
        }

        public void addNode(Node node, Node parentNode)
        {
            AnsStruct structure = new AnsStruct();
            structure.CurrentNode = node;
            structure.ParentNode = parentNode;
            Ans.Add(structure);
        }

        public void DisplayNode()
        {
            foreach (var ansNode in Ans)
            {
                Console.WriteLine(ansNode.CurrentNode.Name + " " + ansNode.ParentNode.Name);
            }
        }
    }

    public struct Node
    { 
        public int Id { get; set; }
        public string Name { get; set; }
        public int Parent_Id { get; set; }
    }

    //generated already By Enosois
    public struct AnsStruct
    {
        public Node CurrentNode { get; set; }
        public Node ParentNode { get; set; }
    }
}
