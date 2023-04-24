class Program {
    static void Main (string[] args){
        Console.Write("Enter the number of items in the bag: ");
        int numItems = int numItems = Convert.Parse(Console.ReadLine());
        string[] items = new string[numItems];
        for(int i = 0; i < numItems; i++)
        Console.WriteLine($"Item {i + 1}:");
        Console.Write("item name: ");
        string itemName = Console.ReadLine();
        Console.Write("Item type (except 'ShowAll'):");
        string itemType = Console.ReadLine();
        if (!items.ContainsKey(itemType))
    }
}