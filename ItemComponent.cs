using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemComponent : MonoBehaviour
{
    [SerializeField] private ItemType _itemType;
    [SerializeField] private SpriteRenderer _spriteRenderer;
    private Item _item;

    public Item Item
    {
        get { return _item; }
    }
	
    private void Start()
    {
        _item = GameManager.Instance.ItemDataBase.GetItemOfId((int)_itemType);
        _spriteRenderer.sprite = _item.Icon;
        GameManager.Instance.ItemContainer.Add(gameObject, this);
    }

    public void Destroy(GameObject gameObject)
    {
        Destroy(gameObject);
    }

    public Item Item
    {
        get { return _item; }
    }
}

public enum ItemType
{
    Battery = 0, 
    Bear = 1
}
