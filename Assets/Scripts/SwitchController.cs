using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchController : MonoBehaviour
{
    public Collider bola;
    public Material onMaterial;
    public Material offMaterial;

    public float score;
    public ScoreManager scoreManager;

    private bool isOn;
    private SwitchState state;
    private Renderer renderer;

    private enum SwitchState
    {
	    Off,
	    On,
	    Blink
    }
    
    private void Start()
    {
        renderer = GetComponent<Renderer>();
        
        Set(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other == bola)
        {
            StartCoroutine(Blink(5));
            Toggle();
        }
    }

    private void Set (bool active)
    {
        isOn = active;

        if (isOn == true)
        {
            renderer.material = onMaterial;
        }
        else
        {
            renderer.material = offMaterial;
        }
    }

   private void Toggle()
    {
        if (state == SwitchState.On)
        {
        Set(false);
        }
	    else
        {
        Set(true);
        }

        scoreManager.AddScore(score);
    }

    private IEnumerator Blink(int times)
    {
        int blinkTimes = times * 2;

        for (int i = 0; i < blinkTimes; i++)
        {
            Set(!isOn);
            yield return new WaitForSeconds (0.5f);
        }
    }
}