using UnityEngine.UI;
using UnityEngine;

public class Cell : MonoBehaviour
{
    [SerializeField] private Image _icon;
    [SerializeField] private GameObject _cellPanel;
    [SerializeField] private Text _itemNameFieldTextField;
    [SerializeField] private Text _itemDescriptionTextField;
    [SerializeField] private Image _iconInCell;
    private Item _item;

    private void Awake()
    {
        _icon.sprite = null;
        _icon.gameObject.SetActive(false);
    }

    public void Initialize(Item item)
    {
        _icon.gameObject.SetActive(true);
        _item = item;
        _icon.sprite = _item.Icon;
    }

    public void OnClickCell()
    {
        if (_item == null) return;

        _cellPanel.SetActive(true);
        _itemNameFieldTextField.text = _item.Name;
        _itemDescriptionTextField.text = _item.Description;
        _iconInCell.sprite = _item.Icon;
    }

    [Obsolete("Пока не реализован",true)]
    public void DropItem()
    {

    }
}
