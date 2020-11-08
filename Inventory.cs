using UnityEngine;

public class Inventory : MonoBehaviour
{
    private List<Item> _items;
    private bool _isButtonTakeItemPressed;

    public List<Item> Items
    {
        get { return _items; }
    }

    private void Start()
    {
        GameManager.Instance.Inventory = this;
        _items = new List<Item>();
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (_isButtonTakeItemPressed && GameManager.Instance.ItemContainer.ContainsKey(collision.gameObject))
        {
            var itemComponent = GameManager.Instance.ItemContainer[collision.gameObject];
            _items.Add(itemComponent.Item);
            itemComponent.Destroy(collision.gameObject);
        }
    }

    public void IsButtonTakeItemPressed(bool isPressed)
    {
        _isButtonTakeItemPressed = isPressed;
    }
}
