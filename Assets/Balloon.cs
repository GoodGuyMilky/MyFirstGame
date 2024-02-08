using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour
{
    public int clickToPop;

    void OnMouseDown()
    {
        clickToPop -= 1;

        transform.localScale += new Vector3(0.2f, 0.2f, 0.2f);

        if (clickToPop == 0)
        {
            Destroy(gameObject);
        }
    }
}
