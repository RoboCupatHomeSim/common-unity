// Generated by gencs from diagnostic_msgs/DiagnosticArray.msg
// DO NOT EDIT THIS FILE BY HAND!

using System;
using System.Collections;
using System.Collections.Generic;
using SIGVerse.RosBridge;
using UnityEngine;

using SIGVerse.RosBridge.std_msgs;
using SIGVerse.RosBridge.diagnostic_msgs;

namespace SIGVerse.RosBridge 
{
	namespace diagnostic_msgs 
	{
		[System.Serializable]
		public class DiagnosticArray : RosMessage
		{
			public std_msgs.Header header;
			public System.Collections.Generic.List<diagnostic_msgs.DiagnosticStatus>  status;


			public DiagnosticArray()
			{
				this.header = new std_msgs.Header();
				this.status = new System.Collections.Generic.List<diagnostic_msgs.DiagnosticStatus>();
			}

			public DiagnosticArray(std_msgs.Header header, System.Collections.Generic.List<diagnostic_msgs.DiagnosticStatus>  status)
			{
				this.header = header;
				this.status = status;
			}

			new public static string GetMessageType()
			{
				return "diagnostic_msgs/DiagnosticArray";
			}

			new public static string GetMD5Hash()
			{
				return "60810da900de1dd6ddd437c3503511da";
			}
		} // class DiagnosticArray
	} // namespace diagnostic_msgs
} // namespace SIGVerse.ROSBridge

