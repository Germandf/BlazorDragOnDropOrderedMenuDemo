namespace BlazorDragAndDropOrderedMenuDemo.Data;

public class DropItem
{
    public string Name { get; init; } = "";
    public string Selector { get; set; } = "";
    public int Order { get; set; }
}
