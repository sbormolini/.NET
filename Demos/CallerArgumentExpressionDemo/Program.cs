using CallerArgumentExpressionDemo;
using System.Diagnostics;

var array = new[] { 1, 2, 3 };

Debug.Assert(array.Length == 3);
Debug.Assert(args.Length == 0, "args.Length == 0");

var arrayEmpty = new int[0];

Helper.ItIsNotEmpty(arrayEmpty);