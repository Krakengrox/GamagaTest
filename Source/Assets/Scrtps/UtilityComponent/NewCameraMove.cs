using UnityEngine;
using System.Collections;

public class NewCameraMove : MonoBehaviour {

    public Transform target;
    public Vector3 firstLimit;

    void Start() {

        this.firstLimit = target.localScale * 2;
        this.transform.position = Vector3.Lerp(this.transform.position, target.transform.position, 1f);

    }
	

	void Update () {
	
	}
}
