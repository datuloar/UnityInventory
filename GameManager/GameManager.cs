using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    public Dictionary<GameObject, ItemComponent> ItemContainer;	
	public ItemBase ItemDataBase;
	[HideInInspector] public Inventory Inventory;
    [HideInInspector] public bool _isButtonTakeItemPressed;
    [SerializeField] private GameObject _inventoryPanel;

    private void Awake()
    {
        Instance = this;
        ItemContainer = new Dictionary<GameObject, ItemComponent>();
    }
}
