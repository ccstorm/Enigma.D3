﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.MemoryModel.MemoryManagement
{
	public interface IMemoryManager
	{
		ILocalHeap LocalHeap { get; }
	}
}
