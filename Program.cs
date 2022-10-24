﻿using System.Collections;
public class Program
{
  public class Node
  {
    public Node next;
    public object data;
  }
  public class MyStack
  {
    Node top;
    public bool IsEmpty()
    {
      return top == null;
    }
    public void Push(object ele)
    {
      Node n = new Node();
      n.data = ele;
      n.next = top;
      top = n;
    }
    public Node Pop()
    {
      if (top == null)
        return null;
      Node d = top;
      top = top.next;
      return d;
    }
    public object Peek(int index){
      MyStack temp = new MyStack();
      int i = -1;
      object data = 0;
      while(i!=index){
        Node t = Pop();
        temp.Push(t.data);
        data = t.data;
        i++;
      }
      while(!temp.IsEmpty())
        Push(temp.Pop().data);
      return data;
    }
  }
  public class Node2
  {
    public Node2 prev, next;
    public object data;
  }
  public class MyQueue
  {
    Node2 rear, front; public bool IsEmpty()
    {
      return rear == null || front == null;
    }
    public void Enqueue(object ele)
    {
      Node2 n = new Node2();
      n.data = ele;
      if (rear == null)
      {
        rear = n; front = n;
      }
      else
      {
        rear.prev = n;
        n.next = rear; rear = n;
      }
    }
    public Node2 Dequeue()
    {
      if (front == null) return null;
      Node2 d = front;
      front = front.prev;
      if (front == null)
        rear = null;
      else
        front.next = null;
      return d;
    }
  }


  static object FindMaxOfStack(in MyStack ms)
  {
    //MyStack nms = new MyStack();
    float max = (float)ms.Pop().data;
    //nms.Push(max);
    while (!ms.IsEmpty())
    {
      float t = (float)ms.Pop().data;
      if (max < t)
        max = t;
      //nms.Push(t);
    }
    /*while(!nms.IsEmpty())
      ms.Push(nms.Pop().data);*/
    return max;
  }
  static object FindMaxOfQueue(in MyQueue mq){
    float max = (float)mq.Dequeue().data;
    while(!mq.IsEmpty()){
      float t = (float)mq.Dequeue().data;
      if(max < t)
        max = t;
    }
    return max;
  }

  static void Main()
  {
    Console.Clear();

    MyStack ms = new MyStack();
    ms.Push(5f); ms.Push(7f); ms.Push(2.5f); ms.Push(8f); ms.Push(4f);
    //System.Console.WriteLine("Max of Stack: {0}", (float)FindMaxOfStack(ms));
    int index = 3;
    System.Console.WriteLine("[{0}]=>{1}", index, ms.Peek(index));
    
    /*MyQueue mq = new MyQueue();
    mq.Enqueue(5f); mq.Enqueue(7f); mq.Enqueue(2.5f); mq.Enqueue(8f); mq.Enqueue(4f);
    System.Console.WriteLine("Max of Queue: {0}", (float)FindMaxOfQueue(mq));*/

    Stack st = new Stack();
    Queue q = new Queue();
    Stack<float> stf = new Stack<float>();
    Queue<float> qf = new Queue<float>();

    Console.ReadLine();
  }
}