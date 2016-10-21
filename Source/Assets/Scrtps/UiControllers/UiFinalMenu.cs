using UnityEngine;
using System.Collections;
using UnityEngine.UI;

/// <summary>
/// Final Menu UI
/// </summary>
public class UiFinalMenu : MonoBehaviour
{
    #region Variables
    public Button restartButton;
    public Text finalCount;
    public RankingData rankingData;
    #endregion

    #region Methods
    public void ShowFinalCount(int value)
    {
        this.finalCount.text = value.ToString();
        if (rankingData.firstPosition < value)
        {
            rankingData.firstPosition = value;
        }
    }
    #endregion

}
