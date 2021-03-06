// Generated by gencs from visualization_msgs/InteractiveMarker.msg
// DO NOT EDIT THIS FILE BY HAND!

using System;
using System.Collections;
using System.Collections.Generic;
using SIGVerse.RosBridge;
using UnityEngine;

using SIGVerse.RosBridge.std_msgs;
using SIGVerse.RosBridge.geometry_msgs;
using SIGVerse.RosBridge.visualization_msgs;

namespace SIGVerse.RosBridge 
{
	namespace visualization_msgs 
	{
		[System.Serializable]
		public class InteractiveMarker : RosMessage
		{
			public std_msgs.Header header;
			public geometry_msgs.Pose pose;
			public string name;
			public string description;
			public float scale;
			public System.Collections.Generic.List<visualization_msgs.MenuEntry>  menu_entries;
			public System.Collections.Generic.List<visualization_msgs.InteractiveMarkerControl>  controls;


			public InteractiveMarker()
			{
				this.header = new std_msgs.Header();
				this.pose = new geometry_msgs.Pose();
				this.name = "";
				this.description = "";
				this.scale = 0.0f;
				this.menu_entries = new System.Collections.Generic.List<visualization_msgs.MenuEntry>();
				this.controls = new System.Collections.Generic.List<visualization_msgs.InteractiveMarkerControl>();
			}

			public InteractiveMarker(std_msgs.Header header, geometry_msgs.Pose pose, string name, string description, float scale, System.Collections.Generic.List<visualization_msgs.MenuEntry>  menu_entries, System.Collections.Generic.List<visualization_msgs.InteractiveMarkerControl>  controls)
			{
				this.header = header;
				this.pose = pose;
				this.name = name;
				this.description = description;
				this.scale = scale;
				this.menu_entries = menu_entries;
				this.controls = controls;
			}

			new public static string GetMessageType()
			{
				return "visualization_msgs/InteractiveMarker";
			}

			new public static string GetMD5Hash()
			{
				return "dd86d22909d5a3364b384492e35c10af";
			}
		} // class InteractiveMarker
	} // namespace visualization_msgs
} // namespace SIGVerse.ROSBridge

