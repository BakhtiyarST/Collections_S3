﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_S3;

internal class CustomEnumerator : IEnumerator<int>
{
	public int Current { get; private set; } = -1;
	 
	object IEnumerator.Current => -1; 

	public void Dispose()
	{
	}

	public bool MoveNext()
	{
		if (Current < 10)
		{
			Current++;
			return true;
		}
		Reset();
		return false;
	}

	public void Reset()
	{
		Current = -1;
	}
}
