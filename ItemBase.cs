using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="New Item DataBase", menuName ="DataBase Item")]
public class ItemBase : ScriptableObject
{
    [SerializeField, HideInInspector] private List<Item> _items;
    [SerializeField] private Item _currentItem;
    private int _currentIndex;

    public void CreateItem()
    {
        if(_items == null)
        {
            _items = new List<Item>();
        }

        var item = new Item();
        _items.Add(item);
        _currentItem = item;
        _currentIndex = _items.Count - 1;
    }

    public void RemoveItem()
    {
        if (_items == null) return;

        if (_currentItem == null) return;

        _items.Remove(_currentItem);
        if(_items.Count > 0)
        {
            _currentItem = _items[0];
        }
        else
        {
            CreateItem();
        }
        _currentIndex = 0;
    }
    
    public void NextItem()
    {
        if(_currentIndex +1 <_items.Count)
        {
            _currentIndex++;
            _currentItem = _items[_currentIndex];
        }
    }

    public void PreviosItem()
    {
        if(_currentIndex > 0)
        {
            _currentIndex--;
            _currentItem = _items[_currentIndex];
        }
    }

    public Item GetItemOfId(int id)
    {
        return _items.Find(item => item.Id == id);
    }
}

[System.Serializable]
public class Item
{
    [SerializeField] private int _id;
    [SerializeField] private int _endGameFactor;
    [SerializeField] private int _count;
    [SerializeField] private string _name;
    [SerializeField] private string _description;
    [SerializeField] private Sprite _icon;

    public int Id
    {
        get { return _id; }
    }

    public int EndGameFactor
    {
        get { return _endGameFactor; }
    }

    public int Count
    {
        get { return _count; }
    }

    public string Name
    {
        get { return _name; }
    }

    public string Description
    {
        get { return _description; }
    }

    public Sprite Icon
    {
        get { return _icon; }
    }
}

