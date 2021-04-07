using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="ItemData" , menuName ="ScriptableObject/ItemData")]
public class ItemData : ScriptableObject
{
	public int ItemId;
	public string ItemName;
	public string Description;
	public Sprite IconSprite;
}
