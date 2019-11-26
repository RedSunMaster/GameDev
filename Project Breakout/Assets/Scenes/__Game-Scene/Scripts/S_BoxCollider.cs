using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_BoxCollider : MonoBehaviour {
    public RectTransform objectRect, parentCanvas;
    public BoxCollider2D boxCollider;
    Rect canvasOld;
    // Use this for initialization
    void Start ()
    {
        if (parentCanvas == null)
        {
            parentCanvas = GetComponentInParent<Canvas>().GetComponent<RectTransform>();
        }
            canvasOld = parentCanvas.rect;
        if (boxCollider == null)
        {
            boxCollider = GetComponent<BoxCollider2D>();
        }
        if (objectRect == null)
        {
            objectRect = GetComponent<RectTransform>();
        }
        boxCollider.size = objectRect.rect.size;
        boxCollider.offset = new Vector2(0, 0);
    }

    // Update is called once per frame
    void Update () {
        if(canvasOld.width != parentCanvas.rect.width
            || canvasOld.height != parentCanvas.rect.height)
        {
            boxCollider.size = objectRect.rect.size;
            boxCollider.offset = new Vector2(0, 0);
            canvasOld = parentCanvas.rect;
        }
    }
}