﻿// Licensed under the MIT license. See LICENSE file.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;

namespace TinyParser
{
	enum CalculatorTokenType
	{
		BinaryOperator,
		UnaryOperator,
		Keyword,
		Value,
		Function
	}

	/// <summary>
	/// 
	/// </summary>
	abstract class ICalculatorToken
		: ISaveLoad
	{
		#region Fields

		Calculator m_Calculator;

        #endregion

        #region Properties

		/// <summary>
		/// 
		/// </summary>
		public TinyParser.Calculator Calculator
		{
			get { return m_Calculator; }
		}

        #endregion

        #region Constructors

		/// <summary>
		/// 
		/// </summary>
		/// <param name="calculator_"></param>
		protected ICalculatorToken(Calculator calculator_)
		{
			m_Calculator = calculator_;
		}

        #endregion

        #region Methods

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public abstract float Evaluate();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="keyword_"></param>
		/// <returns></returns>
		protected float EvaluateKeyword(string keyword_)
		{
			return m_Calculator.Parser.EvaluateKeyword(keyword_);
		}

		#region ISaveLoad Members

		public abstract void Save(XmlNode el_, SaveOption option_);
		public abstract void Load(XmlNode el_, SaveOption option_);

        public abstract void Save(BinaryWriter bw_, SaveOption option_);
        public abstract void Load(BinaryReader br_, SaveOption option_);

		#endregion

        #endregion		
	}
}
