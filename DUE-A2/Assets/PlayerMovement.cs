using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 10f;   // 移动速度
    public float rotateSpeed = 100f; // 旋转速度

    // 前进
    public void Forward()
    {
        transform.position += transform.forward * moveSpeed * Time.deltaTime;
    }

    // 后退
    public void Back()
    {
        transform.position -= transform.forward * moveSpeed * Time.deltaTime;
    }

    // 左移
    public void MoveLeft()
    {
        transform.position -= transform.right * moveSpeed * Time.deltaTime;
    }

    // 右移
    public void MoveRight()
    {
        transform.position += transform.right * moveSpeed * Time.deltaTime;
    }

    // 顺时针旋转（Veer）
    public void Veer()
    {
        transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime);
    }

    // 逆时针旋转（Changerover）
    public void ChangeRover()
    {
        transform.Rotate(Vector3.up * -rotateSpeed * Time.deltaTime);
    }
}
