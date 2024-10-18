using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_S3;

internal class CustomEnumerable : IEnumerable<int>
{
	public IEnumerator<int> GetEnumerator() => custom;

	IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

	private CustomEnumerator custom = new CustomEnumerator();
}
