using System.Collections;
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

		/// <summary>
		/// 
		/// </summary>
		/// <param name="list"></param>
		/// <param name="items"></param>
		public static void Initialise (this Vector3List list, IEnumerable<float3> items)
		{
			list.Clear ();

			list.AddRange (items);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="list"></param>
		/// <param name="items"></param>
		public static void AddRange (this Vector3List list, IEnumerable<float3> items)
		{
			foreach (float3 item in items)
			{
				list.Add (item);
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="array"></param>
		/// <returns></returns>
		public static float3[] ToFloat3Array (this Vector3[] array)
		{
			float3[] newArray = new float3[array.Length];

			for (int i = 0; i < array.Length; i++)
			{
				newArray[i] = array[i];
			}

			return newArray;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="array"></param>
		/// <returns></returns>
		public static Vector3[] ToVector3Array (this NativeArray<float3> array)
		{
			Vector3[] newArray = new Vector3[array.Length];

			for (int i = 0; i < array.Length; i++)
			{
				newArray[i] = array[i];
			}

			return newArray;
		}
	}
}