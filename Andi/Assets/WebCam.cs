using UnityEngine;
using System.Collections;

public class WebCam : MonoBehaviour {


    Renderer r;

	// Use this for initialization
	void Start () {

        WebCamTexture wt = new WebCamTexture();
        r = this.GetComponent<Renderer>();

        r.material.mainTexture = wt;
        wt.Play();
	}
}
