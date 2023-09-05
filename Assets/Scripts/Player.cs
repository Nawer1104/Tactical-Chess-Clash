using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Bullet bullet;

    public static Player Instance;

    public bool canDraw = true;

    private void Awake()
    {
        Instance = this;

    }

    private void OnMouseDown()
    {
        if (!canDraw) return;
        DrawWithMouse.Instance.StartLine(transform.position);
    }

    private void OnMouseDrag()
    {
        if (!canDraw) return;
        DrawWithMouse.Instance.Updateline();
    }

    private void OnMouseUp()
    {
        if (!canDraw) return;
        bullet.positions = new Vector3[DrawWithMouse.Instance.line.positionCount];
        DrawWithMouse.Instance.line.GetPositions(bullet.positions);
        bullet.canMove = true;
        DrawWithMouse.Instance.ResetLine();

    }
}