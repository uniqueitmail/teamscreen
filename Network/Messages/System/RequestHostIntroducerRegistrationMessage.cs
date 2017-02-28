﻿using System;
using LiteNetLib.Utils;
using Model;

namespace Network.Messages.System
{
	public class RequestHostIntroducerRegistrationMessage : BaseMessage
	{

		public RequestHostIntroducerRegistrationMessage()
			: base((ushort)CustomMessageType.RequestHostIntroducerRegistration)
		{
		}

		public override void WritePayload(NetDataWriter message)
		{
			base.WritePayload(message);
		}

		public override void ReadPayload(NetDataReader message)
		{
			base.ReadPayload(message);
		}

	}
}