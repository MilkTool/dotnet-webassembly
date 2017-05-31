﻿namespace WebAssembly
{
	/// <summary>
	/// Many compiler tests can use this template to host the test.
	/// </summary>
	public abstract class CompilerTestBase<T>
		where T : struct
	{
		/// <summary>
		/// Creates a new <see cref="CompilerTestBase{T}"/> instance.
		/// </summary>
		protected CompilerTestBase()
		{
		}

		/// <summary>
		/// Returns a value.
		/// </summary>
		/// <param name="parameter">Input to the test function.</param>
		/// <returns>A value to ensure proper control flow and execution.</returns>
		public abstract T Test(T parameter);
	}
}