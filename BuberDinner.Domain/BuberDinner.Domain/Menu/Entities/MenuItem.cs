using BuberDinner.Domain.Common.Models;
using BuberDinner.Domain.Menu.ValueObjects;

namespace BuberDinner.Domain.Menu.Entities;

public sealed class MenuItem : Entity<MenuItemId>
{
    public string Name { get; set; }
    
    public string Description { get; set; }
    
    public MenuItem(MenuItemId id, string name, string description) 
        : base(id)
    {
        Name = name;
        Description = description;
    }
    
    public static MenuItem Create(string name, string description)
    {
        return new(MenuItemId.CreateUnique(), 
            name, 
            description);
    }
}