using UnityEngine;
using System.Collections;

public class GamePadForAndroid : MonoBehaviour
{
    public GameObject gamePad;

    void Start()
    {

#if UNITY_ANDROID
        this.gamePad.SetActive(true);
#endif

    }

}
