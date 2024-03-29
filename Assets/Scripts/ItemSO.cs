using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "MewItem", menuName = "SO/Item")]
public class ItemSO : ScriptableObject
{
    public string itemName;
    public Sprite itemImg;
    public bool stackable;
}
