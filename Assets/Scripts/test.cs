using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    // �������� �������� ������ �����
    public float speed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        // �������� ��������� RectTransform ������� "Button"
        RectTransform buttonRectTransform = GetComponent<RectTransform>();

        // ������� ������ ����� �� ������������ ����������
        Vector3 newPosition = buttonRectTransform.position;
        newPosition.x -= speed;
        buttonRectTransform.position = newPosition;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
