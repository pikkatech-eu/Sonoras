using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sonoras.Domain;

namespace Sonoras.UI.Contracts
{
	public interface IGazetteerPropertiesDevice
	{
		Gazetteer GetGazetteer(Gazetteer gazetteer = null);
	}
}
