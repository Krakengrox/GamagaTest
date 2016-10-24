using UnityEngine;
using System.Collections;

[CreateAssetMenu(fileName = "Data", menuName = "ObstacleData", order = 2)]
public class ObstacleData : ScriptableObject
{

    public string objectName = "ObstacleData";

    public int damage = 0;

}
