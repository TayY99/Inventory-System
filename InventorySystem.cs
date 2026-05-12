// Inventory System


public class Item // the blueprint for the items
{
	public string Name {get; set; }
	public int Quantity {get; set; }

	public Item(string name, int quantity)
	{
		Name = name;
		Quantity = quantity;
	}
}