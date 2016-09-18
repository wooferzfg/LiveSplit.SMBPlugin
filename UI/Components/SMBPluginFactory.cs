using LiveSplit.Model;
using LiveSplit.UI.Components;
using System;
using UpdateManager;

[assembly: ComponentFactory(typeof(SMBPluginFactory))]

namespace LiveSplit.UI.Components
{
	public class SMBPluginFactory : IComponentFactory, IUpdateable
	{
		public string ComponentName
		{
			get
			{
				return "Super Mario Bros. Plugin";
			}
		}

		public string Description
		{
			get
			{
				return "Rounds splits to the nearest frame rule.";
			}
		}

		public ComponentCategory Category
		{
			get
			{
				return ComponentCategory.Control;
			}
		}

		public string UpdateName
		{
			get
			{
				return ComponentName;
			}
		}

		public string XMLURL
		{
			get
			{
				return "http://livesplit.org/update/Components/noupdates.xml";
			}
		}

		public string UpdateURL
		{
			get
			{
				return "http://livesplit.org/update/";
			}
		}

		public Version Version
		{
			get
			{
				return Version.Parse("1.0");
			}
		}

		public IComponent Create(LiveSplitState state)
		{
			return new SMBPlugin(state);
		}
	}
}
