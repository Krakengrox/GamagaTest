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
    public int maxHp;
    public Image fillO2;
    public int maxO2;
    public float amountHpChange;
    bool change;
    public float amountO2Change;
    #endregion

    #region Methods
    public void ResetFills(float maxHp, float maxO2)
    {
        this.fillHealth.fillAmount = 1;
        this.fillO2.fillAmount = 1;
        this.amountHpChange = 1;
        this.amountO2Change = 1;

    }

    public void ReduceHpAmount(float amount)
    {
        if (fillHealth && maxHp > 0)
        {
            this.amountHpChange = fillHealth.fillAmount - (amount / this.maxHp);

        }
    }

    public void ReduceO2Amount(float amount)
    {
        if (fillHealth && maxHp > 0)
        {
            this.amountO2Change = fillO2.fillAmount - (amount / this.maxO2);
        }
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
