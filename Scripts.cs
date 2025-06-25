

//INTERFACES

// IEquippable.cs
public interface IEquippable
{
    void Equip();
}


//IThrowable.cs
public interface IThrowable
{
    void Throw();
}

//Item.cs
using UnityEngine;

public class Item: MonoBehaviour
{
    public string itemName;
}

//BASE ITEM CLASS

//Item.cs
using UnityEngine;

public class Item: MonoBehaviour
{
    public string itemName;
}

//EXAMPLE ITEMS
// Sword.cs
using UnityEngine;

public class Sword : Item, IEquipable
{
    public void Equip()
    {
        Debug.Log($"You equipped the {itemName}!");
    }
}

// Rock.cs
using UnityEngine;

public class Rock : Item, IThrowable
{
    public void Throw()
    {
        Debug.Log($"You threw the {itemName}!");
    }
}

// Spear.cs
using UnityEngine;

public class Spear : Item, IEquipable, IThrowable
{
    public void Equip()
    {
        Debug.Log($"You equipped the {itemName}!");
    }

    public void Throw()
    {
        Debug.Log($"You threw the {itemName}!");
    }
}
