// Generated by gencs from geometry_msgs/Polygon.msg
// DO NOT EDIT THIS FILE BY HAND!

using System;
using System.Collections;
using System.Collections.Generic;
using SIGVerse.RosBridge;
using UnityEngine;

using SIGVerse.RosBridge.geometry_msgs;

namespace SIGVerse.RosBridge 
{
	namespace geometry_msgs 
	{
		[System.Serializable]
		public class Polygon : RosMessage
		{
			public System.Collections.Generic.List<geometry_msgs.Point32>  points;


			public Polygon()
			{
				this.points = new System.Collections.Generic.List<geometry_msgs.Point32>();
			}

			public Polygon(System.Collections.Generic.List<geometry_msgs.Point32>  points)
			{
				this.points = points;
			}

			new public static string GetMessageType()
			{
				return "geometry_msgs/Polygon";
			}

			new public static string GetMD5Hash()
			{
				return "cd60a26494a087f577976f0329fa120e";
			}
		} // class Polygon
	} // namespace geometry_msgs
} // namespace SIGVerse.ROSBridge

