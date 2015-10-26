using UnityEngine;
using System.Collections;

public class WebCam : MonoBehaviour {

	// Use this for initialization
	void Start () {

        WebCamDevice[] devices = WebCamTexture.devices;
        string backCamName = "";
        for (int i = 0; i < devices.Length; i++)
        {
            Debug.Log("Device:" + devices[i].name + "IS FRONT FACING:" + devices[i].isFrontFacing);

            if (!devices[i].isFrontFacing)
            {
                backCamName = devices[i].name;
            }
        }

        WebCamTexture wct = new WebCamTexture(backCamName);

        this.GetComponent<Renderer>().material.mainTexture = wct;
        wct.Play();

	}
}
