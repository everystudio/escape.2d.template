using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaController : MonoBehaviour
{
	public GameObject m_Front;
	[HideInInspector]
	public GameObject m_Left;
	public GameObject m_Right;
	[HideInInspector]
	public GameObject m_Back;

	private void Awake()
	{
		if (m_Front != null)
		{
			m_Front.GetComponent<AreaController>().m_Back = gameObject;
		}
		if (m_Right != null)
		{
			m_Right.GetComponent<AreaController>().m_Left = gameObject;
		}
	}

	private void OnDrawGizmos()
	{
		if (m_Front != null)
		{
			DebugUtil.DrawGizmoArrow(
				transform.position,
				new Vector3(
					m_Front.transform.position.x - transform.position.x,
					m_Front.transform.position.y - transform.position.y,
					0.0f),
				Color.cyan, 1f, 25f);
		}
		if (m_Right!= null)
		{
			DebugUtil.DrawGizmoArrow(
				transform.position,
				new Vector3(
					m_Right.transform.position.x - transform.position.x,
					m_Right.transform.position.y - transform.position.y,
					0.0f),
				Color.blue, 1f, 25f);
		}
	}
	private void OnValidate()
	{
	}

	public void Show()
	{
		gameObject.GetComponentInChildren<Cinemachine.CinemachineVirtualCamera>().Priority = 20;
		GameMain.Instance.m_btnLeft.gameObject.SetActive(m_Left != null);
		GameMain.Instance.m_btnRight.gameObject.SetActive(m_Right != null);
		GameMain.Instance.m_btnBack.gameObject.SetActive(m_Back != null);
	}
	public void Hide()
	{
		gameObject.GetComponentInChildren<Cinemachine.CinemachineVirtualCamera>().Priority = 10;
	}

}
