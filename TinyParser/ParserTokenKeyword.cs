﻿// Licensed under the MIT license. See LICENSE file.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TinyParser
{
	/// <summary>
	/// 
	/// </summary>
	class ParserTokenKeyword
		: ParserToken
	{
		#region Fields

		#endregion

		#region Properties

		#endregion

		#region Constructors

		/// <summary>
		/// 
		/// </summary>
		/// <param name="parser_"></param>
		/// <param name="token_"></param>
		public ParserTokenKeyword(Parser parser_, string token_)
			: base(parser_, token_)
		{}

        #endregion

        #region Methods

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sentence_"></param>
		/// <returns></returns>
		public override bool Check(string sentence_)
		{
			if (m_Token.Equals(sentence_) == true)
			{
				Parser.AddCalculator(new CalculatorTokenKeyword(Parser.Calculator, m_Token));
				return true;
			}

			return false;
		}

        #endregion
	}
}
