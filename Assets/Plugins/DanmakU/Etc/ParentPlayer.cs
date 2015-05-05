﻿// Copyright (c) 2015 James Liu
//	
// See the LISCENSE file for copying permission.

using UnityEngine;

namespace DanmakU {

	/// <summary>
	/// A small utility script that forces its GameObject to become a child GameObject of the Player
	/// </summary>
	public class ParentPlayer : MonoBehaviour {
		
		[SerializeField]
		private Vector2 offset;

		void Awake () {
			transform.parent = FindObjectOfType<DanmakuPlayer>().transform;
			transform.localPosition = offset;
			Destroy (this);
		}
	}


}