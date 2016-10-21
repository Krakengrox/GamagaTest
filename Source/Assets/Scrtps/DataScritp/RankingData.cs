using UnityEngine;
using System.Collections;

[CreateAssetMenu(fileName = "Data", menuName = "RankingData", order = 5)]
public class RankingData : ScriptableObject {

    public string objectName = "RankingData";

    public int firstPosition = 0;
    public int seccondPosition = 0;
    public int thirdPosition = 0;

}
