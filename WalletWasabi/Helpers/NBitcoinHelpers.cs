﻿using NBitcoin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WalletWasabi.Helpers
{
	public static class NBitcoinHelpers
	{
		public static string HashOutpoints(IEnumerable<OutPoint> outPoints)
		{
			var sb = new StringBuilder();
			foreach (OutPoint input in outPoints.OrderBy(x => x.Hash.ToString()).OrderBy(x => x.N))
			{
				
				sb.Append(ByteHelpers.ToHex(input.ToBytes()));
			}
			
			return HashHelpers.GenerateSha256Hash(sb.ToString());
		}

	}
}
