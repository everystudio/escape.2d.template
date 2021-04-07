using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemButton : MonoBehaviour
{
	public Button m_btn;
	public Image m_imgIcon;
	private ItemData m_itemData;

	private void Awake()
	{
		m_btn.onClick.AddListener(() =>
		{
			GameMain.Instance.ShowItemDetail(m_itemData);
		});
	}

	public void Show(ItemData _data)
	{
		m_itemData = _data;
		if ( _data == null)
		{
			m_imgIcon.sprite = null;
		}
		else
		{
			m_imgIcon.sprite = _data.IconSprite;
		}
	}
}
