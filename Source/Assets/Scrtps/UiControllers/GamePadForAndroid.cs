using UnityEngine;
using System.Collections;

/// <summary>
/// Show game pad Canvas only in android
/// </summary>
public class GamePadForAndroid : MonoBehaviour
{
    #region Variables
    public GameObject gamePad;
    #endregion

    #region Methods
    void Start()
    {

#if UNITY_ANDROID
        this.gamePad.SetActive(true);
#else
        this.gamePad.SetActive(false);
#endif
        #endregion
    }

}
