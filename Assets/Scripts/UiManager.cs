using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{
    public GameObject endingCredit;
    public GameObject endingCredit2;

    public float speed = 1f; // 올라가는 속도. Inspector에서 조절 가능.

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // endingCredit의 현재 위치를 가져옵니다.
        Vector3 currentPos = endingCredit.transform.position;

        // y 위치를 업데이트 합니다.
        currentPos.y += speed * Time.deltaTime;

        // 수정된 위치를 endingCredit2에 다시 설정합니다.
        endingCredit.transform.position = currentPos;

        Vector3 currentPos1 = endingCredit2.transform.position;

        // y 위치를 업데이트 합니다.
        currentPos1.y += speed * Time.deltaTime;

        // 수정된 위치를 endingCredit2에 다시 설정합니다.
        endingCredit2.transform.position = currentPos1;
    }
}

