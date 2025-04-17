using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class UICursor : MonoBehaviour
{
    public RectTransform customCursor;

    private void Update()
    {
        Vector3 mousePosition = Input.mousePosition;

        customCursor.position = mousePosition;
    }
}
