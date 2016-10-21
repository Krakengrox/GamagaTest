using UnityEngine;
using System.Collections;
using UnityEngine.UI;

/// <summary>
/// Ui init Menu control
/// </summary>
public class UiInitMenu : MonoBehaviour
{
    #region Variables
    public Button starGameBtn;
    public Button rankingBtn;
    public GameObject rankingMenu;
    #endregion

    #region Methods
    void Start()
    {
        this.rankingBtn.onClick.AddListener(Ranking);
    }

    void Ranking()
    {
        this.rankingMenu.SetActive(true);
    }

    IEnumerable FadeElement()
    {
        yield return null;
    }
    #endregion
}
