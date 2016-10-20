using UnityEngine;
using System.Collections;

[CreateAssetMenu(fileName = "Data", menuName = "ItemData", order = 2)]
public class ItemData : ScriptableObject
{

    public string objectName = "PlayerData";

    public int valueItem = 0;

}
