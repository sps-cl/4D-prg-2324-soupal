using System;

interface IRendarable {
    void Render()
}

class Square : IRendarable {
    private int x;

    public void Render() {
        Console.WriteLine("Renderuju")
    }
}

class Rectangle {
    private int w;
    private int h;

    public void Render() {
        Console.WriteLine("Renderuju")
    }
    
    private void ChangeShape() {
        Console.WriteLine("Měnim")
    }

}

class Program {
    public static void Main (string [] args) {
        Rectangle r1 = new Rectangle();
        Square s1 = new Square();

        list<IRendarable> list = new List<IRendarable>();

        list.add(r1);
        list.add(s1);

        foreach(IRendarable)
    }
}