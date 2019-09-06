﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Collections;
using Unity.Mathematics;

namespace ScriptableFramework.Mathematics
{
	/// <summary>
	/// 
	/// </summary>
	public static class Extensions
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="list"></param>
		/// <returns></returns>
		public static float3[] ToFloat3Array (this Vector3List list)
		{
			float3[] newArray = new float3[list.Count];

			for (int i = 0; i < list.Count; i++)
			{
				newArray[i] = list[i];
			}

			return newArray;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="list"></param>
		/// <returns></returns>
		public static List<float3> ToFloat3List (this Vector3List list)
		{
			List<float3> newList = new List<float3> ();

			for (int i = 0; i < list.Count; i++)
			{
				newList.Add (list[i]);
			}

			return newList;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="list"></param>
		/// <param name="allocator"></param>
		/// <returns></returns>
		public static NativeArray<float3> ToFloat3NativeArray (this Vector3List list, Allocator allocator)
		{
			return new NativeArray<float3> (list.ToFloat3Array (), allocator);
		}
	}
}