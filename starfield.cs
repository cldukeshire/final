using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class starfield : MonoBehaviour
{
    public GameController gameController;
    private ParticleSystem ps;
    public float hSliderValue = 1.0F;

    // Start is called before the first frame update
    void Start()
    {
        ps = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameController.score >= 200)
        {
            var main = ps.main;
            main.simulationSpeed = hSliderValue;
        }
    }
}
