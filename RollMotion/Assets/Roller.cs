using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roller : MonoBehaviour
{
    [Header("Spawning")]
    [SerializeField] float radius;
    [SerializeField] Material dotsRenderer;

    [Header("Rotation")]
    [SerializeField] float rotSpeed;

    [Header("Controls")]

    private const int DOT_COUNT = 16; 

    // Start is called before the first frame update
    void Start()
    {
        SetUpDots();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * (rotSpeed * Time.deltaTime));
    }


    private void SetUpDots()
    {
        for (int i = 0; i < DOT_COUNT; i++)
        {
            Vector2 value = new Vector2(Random.Range(-radius, radius), Random.Range(-radius, radius));
            dotsRenderer.SetVector("_Dot" + (i + 1), value);
            print(dotsRenderer.GetVector("_Dot" + (i + 1)));
        }
    }
}
