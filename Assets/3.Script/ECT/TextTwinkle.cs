using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextTwinkle : MonoBehaviour
{
    public float blinkInterval = 0.5f; // ��¦�̴� ����
    private Text textComponent;
    private bool isBlinking = false;

    private void Start()
    {
        textComponent = GetComponent<Text>();
        if (textComponent == null)
        {
            Debug.LogError("TextTwinkle ��ũ��Ʈ�� Text ������Ʈ�� �����ؾ� �մϴ�.");
            enabled = false;
        }

        // ��¦�̴� �ڷ�ƾ ����
        StartCoroutine(BlinkText());
    }

    private IEnumerator BlinkText()
    {
        while (true)
        {
            isBlinking = !isBlinking;
            textComponent.enabled = isBlinking;
            yield return new WaitForSeconds(blinkInterval);
        }
    }
}
