using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MaketItMove : MonoBehaviour
{
    [SerializeField] private RawImage m_rawImage;
    [SerializeField] private float m_x, m_y;

    void Update()
    {
        m_rawImage.uvRect = new Rect(m_rawImage.uvRect.position + new Vector2(m_x, m_y) * Time.deltaTime, m_rawImage.uvRect.size);
    }
}
