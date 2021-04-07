using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMain : Singleton<GameMain>
{
	public Button m_btnLeft;
	public Button m_btnRight;
	public Button m_btnBack;

	public AreaController m_areaCurrent;

	[SerializeField]
	private GameObject m_goItemButtonRoot;
	public ItemButton[] m_btnItemArr;
	public List<ItemData> item_list = new List<ItemData>();

	public override void Initialize()
	{
		m_btnItemArr = m_goItemButtonRoot.GetComponentsInChildren<ItemButton>();
		m_btnLeft.onClick.AddListener(() =>
		{
			m_areaCurrent.Hide();
			m_areaCurrent = m_areaCurrent.m_Left.GetComponent<AreaController>();
			m_areaCurrent.Show();
		});
		m_btnRight.onClick.AddListener(() =>
		{
			m_areaCurrent.Hide();
			m_areaCurrent = m_areaCurrent.m_Right.GetComponent<AreaController>();
			m_areaCurrent.Show();
		});
		m_btnBack.onClick.AddListener(() =>
		{
			m_areaCurrent.Hide();
			m_areaCurrent = m_areaCurrent.m_Back.GetComponent<AreaController>();
			m_areaCurrent.Show();
		});
	}

	public void MoveFront()
	{
		m_areaCurrent.Hide();
		m_areaCurrent = m_areaCurrent.m_Front.GetComponent<AreaController>();
		m_areaCurrent.Show();
	}

	private void Start()
	{
		m_areaCurrent.Show();
	}
	public void PickupItemData(ItemData _itemData)
	{
		Debug.Log($"pickup_item.name={_itemData.ItemName}");
		item_list.Add(_itemData);
		ShowItem();

		MessageWindow.Instance.Show($"{_itemData.ItemName}を手に入れた");
	}

	public void ShowItem()
	{
		for( int i = 0; i < m_btnItemArr.Length; i++)
		{
			if (i < item_list.Count)
			{
				m_btnItemArr[i].Show(item_list[i]);
			}
			else
			{
				m_btnItemArr[i].Show(null);
			}
		}
	}

	public void ShowItemDetail(ItemData _itemData)
	{
		if (_itemData != null)
		{
			ItemDetail.Instance.Show(_itemData);
		}
	}


}
