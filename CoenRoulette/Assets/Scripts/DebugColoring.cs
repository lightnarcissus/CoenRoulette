using UnityEngine;
using System.Collections;

public class DebugColoring : MonoBehaviour {

    public Color texColor;

	// Use this for initialization
	void Start () {

        GetComponent<Renderer>().material.color = texColor;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
