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
    #endregion

    #region Methods
    public void ShowFinalCount(int value)
    {
        this.finalCount.text = value.ToString();
    }
    #endregion

}
