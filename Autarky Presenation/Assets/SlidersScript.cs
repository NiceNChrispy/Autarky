using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SlidersScript : MonoBehaviour {

    public Text[] values;
    public Slider[] sliders;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        values[0].text = sliders[0].value.ToString();
        values[1].text = sliders[1].value.ToString();
        values[2].text = sliders[2].value.ToString();
        values[3].text = sliders[3].value.ToString();
    }
}
