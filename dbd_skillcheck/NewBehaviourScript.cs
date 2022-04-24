using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public bool onSuccessArea;
    public bool flipflop;
    public float speed = 10f;

    // Update is called once per frame
    void Update()
    {
        if(flipflop) transform.Rotate(new Vector3(0, 0, speed * Time.deltaTime));
        else transform.Rotate(new Vector3(0, 0, -1 * (speed * Time.deltaTime)));
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(onSuccessArea)
            {
                GameObject.Find("/ui/Canvas/fail").SetActive(false);
                GameObject.Find("/ui/Canvas/success").SetActive(true);
                StopCoroutine(FalseYap());
                StartCoroutine(FalseYap());
            }
            else
            {
                GameObject.Find("/ui/Canvas/success").SetActive(false);
                GameObject.Find("/ui/Canvas/fail").SetActive(true);
                StopCoroutine(FalseYap());
                StartCoroutine(FalseYap());

            }
            flipflop = !flipflop;
        }

        if(Input.GetKeyDown(KeyCode.Z))
        {
            Time.timeScale = 1;
        }

    }

    private IEnumerator FalseYap()
    {
        yield return new WaitForSeconds(2f);
        GameObject.Find("/ui/Canvas/fail").SetActive(false);
        GameObject.Find("/ui/Canvas/success").SetActive(false);

    }
    
}
