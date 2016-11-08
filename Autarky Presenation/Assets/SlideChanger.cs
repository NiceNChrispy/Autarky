using UnityEngine;
using System.Collections;

public class SlideChanger : MonoBehaviour {

    public GameObject[] slides;

	// Use this for initialization
	void Start ()
    {
        for (int i = 0; i < slides.Length; i++)
        {
            slides[i].SetActive(false);
        }
        slides[0].SetActive(true);
    }
	
	// Update is called once per frame
	void Update ()
    {
	    if(Input.GetKeyDown(KeyCode.E))
        {

        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            for (int i = 0; i < slides.Length; i++)
            {
                slides[i].SetActive(false);
            }
            slides[0].SetActive(true);
        }
    }

    public void SwitchToSlide(int slideNumber)
    {
        for (int i = 0; i < slides.Length; i++)
        {
            slides[i].SetActive(false);
        }
        slides[slideNumber].SetActive(true);
    }
}
