using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("j"))
        {
            StartCoroutine(T1());
        }

        if (Input.GetKeyDown("k"))
        {
            StartCoroutine(T2());
        }
    }


    IEnumerator T1()
    {
        float duration = 5;
        float elapsedTime = 0;
        int n = 0;
        while (true)
        {
            elapsedTime += Time.deltaTime;
            if (elapsedTime >= duration)
            {
                elapsedTime = 0;

                n++;
                Debug.Log(n);

                if (n >= 3)
                {
                    Debug.Log("ok");

                    yield break;
                }
            }

            yield return 0;
        }
    }

    IEnumerator T2()
    {
        float duration = 5;
        int n = 0;
        while (true)
        {
            yield return new WaitForSeconds(duration);

            n++;
            Debug.Log(n);

            if (n >= 3)
            {
                Debug.Log("ok");

                yield break;
            }
        }
    }
}
