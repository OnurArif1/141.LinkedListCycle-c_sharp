

bool HasCycle(Node head)
{
    Node temp = head;
    Node temp2 = head;

    while (temp2 != null && temp2.next != null)
    {
        temp = temp.next;
        temp2 = temp2.next.next;

        if (temp == temp2)
        {
            return true;
        }
    }
    return false;
}



class Node
{
    Node head;
    public Node next;

    public Node(Node head)
    {
        this.head = head;
        this.next = null;
    }
}