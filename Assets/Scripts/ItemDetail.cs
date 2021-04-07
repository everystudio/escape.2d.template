using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemDetail : Singleton<ItemDetail>
{
	public GameObject m_goRoot;
	public Button m_btnClose;
	public Image m_imgIcon;
	public Text m_txtMessage;

	public override void Initialize()
	{
		base.Initialize();
		Hide();
	}

	public void Show(ItemData _data)
	{
		if (_data != null)
		{
			m_goRoot.SetActive(true);
			m_imgIcon.sprite = _data.IconSprite;
			m_txtMessage.text = _data.Description;
		}
	}
	public void Hide()
	{
		m_goRoot.SetActive(false);
	}
}
