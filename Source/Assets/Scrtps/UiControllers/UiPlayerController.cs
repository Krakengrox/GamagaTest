using UnityEngine;
using System.Collections;
using UnityEngine.UI;

/// <summary>
/// UI controll life and o2 barrs
/// </summary>
public class UiPlayerController : MonoBehaviour
{
    #region Variables
    public Image fillHealth;
    public float maxHp;
    public Image fillO2;
    public float maxO2;
    public float amountHpChange;
    public float amountO2Change;
    public Text amountGuears;
    #endregion

    #region Methods
    public void ResetFills(float maxHp, float maxO2)
    {
        this.fillHealth.fillAmount = 1;
        this.maxHp = maxHp;

        this.fillO2.fillAmount = 1;
        this.maxO2 = maxO2;

    }

    public void ReduceHpAmount(float amount)
    {

        this.fillHealth.fillAmount -= (amount / this.maxHp);
        Debug.Log("amount " + amount + "fill" + fillHealth.fillAmount);
        //if (fillHealth && maxHp > 0)
        //{
        //    this.amountHpChange = fillHealth.fillAmount - (amount / this.maxHp);

        //}
    }

    public void ReduceO2Amount(float amount)
    {
        this.fillO2.fillAmount -= (amount / this.maxO2);

        //if (fillHealth && maxHp > 0)
        //{
        //    this.amountO2Change = fillO2.fillAmount - (amount / this.maxO2);
        //}
    }
    void Update()
    {

        //if (this.fillHealth.fillAmount < amountHpChange)
        //{
        //    this.fillHealth.fillAmount += Time.fixedDeltaTime * Time.timeScale * GameConstans.timeUpProgresiveBar;
        //}

        //if (this.fillHealth.fillAmount > amountHpChange)
        //{
        //    this.fillHealth.fillAmount -= Time.fixedDeltaTime * Time.timeScale * GameConstans.timeUpProgresiveBar;

        //}

        //if (this.fillO2.fillAmount < amountO2Change)
        //{
        //    this.fillO2.fillAmount += Time.fixedDeltaTime * Time.timeScale * GameConstans.timeUpProgresiveBar;
        //}

        //if (this.fillO2.fillAmount > amountO2Change)
        //{
        //    this.fillO2.fillAmount -= Time.fixedDeltaTime * Time.timeScale * GameConstans.timeUpProgresiveBar;

        //}
    }

    #endregion

}
