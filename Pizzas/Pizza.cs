using System.Transactions;

public abstract class Pizza {
    protected string name = "generic pizza";
    protected string dough;
    protected string sause;
    protected List<string> toppings = new List<string>();

        Pizza order()
    {
        this.prepare();
        this.bake();
        this.cut();
        this.box();
        return this;
    }
    public void prepare() {
        Console.WriteLine("Preparing " + name);
        Console.WriteLine("Tossing dough...");
        Console.WriteLine("Splashing sauce...");
        Console.WriteLine("Adding toppings : ");
        for (int i=0; i < toppings.Count; i++)
        {
            Console.WriteLine(" " + toppings[i]);
        }
    }

    public void bake() {
        Console.WriteLine("Bake for 25 minutes at 180C");
    }

    public void cut() {
        Console.WriteLine("Cutting into wedges...");
    }

    public void box() {
        Console.WriteLine("Putting in a box");
    }

}