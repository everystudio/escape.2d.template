using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MessageWindow : Singleton<MessageWindow>
{
	private Animator m_animator;
	private Text m_txtMessage;

	public override void Initialize()
	{
		base.Initialize();
		m_animator = GetComponent<Animator>();
		m_txtMessage = transform.Find("imgWindow/txtMessage").GetComponent<Text>();
	}
	public void Show(string _strMessage)
	{
		m_txtMessage.text = _strMessage;
		m_animator.Play("show");
	}
}
