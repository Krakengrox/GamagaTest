using UnityEngine;
using System.Collections;
using UnityEngine.UI;

/// <summary>
/// Ui Rank Controll
/// </summary>
public class UiRanking : MonoBehaviour
{
    #region Variables
    public RankingData rankingData;
    public GameObject rankingTablet;
    public Button exitButton;
    public Text first;
    public Text seccond;
    public Text third;
    #endregion

    #region Methods
    void Start()
    {
        this.exitButton.onClick.AddListener(ExitAction);
        Debug.Log("Start");
    }

    void OnEnable()
    {
        Debug.Log("eneabled");
        this.first.text = this.rankingData.firstPosition.ToString();
        this.seccond.text = this.rankingData.seccondPosition.ToString();
        this.third.text = this.rankingData.thirdPosition.ToString();
    }

    void ExitAction()
    {

        this.gameObject.SetActive(false);
    }

    IEnumerable FadeElement()
    {
        rankingTablet.GetComponent<CanvasGroup>().alpha = 0;

        yield return null;
    }
    #endregion
}
