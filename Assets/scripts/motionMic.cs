using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class motionMic : MonoBehaviour {

    public Material CubeMaterial;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        CubeMaterial.SetTexture("_MetaTexture", micController.SpectrumTexture);
    }
}
