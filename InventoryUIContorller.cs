using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUIContorller : MonoBehaviour
{
    [SerializeField] private Cell[] _cells;
    [SerializeField] private int _cellCount;
    [SerializeField] private Cell _cellPrefab;
    [SerializeField] private Transform _cellTransform;

    private void Initialize()
    {
        _cells = new Cell[_cellCount];

        for (int i = 0; i < _cellCount; i++)
        {
           _cells[i] = Instantiate(_cellPrefab, _cellTransform);

        }
        _cellPrefab.gameObject.SetActive(false);
    }

    private void OnEnable()
    {
        if (_cells == null || _cells.Length <= 0)
        {
            Initialize();
        }

        var inventory = GameManager.Instance.Inventory;

        for (int i = 0; i < inventory.Items.Count; i++)
        {
            if (i < _cells.Length)
            {
                _cells[i].Initialize(inventory.Items[i]);
            }
        }
    }
}
