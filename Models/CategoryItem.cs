namespace QOL_Upper_App_v3.Models;

public class CategoryItem
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string Name { get; set; } = string.Empty;
    public string Type { get; set; } = "expense"; // "expense" (支出) または "income" (収入)
    public string Color { get; set; } = "#4E73DF";
    public int Order { get; set; } = 0;
}