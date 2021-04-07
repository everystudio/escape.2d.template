using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class TweenTest : MonoBehaviour
{
    private bool m_bIsLeft;

    private Tweener m_tweener;
    private Sequence m_sequence;

    void Start()
    {
        m_bIsLeft = true;
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if( m_tweener != null)
            {
                m_tweener.Complete();
            }
            if (m_sequence != null)
            {
                m_sequence.Complete();
            }
            m_sequence = transform.DOJump(Vector3.zero, 3.0f, 1, 3.0f)
                .SetRelative()
                .SetEase(Ease.Linear);
            //m_tweener = transform.DOMoveX(m_bIsLeft ? 10.0f : -10.0f, 5.0f).SetRelative();

            m_bIsLeft = !m_bIsLeft;
        }
    }



}
